using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Repositories;
using Semantica.Storage.DataStores;

#pragma warning disable CS1712

namespace Semantica.Domain.Data.Repositories;

/// <summary>
/// Base class that provides default implementations for all methods of
/// <see cref="IAddRemoveRepository{TDomain,TDomainAdd,TKey}"/>.
/// </summary>
/// <remarks> Use when different model types are used for add and read methods. </remarks>
/// <typeparam name="TStorage"> Type of the storage model class used to represent the entity or value object. </typeparam>
/// <inheritdoc cref="IAddRemoveRepository{TDomain,TDomainAdd,TKey}"/>
public abstract class AddRemoveRepositoryBase<TStorage, TDomainAdd, TDomain, TKey>
    : ReadRepositoryBase<TStorage, TDomain, TKey>, IAddRemoveRepository<TDomainAdd, TDomain, TKey>
    where TStorage : class, new()
    where TDomain : class, IDomainModel<TKey>
    where TDomainAdd : class
    where TKey : struct, IEquatable<TKey>
{
    protected AddRemoveRepositoryBase(
            IDataStore<TStorage, TKey> dataStore,
            IAddRemoveReadConverter<TStorage, TDomain, TDomainAdd, TKey> converter
        )
        : base(dataStore, converter)
    {
    }
    
    protected override IAddRemoveReadConverter<TStorage, TDomain, TDomainAdd, TKey> Converter 
        => (IAddRemoveReadConverter<TStorage, TDomain, TDomainAdd, TKey>)base.Converter;

    public virtual Func<TKey> Add(TDomainAdd domainModel)
    {
        var storageModel = Converter.ToStorage(domainModel);
        DataStore.Insert(storageModel);
        return () => Converter.ToKey(storageModel);
    }

    public virtual Func<IEnumerable<TKey>> AddRange(IEnumerable<TDomainAdd> domainModels)
    {
        var storageModels = domainModels.AsReadOnlyCollection().SelectArray(Converter.ToStorage);
        DataStore.InsertMany(storageModels);
        return () => storageModels.Select(Converter.ToKey);
    }

    public virtual void Remove(TKey key)
    {
        DataStore.Delete(key);
    }

    public virtual void RemoveRange(IEnumerable<TKey> keys)
    {
        foreach (var key in keys)
        {
            Remove(key);
        }
    }
}
