using System.ComponentModel.DataAnnotations.Schema;
using Semantica.Domain;
using Semantica.Domain.DesignAttributes;
using Semantica.Lib.Tests.Design.Examples.Keys;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

[DependentEntity<SimpleRootUnlayeredModel>(CompositeUnlayered.Key, purpose: ModelPurpose.Repository | ModelPurpose.Storage, EntityName = CompositeUnlayered.Name, ModuleName = SimpleRootUnlayered.Module)]
public record CompositeUnlayeredModel :  IDomainModel<CompositeKey>
{

    [NotMapped]
    public CompositeKey Key
    {
        get => new CompositeKey(new SimpleRootKey(SimpleId), (Kind)Kind);
        init
        {
            SimpleId = value.ForeignKey.Id;
            Kind = (char)value.Kind;
        }
    }

    public int SimpleId { get; init; }
    
    public char Kind { get; init; }
    
    public int Value { get; set; }

}

#region entity statics

public static class CompositeUnlayered
{
    public const KeyKind Key = KeyKind.Primary | KeyKind.Composite;
    public const string Name = nameof(CompositeUnlayered);
}

#endregion