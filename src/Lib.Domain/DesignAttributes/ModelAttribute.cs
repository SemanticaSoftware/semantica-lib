using System.Diagnostics;
using Semantica.Checks;

namespace Semantica.Domain.DesignAttributes;

/// <summary>
/// Indicates any model. Purpose is defined by the <see cref="ModelPurpose"/> property.
/// </summary>
[Conditional("DOMAIN")]
[AttributeUsage(validOn: AttributeTargets.Class | AttributeTargets.Struct)]
public class ModelAttribute : Attribute
{
    public ModelAttribute(KeyKind primaryKeyKind, ModelPurpose purpose = ModelPurpose.Domain)
    {
        PrimaryKeyKind = primaryKeyKind;
        Purpose = purpose;
    }

    public ModelAttribute(ModelPurpose purpose = ModelPurpose.Domain)
        :this(default, purpose)
    { }

    /// <summary>
    /// Type of primary key used for the entity. If a specific struct is used for the key in <see cref="IDomainModel{TKey}"/>,
    /// and that key has a <see cref="DomainKeyAttribute"/>, this value is ignored, and the value indicated in that attribute is
    /// used instead. 
    /// </summary>
    public KeyKind PrimaryKeyKind { get; }

    /// <summary>
    /// Optional. The name of the module that the model is considered to be part of. 
    /// </summary>
    public string? ModuleName { get; init; }
    
    /// <summary>
    /// A flags enum of type <see cref="ModelPurpose"/> that indicates what the model represents, and where and how it is used.  
    /// </summary>
    public ModelPurpose Purpose { get; }
}

/// <summary>
/// Indicates a model that represents a particular entity in your domain.
/// </summary>
[Conditional("DOMAIN")]
public class EntityAttribute : ModelAttribute
{
        
    public string? EntityName { get; init; }

    public EntityAttribute(KeyKind primaryKeyKind, ModelPurpose purpose = ModelPurpose.Entity) 
        : base(primaryKeyKind | KeyKind.Unique | KeyKind.Primary, purpose | ModelPurpose.Entity)
    { }
    
    public EntityAttribute(ModelPurpose purpose = ModelPurpose.Entity) 
        : base(KeyKind.Unique | KeyKind.Primary, purpose | ModelPurpose.Entity)
    { }

}

/// <summary>
/// Indicates a model that represents a particular value object in your domain.
/// </summary>
[Conditional("DOMAIN")]
public class ValueObjectAttribute : ModelAttribute
{
    public Type? OwnerType { get; }
    
    public ValueObjectAttribute(Type? ownerType, KeyKind primaryKeyKind, ModelPurpose purpose = ModelPurpose.Domain)
        : base(primaryKeyKind, purpose)
    {
        Guard.Contract(! primaryKeyKind.HasFlag(KeyKind.Natural));
        OwnerType = ownerType;
    }
    
    public ValueObjectAttribute(Type? ownerType, ModelPurpose purpose = ModelPurpose.Domain)
        : this(null, default, purpose)
    { }
    
    public ValueObjectAttribute(ModelPurpose purpose = ModelPurpose.Domain)
        : this(null, default, purpose)
    { }
}

/// <summary>
/// Indicates a model that represents a particular entity in your domain that is dependent on some principal entity in the same
/// aggregate.
/// </summary>
[Conditional("DOMAIN")]
public class DependentEntityAttribute : EntityAttribute
{
    public Type PrincipalType { get; }

    public DependentEntityAttribute(
            Type principalType,
            KeyKind primaryKeyKind,
            ModelPurpose purpose = ModelPurpose.Entity
        ) : base(primaryKeyKind, purpose)
    {
        PrincipalType = principalType;
    }
    
    public DependentEntityAttribute(
            Type principalType,
            ModelPurpose purpose = ModelPurpose.Entity
        ) : this(principalType, KeyKind.Unique | KeyKind.Primary, purpose)
    { }
}

/// <summary>
/// Indicates a model that represents a particular entity in your domain that is the root entity in its aggregate.
/// </summary>
[Conditional("DOMAIN")]
public class AggregateRootEntityAttribute : EntityAttribute
{
    public AggregateRootEntityAttribute(KeyKind primaryKeyKind, ModelPurpose purpose = ModelPurpose.Entity)
        : base(primaryKeyKind, purpose)
    { }

    public AggregateRootEntityAttribute(ModelPurpose purpose = ModelPurpose.Entity)
        : this(default, purpose)
    { }
}

#if NET7_0_OR_GREATER

/// <inheritdoc/>
/// <typeparam name="TEntity"> The main type representing the entity that is the principal for this entity. </typeparam>
[Conditional("DOMAIN")]
public class DependentEntityAttribute<TEntity> : DependentEntityAttribute
{
    public DependentEntityAttribute(
        KeyKind primaryKeyKind, 
        ModelPurpose purpose = ModelPurpose.Entity
        ) : base(typeof(TEntity), primaryKeyKind, purpose)
    {
    }

    public DependentEntityAttribute(ModelPurpose purpose = ModelPurpose.Entity) : base(typeof(TEntity), purpose)
    { }
}

/// <inheritdoc/>
/// <typeparam name="TEntity"> The main type representing the entity that is the owner for this value object. </typeparam>
[Conditional("DOMAIN")]
public class ValueObjectAttribute<TEntity> : ValueObjectAttribute
{
    public ValueObjectAttribute(KeyKind primaryKeyKind, ModelPurpose purpose = ModelPurpose.Domain) : base(typeof(TEntity), primaryKeyKind, purpose)
    {
    }
    
    public ValueObjectAttribute(ModelPurpose purpose = ModelPurpose.Domain) : base(typeof(TEntity), purpose)
    {
    }
}

#endif
