using System.Collections;
using JetBrains.Annotations;

namespace Semantica.Collections;

/// <inheritdoc />>
public class RetrievalCollection<T> : IRetrievalCollection<T>
{
    private readonly LinkedList<T> _items;
    private bool _isEnumerating;

    [CollectionAccess(CollectionAccessType.UpdatedContent)]
    public RetrievalCollection(IEnumerable<T> items)
    {
        _items = new LinkedList<T>(items);
    }

    public int Count => _items.Count;

    [CollectionAccess(CollectionAccessType.ModifyExistingContent)]
    public T RetrieveFirstOrDefault(Func<T, bool> predicate)
    {
        if (!TryFindFirstMatchingNode(predicate, out var node))
        {
            return default(T);
        }

        return RetrieveNode(node);
    }

    [CollectionAccess(CollectionAccessType.ModifyExistingContent)]
    public IEnumerable<T> Retrieve(Func<T, bool> predicate)
    {
        if (_isEnumerating)
        {
            throw new InvalidOperationException("RetrievalCollection is already being enumerated.");
        }
        _isEnumerating = true;
        LinkedListNode<T> nextNode;
        for (var node = _items.First; node != null; node = nextNode)
        {
            nextNode = node.Next;
            if (predicate(node.Value))
            {
                yield return RetrieveNode(node);
            }
        }
        _isEnumerating = false;
    }

    private T RetrieveNode(LinkedListNode<T> node)
    {
        var value = node.Value;
        _items.Remove(node);
        return value;
    }

    private bool TryFindFirstMatchingNode(Func<T, bool> predicate, out LinkedListNode<T> firstMatchingNode)
    {
        for (var node = _items.First; node != null; node = node.Next)
        {
            if (predicate(node.Value))
            {
                firstMatchingNode = node;
                return true;
            }
        }
        firstMatchingNode = null;
        return false;
    }

    public bool IsEmpty() => _items.First == null;

    [CollectionAccess(CollectionAccessType.Read)]
    public IEnumerator<T> GetEnumerator()
    {
        return _items.GetEnumerator();
    }

    [CollectionAccess(CollectionAccessType.Read)]
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
