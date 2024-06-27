using Semantica.Domain.DesignAttributes;

namespace Semantica.Domain;

/// <summary>
/// Implement on any model class that represents a single entity or value object in the domain that has a simple key (i.e. the
/// key is not <see cref="KeyKind.Composite"/>.), and has been persisted in the repository.
/// </summary>
/// <typeparam name="TKey"> The type of the simple key. </typeparam>
public interface ISimpleDomainModel<out TKey> : IDomainModel<TKey>
    where TKey: struct, IEquatable<TKey>
{
}
