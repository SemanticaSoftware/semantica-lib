namespace Semantica.Domain.Repositories;

/// <summary>
/// An isolated interface providing onlt the Remove-methods of a repository.
/// </summary>
/// <typeparam name="TKey"> The type used as key of the elements. </typeparam>
public interface IRemoveRepository<in TKey>
    where TKey : struct, IEquatable<TKey>
{
    /// <summary>
    /// Sets up removing the entity instance corresponding to the provided key from the persistent collection. The persistence
    /// isn't finalized until the current <see cref="IUnitOfWork"/> is completed.
    /// </summary>
    /// <param name="key">
    /// A key representing the element instance to be removed.
    /// </param>
    void Remove(TKey key);
    
    /// <summary>
    /// Sets up removing the entity instances corresponding to the provided keys from the persistent collection. The persistence
    /// isn't finalized until the current <see cref="IUnitOfWork"/> is completed.
    /// </summary>
    /// <param name="keys">
    /// An enumeration of keys representing the element instances to be removed.
    /// </param>
    void RemoveRange(IEnumerable<TKey> keys);
}
