namespace Semantica.Storage;

/// <summary>
/// Generic implementation of <see cref="IKeyConverter{TStorage,TKey}"/> that can be instantiated with delegate functions to
/// provide the conversions.
/// </summary>
/// <typeparam name="TStorage"> Type of the storage model class. </typeparam>
/// <typeparam name="TKey"> Primary key type for the entity or value object in domain. </typeparam>
public class KeyConverter<TStorage, TKey> : IKeyConverter<TStorage, TKey>
    where TKey : struct
{
    private readonly Func<TStorage, TKey> _keyFunc;
    private readonly Func<TKey, TStorage> _modelFunc;

    public KeyConverter(Func<TStorage, TKey> keyFunc, Func<TKey, TStorage> modelFunc)
    {
        _keyFunc = keyFunc;
        _modelFunc = modelFunc;
    }

    public TKey ToKey(TStorage storageModel) => _keyFunc(storageModel);

    public TStorage ToBlankStorageModel(TKey key) => _modelFunc(key);
}
