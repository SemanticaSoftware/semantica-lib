using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Semantica.Storage.DataStores;

public interface ISimplePredicateProvider<TStorage, in TKey> : IPredicateProvider<TStorage, TKey>
    where TKey : struct
{
    Expression<Func<TStorage, bool>> MatchesAny(IReadOnlyCollection<TKey> keys);
}