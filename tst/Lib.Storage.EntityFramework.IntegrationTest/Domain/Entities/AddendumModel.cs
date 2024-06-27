using Semantica.Domain;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.ValueTypes;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;

public class AddendumModel : ISimpleDomainModel<RootKey>
{
    public RootKey Key { get; set; }

    public int AddendumProp { get; set; }

    public int ImmutableAddendumProp { get; set; }

    public ValueTypeModel? Values { get; set; }
}