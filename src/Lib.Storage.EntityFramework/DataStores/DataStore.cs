using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semantica.Extensions;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Storage.EntityFramework.DataStores;

public class DataStore<TStorage, TKey> : IDataStore<TStorage, TKey>
    where TStorage : class, new()
    where TKey : struct, IEquatable<TKey>
{
    private readonly IDbContextProvider _contextProvider;

    public DataStore(
            IDbContextProvider contextProvider,
            IStorageCache<TKey, TStorage> cache,
            IKeyConverter<TStorage, TKey> keyConverter,
            IPredicateProvider<TStorage, TKey> predicateProvider
        )
    {
        _contextProvider = contextProvider;
        PredicateProvider = predicateProvider;
        KeyConverter = keyConverter;
        Cache = cache;
    }

    protected virtual IStorageCache<TKey, TStorage> Cache { get; }
    
    protected DbContext Context => _contextProvider.ActiveContext;

    protected DbSet<TStorage> DbSet => Context.Set<TStorage>();
    
    protected virtual IKeyConverter<TStorage, TKey> KeyConverter { get; }

    protected virtual IPredicateProvider<TStorage, TKey> PredicateProvider { get; }

    protected virtual IQueryable<TStorage> Queryable => DbSet.AsNoTracking();

    public virtual bool Exists(TKey key)
    {
        return Cache.TryGet(key, out var storageModel) || Queryable.Any(PredicateProvider.IsMatch(key));
    }

    public virtual async Task<bool> ExistsAsync(TKey key, CancellationToken cancellationToken = default)
    {
        return Cache.TryGet(key, out var storageModel) || await Queryable.AnyAsync(PredicateProvider.IsMatch(key), cancellationToken);
    }

    public virtual bool ExistsMany(IReadOnlyCollection<TKey> keys)
    {
        return keys.All(Exists);
    }

    public virtual async Task<bool> ExistsManyAsync(IReadOnlyCollection<TKey> keys, CancellationToken cancellationToken = default)
    {
        foreach (var key in keys)
        {
            if (! await ExistsAsync(key, cancellationToken)) return false;
        }
        return true;
    }

    public virtual TStorage? Retrieve(TKey key)
    {
        if (!Cache.TryGet(key, out var storageModel))
        {
            storageModel = Query(Queryable, (sm) => key, PredicateProvider.IsMatch(key));
        }

        return storageModel;
    }

    public virtual TStorage? Retrieve(TKey key, IInclusion<TStorage>? inclusion)
    {
        if (key.Equals(default))
        {
            return null;
        }
        var storageModel = Query(Queryable.IncludeIfNotNull(inclusion), _ => key, PredicateProvider.IsMatch(key));
        inclusion?.RegisterQueryResult(storageModel);
        return storageModel;
    }

    public virtual T? Retrieve<T>(TKey key, Expression<Func<TStorage, T>> selectFunc)
    {
        if (key.Equals(default))
        {
            return default;
        }
        return Queryable.Where(PredicateProvider.IsMatch(key)).Select(selectFunc).FirstOrDefault();
    }

    public virtual TStorage? Retrieve(Expression<Func<TStorage, bool>> predicate)
    {
        return Query(Queryable, KeyConverter.ToKey, predicate);
    }

    public virtual TStorage? Retrieve(Expression<Func<TStorage, bool>> predicate, IInclusion<TStorage>? inclusion)
    {
        var storageModel = Query(Queryable.IncludeIfNotNull(inclusion), KeyConverter.ToKey, predicate);
        inclusion?.RegisterQueryResult(storageModel);
        return storageModel;
    }

    public IReadOnlyList<TStorage> RetrieveAll(bool allModels)
    {
        var storageModels = Cache.TryGetAll(out var cachedModels)
            ? cachedModels.ToReadOnlyList()
            : Queryable.ToReadOnlyList();
        if (! Cache.ContainsAll) CacheRange(storageModels, allModels: true);
        return storageModels;
    }

    public IReadOnlyList<TStorage> RetrieveAll(IInclusion<TStorage>? inclusion)
    {
        var storageModels = Cache.TryGetAll(out var cachedModels)
            ? cachedModels.ToReadOnlyList()
            : Queryable.IncludeIfNotNull(inclusion).ToReadOnlyList();
        if (! Cache.ContainsAll) CacheRange(storageModels, allModels: true);
        inclusion?.RegisterQueryResult(storageModels);
        return storageModels;
    }

    public IReadOnlyList<T> RetrieveAll<T>(Expression<Func<TStorage, T>> selectFunc)
        => Queryable.Select(selectFunc).ToReadOnlyList();

    public virtual async Task<TStorage?> RetrieveAsync(TKey key, CancellationToken cancellationToken = default)
    {
        if (key.Equals(default))
        {
            return null;
        }
        if (!Cache.TryGet(key, out var storageModel))
        {
            storageModel = await QueryAsync(Queryable, _ => key, PredicateProvider.IsMatch(key), cancellationToken);
        }

        return storageModel;
    }

    public virtual async Task<TStorage?> RetrieveAsync(
        TKey key,
        IInclusion<TStorage>? inclusion,
        CancellationToken cancellationToken = default)
    {
        if (key.Equals(default))
        {
            return null;
        }
        var storageModel = await QueryAsync(Queryable.IncludeIfNotNull(inclusion), (sm) => key, PredicateProvider.IsMatch(key), cancellationToken);
        inclusion?.RegisterQueryResult(storageModel);
        return storageModel;
    }

    public virtual Task<T?> RetrieveAsync<T>(
        TKey key,
        Expression<Func<TStorage, T>> selectFunc,
        CancellationToken cancellationToken = default)
    {
        if (key.Equals(default))
        {
            return Task.FromResult(default(T?));
        }
        return Queryable.Where(PredicateProvider.IsMatch(key))
                        .Select(selectFunc)
                        .FirstOrDefaultAsync(cancellationToken);
    }

    public virtual Task<TStorage?> RetrieveAsync(
        Expression<Func<TStorage, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        return QueryAsync(Queryable, KeyConverter.ToKey, predicate, cancellationToken);
    }

    public async Task<TStorage?> RetrieveAsync(
        Expression<Func<TStorage, bool>> predicate,
        IInclusion<TStorage>? inclusion,
        CancellationToken cancellationToken = default)
    {
        var storageModel = await QueryAsync(Queryable.IncludeIfNotNull(inclusion), KeyConverter.ToKey, predicate, cancellationToken);
        inclusion?.RegisterQueryResult(storageModel);
        return storageModel;
    }

    public async Task<IReadOnlyList<TStorage>> RetrieveAllAsync(CancellationToken cancellationToken = default)
    {
        var storageModels = Cache.TryGetAll(out var cachedModels)
            ? cachedModels.ToReadOnlyList()
            : await Queryable.ToReadOnlyListAsync(cancellationToken);
        if (! Cache.ContainsAll) CacheRange(storageModels, allModels: true);
        return storageModels;
    }

    public async Task<IReadOnlyList<TStorage>> RetrieveAllAsync(
        IInclusion<TStorage>? inclusion, 
        CancellationToken cancellationToken = default)
    {
        var storageModels = Cache.TryGetAll(out var cachedModels)
            ? cachedModels.ToReadOnlyList()
            : await Queryable.IncludeIfNotNull(inclusion).ToReadOnlyListAsync(cancellationToken);
        if (! Cache.ContainsAll) CacheRange(storageModels, allModels: true);
        inclusion?.RegisterQueryResult(storageModels);
        return storageModels;
    }

    public Task<IReadOnlyList<T>> RetrieveAllAsync<T>(
        Expression<Func<TStorage, T>> selectFunc, CancellationToken cancellationToken = default) 
        => Queryable.Select(selectFunc).ToReadOnlyListAsync(cancellationToken);

    public virtual async Task<IReadOnlyList<TStorage>> RetrieveManyAsync(
        IReadOnlyCollection<TKey> keys,
        CancellationToken cancellationToken = default)
    {
        var results = new List<TStorage>(keys.Count);
        foreach (var key in keys.WhereNotDefault())
        {
            var result = await RetrieveAsync(key, cancellationToken);
            results.AddIfNotNull(result);
        }

        return results;
    }

    public virtual async Task<IReadOnlyList<TStorage>> RetrieveManyAsync(
        IReadOnlyCollection<TKey> keys,
        IInclusion<TStorage>? inclusion,
        CancellationToken cancellationToken = default)
    {
        var results = new List<TStorage>(keys.Count);
        foreach (var key in keys.WhereNotDefault())
        {
            var result = await RetrieveAsync(key, inclusion, cancellationToken);
            results.AddIfNotNull(result);
        }

        return results;
    }

    public virtual async Task<IReadOnlyList<T>> RetrieveManyAsync<T>(
        IReadOnlyCollection<TKey> keys,
        Expression<Func<TStorage, T>> selectFunc,
        CancellationToken cancellationToken = default)
    {
        var results = new List<T>(keys.Count);
        foreach (var key in keys.WhereNotDefault())
        {
            var result = await RetrieveAsync(key, selectFunc, cancellationToken);
            results.AddIfNotNull(result);
        }

        return results;    
    }

#if NET7_0_OR_GREATER
    public virtual T? Retrieve<T>(TKey key)
        where T : IMappable<TStorage, T>
    {
        if (key.Equals(default))
        {
            return default(T?);
        }
        return Queryable.Where(PredicateProvider.IsMatch(key))
                        .Select(T.Mapping)
                        .FirstOrDefault();
    }

    public IReadOnlyList<T> RetrieveAll<T>()
        where T : IMappable<TStorage, T> 
        => Queryable.Select(T.Mapping).ToReadOnlyList();

    public virtual Task<T?> RetrieveAsync<T>(TKey key, CancellationToken cancellationToken = default)
        where T : IMappable<TStorage, T>
    {
        if (key.Equals(default))
        {
            return Task.FromResult(default(T?));
        }
        return Queryable.Where(PredicateProvider.IsMatch(key))
                        .Select(T.Mapping)
                        .FirstOrDefaultAsync(cancellationToken);
    }

    
    public Task<IReadOnlyList<T>> RetrieveAllAsync<T>(CancellationToken cancellationToken = default) 
        where T : IMappable<TStorage, T>
        => Queryable.Select(T.Mapping).ToReadOnlyListAsync(cancellationToken);
    
    public virtual async Task<IReadOnlyList<T>> RetrieveManyAsync<T>(
        IReadOnlyCollection<TKey> keys,
        CancellationToken cancellationToken = default)
        where T : IMappable<TStorage, T>
    {
        var results = new List<T>(keys.Count);
        foreach (var key in keys.WhereNotDefault())
        {
            var result = await RetrieveAsync<T>(key, cancellationToken);
            results.AddIfNotNull(result);
        }

        return results;    
    }
#endif
    
    private TStorage? Query(IQueryable<TStorage> query, Func<TStorage, TKey> keyFunc, Expression<Func<TStorage, bool>> predicate)
    {
        var storageModel = query.FirstOrDefault(predicate);
        if (storageModel != null)
        {
            Cache.Cache(keyFunc(storageModel), storageModel);
        }

        return storageModel;
    }

    private async Task<TStorage?> QueryAsync(
        IQueryable<TStorage> query,
        Func<TStorage, TKey> keyFunc,
        Expression<Func<TStorage, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        var storageModel = await query.FirstOrDefaultAsync(predicate, cancellationToken);
        if (storageModel != null)
        {
            Cache.Cache(keyFunc(storageModel), storageModel);
        }

        return storageModel;
    }

    public virtual void Insert(TStorage storageModel)
    {
        DbSet.Add(storageModel);
    }

    public virtual void InsertMany(IEnumerable<TStorage> storageModels)
    {
        foreach (var model in storageModels)
        {
            Insert(model);
        }
    }

    public virtual void Update(TStorage storageModel)
    {
        Update(storageModel, null);
    }

    public virtual void Update(TStorage storageModel, IEnumerable<string>? propertyNamesToSetUnmodified)
    {
        DbSet.Update(storageModel);
        SetPropertyModifiedState(storageModel, propertyNamesToSetUnmodified, false);
    }

    public virtual void UpdateColumns(TStorage storageModel, IEnumerable<string> propertyNamesToSetModified)
    {
        DbSet.Attach(storageModel);
        SetPropertyModifiedState(storageModel, propertyNamesToSetModified, true);
    }

    public virtual void UpdateColumns(TStorage storageModel, string propertyName, params string[] extraProperties)
    {
        UpdateColumns(storageModel, extraProperties.PrecedeBy(propertyName));
    }

    public virtual void Delete(TKey key)
    {
        Delete(KeyConverter.ToBlankStorageModel(key));
    }

    public virtual void Delete(TStorage storageModel)
    {
        DbSet.Remove(storageModel);
    }

    protected void CacheRange(IEnumerable<TStorage> storageModels, bool allModels = false)
    {
        if (allModels)
        {
            Cache.CacheAll(storageModels.Select(model => (KeyConverter.ToKey(model), model)));
        }
        else foreach (var model in storageModels)
        {
            Cache.Cache(KeyConverter.ToKey(model), model);
        }
    }
    
    protected virtual void SetPropertyModifiedState(TStorage storageModel, IEnumerable<string>? propertyNames, bool isModified)
    {
        if (propertyNames == null)
        {
            return;
        }

        var entityEntry = Context.Entry(storageModel);
        foreach (var property in propertyNames)
        {
            entityEntry.Property(property).IsModified = isModified;
        }
    }
}
