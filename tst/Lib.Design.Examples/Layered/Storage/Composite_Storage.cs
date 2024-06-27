using System.Linq.Expressions;
using Semantica.Domain.DesignAttributes;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;
using Semantica.Lib.Tests.Design.Examples.Layered.Storage.Models;
using Semantica.Storage;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Storage
{
    namespace Models
    {
        [DependentEntity<SimpleRootModel>(ModelPurpose.Storage, EntityName = Composite.Name, ModuleName = SimpleRoot.Module)]
        record CompositeStorage
        {
            public int SimpleId { get; init; }

            public char Kind { get; init; }

            public int Value { get; set; }
        }
    }

    class CompositeDataStore : DataStore<CompositeStorage, CompositeKey>, ICompositeDataStore
    {
        public CompositeDataStore(
                IDbContextProvider context,
                IStorageCache<CompositeKey, CompositeStorage> cache,
                IKeyConverter<CompositeStorage, CompositeKey> keyConverter,
                ICompositePredicateProvider predicateProvider
            ) : base(context, cache, keyConverter, predicateProvider)
        {
        }
    }
    
    #region dependencies

    interface ICompositeDataStore : IDataStore<CompositeStorage, CompositeKey>
    {

    }

    interface ICompositePredicateProvider : IPredicateProvider<CompositeStorage, CompositeKey>
    {

    }

    class CompositePredicateProvider : ICompositePredicateProvider
    {
        public Expression<Func<CompositeStorage, bool>> IsMatch(CompositeKey key)
        {
            var simpleId = key.ForeignKey.Id;
            var kind = (char)key.Kind;
            return storageRow => storageRow.SimpleId == simpleId && storageRow.Kind == kind;
        }
    }
    
    #endregion
}