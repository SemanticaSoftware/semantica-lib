using Semantica.Domain;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.ValueTypes;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;

public class RootModel : ISimpleDomainModel<RootKey>
{
    public RootKey Key { get; set; }
    public string Prop { get; set; }
    public string ImmutableProp { get; set; }
    public string NotMappedProp { get; set; }
    public ValueTypeModel? Values { get; set; }
}