#nullable enable
using Semantica.Domain;
using Semantica.Domain.DesignAttributes;
using Semantica.Domain.Electives;
using Semantica.Lib.Tests.Design.Examples.Keys;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;

[DependentEntity<SimpleRootModel>(ModelPurpose.Repository, EntityName = First.Name, ModuleName = SimpleRoot.Module)]
public record FirstSubIsolationModel(SimpleRootKey Key) : IDomainModel<SimpleRootKey>
{
    public decimal Value { get; set; }
    
    public Guid GuidKey { get; set; }

    public SecondSubModel? SecondSub { get; set; }
}

[DependentEntity<SimpleRootModel>]
public record FirstSubModel(SimpleRootKey Key) : FirstSubIsolationModel(Key)
{
    [Link]
    public Elective<GuidModel?> Guid { get; set; } 
}


#region entity statics

public static class First
{
    public const string Name = nameof(First);
}

#endregion