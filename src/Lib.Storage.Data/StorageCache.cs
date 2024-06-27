#nullable enable
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Semantica.Domain;
using Semantica.Storage.DataStores;

namespace Semantica.Storage.Data;

public class StorageCache<TKey, TEntity>: IStorageCache<TKey, TEntity>
    where TEntity : class
    where TKey : struct, IEquatable<TKey>
{
    private readonly ConcurrentDictionary<TKey, TEntity> _dictionary = new();
    
    public bool ContainsAll { get; private set; }

    public StorageCache(IUnitOfWorkManager unitOfWorkManager)
    {
        unitOfWorkManager.AttachWorkCompletedObserver(Flush);
    }

    public bool TryGet(TKey key, [NotNullWhen(returnValue: true)] out TEntity? model)
    {
        return _dictionary.TryGetValue(key, out model);
    }
    
    public bool TryGetAll([NotNullWhen(returnValue: true)] out IEnumerable<TEntity>? models)
    {
        models = ContainsAll ? _dictionary.Values : null;
        return ContainsAll;
    }
    
    public void Cache(TKey key, TEntity model)
    {
        _dictionary[key] = model;
    }

    public void CacheAll(IEnumerable<(TKey key, TEntity model)> tuples)
    {
        ContainsAll = true;
        foreach ((TKey key, TEntity model) in tuples)
        {
            _dictionary[key] = model;
        }
    }


    public void Flush()
    {
        _dictionary.Clear();
        ContainsAll = false;
    }

    public void Invalidate(TKey key)
    {
        if (_dictionary.TryRemove(key, out var entity))
            ContainsAll = false;
    }
}
