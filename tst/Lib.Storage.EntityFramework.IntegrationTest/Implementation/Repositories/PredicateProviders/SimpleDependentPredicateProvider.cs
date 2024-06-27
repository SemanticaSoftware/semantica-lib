using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.PredicateProviders;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Linq;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.PredicateProviders;

public class SimpleDependentPredicateProvider : ISimpleDependentPredicateProvider
{
    public Expression<Func<SimpleDependent, bool>> IsMatch(SimpleDependentKey key)
    {
        var id = key.Id;
        return sd => sd.Id == id;
    }

    public Expression<Func<SimpleDependent, bool>> MatchesAny(IReadOnlyCollection<SimpleDependentKey> keys)
    {
        var ids = keys.SelectArray(k => k.Id);
        return sd => ids.Contains(sd.Id);
    }

    public Expression<Func<SimpleDependent, bool>> MatchesAggregateKey(RootKey aggregateKey)
    {
        var id = aggregateKey.Id;
        return sd => sd.RootId == id;
    }

    public Expression<Func<SimpleDependent, bool>> MatchesAnyAggregateKey(IReadOnlyCollection<RootKey> aggregateKeys)
    {
        var ids = aggregateKeys.SelectArray(k => k.Id);
        return sd => ids.Contains(sd.RootId);
    }
}