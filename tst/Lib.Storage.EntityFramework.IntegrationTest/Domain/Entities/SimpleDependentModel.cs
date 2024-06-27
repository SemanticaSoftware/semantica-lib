using Semantica.Domain;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;

public class SimpleDependentModel : ISimpleDomainModel<SimpleDependentKey>
{
    public SimpleDependentKey Key { get; set; }
    public RootKey RootKey { get; set; }
    public bool DependentProp { get; set; }
}