#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
using Semantica.Domain;
using Semantica.Domain.DesignAttributes;
using Semantica.Lib.Tests.Design.Examples.Keys;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

[AggregateRootEntity(SimpleRootUnlayered.Key, ModelPurpose.Repository | ModelPurpose.Storage, EntityName = SimpleRootUnlayered.Name, ModuleName = SimpleRootUnlayered.Module)]
public record SimpleRootUnlayeredModel : ISimpleDomainModel<SimpleRootKey>
{
    
    [NotMapped]
    public SimpleRootKey Key
    {
        get => new SimpleRootKey(Id);
        init => Id = value.Id;
    }
    
    public int Id  { get; init; }

    public int Value { get; set; }
    
    public int Progression { get; set; }
    
    [Dependent(RelationKind.One)]
    public FirstUnlayeredSubModel? FirstSub { get; set; }
}

#region entity statics

public static class SimpleRootUnlayered
{
    public const KeyKind Key = KeyKind.Id;
    public const string Module = nameof(Domain) + nameof(Unlayered);
    public const string Name = nameof(SimpleRootUnlayered);
}

#endregion