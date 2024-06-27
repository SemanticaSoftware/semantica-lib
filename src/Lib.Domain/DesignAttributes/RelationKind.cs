namespace Semantica.Domain.DesignAttributes;

/// <summary> Specifies the cardinality and other attributes of a relationship. </summary>
/// <remarks>
/// If the cardinality of a side is not specified, it's Zero-or-One. If both flags of a side are 1, interpret it as One-or-More.
/// </remarks>
[Flags]
public enum RelationKind
{
    #region cardinality combined
    /// <summary> Specifies a One to Zero-Or-More relationship cardinality. </summary>
    OneToMany = One | ToMore,
    /// <summary> Specifies a Zero-Or-More to One relationship cardinality. </summary>
    ManyToOne = More | ToOne,
    /// <summary> Specifies the left side of the cardinality. </summary>
    OneOrMore = One | More,
    /// <summary> Specifies the right side of the cardinality. </summary>
    ToOneOrMore = ToOne | ToMore,
    #endregion
    
    /// <summary> Specifies the left side of the cardinality. </summary>
    One = 1,
    /// <summary> Specifies the left side of the cardinality. </summary>
    More = 1 << 1,
    /// <summary> Specifies the right side of the cardinality. </summary>
    ToOne = 1 << 2,
    /// <summary> Specifies the right side of the cardinality. </summary>
    ToMore = 1 << 3,

    #region attributes combined
    /// <summary> Indicates that the target of this relationship is an owned value object. </summary>
    OwnedValueObject = Owned | ValueObject,
    /// <summary> Indicates a relationship property on an entity that points to the owned. </summary>
    Owned = Ownership,
    /// <summary> Indicates a relationship property that points to the owner entity. </summary>
    Owner = Ownership | Forward,
    #endregion

    /// <summary>
    /// Setting this flag implies the relationship conveys ownership. <see cref="Forward"/> flag determines direction.
    /// </summary>
    Ownership = 1 << 4,
    /// <summary>
    /// Without the <see cref="Ownership"/> flag set, setting this flag means the target will never reference back, and it's
    /// (potentially) bidirectional otherwise.
    /// With the <see cref="Ownership"/> flag set it means the relation points towards the owner.
    /// </summary>
    Forward = 1 << 5,
    /// <summary>
    /// Indicates that the target of this relationship is a value object, not an entity. Note that a value object is normally
    /// always <see cref="Owner"/>, and never (flag is illegal/ignored if) <see cref="Owned"/>. 
    /// </summary>
    ValueObject = 1 << 6,
}
