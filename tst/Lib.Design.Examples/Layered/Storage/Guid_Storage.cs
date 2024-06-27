using System.Linq.Expressions;
using Semantica.Domain.DesignAttributes;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Storage
{
    [Entity(primaryKeyKind: KeyKind.Guid, purpose: ModelPurpose.Storage, EntityName = nameof(Guid), ModuleName = SimpleRoot.Module)]
    record GuidStorage
    {
        public Guid Key { get; set; }

        public int Value { get; set; }
    }
    
    class GuidPredicateProvider : ISimplePredicateProvider<GuidStorage, Guid>
    {
        public Expression<Func<GuidStorage, bool>> IsMatch(Guid key)
        {
            return storageRow => storageRow.Key == key;
        }

        public Expression<Func<GuidStorage, bool>> MatchesAny(IReadOnlyCollection<Guid> keys)
        {
            return storageRow => keys.Contains(storageRow.Key);
        }
    }
}