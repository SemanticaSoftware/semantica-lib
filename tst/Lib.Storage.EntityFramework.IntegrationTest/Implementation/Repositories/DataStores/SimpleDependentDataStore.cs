using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.DataStores;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.PredicateProviders;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Storage;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.DataStores;

public class SimpleDependentDataStore : SimpleDataStore<SimpleDependent, SimpleDependentKey>, ISimpleDependentDataStore
{
    private readonly ISimpleAggregateDataStoreInternal<SimpleDependent, RootKey> _aggregateDataStore;

    public SimpleDependentDataStore(
            IDbContextProvider context,
            ISimpleAggregateDataStoreInternal<SimpleDependent, RootKey> aggregateDataStore,
            IStorageCache<SimpleDependentKey, SimpleDependent> cache,
            IKeyConverter<SimpleDependent, SimpleDependentKey> keyConverter,
            ISimpleDependentPredicateProvider predicateProvider
        ) : base(context, cache, keyConverter, predicateProvider)
    {
        _aggregateDataStore = aggregateDataStore;
    }

    private ISimpleDependentPredicateProvider SpecificPredicateProvider => (ISimpleDependentPredicateProvider) PredicateProvider;

    #region delegated ISimpleAggregateDataStore members
    
    public Task<IReadOnlyList<SimpleDependent>> RetrieveAggregationAsync(RootKey aggregateKey, CancellationToken cancellationToken = default)
    {
        return _aggregateDataStore.RetrieveAggregationAsync(aggregateKey, cancellationToken);
    }
    
    public Task<IReadOnlyList<SimpleDependent>> RetrieveAggregationAsync(RootKey aggregateKey, IInclusion<SimpleDependent> inclusion, CancellationToken cancellationToken = default)
    {
        return _aggregateDataStore.RetrieveAggregationAsync(aggregateKey, inclusion, cancellationToken);
    }
    
    public Task<IReadOnlyList<T>> RetrieveAggregationAsync<T>(RootKey aggregateKey, Expression<Func<SimpleDependent, T>> selectFunc, CancellationToken cancellationToken = default)
    {
        return _aggregateDataStore.RetrieveAggregationAsync(aggregateKey, selectFunc, cancellationToken);
    }
    
    public Task<IReadOnlyList<T>> RetrieveAggregationAsync<T>(RootKey aggregateKey, CancellationToken cancellationToken = default)
        where T : IMappable<SimpleDependent, T>
    {
        return _aggregateDataStore.RetrieveAggregationAsync<T>(aggregateKey, cancellationToken);
    }
    
    #endregion
}
