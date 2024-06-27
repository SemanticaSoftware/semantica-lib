namespace Semantica.Domain.Data.DomainStorageConverters;

/// <summary>
/// A converter interface used to make replicates (copies) of a storage model. Replicating creates a new instance (key is not
/// copied), with the same values as the original, that can be added using the datastore. If the primary key is generated in
/// the storage system (e.g. database) itself, new key value should not be provided, otherwise it should.
/// </summary>
/// <typeparam name="TStorage"> Type of the storage model. </typeparam>
/// <typeparam name="TKey"> Primary key type for the entity or value object in domain. </typeparam>
public interface IStorageReplicator<TStorage, TKey>
    where TKey: struct, IEquatable<TKey>
{
    /// <summary>
    /// Makes a copy of <paramref name="storageModel"/>. Primary key is not copied.
    /// </summary>
    /// <param name="storageModel"> Storage model instance to copy. </param>
    /// <param name="newKey">
    /// Optional. Primary key value for the new instance. Omit iff storage system generates the new id.
    /// </param>
    /// <returns> A new storage model instance. </returns>
    TStorage Replicate(TStorage storageModel, TKey? newKey = default);
}
