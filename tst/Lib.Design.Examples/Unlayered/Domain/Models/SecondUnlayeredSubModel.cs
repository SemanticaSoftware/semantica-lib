using Semantica.Domain;
using Semantica.Domain.DesignAttributes;
using Semantica.Lib.Tests.Design.Examples.Keys;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

[DependentEntityAttribute<FirstUnlayeredSubModel>(SecondUnlayered.Key, purpose: ModelPurpose.Repository | ModelPurpose.Storage, EntityName = SecondUnlayered.Name, ModuleName = SimpleRootUnlayered.Module)]
public record SecondUnlayeredSubModel(SecondSubKey Key) : ISubEntity<SecondSubKey, SimpleRootKey>
{
    public decimal Value { get; set; }
}

#region entity statics

public static class SecondUnlayered
{
    public const KeyKind Key = SimpleRootUnlayered.Key | KeyKind.Foreign;
    public const string Name = nameof(SecondUnlayered);
}

#endregion