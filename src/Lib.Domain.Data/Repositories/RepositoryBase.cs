using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Repositories;
using Semantica.Storage.DataStores;

#pragma warning disable CS1712

namespace Semantica.Domain.Data.Repositories;

/// <summary>
/// Base class that provides default implementations for all methods of
/// <see cref="IRepository{TDomainOut,TDomainAdd,TDomainReplace,TKey}"/>.
/// </summary>
/// <remarks> Use when different model types are used for add, replace and read methods. </remarks>
/// <typeparam name="TStorage"> Type of the storage model class used to represent the entity or value object. </typeparam>
/// <inheritdoc cref="IRepository{TDomainAdd,TDomainReplace,TDomainOut,TKey}"/>
public abstract class RepositoryBase<TStorage, TDomainAdd, TDomainReplace, TDomainOut, TKey>
    : AddRemoveRepositoryBase<TStorage, TDomainAdd, TDomainOut, TKey>
        , IRepository<TDomainAdd, TDomainReplace, TDomainOut, TKey>
    where TStorage : class, new()
    where TDomainOut : class, IDomainModel<TKey>
    where TDomainAdd : class
    where TDomainReplace : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
    protected RepositoryBase(
            IDataStore<TStorage, TKey> dataStore,
            IDomainStorageConverter<TStorage, TDomainAdd, TDomainReplace, TDomainOut, TKey> converter
        ) : base(dataStore, converter)
    {
        PropertyNames = null;
    }
    
    protected RepositoryBase(
            IDataStore<TStorage, TKey> dataStore,
            IDomainStorageConverter<TStorage, TDomainAdd, TDomainReplace, TDomainOut, TKey> converter,
            IPropertyAnalyser? analyser
        ) : base(dataStore, converter)
    {
        PropertyNames = analyser == null 
            ? null 
            : new Lazy<PropertyAnalysisResult>(analyser.GetOrAnalyse<TStorage>);
    }

    protected Lazy<PropertyAnalysisResult>? PropertyNames { get; }
    
    protected override IDomainStorageConverter<TStorage, TDomainAdd, TDomainReplace, TDomainOut, TKey> Converter 
        => (IDomainStorageConverter<TStorage, TDomainAdd, TDomainReplace, TDomainOut, TKey>)base.Converter;

    public virtual void Replace(TDomainReplace domainModel)
    {
        var storageModel = Converter.ToStorage(domainModel);
        DataStore.Update(storageModel, PropertyNames?.Value.ImmutableProperties);
    }

    public virtual void ReplaceRange(IEnumerable<TDomainReplace> domainModels)
    {
        foreach (var model in domainModels)
        {
            Replace(model);
        }
    }
}

/// <summary>
/// Base class that provides default implementations for all methods of <see cref="IRepository{TDomainAdd,TDomain,TKey}"/>.
/// </summary>
/// <remarks> Use when one model type is used for adds and another for replace and read methods. </remarks>
/// <typeparam name="TStorage"> Type of the storage model class used to represent the entity or value object. </typeparam>
/// <inheritdoc cref="IRepository{TDomainAdd, TDomain, TKey}"/>
public abstract class RepositoryBase<TStorage, TDomainAdd, TDomain, TKey>
    : RepositoryBase<TStorage, TDomainAdd, TDomain, TDomain, TKey>
        , IRepository<TDomainAdd, TDomain, TKey>
    where TStorage : class, new()
    where TDomainAdd : class
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
    protected RepositoryBase(
            IDataStore<TStorage, TKey> dataStore,
            IDomainStorageConverter<TStorage, TDomainAdd, TDomain, TDomain, TKey> converter,
            IPropertyAnalyser? analyser
        )
        : base(dataStore, converter, analyser)
    {
    }
}

/// <summary>
/// Base class that provides default implementations for all methods of <see cref="IRepository{TDomain, TKey}"/>.
/// </summary>
/// <remarks> Use when the same model type is used for add, replace and read methods. </remarks>
/// <typeparam name="TStorage"> Type of the storage model class used to represent the entity or value object. </typeparam>
/// <inheritdoc cref="IRepository{TDomain, TKey}"/>
public abstract class RepositoryBase<TStorage, TDomain, TKey>
    : RepositoryBase<TStorage, TDomain, TDomain, TDomain, TKey>
        , IRepository<TDomain, TKey>
    where TStorage : class, new()
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
    protected RepositoryBase(
            IDataStore<TStorage, TKey> dataStore,
            IDomainStorageConverter<TStorage, TDomain, TDomain, TDomain, TKey> converter,
            IPropertyAnalyser? analyser
        )
        : base(dataStore, converter, analyser)
    {
    }
}