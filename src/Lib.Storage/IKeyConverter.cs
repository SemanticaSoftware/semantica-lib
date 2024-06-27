namespace Semantica.Storage;

/// <summary>
///     Generic converter used by the base repository to convert keys into storage models and back.
/// </summary>
/// <typeparam name="TStorage">Storage model type</typeparam>
/// <typeparam name="TKey">Primary key type for entity</typeparam>
public interface IKeyConverter<TStorage, TKey>
    where TKey : struct
{
    /// <summary>
    ///     Makes a key from a storage model.
    /// </summary>
    TKey ToKey(TStorage storageModel);

    /// <summary>
    ///     Creates an empty storage model with only key properties set. Used for removing entities.
    /// </summary>
    TStorage ToBlankStorageModel(TKey key);
}
