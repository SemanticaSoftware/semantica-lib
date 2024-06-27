using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Storage.EntityFramework.DataStores;

public class SimpleAggregateDataStore<TStorage, TAggregateKey> 
    : AggregateDataStore<TStorage, TAggregateKey>, ISimpleAggregateDataStoreInternal<TStorage, TAggregateKey>
    where TStorage : class, new()
    where TAggregateKey : struct, IEquatable<TAggregateKey>
{
    public SimpleAggregateDataStore(
        IDbContextProvider contextProvider,
        IStorageCache<TAggregateKey, IReadOnlyList<TStorage>>? cache,
        IAggregatePredicateProvider<TStorage, TAggregateKey> predicateProvider) 
        : base(contextProvider, cache, predicateProvider)
    {
    }

    public virtual Task<IReadOnlyList<TStorage>> RetrieveAggregationManyAsync(
        IReadOnlyCollection<TAggregateKey> aggregateKeys,
        CancellationToken cancellationToken = default)
    {
        return RetrieveAggregationManyAsync(aggregateKeys, null, cancellationToken);
    }

    public virtual async Task<IReadOnlyList<TStorage>> RetrieveAggregationManyAsync(
        IReadOnlyCollection<TAggregateKey> aggregateKeys,
        IInclusion<TStorage>? inclusion,
        CancellationToken cancellationToken = default)
    {
        var result = await Queryable.Where(PredicateProvider.MatchesAnyAggregateKey(aggregateKeys))
                                    .IncludeIfNotNull(inclusion)
                                    .ToReadOnlyListAsync(cancellationToken);
        inclusion?.RegisterQueryResult(result);
        return result;
    }

    public virtual async Task<IReadOnlyList<T>> RetrieveAggregationManyAsync<T>(
        IReadOnlyCollection<TAggregateKey> aggregateKeys,
        Expression<Func<TStorage, T>> selectFunc,
        CancellationToken cancellationToken = default)
    {
        var result = await Queryable.Where(PredicateProvider.MatchesAnyAggregateKey(aggregateKeys))
                                    .Select(selectFunc)
                                    .ToReadOnlyListAsync(cancellationToken);
        return result;
    }

#if NET7_0_OR_GREATER
    public virtual async Task<IReadOnlyList<T>> RetrieveAggregationManyAsync<T>(
        IReadOnlyCollection<TAggregateKey> aggregateKeys,
        CancellationToken cancellationToken = default)
        where T : IMappable<TStorage, T>
    {
        var result = await Queryable.Where(PredicateProvider.MatchesAnyAggregateKey(aggregateKeys))
                                    .Select(T.Mapping)
                                    .ToReadOnlyListAsync(cancellationToken);
        return result;
    }
#endif
}
