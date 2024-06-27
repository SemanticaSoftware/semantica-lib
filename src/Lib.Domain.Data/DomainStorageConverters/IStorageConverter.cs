using System.Diagnostics.CodeAnalysis;
using Semantica.Domain.Data.Repositories;

namespace Semantica.Domain.Data.DomainStorageConverters;

/// <summary>
/// Converter interface used by the base repository to convert storage models to domain models of one entity or value object.
/// This is the full interface required by <see cref="ReadRepositoryBase{TStorage,TDomain,TKey}"/> base class.
/// </summary>
/// <typeparam name="TStorage"> Storage model type. </typeparam>
/// <typeparam name="TDomain"> Domain model type. </typeparam>
/// <typeparam name="TKey"> Primary key type for the entity or value object in domain. </typeparam>
public interface IStorageConverter<in TStorage, out TDomain, TKey>
    where TDomain : class, IDomainModel<TKey>
    where TStorage : class
    where TKey : struct, IEquatable<TKey>
{
    /// <summary> Converts a storage model instance to its domain model representation. </summary>
    /// <returns> Domain model instance. </returns>
    TDomain ToDomain(TStorage storageModel);
}