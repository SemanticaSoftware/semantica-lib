using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Semantica.Patterns;

namespace Semantica.Storage.DataStores;

public interface IAggregateDataStore<TStorage, in TAggregateKey>
    where TStorage : class
    where TAggregateKey : struct, IEquatable<TAggregateKey>
{
    [Pure]
    Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync(
        TAggregateKey aggregateKey,
        CancellationToken cancellationToken = default);

    [Pure]
    Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync(
        TAggregateKey aggregateKey,
        IInclusion<TStorage>? inclusion,
        CancellationToken cancellationToken = default);

    [Pure]
    Task<IReadOnlyList<T>> RetrieveAggregationAsync<T>(
        TAggregateKey aggregateKey,
        Expression<Func<TStorage, T>> selectFunc,
        CancellationToken cancellationToken = default);

#if NET7_0_OR_GREATER
    [Pure]
    Task<IReadOnlyList<T>> RetrieveAggregationAsync<T>(
        TAggregateKey aggregateKey,
        CancellationToken cancellationToken = default) where T: IMappable<TStorage, T>;
#endif
}
public interface ISimpleAggregateDataStore<TStorage, in TAggregateKey> : IAggregateDataStore<TStorage, TAggregateKey>
    where TStorage : class
    where TAggregateKey : struct, IEquatable<TAggregateKey>
{
    [Pure]
    Task<IReadOnlyList<TStorage>> RetrieveAggregationManyAsync(
        IReadOnlyCollection<TAggregateKey> aggregateKeys,
        CancellationToken cancellationToken = default);

    [Pure]
    Task<IReadOnlyList<TStorage>> RetrieveAggregationManyAsync(
        IReadOnlyCollection<TAggregateKey> aggregateKeys,
        IInclusion<TStorage>? inclusion,
        CancellationToken cancellationToken = default);

    [Pure]
    Task<IReadOnlyList<T>> RetrieveAggregationManyAsync<T>(
        IReadOnlyCollection<TAggregateKey> aggregateKeys,
        Expression<Func<TStorage, T>> selectFunc,
        CancellationToken cancellationToken = default);

#if NET7_0_OR_GREATER
    [Pure]
    Task<IReadOnlyList<T>> RetrieveAggregationManyAsync<T>(
        IReadOnlyCollection<TAggregateKey> aggregateKeys,
        CancellationToken cancellationToken = default) where T: IMappable<TStorage, T>;
#endif
}
