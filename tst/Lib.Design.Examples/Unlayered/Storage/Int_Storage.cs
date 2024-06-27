using System.Linq.Expressions;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Storage;

class IntUnlayeredPredicateProvider : ISimplePredicateProvider<IntModel, int>
{
    public Expression<Func<IntModel, bool>> IsMatch(int key)
    {
        return storageRow => storageRow.Key == key;
    }

    public Expression<Func<IntModel, bool>> MatchesAny(IReadOnlyCollection<int> keys)
    {
        return storageRow => keys.Contains(storageRow.Key);
    }
}