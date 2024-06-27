using System.Linq.Expressions;
using Semantica.Domain;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Storage;

class SimpleRootUnlayeredPredicateProvider : ISimplePredicateProvider<SimpleRootUnlayeredModel, SimpleRootKey>
{
    public Expression<Func<SimpleRootUnlayeredModel, bool>> IsMatch(SimpleRootKey key)
    {
        var id = key.Id;
        return storageRow => storageRow.Id == id;
    }

    public Expression<Func<SimpleRootUnlayeredModel, bool>> MatchesAny(IReadOnlyCollection<SimpleRootKey> keys)
    {
        var ids = keys.ToIdArray();
        return storageRow => ids.Contains(storageRow.Id);
    }
}
