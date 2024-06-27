namespace Semantica.Domain;

/// <summary>
/// Implement on any model class that represents a single entity or value object in the domain that has a key, and has been
/// persisted in the repository.
/// </summary>
/// <typeparam name="TKey"> The type of the key. </typeparam>
public interface IDomainModel<out TKey>
    where TKey: struct, IEquatable<TKey>
{
    TKey Key { get; }
}