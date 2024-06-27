using Semantica.Domain.Data.Repositories;
using Semantica.Storage;

namespace Semantica.Domain.Data.DomainStorageConverters;

/// <summary>
/// Converter interface used by the base repository to convert storage models to domain models and back of one entity or
/// value object. This is the full interface required by <see cref="AddRemoveRepositoryBase{TStorage,TDomain,TDomainAdd,TKey}"/>
/// base class. 
/// </summary>
/// <remarks> Use when different model types are used for add and read methods. </remarks>
/// <typeparam name="TStorage"> Storage model type. </typeparam>
/// <typeparam name="TDomainOut"> Domain model type. </typeparam>
/// <typeparam name="TDomainAdd"> Domain model type used for creation. </typeparam>
/// <typeparam name="TKey"> Primary key type for the entity or value object in domain. </typeparam>
public interface IAddRemoveReadConverter<TStorage, out TDomainOut, in TDomainAdd, TKey>
    : IDomainConverter<TStorage, TDomainAdd>
        , IKeyConverter<TStorage, TKey>
        , IStorageConverter<TStorage, TDomainOut, TKey>
    where TStorage : class
    where TDomainOut : class, IDomainModel<TKey>
    where TDomainAdd : class
    where TKey : struct, IEquatable<TKey>
{
}

/// <summary>
/// Converter interface used by the base repository to convert storage models to domain models and back of one entity or
/// value object. This is the full interface required by <see cref="AddRemoveRepositoryBase{TStorage,TDomain,TDomain,TKey}"/>
/// base class. 
/// </summary>
/// <remarks> Use when the same model type is used for add and read methods. </remarks>
/// <typeparam name="TStorage"> Storage model type. </typeparam>
/// <typeparam name="TDomain"> Domain model type. </typeparam>
/// <typeparam name="TKey"> Primary key type for the entity or value object in domain. </typeparam>
public interface IAddRemoveReadConverter<TStorage, TDomain, TKey> : IAddRemoveReadConverter<TStorage, TDomain, TDomain, TKey>
    where TStorage : class 
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
}
