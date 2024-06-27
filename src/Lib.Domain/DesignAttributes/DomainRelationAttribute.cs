using System.Diagnostics;
using Semantica.Checks;
using Semantica.Core;

namespace Semantica.Domain.DesignAttributes;

/// <summary>
/// Indicates a property that represents a relationship to another domain object.  
/// </summary>
/// <remark>
/// Will guard for illegal combinations of <see cref="RelationKind"/> flags during construction.
/// </remark>
[Conditional("DOMAIN")]
[AttributeUsage(validOn: AttributeTargets.Property)]
public class DomainRelationAttribute : Attribute
{
    public DomainRelationAttribute(RelationKind relationKind)
    {
        Guard.For(Logic.Follows(relationKind.IsOwner(), relationKind.GetCardinalTo() == RelationKind.ToOne));
        
        RelationKind = relationKind;
    }
    public RelationKind RelationKind { get; }
}

/// <summary>
/// Indicates a property that contains a reference to other entity objects.
/// </summary>
/// <inheritdoc/>
[Conditional("DOMAIN")]
public class EntityRelationAttribute : DomainRelationAttribute
{
    public EntityRelationAttribute(RelationKind relationKind) : base(relationKind)
    {
        Guard.For(! relationKind.HasFlag(RelationKind.ValueObject));
    }
}

/// <summary>
/// Indicates a property that contains an aggregation of owned entity objects.
/// </summary>
/// <inheritdoc/>
[Conditional("DOMAIN")]
public class DependentAttribute : EntityRelationAttribute
{
    /// <summary>
    /// Default relation is <see cref="RelationKind.Owned"/> with one to many cardinality. 
    /// </summary>
    /// <param name="cardinality"></param>
    /// <param name="relationKind">
    ///     Forces <see cref="RelationKind.Owned"/> and <see cref="RelationKind.One"/>.
    /// </param>
    public DependentAttribute(RelationKind cardinality, RelationKind relationKind = RelationKind.Owned | RelationKind.OneToMany)
        : base(relationKind.ForceOwned().ForceFromOne())
    {
        Guard.For(relationKind.HasFlag(RelationKind.ToMore));
    }
}

/// <summary>
/// Indicates a property that contains a reference to a linked entity that is in a different aggregate.
/// </summary>
/// <inheritdoc/>
[Conditional("DOMAIN")]
public class LinkAttribute : EntityRelationAttribute
{
    /// <summary>
    /// Default relation is <see cref="RelationKind.Forward"/> with zero-or-more to zero-or-one cardinality. 
    /// </summary>
    public LinkAttribute(RelationKind relationKind = RelationKind.Forward | RelationKind.More)
        : base(relationKind)
    {
        Guard.For(! relationKind.HasFlag(RelationKind.Ownership));
        Guard.For(! relationKind.HasFlag(RelationKind.ValueObject));
    }
}

/// <summary> Indicates a property that contains a reference to the owning entity object. </summary>
/// <inheritdoc/>
[Conditional("DOMAIN")]
public class OwnerAttribute : EntityRelationAttribute
{
    /// <summary> Default relation is <see cref="RelationKind.Owner"/> with zero-or-more to one cardinality. </summary>
    /// <param name="relationKind">
    /// Forces <see cref="RelationKind.Owner"/> and <see cref="RelationKind.ToOne"/>.
    /// </param>
    public OwnerAttribute(RelationKind relationKind = RelationKind.Owner | RelationKind.ManyToOne)
        : base(relationKind.ForceOwner().ForceToOne())
    {
    }
}

/// <summary> Indicates a property that contains the references of one or a collection of value objects. </summary>
/// <inheritdoc/>
[Conditional("DOMAIN")]
public class ValueAttribute : DomainRelationAttribute
{
    /// <summary>
    /// Default relation is <see cref="RelationKind.OwnedValueObject"/>, (To-) cardinality has to be specified. Left
    /// cardinality is always <see cref="RelationKind.One"/>. 
    /// </summary>
    /// <param name="cardinality"> Used to specify the right (to) side of the cardinality. </param>
    /// <param name="relationKind">
    /// Forces <see cref="RelationKind.OwnedValueObject"/> and <see cref="RelationKind.One"/>.
    /// </param>
    public ValueAttribute(RelationKind cardinality, RelationKind relationKind = RelationKind.OwnedValueObject)
        : base(relationKind.ForceValueObject().ForceCardinal(cardinality.ForceFromOne()))
    {
    }
}