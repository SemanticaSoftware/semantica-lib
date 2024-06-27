using System.Linq.Expressions;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Storage;

class GuidUnlayeredPredicateProvider : ISimplePredicateProvider<GuidModel, Guid>
{
    public Expression<Func<GuidModel, bool>> IsMatch(Guid key)
    {
        return storageRow => storageRow.Key == key;
    }

    public Expression<Func<GuidModel, bool>> MatchesAny(IReadOnlyCollection<Guid> keys)
    {
        return storageRow => keys.Contains(storageRow.Key);
    }
}