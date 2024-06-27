#nullable enable
using Semantica.Domain;
using Semantica.Domain.DesignAttributes;
using Semantica.Domain.Electives;
using Semantica.Lib.Tests.Design.Examples.Keys;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;

public interface ISimpleRootModel
{
    int Value { get; set; }
    
    [Dependent(RelationKind.One)]
    FirstSubIsolationModel? FirstSub { get; set; }
}

[AggregateRootEntity(EntityName = SimpleRoot.Name, ModuleName = SimpleRoot.Module)]
public abstract record SimpleRootModelBase : ISimpleDomainModel<SimpleRootKey>, ISimpleRootModel
{
    public virtual SimpleRootKey Key { get; init; }

    public int Value { get; set; }
    
    public int Progression { get; set; }
    
    [Dependent(RelationKind.One)]
    public FirstSubIsolationModel? FirstSub { get; set; }
}

[AggregateRootEntity(ModelPurpose.Isolation)]
public record SimpleRootIsolationModel : SimpleRootModelBase
{
    public DateTime TimeStamp { get; set; }
}

[AggregateRootEntity(ModelPurpose.Isolation | ModelPurpose.Add, EntityName = SimpleRoot.Name, ModuleName = SimpleRoot.Module)]
public record SimpleRootAddModel : ISimpleRootModel
{
    public int Value { get; set; }
    
    public DateTime TimeStamp { get; init; }
    
    [Dependent(RelationKind.One)]
    public FirstSubIsolationModel? FirstSub { get; set; }
}

[AggregateRootEntity(ModelPurpose.Isolation | ModelPurpose.Replace)]
public record SimpleRootReplaceModel : SimpleRootIsolationModel
{
    public string LogUserName { get; init; } = null!;
    
    public DateTime LogTimeStamp { get; init; }
}

[AggregateRootEntity]
public record SimpleRootModel : SimpleRootIsolationModel
{

    [Dependent(RelationKind.One)]
    public new FirstSubModel? FirstSub { get => (FirstSubModel?) base.FirstSub; set => base.FirstSub = value; }
    
    [Dependent(RelationKind.OneToMany)]
    public OwnedList<CompositeModel> Dependents { get; set; }

    [Value(RelationKind.OneToMany)]
    public ElectiveList<LogModel> Logs { get; set; }
}

#region entity statics

public static class SimpleRoot
{
    public const string Module = nameof(Domain);
    public const string Name = nameof(SimpleRoot);
}

#endregion