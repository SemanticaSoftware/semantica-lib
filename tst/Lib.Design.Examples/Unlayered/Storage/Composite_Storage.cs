using System.Linq.Expressions;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Storage;

class CompositeUnlayeredPredicateProvider : IPredicateProvider<CompositeUnlayeredModel, CompositeKey>
{
    public Expression<Func<CompositeUnlayeredModel, bool>> IsMatch(CompositeKey key)
    {
        var simpleId = key.ForeignKey.Id;
        var kind = (char)key.Kind;
        return storageRow => storageRow.SimpleId == simpleId && storageRow.Kind == kind;
    }
}