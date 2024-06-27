using System.Collections;
using JetBrains.Annotations;
using Semantica.Checks;

namespace Semantica.Collections;

public class SingleItemList<T> : IList<T>, IReadOnlyList<T>
{
    private readonly T _item;
    private readonly int _index;

    [CollectionAccess(CollectionAccessType.UpdatedContent)]
    public SingleItemList(T item, int index, int minimumLength = 0)
    {
        Check.NotNullOrDefault(item).Contract();
        _item = item;
        _index = index;
        Count = Math.Max(_index + 1, minimumLength);
    }

    public int Count { get; }
    public bool IsReadOnly => true;

    [CollectionAccess(CollectionAccessType.Read)]
    public T this[int index]
    {
        get {
            Guard.Index(index, Count);
            return _index == index ? _item : default(T);
        }
        set => throw new System.NotSupportedException();
    }

    [CollectionAccess(CollectionAccessType.Read)]
    public bool Contains(T item)
    {
        return _item.Equals(item);
    }

    [CollectionAccess(CollectionAccessType.Read)]
    public int IndexOf(T item)
    {
        if (Equals(item, default(T)) && _index > 0)
        {
            return 0;                
        }
        return Contains(item) ? _index : -1;
    }

    public void Add(T item)
    {
        throw new System.NotSupportedException();
    }

    public void Clear()
    {
        throw new System.NotSupportedException();
    }

    [CollectionAccess(CollectionAccessType.Read)]
    public void CopyTo(T[] array, int arrayIndex)
    {
        var newItemIndex = arrayIndex + _index;
        var newCount = arrayIndex + Count;
        for (var i = arrayIndex; i < newCount; i++)
        {
            array[i] = i == newItemIndex ? _item : default(T);
        }
    }

    public bool Remove(T item)
    {
        throw new System.NotSupportedException();
    }

    public void Insert(int index, T item)
    {
        throw new System.NotSupportedException();
    }

    public void RemoveAt(int index)
    {
        throw new System.NotSupportedException();
    }

    [CollectionAccess(CollectionAccessType.Read)]
    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < _index - 1; i++)
        {
            yield return default(T);
        }
        yield return _item;
    }

    [CollectionAccess(CollectionAccessType.Read)]
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
