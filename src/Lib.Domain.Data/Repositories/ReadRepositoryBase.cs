using System.Threading;
using System.Threading.Tasks;
using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Repositories;
using Semantica.Storage.DataStores;

#pragma warning disable CS1712

namespace Semantica.Domain.Data.Repositories;

/// <summary>
/// Base class that provides default implementations for all methods of <see cref="IReadRepository{TDomain,TKey}"/>.
/// </summary>
/// <typeparam name="TStorage"> Type of the storage model class used to represent the entity or value object. </typeparam>
/// <inheritdoc cref="IReadRepository{TDomain,TKey}"/>
public abstract class ReadRepositoryBase<TStorage, TDomain, TKey> : IReadRepository<TDomain, TKey>
    where TStorage : class, new()
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
    private readonly IStorageConverter<TStorage, TDomain, TKey> _converter;

    protected ReadRepositoryBase(IDataStore<TStorage, TKey> dataStore, IStorageConverter<TStorage, TDomain, TKey> converter)
    {
        DataStore = dataStore;
        _converter = converter;
    }

    protected virtual IStorageConverter<TStorage, TDomain, TKey> Converter => _converter;
    protected IDataStore<TStorage, TKey> DataStore { get; }

    public virtual bool Contains(TKey key)
    {
        return DataStore.Exists(key);
    }

    public virtual Task<bool> ContainsAsync(TKey key, CancellationToken cancellationToken = default)
    {
        return DataStore.ExistsAsync(key, cancellationToken);
    }

    public virtual async Task<TDomain?> GetAsync(TKey key, CancellationToken cancellationToken = default)
    {
        var storageModel = await DataStore.RetrieveAsync(key, cancellationToken);
        if (storageModel == null) return null;
        
        var domainModel = Converter.ToDomain(storageModel);
        return domainModel;
    }

    public async Task<IReadOnlyList<TDomain>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var storageModels = await DataStore.RetrieveAllAsync(cancellationToken);
        var domainModels = storageModels.SelectArray(Converter.ToDomain);
        return domainModels!;
    }

    public virtual async Task<IReadOnlyList<TDomain>> GetListAsync(IEnumerable<TKey> keys, CancellationToken cancellationToken = default)
    {
        var storageModels = await DataStore.RetrieveManyAsync(keys.AsReadOnlyCollection(), cancellationToken);
        var domainModels = storageModels.SelectArray(Converter.ToDomain);
        return domainModels!;
    }

    public virtual async Task<IReadOnlyList<TDomain?>> GetListInMatchingOrderAsync(IEnumerable<TKey> keys, CancellationToken cancellationToken = default)
    {
        var keyCollection = keys.AsReadOnlyCollection();
        var domainModels = await GetListAsync(keyCollection, cancellationToken);
        var orderedDomainModels = keyCollection.SelectArray(
                key => domainModels.FirstOrDefault(model => key.Equals(model.Key))
            );
        return orderedDomainModels;
    }
}
