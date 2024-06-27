using System;

namespace Semantica.Storage.DataStores;

public interface ISimpleAggregateDataStoreInternal<TStorage, in TAggregateKey>
    : IAggregateDataStoreInternal<TStorage, TAggregateKey>, ISimpleAggregateDataStore<TStorage, TAggregateKey>
    where TStorage : class
    where TAggregateKey : struct, IEquatable<TAggregateKey>
{
}
