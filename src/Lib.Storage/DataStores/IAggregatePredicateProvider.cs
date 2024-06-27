using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Semantica.Patterns.Domain;

namespace Semantica.Storage.DataStores;

public interface IAggregatePredicateProvider<TStorage, in TAggregateKey>
    where TStorage : class
    where TAggregateKey : struct
{
    Expression<Func<TStorage, bool>> MatchesAggregateKey(TAggregateKey aggregateKey);

    Expression<Func<TStorage, bool>> MatchesAnyAggregateKey(IReadOnlyCollection<TAggregateKey> aggregateKeys);
}