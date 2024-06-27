using System.Collections;
using JetBrains.Annotations;
using Semantica.Checks;

namespace Semantica.Collections;

/// <summary>
///     Simple implementation for IReadOnlyDictionary that's cheap to create but more expensive to query.
///     Does not enforce uniqueness of keys. In case of multiple equal keys, the value belonging to the first instance of the key is returned.
///     Use for cases where the dictionary interface is convenient for the code, but building a hash-based dictionary would be overkill.
///     Use when individual items are not retrieved more then a couple of times.
/// </summary>
/// <remarks>
/// Most of the IDictionary methods are intentionally unimplemented or delegated.
/// If the Dictionary functionality is needed, a regular Dictionary can be used.
/// This exist, for example, to enumerate over KeyValuePairs or lookup each item once in small lists.
/// </remarks>
/// <typeparam name="TKey">Type of key</typeparam>
/// <typeparam name="TValue">Type of values</typeparam>
public class ArrayDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>, IDictionary<TKey, TValue>
    where TKey: IEquatable<TKey>
{
    private readonly IReadOnlyList<KeyValuePair<TKey, TValue>> _content;

    [CollectionAccess(CollectionAccessType.UpdatedContent)]
    public ArrayDictionary(IEnumerable<KeyValuePair<TKey, TValue>> items)
    {
        Check.NotNull(items).Contract();
        _content = items.ToArray();
    }

    [CollectionAccess(CollectionAccessType.UpdatedContent)]
    public ArrayDictionary(object[][] items)
    {
        Check.NotNull(items).Contract();
        _content = items.Select(ToPair).ToArray();

        KeyValuePair<TKey, TValue> ToPair(object[] item, int i)
        {
            Check.NotNull(item).Contract();
            if (item.Length != 2) Throw.Guard( $"item {i} does note have two subitems", nameof(items));
            if (item[0] is not TKey) Throw.Guard($"item {i} key is not of type {typeof(TKey)}", nameof(items));
            if (item[1] is not TValue) Throw.Guard($"item {i} key is not of type {typeof(TValue)}", nameof(items));
            return new KeyValuePair<TKey, TValue>((TKey) item[0], (TValue) item[1]);
        }
    }

    public int Count => _content.Count;

    public bool IsReadOnly => true;

    public IEnumerable<TKey> Keys => _content.Select(pair => pair.Key);

    public IEnumerable<TValue> Values => _content.Select(pair => pair.Value);

    [CollectionAccess(CollectionAccessType.Read)]
    public TValue this[TKey key]
    {
        get => TryGetValue(key, out var value)
            ? value
            : throw new KeyNotFoundException($"Key [{key}] not found");
    }

    [CollectionAccess(CollectionAccessType.Read)]
    public bool ContainsKey(TKey key)
    {
        return _content.Any(pair => pair.Key.Equals(key));
    }

    [CollectionAccess(CollectionAccessType.Read)]
    public bool TryGetValue(TKey key, out TValue value)
    {
        return _content.Where(pair => pair.Key.Equals(key))
                       .Select(pair => pair.Value)
                       .TryFirst(out value);
    }

    [CollectionAccess(CollectionAccessType.Read)]
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return _content.GetEnumerator();
    }

    [CollectionAccess(CollectionAccessType.Read)]
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    [CollectionAccess(CollectionAccessType.Read)]
    public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
    {
        _content.CopyTo(array);
    }

    // These IDictionary methods are intentionally unimplemented.
    // If the Dictionary functionality is needed, a regular Dictionary can be used.
    // This exist, for example, to enumerate over KeyValuePairs or lookup each item once in small lists.
    #region Unimplemented or delegated IDictionary methods
    
    /// <remarks>
    /// If the Dictionary functionality is needed, a regular Dictionary can be used.
    /// </remarks>
    /// <exception cref="NotImplementedException">The set is intentionally unimplemented.</exception>
    TValue IDictionary<TKey, TValue>.this[TKey key]
    {
        get => this[key];
        set => throw new NotImplementedException();
    }
    ICollection<TValue> IDictionary<TKey, TValue>.Values => Values.ToList();
    ICollection<TKey> IDictionary<TKey, TValue>.Keys => Keys.ToList();
    
    #region Unimplemented IDictionary methods
    
    /// <remarks>
    /// If the Dictionary functionality is needed, a regular Dictionary can be used.
    /// </remarks>
    /// <exception cref="NotImplementedException">This IDictionary method is intentionally unimplemented.</exception>
    public void Add(KeyValuePair<TKey, TValue> item)
    {
        throw new NotImplementedException();
    }

    /// <remarks>
    /// If the Dictionary functionality is needed, a regular Dictionary can be used.
    /// </remarks>
    /// <exception cref="NotImplementedException">This IDictionary method is intentionally unimplemented.</exception>
    public void Clear()
    {
        throw new NotImplementedException();
    }

    /// <remarks>
    /// If the Dictionary functionality is needed, a regular Dictionary can be used.
    /// </remarks>
    /// <exception cref="NotImplementedException">This IDictionary method is intentionally unimplemented.</exception>
    public bool Contains(KeyValuePair<TKey, TValue> item)
    {
        throw new NotImplementedException();
    }

    /// <remarks>
    /// If the Dictionary functionality is needed, a regular Dictionary can be used.
    /// </remarks>
    /// <exception cref="NotImplementedException">This IDictionary method is intentionally unimplemented.</exception>
    public bool Remove(KeyValuePair<TKey, TValue> item)
    {
        throw new NotImplementedException();
    }

    /// <remarks>
    /// If the Dictionary functionality is needed, a regular Dictionary can be used.
    /// </remarks>
    /// <exception cref="NotImplementedException">This IDictionary method is intentionally unimplemented.</exception>
    public void Add(TKey key, TValue value)
    {
        throw new NotImplementedException();
    }

    /// <remarks>
    /// If the Dictionary functionality is needed, a regular Dictionary can be used.
    /// </remarks>
    /// <exception cref="NotImplementedException">This IDictionary method is intentionally unimplemented.</exception>
    public bool Remove(TKey key)
    {
        throw new NotImplementedException();
    }

    #endregion
    #endregion
}
