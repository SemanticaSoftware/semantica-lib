using Semantica.Domain.DesignAttributes;

namespace Semantica.Domain.Electives;

/// <summary>
/// <para>
/// Indicates an entity type that is the target of an <see cref="IElective{T}"/> that conveys ownership. 
/// </para>
/// <para>
/// Note that only entities can be owned, and value objects should never be owned. An entity can have only one direct owner.
/// It can have more owners through transitivity.  
/// </para>
/// </summary>
public interface IOwned { }

/// <inheritdoc />
/// <typeparam name="TOwner"> The entity type that owns this type. </typeparam>
public interface IOwned<TOwner> : IOwned
{
    /// <summary>
    /// When loaded, contains a reference to the owning entity.
    /// </summary>
    [Owner]
    Owner<TOwner> Owner { set; }
}
