namespace Semantica.Domain.Repositories;

/// <summary>
/// An isolated interface providing only the Replace-methods of a repository.
/// </summary>
/// <typeparam name="TDomain"> The type of the model class accepted for the Replace-methods. </typeparam>
/// <typeparam name="TKey"> The type used as key of the elements. </typeparam>
public interface IReplaceRepository<in TDomain, TKey>
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{

    /// <summary>
    /// Sets up replacing the current entity instance in the persistent collection with the provided model. The persistence
    /// isn't finalized until the current <see cref="IUnitOfWork"/> is completed. 
    /// </summary>
    /// <param name="domainModel"> A model representing the entity instance to replace. </param>
    void Replace(TDomain domainModel);

    /// <summary>
    /// Sets up replacing the current entity instances in the persistent collection with the provided models. The persistence
    /// isn't finalized until the current <see cref="IUnitOfWork"/> is completed. 
    /// </summary>
    /// <param name="domainModels"> An enumeration of models representing the entity instance to replace. </param>
    void ReplaceRange(IEnumerable<TDomain> domainModels);    
}
