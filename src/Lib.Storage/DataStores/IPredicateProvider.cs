using System;
using System.Linq.Expressions;

namespace Semantica.Storage.DataStores;

public interface IPredicateProvider<TStorage, in TKey>
    where TKey : struct
{
    Expression<Func<TStorage, bool>> IsMatch(TKey key);
}