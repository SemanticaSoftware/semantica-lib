namespace Semantica.Patterns.Domain;

/// <summary>
/// A key that is a subkey has only one property, which is the inner key. The identity of the sub-entity is always the same as
/// the principal, although not every key of the principal wil be a valid subkey. Use subkeys when other entities can reference
/// the sub-entity, but are not valid for the main entity when it's not also a sub-entity. 
/// </summary>
/// <typeparam name="TKey"> Type of the key of the principal entity. </typeparam>
public interface ISubKey<out TKey>
    where TKey : struct, IEquatable<TKey>
{
    TKey Key { get; }
}
