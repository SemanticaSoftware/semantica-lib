using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Semantica.Order;
using Semantica.Patterns;

namespace Semantica.Storage.DataStores;

public interface IAggregateDataStoreInternal<TStorage, in TAggregateKey> : IAggregateDataStore<TStorage, TAggregateKey>
    where TStorage : class
    where TAggregateKey : struct, IEquatable<TAggregateKey>
{
    Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync<TOrderProp>(
        TAggregateKey aggregateKey,
        Order<TStorage, TOrderProp> orderBy,
        CancellationToken cancellationToken = default)
        where TOrderProp : IComparable<TOrderProp>;

    Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync<TOrderProp, TThenProp>(
        TAggregateKey aggregateKey,
        Order<TStorage, TOrderProp> orderBy,
        Order<TStorage, TThenProp> thenBy,
        CancellationToken cancellationToken = default)
        where TOrderProp : IComparable<TOrderProp>
        where TThenProp : IComparable<TThenProp>;

    Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync<TOrderProp>(
            TAggregateKey aggregateKey,
            IInclusion<TStorage>? inclusion,
            Order<TStorage, TOrderProp> orderBy,
            CancellationToken cancellationToken = default
        )
        where TOrderProp : IComparable<TOrderProp>;

    Task<IReadOnlyList<TStorage>> RetrieveAggregationAsync<TOrderProp, TThenProp>(
        TAggregateKey aggregateKey,
        IInclusion<TStorage>? inclusion,
        Order<TStorage, TOrderProp> orderBy,
        Order<TStorage, TThenProp> thenBy,
        CancellationToken cancellationToken = default)
        where TOrderProp : IComparable<TOrderProp>
        where TThenProp : IComparable<TThenProp>;
}
