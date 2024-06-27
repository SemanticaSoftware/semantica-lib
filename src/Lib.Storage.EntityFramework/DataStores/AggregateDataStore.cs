using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semantica.Order;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Storage.EntityFramework.DataStores;

public class AggregateDataStore<TStorage, TAggregateKey> : IAggregateDataStoreInternal<TStorage, TAggregateKey>
    where TStorage : class, new()
    where TAggregateKey : struct, IEquatable<TAggregateKey>
{
    private readonly IDbContextProvider _contextProvider;
    protected virtual IStorageCache<TAggregateKey, IReadOnlyList<TStorage>>? Cache { get; }
    protected DbContext Context => _contextProvider.ActiveContext;
    protected DbSet<TStorage> DbSet => Context.Set<TStorage>();
    protected virtual IAggregatePredicateProvider<TStorage, TAggregateKey> PredicateProvider { get; }
    protected virtual IQueryable<TStorage> Queryable => DbSet.AsNoTracking();

    public AggregateDataStore(
            IDbContextProvider contextProvider,
            IStorageCache<TAggregateKey, IReadOnlyList<TStorage>>? cache,
            IAggregatePredicateProvider<TStorage, TAggregateKey> predicateProvider
        )
    {
        _contextProvider = contextProvider;
        PredicateProvider = predicateProvider;
        Cache = cache;
    }

    public virtual Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync(
        TAggregateKey aggregateKey,
        CancellationToken cancellationToken = default)
    {
        return RetrieveAggregationAsync<bool, bool>(aggregateKey, null, default, default, cancellationToken);
    }

    public virtual Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync<TOrderProp>(
        TAggregateKey aggregateKey,
        Order<TStorage, TOrderProp> orderBy,
        CancellationToken cancellationToken = default)
        where TOrderProp : IComparable<TOrderProp>
    {
        return RetrieveAggregationAsync<TOrderProp, bool>(aggregateKey, null, orderBy, default, cancellationToken);
    }

    public virtual Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync<TOrderProp, TThenProp>(
        TAggregateKey aggregateKey,
        Order<TStorage, TOrderProp> orderBy,
        Order<TStorage, TThenProp> thenBy,
        CancellationToken cancellationToken = default)
        where TOrderProp : IComparable<TOrderProp>
        where TThenProp : IComparable<TThenProp>
    {
        return RetrieveAggregationAsync(aggregateKey, null, orderBy, thenBy, cancellationToken);
    }

    public virtual Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync(
        TAggregateKey aggregateKey,
        IInclusion<TStorage>? inclusion,
        CancellationToken cancellationToken = default)
    {
        return RetrieveAggregationAsync<bool, bool>(aggregateKey, inclusion, default, default, cancellationToken);
    }

    public virtual async Task<IReadOnlyList<T>> RetrieveAggregationAsync<T>(
        TAggregateKey aggregateKey,
        Expression<Func<TStorage, T>> selectFunc,
        CancellationToken cancellationToken = default)
    {
        if (aggregateKey.Equals(default))
        {
            return ArraySegment<T>.Empty;
        }
        var result = await Queryable.Where(PredicateProvider.MatchesAggregateKey(aggregateKey))
                                    .Select(selectFunc)
                                    .ToReadOnlyListAsync(cancellationToken);
        return result;
    }

    public virtual Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync<TOrderProp>(
        TAggregateKey aggregateKey,
        IInclusion<TStorage>? inclusion,
        Order<TStorage, TOrderProp> orderBy,
        CancellationToken cancellationToken = default)
        where TOrderProp : IComparable<TOrderProp>
    {
        return RetrieveAggregationAsync<TOrderProp, bool>(aggregateKey, inclusion, orderBy, default, cancellationToken);
    }

    public virtual async Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync<TOrderProp, TThenProp>(
        TAggregateKey aggregateKey,
        IInclusion<TStorage>? inclusion,
        Order<TStorage, TOrderProp> orderBy,
        Order<TStorage, TThenProp> thenBy,
        CancellationToken cancellationToken = default)
        where TOrderProp : IComparable<TOrderProp>
        where TThenProp : IComparable<TThenProp>
    {
        if (aggregateKey.Equals(default))
        {
            return ArraySegment<TStorage>.Empty;
        }
        if (Cache != null && inclusion == null && Cache.TryGet(aggregateKey, out var cached))
        {
            return cached.OrderByThenByConditional(orderBy, thenBy);
        }

        var result = await Queryable.Where(PredicateProvider.MatchesAggregateKey(aggregateKey))
                                    .IncludeIfNotNull(inclusion)
                                    .OrderByThenByConditional(orderBy, thenBy)
                                    .ToReadOnlyListAsync(cancellationToken);
        inclusion?.RegisterQueryResult(result);
        Cache?.Cache(aggregateKey, result);
        return result;
    }


#if NET7_0_OR_GREATER 
    public virtual async Task<IReadOnlyList<T>> RetrieveAggregationAsync<T>(
        TAggregateKey aggregateKey,
        CancellationToken cancellationToken = default)
        where T : IMappable<TStorage, T>
    {
        var result = await Queryable.Where(PredicateProvider.MatchesAggregateKey(aggregateKey))
                                    .Select(T.Mapping)
                                    .ToReadOnlyListAsync(cancellationToken);
        return result;
    }
#endif    
}
