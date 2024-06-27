using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.PredicateProviders;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.PredicateProviders;

public class RootPredicateProvider : IRootPredicateProvider
{
    public Expression<Func<Root, bool>> IsMatch(RootKey key)
    {
        return ar => ar.Id == key.Id;
    }

    public Expression<Func<Root, bool>> MatchesAny(IReadOnlyCollection<RootKey> keys)
    {
        var ids = keys.Select(k => k.Id).ToArray();
        return ar => ids.Contains(ar.Id);
    }
}