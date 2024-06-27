using Semantica.Domain.Data.Repositories;

namespace Semantica.Domain.Data.DomainStorageConverters;

/// <summary>
/// Converter interface used by the base repository to convert storage models to domain models and back of one entity or
/// value object. This is the full interface required by
/// <see cref="RepositoryBase{TStorage,TDomainAdd,TDomainReplace,TDomainOut,TKey}"/> base class. 
/// </summary>
/// <remarks> Use when different model types are used for add, replace and read methods. </remarks>
/// <typeparam name="TStorage"> Storage model type. </typeparam>
/// <typeparam name="TDomainOut"> Domain model type </typeparam>
/// <typeparam name="TDomainAdd"> Domain model type for creating. </typeparam>
/// <typeparam name="TDomainReplace"> Domain model type used for replacing. </typeparam>
/// <typeparam name="TKey"> Primary key type for the entity or value object in domain. </typeparam>
public interface IDomainStorageConverter<TStorage, in TDomainAdd, in TDomainReplace, out TDomainOut, TKey>
    : IAddRemoveReadConverter<TStorage, TDomainOut, TDomainAdd, TKey>
    where TStorage : class, new()
    where TDomainOut : class, IDomainModel<TKey>
    where TDomainAdd : class
    where TDomainReplace : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
    TStorage ToStorage(TDomainReplace domainModel);
}

/// <summary>
/// Converter interface used by the base repository to convert storage models to domain models and back of one entity or
/// value object. This is the full interface required by
/// <see cref="RepositoryBase{TStorage,TDomainAdd,TDomain,TKey}"/> base class. 
/// </summary>
/// <remarks> Use when one model type is used for adds and another for replace and read methods. </remarks>
/// <typeparam name="TStorage"> Storage model type. </typeparam>
/// <typeparam name="TDomainAdd"> Domain model type for creating. </typeparam>
/// <typeparam name="TDomain"> Domain model type. </typeparam>
/// <typeparam name="TKey"> Primary key type for the entity or value object in domain. </typeparam>
public interface IDomainStorageConverter<TStorage, in TDomainAdd, TDomain, TKey>
    : IDomainStorageConverter<TStorage, TDomainAdd, TDomain, TDomain, TKey>
    where TStorage : class, new()
    where TDomain : class, IDomainModel<TKey>
    where TDomainAdd : class
    where TKey : struct, IEquatable<TKey>
{
}

/// <summary>
/// Converter interface used by the base repository to convert storage models to domain models and back of one entity or
/// value object. This is the full interface required by
/// <see cref="RepositoryBase{TStorage,TDomain,TKey}"/> base class. 
/// </summary>
/// <remarks> Use when the same model type is used for add, replace and read methods. </remarks>
/// <typeparam name="TStorage">Storage model type</typeparam>
/// <typeparam name="TDomain">Confined domain model type</typeparam>
/// <typeparam name="TKey">Primary key type for entity/model</typeparam>
public interface IDomainStorageConverter<TStorage, TDomain, TKey>
    : IDomainStorageConverter<TStorage, TDomain, TDomain, TDomain, TKey>
    where TStorage : class, new()
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
}