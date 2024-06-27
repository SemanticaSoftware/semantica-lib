namespace Semantica.Domain.DesignAttributes;

/// <summary>
/// <para>
/// Describes the kind of a key type or property.
/// </para>
/// <para>
/// <see href="https://en.wikipedia.org/wiki/Unique_key">Wiki Unique Key.</see>
/// <a href="https://en.wikipedia.org/wiki/Unique_key">Wiki Unique Key.</a>
/// </para>
/// </summary>
[Flags]
public enum KeyKind
{
    /// <summary>
    /// Indicates a (unique) key of it's entity or in the current context. Can only be 0 for _properties_ that are (foreign)
    /// references that represent many-to-one relationships    
    /// </summary>
    Unique = 1,
    /// <summary>
    /// <para>
    /// The key that is selected as the primary key. Only one key within an entity is selected to be the primary key. This is the key that is allowed to migrate to other entities to define the relationships that exist among the entities.
    /// </para>
    /// <para>
    /// A value of 0 for this flag means the key is an Alternate key.
    /// </para>
    /// </summary>
    Primary = 1 << 1 | Unique,
    /// <summary>
    /// A key that has migrated to another entity.  
    /// </summary>
    Foreign = 1 << 2, 
    /// <summary>
    /// <para>
    /// A key made from at least two attributes.
    /// </para>
    /// <para>
    /// A value of 0 for this flag means the key is a Simple key (or a Concatenated key, which is functionally equivalent).
    /// </para>
    /// </summary>
    Composite = 1 << 3,
    /// <summary>
    /// <para>
    /// </para>
    /// <para>
    /// A value of 0 for this flag means the key is a Surrogate key
    /// </para>
    /// </summary>
    Natural = 1 << 4,
    /// <summary>
    /// The value of the key is a single integer. Invalid for <see cref="Composite"/> keys. Mutually exclusive with <see cref="Guid"/>.
    /// </summary>
    Integer = 1 << 5, //
    /// <summary>
    /// The value of the key is a single <see cref="Guid"/>. Invalid for <see cref="Composite"/> keys. Mutually exclusive with <see cref="Integer"/>.
    /// </summary>
    Guid = 1 << 6, 
    /// <summary>
    /// Typical identity (ID)
    /// </summary>
    Id = Primary | Integer,
    /// <summary>
    /// Typical for an entity with a one-to-zero-or-one relationship with it's principal.  
    /// </summary>
    ForeignId = Id | Foreign
}