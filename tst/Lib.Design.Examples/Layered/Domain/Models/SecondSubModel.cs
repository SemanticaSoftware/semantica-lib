using Semantica.Domain;
using Semantica.Domain.DesignAttributes;
using Semantica.Lib.Tests.Design.Examples.Keys;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;

[DependentEntity<FirstSubModel>(ModelPurpose.Repository, EntityName = Second.Name, ModuleName = SimpleRoot.Module)]
public record SecondSubModel(SecondSubKey Key) : ISubEntity<SecondSubKey, SimpleRootKey>
{
    public decimal Value { get; set; }
}

#region entity statics

public static class Second
{
    public const string Name = nameof(Second); 
}

#endregion