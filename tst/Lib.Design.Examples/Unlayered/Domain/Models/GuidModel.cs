using Semantica.Domain;
using Semantica.Domain.DesignAttributes;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

[Entity(KeyKind.Guid, EntityName = nameof(Guid), ModuleName = SimpleRootUnlayered.Module)]
public record GuidModel : ISimpleDomainModel<Guid>
{
    public Guid Key { get; set; }

    public int Value { get; set; }
}