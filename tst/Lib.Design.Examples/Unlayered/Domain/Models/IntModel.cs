using Semantica.Domain;
using Semantica.Domain.DesignAttributes;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

[Entity(KeyKind.Id, EntityName = nameof(Int32), ModuleName = SimpleRootUnlayered.Module)]
public record IntModel : ISimpleDomainModel<int>
{
    public int Key { get; set; }

    public int Value { get; set; }
}