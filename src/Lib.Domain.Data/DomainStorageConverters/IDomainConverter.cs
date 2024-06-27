namespace Semantica.Domain.Data.DomainStorageConverters;

/// <summary>
/// Converter interface used by the base repository to convert domain models to storage models of one entity or value object.
/// </summary>
/// <typeparam name="TStorage"> Storage model type. </typeparam>
/// <typeparam name="TDomain"> Domain model type. </typeparam>
public interface IDomainConverter<out TStorage, in TDomain>
    where TDomain : class
    where TStorage : class
{
    /// <summary> Converts a domain model instance to its storage model representation. </summary>
    /// <returns> Storage model instance. </returns>
    TStorage ToStorage(TDomain domainModel);
}
