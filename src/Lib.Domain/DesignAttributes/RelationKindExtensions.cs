using System.Diagnostics.Contracts;

namespace Semantica.Domain.DesignAttributes;

[Pure]
public static class RelationKindExtensions
{
    public static RelationKind ForceCardinal(this RelationKind relationKind, RelationKind cardinal) 
        => (relationKind & ~CardinalMask) | (cardinal & CardinalMask);

    public static RelationKind ForceEntity(this RelationKind relationKind)
        => relationKind & ~RelationKind.ValueObject; 
    
    public static RelationKind ForceFrom(this RelationKind relationKind, RelationKind cardinalFrom) 
        => (relationKind & ~CardinalFromMask) | (cardinalFrom & CardinalFromMask);

    public static RelationKind ForceFromOne(this RelationKind relationKind) 
        => (relationKind & ~CardinalFromMask) | RelationKind.One;
    
    public static RelationKind ForceOwned(this RelationKind relationKind) 
        => (relationKind & ~AttributeMask) | RelationKind.Owned;

    public static RelationKind ForceOwner(this RelationKind relationKind) 
        => (relationKind & ~AttributeMask) | RelationKind.Owner;

    public static RelationKind ForceTo(this RelationKind relationKind, RelationKind cardinalTo) 
        => (relationKind & ~CardinalToMask) | (cardinalTo & CardinalToMask);

    public static RelationKind ForceToOne(this RelationKind relationKind) 
        => (relationKind & ~CardinalToMask) | RelationKind.ToOne;
    
    public static RelationKind ForceValueObject(this RelationKind relationKind) 
        => (relationKind & ~AttributeMask) | RelationKind.OwnedValueObject;
    
    public static RelationKind GetCardinal(this RelationKind relationKind) => relationKind & CardinalMask;
    public static RelationKind GetCardinalFrom(this RelationKind relationKind) => relationKind & CardinalFromMask;
    public static RelationKind GetCardinalTo(this RelationKind relationKind) => relationKind & CardinalToMask;
    
    public static RelationKind GetRelationAttributes(this RelationKind relationKind) => relationKind & AttributeMask;

    public static bool IsForward(this RelationKind relationKind) => (relationKind & OwnershipTypeMask) == RelationKind.Forward;
    
    public static bool IsOwned(this RelationKind relationKind) => (relationKind & OwnershipTypeMask) == RelationKind.Owned;

    public static bool IsOwner(this RelationKind relationKind) => (relationKind & OwnershipTypeMask) == RelationKind.Owner;

    public static bool IsValueObject(this RelationKind relationKind) 
        => (relationKind & AttributeMask) == RelationKind.OwnedValueObject;
     
    internal const RelationKind CardinalMask = CardinalFromMask | CardinalToMask;
    internal const RelationKind CardinalFromMask = RelationKind.OneOrMore;
    internal const RelationKind CardinalToMask = RelationKind.ToOneOrMore;
    internal const RelationKind OwnershipTypeMask = RelationKind.Owner;
    internal const RelationKind AttributeMask = RelationKind.Owner | RelationKind.ValueObject;
}
