namespace Semantica.Domain.Repositories;

/// <summary>
/// Collection-like interface that provides persistent storage for the domain entity or value object that is respresented by the
/// indicated model types.
/// </summary>
/// <remarks> Use when different model types are used for add, replace and read methods. </remarks>
/// <typeparam name="TDomainAdd"> The type of the model class accepted for the Add-methods. </typeparam>
/// <typeparam name="TDomainReplace"> The type of the model class accepted for the Replace-methods. </typeparam>
/// <typeparam name="TDomainOut"> The type of the model class returned from the Get-methods. </typeparam>
/// <typeparam name="TKey"> The type used as key of the elements. </typeparam>
public interface IRepository<in TDomainAdd, in TDomainReplace, TDomainOut, TKey>
    : IAddRepository<TDomainAdd, TKey>
        , IReadRepository<TDomainOut, TKey>
        , IRemoveRepository<TKey>
        , IReplaceRepository<TDomainReplace, TKey>
    where TDomainOut : class, IDomainModel<TKey>
    where TDomainAdd : class
    where TDomainReplace : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
}

/// <summary>
/// Collection-like interface that provides persistent storage for the domain entity or value object that is respresented by the
/// indicated model types.
/// </summary>
/// <remarks> Use when one model type is used for adds and another for replace and read methods. </remarks>
/// <typeparam name="TDomainAdd"> The type of the model class accepted for the Add-methods. </typeparam>
/// <typeparam name="TDomain">
/// The type of the model class returned from the Get-methods and accepted for the Replace-methods.
/// </typeparam>
/// <typeparam name="TKey"> The type used as key of the elements. </typeparam>
public interface IRepository<in TDomainAdd, TDomain, TKey> : IRepository<TDomainAdd, TDomain, TDomain, TKey>
    where TDomain : class, IDomainModel<TKey>
    where TDomainAdd : class
    where TKey : struct, IEquatable<TKey>
{
}

/// <summary>
/// Collection-like interface that provides persistent storage for the domain entity or value object that is respresented by the
/// indicated model types.
/// </summary>
/// <remarks> Use when the same model type is used for add, replace and read methods. </remarks>
/// <typeparam name="TDomain"> The type of the model class used to represent the entity. </typeparam>
/// <typeparam name="TKey"> The type used as key of the elements. </typeparam>
public interface IRepository<TDomain, TKey> : IRepository<TDomain, TDomain, TKey>
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{

}
