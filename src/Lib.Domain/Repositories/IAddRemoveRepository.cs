namespace Semantica.Domain.Repositories;

/// <summary>
/// Collection-like interface that provides persistent storage for the domain entity or value object that is respresented by the
/// indicated model types.
/// This interface supports only read, add and remove methods, and does not support replacing entities.  
/// </summary>
/// <remarks> Use when different model types are used for add and read methods. </remarks>
/// <typeparam name="TDomainAdd"> The type of the model class accepted for the Add-methods. </typeparam>
/// <typeparam name="TDomain"> The type of the model class accepted for the Replace-methods. </typeparam>
/// <typeparam name="TKey"> The type used as key of the elements. </typeparam>
public interface IAddRemoveRepository<in TDomainAdd, TDomain, TKey>
    : IAddRepository<TDomainAdd, TKey>, IReadRepository<TDomain, TKey>, IRemoveRepository<TKey>
    where TDomain : class, IDomainModel<TKey>
    where TDomainAdd : class
    where TKey : struct, IEquatable<TKey>
{
}

/// <summary>
/// Collection-like interface that provides persistent storage for the entity that is respresented by the provided domain models.
/// This interface supports only read, add and remove methods, and does not support replacing entities.  
/// </summary>
/// <remarks> Use when the same model type is used for add and read methods. </remarks>
/// <typeparam name="TDomain"> The type of the model class used to represent the entity. </typeparam>
/// <typeparam name="TKey"> The type used as key of the elements. </typeparam>
public interface IAddRemoveRepository<TDomain, TKey> : IAddRemoveRepository<TDomain, TDomain, TKey>
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
}
