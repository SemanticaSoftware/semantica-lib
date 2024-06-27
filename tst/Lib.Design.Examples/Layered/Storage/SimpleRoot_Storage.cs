#nullable enable
using System.Linq.Expressions;
using Semantica.Domain;
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
        [AggregateRootEntity(ModelPurpose.Storage, EntityName = SimpleRoot.Name, ModuleName = SimpleRoot.Module)]
        record SimpleRootStorage
        {
            public int Id { get; init; }

            public int Progression { get; set; }
    
            public DateTime TimeStamp { get; set; }

            public int Value { get; set; }
            
            public FirstSubStorage? FirstSub { get; set; }
    
            public IEnumerable<LogStorage>? Logs { get; set; }
        }
        
        [DependentEntity<SimpleRootModel>(ModelPurpose.Storage, EntityName = First.Name, ModuleName = SimpleRoot.Module)]
        record FirstSubStorage
        {
            public int Id { get; set; }

            public Guid? Guid { get; set; }

            public decimal Value { get; set; }
            
            public SecondSubStorage? SecondSub { get; set; }
        }
        
        [DependentEntity<FirstSubModel>(ModelPurpose.Storage, EntityName = Second.Name, ModuleName = SimpleRoot.Module)]
        record SecondSubStorage
        {
            public int Id { get; set; }
            
            public decimal Value { get; set; }
        }

        [ValueObject]
        record LogStorage
        {
            public int Id { get; init; }
    
            public DateTime TimeStamp { get; set; }
    
            public string? UserName { get; init; }
        }
    }
    
    class SimpleRootDataStore : SimpleDataStore<SimpleRootStorage, SimpleRootKey>, ISimpleRootDataStore
    {
        public SimpleRootDataStore(
                IDbContextProvider context,
                IStorageCache<SimpleRootKey, SimpleRootStorage> cache,
                IKeyConverter<SimpleRootStorage, SimpleRootKey> keyConverter,
                ISimpleRootPredicateProvider predicateProvider
            ) : base(context, cache, keyConverter, predicateProvider)
        {
        }
    }
    
    #region dependencies

    interface ISimpleRootDataStore : IDataStore<SimpleRootStorage, SimpleRootKey>
    {
    
    }

    interface ISimpleRootPredicateProvider : ISimplePredicateProvider<SimpleRootStorage, SimpleRootKey>
    {
    
    }

    class SimpleRootPredicateProvider : ISimpleRootPredicateProvider
    {
        public Expression<Func<SimpleRootStorage, bool>> IsMatch(SimpleRootKey key)
        {
            var id = key.Id;
            return storageRow => storageRow.Id == id;
        }

        public Expression<Func<SimpleRootStorage, bool>> MatchesAny(IReadOnlyCollection<SimpleRootKey> keys)
        {
            var ids = keys.ToIdArray();
            return storageRow => ids.Contains(storageRow.Id);
        }
    }
    
    #endregion
}