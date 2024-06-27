using System.Diagnostics.CodeAnalysis;

namespace Semantica.Domain.Data.DomainStorageConverters;

/// <summary>
/// Converter interface to convert storage models to domain models of one entity or value object. The domain model type is the
/// type used as the aggregation domain model. i.e. a model type with properties that reference other domain model types, and
/// is not used in the repository.   
/// </summary>
/// <remarks>
/// Implement this interface on a domain storage converter when you have an aggregation model type, and use it in your
/// aggregators.
/// </remarks>
/// <typeparam name="TStorage"> Storage model type. </typeparam>
/// <typeparam name="TDomain"> Aggregation domain model type. </typeparam>
public interface IAggregationStorageConverter<in TStorage, out TDomain>
    where TDomain : class
    where TStorage : class
{
    /// <summary> Converts a storage model instance to its domain model representation. </summary>
    /// <returns> Domain model instance. </returns>
    TDomain ToAggregation(TStorage storageModel);
}
