using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Storage.EntityFramework.DataStores;

public class SimpleDataStore<TStorage, TKey> : DataStore<TStorage, TKey>, ISimpleDataStore<TStorage, TKey>
    where TStorage : class, new()
    where TKey : struct, IEquatable<TKey>
{
    public SimpleDataStore(
            IDbContextProvider context,
            IStorageCache<TKey, TStorage> cache,
            IKeyConverter<TStorage, TKey> keyConverter,
            ISimplePredicateProvider<TStorage, TKey> predicateProvider
        ) : base(context, cache, keyConverter, predicateProvider)
    {
    }

    protected override ISimplePredicateProvider<TStorage, TKey> PredicateProvider => (ISimplePredicateProvider<TStorage, TKey>)base.PredicateProvider;

    public override bool ExistsMany(IReadOnlyCollection<TKey> keys)
    {
        return keys.Count == Queryable.Where(PredicateProvider.MatchesAny(keys)).Count();
    }
    
    public override async Task<bool> ExistsManyAsync(
        IReadOnlyCollection<TKey> keys,
        CancellationToken cancellationToken = default)
    {
        return keys.Count == await Queryable.Where(PredicateProvider.MatchesAny(keys)).CountAsync(cancellationToken);
    }

    public override async Task<IReadOnlyList<TStorage>> RetrieveManyAsync(
        IReadOnlyCollection<TKey> keys,
        CancellationToken cancellationToken = default)
    {
        var results = new List<TStorage>(keys.Count);
        var keysToQuery = new List<TKey>();
        foreach (var key in keys)
        {
            if (Cache.TryGet(key, out var entity))
            {
                results.Add(entity);
            }
            else
            {
                keysToQuery.Add(key);
            }
        }

        var retrieved = await Queryable.Where(PredicateProvider.MatchesAny(keysToQuery)).ToListAsync(cancellationToken);
        CacheRange(retrieved);
        results.AddRange(retrieved);
        return results;
    }

    public override async Task<IReadOnlyList<TStorage>> RetrieveManyAsync(
        IReadOnlyCollection<TKey> keys,
        IInclusion<TStorage>? inclusion,
        CancellationToken cancellationToken = default)
    {
        var results = await Queryable.IncludeIfNotNull(inclusion)
                                     .Where(PredicateProvider.MatchesAny(keys))
                                     .ToReadOnlyListAsync(cancellationToken);
        inclusion?.RegisterQueryResult(results);
        CacheRange(results);
        return results;
    }

    public override Task<IReadOnlyList<T>> RetrieveManyAsync<T>(
        IReadOnlyCollection<TKey> keys,
        Expression<Func<TStorage, T>> selectFunc,
        CancellationToken cancellationToken = default)
    {
        var results = Queryable.Where(PredicateProvider.MatchesAny(keys))
                                     .Select(selectFunc)
                                     .ToReadOnlyListAsync(cancellationToken);
        return results;
    }
    
#if NET7_0_OR_GREATER
    public override Task<IReadOnlyList<T>> RetrieveManyAsync<T>(
        IReadOnlyCollection<TKey> keys,
        CancellationToken cancellationToken = default)
    {
        var results = Queryable.Where(PredicateProvider.MatchesAny(keys))
                               .Select(T.Mapping)
                               .ToReadOnlyListAsync(cancellationToken);
        return results;
        
    }

#endif
}
