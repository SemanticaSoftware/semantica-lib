using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.PredicateProviders;

public interface ISimpleDependentPredicateProvider : ISimplePredicateProvider<SimpleDependent, SimpleDependentKey>, IAggregatePredicateProvider<SimpleDependent, RootKey>
{
}