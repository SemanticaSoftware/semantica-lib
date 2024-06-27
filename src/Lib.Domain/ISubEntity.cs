using Semantica.Patterns.Domain;

namespace Semantica.Domain;

/// <summary>
/// Implement on a model class that represents an entity that shares identity with a principal entity, but uses a different key
/// type for differentiation, but that type only contains the key of the principal entity. The relation of this entity to its
/// principal should be zero-or-one to one. When this is all the case, we call the dependent entity a subentity. Only relevant
/// for model classes that have been persisted in the repository.
/// </summary>
/// <typeparam name="TSubKey"> Key type of the sub entity. </typeparam>
/// <typeparam name="TPrincipalKey"> Key type of the principal entity that is contained in the subkey. </typeparam>
public interface ISubEntity<out TSubKey, out TPrincipalKey> : IDomainModel<TSubKey>
    where TSubKey: struct, IEquatable<TSubKey>, ISubKey<TPrincipalKey> 
    where TPrincipalKey : struct, IEquatable<TPrincipalKey>
{
}