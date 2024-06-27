using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.DataStores;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.PredicateProviders;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Storage;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.DataStores;

public class RootDataStore : SimpleDataStore<Root, RootKey>, IRootDataStore
{
    public RootDataStore(
            IDbContextProvider context,
            IStorageCache<RootKey, Root> cache,
            IKeyConverter<Root, RootKey> keyConverter,
            IRootPredicateProvider predicateProvider
        ) : base(context, cache, keyConverter, predicateProvider)
    {
    }
}