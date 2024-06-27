namespace Semantica.Domain.Data.DomainStorageConverters;

/// <summary>
/// Converter interface that is not directly used by repository base classes, but can be helpful as a way to standarize common
/// property assignment in converters when multiple ToStorage implementations are needed. 
/// </summary>
/// <typeparam name="TStorage"> Type of the storage model. </typeparam>
/// <typeparam name="TDomainCommon"> Domain base class/interface that has the common properties. </typeparam>
public interface ICommonPropertyStorageConverter<in TStorage, in TDomainCommon>
{
    /// <summary>
    /// Sets the properties on <paramref name="storageModel"/> that can be accessed through the
    /// <typeparamref name="TDomainCommon"/> type.
    /// </summary>
    /// <param name="storageModel"> Storage model instance to set the properties on. </param>
    /// <param name="domainModel"> Domain model instance (as base type) to get the values from. </param>
    void SetCommonStorageProperties(TStorage storageModel, TDomainCommon domainModel);
}
