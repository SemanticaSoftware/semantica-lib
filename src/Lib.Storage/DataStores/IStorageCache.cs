using System;
using System.Diagnostics.CodeAnalysis;

namespace Semantica.Storage.DataStores;

public interface IStorageCache<TKey, TStorage>
    where TKey : struct, IEquatable<TKey>
    where TStorage : class
{
    bool ContainsAll { get; }
    
    void Cache(TKey key, TStorage model);
    
    void CacheAll(IEnumerable<(TKey key, TStorage model)> tuples);
    
    void Flush();
    
    void Invalidate(TKey key);
    
    bool TryGet(TKey key,[NotNullWhen(returnValue: true)]  out TStorage? model);
    
    bool TryGetAll([NotNullWhen(returnValue: true)] out IEnumerable<TStorage>? models);
}
