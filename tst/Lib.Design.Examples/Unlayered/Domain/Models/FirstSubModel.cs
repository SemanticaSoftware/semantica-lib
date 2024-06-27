#nullable enable
using Semantica.Domain;
using Semantica.Domain.DesignAttributes;
using Semantica.Domain.Electives;
using Semantica.Lib.Tests.Design.Examples.Keys;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

[DependentEntity<SimpleRootUnlayeredModel>(FirstUnlayered.Key, purpose: ModelPurpose.Repository | ModelPurpose.Storage, EntityName = FirstUnlayered.Name, ModuleName = SimpleRootUnlayered.Module)]
public record FirstUnlayeredSubModel(SimpleRootKey Key) : IDomainModel<SimpleRootKey>
{
    public decimal Value { get; set; }
    
    public Guid GuidKey { get; set; }

    public SecondUnlayeredSubModel? SecondSub { get; set; }

    [Link]
    public Elective<GuidModel?> Guid { get; set; } 
}

#region entity statics

public static class FirstUnlayered
{
    public const KeyKind Key = SimpleRootUnlayered.Key | KeyKind.Foreign;
    public const string Name = nameof(FirstUnlayered);
}

#endregion