using System.Diagnostics;
using Semantica.Domain;
using Semantica.Domain.DesignAttributes;
using Semantica.Domain.Electives;
using Semantica.Lib.Tests.Design.Examples.Keys;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;

[DependentEntity<SimpleRootModel>(ModelPurpose.Repository, EntityName = Composite.Name, ModuleName = SimpleRoot.Module)]
public record CompositeIsolationModel : IDomainModel<CompositeKey>
{
    public CompositeKey Key { get; init; }

    public int Value { get; set; }
}

[DependentEntity<SimpleRootModel>]
public record CompositeModel : CompositeIsolationModel, IOwned<SimpleRootModel>
{
    [Owner]
    public Owner<SimpleRootModel> SimpleRoot { get; set; }
    
    #region IOwned
    public Owner<SimpleRootModel> Owner { set => SimpleRoot = value; }
    
    #endregion
}

#region entity statics

public static class Composite
{
    public const string Name = nameof(Composite);
}

#endregion