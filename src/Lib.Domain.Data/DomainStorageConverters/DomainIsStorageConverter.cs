using Semantica.Storage;

namespace Semantica.Domain.Data.DomainStorageConverters;

/// <summary>
/// Generic implementation for <see cref="IDomainStorageConverter{TStorage,TDomain,TKey}"/>, used when TStorage and TDomain are
/// the same type (i.e., the storage type is also used as domain type). The implementation requires injecting a
/// <see cref="IKeyConverter{TStorage,TKey}"/>.
/// </summary>
/// <typeparam name="TDomain"> Model type used for storage and domain. </typeparam>
/// <typeparam name="TKey"> Primary key type for the entity or value object in domain. </typeparam>
public class DomainIsStorageConverter<TDomain, TKey> : IDomainStorageConverter<TDomain, TDomain, TKey>
    where TDomain : class, IDomainModel<TKey>, new() where TKey : struct, IEquatable<TKey>
{
    private readonly IKeyConverter<TDomain, TKey> _keyConverter;
    
    public DomainIsStorageConverter(IKeyConverter<TDomain, TKey> keyConverter) { _keyConverter = keyConverter; }

    public TDomain ToBlankStorageModel(TKey key) => _keyConverter.ToBlankStorageModel(key);

    public TDomain ToDomain(TDomain storageModel) => storageModel;
    
    public TKey ToKey(TDomain storageModel) => _keyConverter.ToKey(storageModel);

    public TDomain ToStorage(TDomain domainModel) => domainModel;
}