using System.Collections;

namespace Semantica.Trees.Implementations;

/// <inheritdoc />
public class TreePathNode<T> : ITreePathNode<T>
{
    internal TreePathNode(TreePath<T> owner, int index, T payload, bool isLeaf)
    {
        Owner = owner;
        Index = index;
        IsLeafNode = isLeaf;
        Payload = payload;
    }

    public int Index { get; }

    public bool IsLeafNode { get; }

    public IReadOnlyTreePath<T> Owner { get; }

    public T Payload { get; }

    public int Level => Index;

    public bool IsRootNode => IsRoot();

    public ITreePathNode<T> NextNode => IsUltimate() ? null : Owner.Nodes[Index + 1];

    public ITreePathNode<T> ParentNode => IsRoot() ? null : Owner.Nodes[Index - 1];

    public int GetAncestorCount() => Level;

    public bool IsLeaf() => IsLeafNode;

    public bool IsRoot() => Index == 0;

    public bool IsUltimate() => Index == Owner.Depth;

    public IEnumerator<ITreePathNode<T>> GetEnumerator()
    {
        ITreePathNode<T> nextNode = this;
        yield return nextNode;
        while (! nextNode.IsLeaf())
        {
            nextNode = nextNode.NextNode;
            yield return nextNode;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}