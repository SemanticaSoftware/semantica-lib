namespace Semantica.Domain.Repositories;

/// <summary>
/// An isolated interface providing only the Add-methods of a repository.
/// </summary>
/// <typeparam name="TDomain"> The type of the model class accepted for the Add-methods. </typeparam>
/// <typeparam name="TKey"> The type used as key of the entity. </typeparam>
public interface IAddRepository<in TDomain, out TKey>
    where TDomain : class
    where TKey : struct, IEquatable<TKey>
{
    /// <summary>
    /// Sets up adding the provided model to the persistent collection as a new entity instance. The persistence isn't finalized
    /// until the current <see cref="IUnitOfWork"/> is completed. The method returns a function that will return the
    /// new key after completion of the unitofwork (if the technology supports this).
    /// </summary>
    /// <param name="domainModel">
    /// A model representing the new entity instance. If the underlying technology will generate a new key, the domain model
    /// should not contain a (non-empty) primary key.
    /// </param>
    /// <returns> A function that returns the key of the model, when executed after the unitofwork was completed. </returns>
    Func<TKey> Add(TDomain domainModel);

    /// <summary>
    /// Sets up adding the provided collection of models to the persistent collection as a new entity instance. The persistence
    /// isn't finalized until the current <see cref="IUnitOfWork"/> is completed. The method returns an enumeration
    /// of functions that will return the new keys after completion of the unitofwork (if the technology supports this).
    /// </summary>
    /// <param name="domainModels">
    /// An enumeration of models representing the new entity instances. If the underlying technology will generate a new key,
    /// the domain models should not contain a (non-empty) primary key.
    /// </param>
    /// <returns>
    /// An enumeration of functions that returns the key of the model, when executed after the unitofwork was completed.
    /// </returns>
    Func<IEnumerable<TKey>> AddRange(IEnumerable<TDomain> domainModels);
}