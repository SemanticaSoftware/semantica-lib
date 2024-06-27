using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Semantica.Storage.DataStores;

public interface IDataStore<TStorage, in TKey>
    where TStorage : class
    where TKey : struct, IEquatable<TKey>
{
    bool Exists(TKey key);

    Task<bool> ExistsAsync(TKey key, CancellationToken cancellationToken = default);
    
    bool ExistsMany(IReadOnlyCollection<TKey> keys);
    
    Task<bool> ExistsManyAsync(IReadOnlyCollection<TKey> keys, CancellationToken cancellationToken = default);

    TStorage? Retrieve(TKey key);

    TStorage? Retrieve(TKey key, IInclusion<TStorage>? inclusion);

    T? Retrieve<T>(TKey key, Expression<Func<TStorage, T>> selectFunc);

    TStorage? Retrieve(Expression<Func<TStorage, bool>> predicate);

    TStorage? Retrieve(Expression<Func<TStorage, bool>> predicate, IInclusion<TStorage>? inclusion);

    IReadOnlyList<TStorage> RetrieveAll(bool allModels);

    IReadOnlyList<TStorage> RetrieveAll(IInclusion<TStorage>? inclusion);
    
    IReadOnlyList<T> RetrieveAll<T>(Expression<Func<TStorage, T>> selectFunc);

    Task<TStorage?> RetrieveAsync(TKey key, CancellationToken cancellationToken = default);

    Task<TStorage?> RetrieveAsync(TKey key, IInclusion<TStorage>? inclusion, CancellationToken cancellationToken = default);

    Task<T?> RetrieveAsync<T>(TKey key, Expression<Func<TStorage, T>> selectFunc, CancellationToken cancellationToken = default);

    Task<TStorage?> RetrieveAsync(Expression<Func<TStorage, bool>> predicate, CancellationToken cancellationToken = default);

    Task<TStorage?> RetrieveAsync(Expression<Func<TStorage, bool>> predicate, IInclusion<TStorage>? inclusion, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<TStorage>> RetrieveAllAsync(CancellationToken cancellationToken = default);
    
    Task<IReadOnlyList<TStorage>> RetrieveAllAsync(IInclusion<TStorage>? inclusion, CancellationToken cancellationToken = default);
    
    Task<IReadOnlyList<T>> RetrieveAllAsync<T>(Expression<Func<TStorage, T>> selectFunc, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<TStorage>> RetrieveManyAsync(IReadOnlyCollection<TKey> keys, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<TStorage>> RetrieveManyAsync(IReadOnlyCollection<TKey> keys, IInclusion<TStorage>? inclusion, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<T>> RetrieveManyAsync<T>(IReadOnlyCollection<TKey> keys, Expression<Func<TStorage, T>> selectFunc, CancellationToken cancellationToken = default);


#if NET7_0_OR_GREATER
    T? Retrieve<T>(TKey key) where T: IMappable<TStorage, T>;

    IReadOnlyList<T> RetrieveAll<T>() where T: IMappable<TStorage, T>;

    Task<T?> RetrieveAsync<T>(TKey key, CancellationToken cancellationToken = default) where T: IMappable<TStorage, T>;

    Task<IReadOnlyList<T>> RetrieveAllAsync<T>(CancellationToken cancellationToken = default) where T: IMappable<TStorage, T>;

    Task<IReadOnlyList<T>> RetrieveManyAsync<T>(IReadOnlyCollection<TKey> keys, CancellationToken cancellationToken = default) where T: IMappable<TStorage, T>;
#endif

    void Insert(TStorage storageModel);

    void InsertMany(IEnumerable<TStorage> storageModels);

    void Update(TStorage storageModel);

    void Update(TStorage storageModel, IEnumerable<string>? propertyNamesToSetUnmodified);

    void UpdateColumns(TStorage storageModel, IEnumerable<string> propertyNamesToSetModified);

    void UpdateColumns(TStorage storageModel, string propertyName, params string[] extraProperties);

    void Delete(TKey key);

    void Delete(TStorage storageModel);
}
