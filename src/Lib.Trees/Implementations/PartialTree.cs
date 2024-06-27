#nullable enable
using System.Collections;
using Semantica.Checks;

namespace Semantica.Trees.Implementations;

public class PartialTree<T> : IReadOnlyPartialTree<T>
{
    private readonly PartialTreeNode<T>[] _nodes;

    public PartialTree(IReadOnlyList<IArrayTreeNode<T>> nodes)
    {
        _nodes = nodes.SelectArray(node => new PartialTreeNode<T>(this, node));
    }

    public PartialTree(IEnumerable<IArrayTreeNode<T>> nodes, int count)
    {
        Check.NotNegative(count).Contract();
        _nodes = nodes.Select(node => new PartialTreeNode<T>(this, node)).ToArray(count, PartialTreeNode<T>.Dummy);
    }

    public IPartialTreeNode<T> RootNode => _nodes[0];

    public int Count => _nodes.Length;

    public IPartialTreeNode<T> this[int index] => _nodes[index];

    /// <summary>
    /// A tree is considered empty if there are no nodes besides the root node.  
    /// </summary>
    public bool IsEmpty()
    {
        return Count == 1;
    }

    public IEnumerator<IPartialTreeNode<T>> GetEnumerator()
    {
        return _nodes.Cast<IPartialTreeNode<T>>().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// Creates a new tree with the same shape as the current instance, but with all node payloads converted to <typeparamref name="TOut"/> using the provided <paramref name="convertFunc"/>.
    /// This method is used by <see cref="Converters.TreeConverter"/>. 
    /// </summary>
    internal PartialTree<TOut> CopyToNew<TOut>(Func<IPartialTreeNode<T>, TOut> convertFunc)
    {
        var tree = new PartialTree<TOut>(_nodes.SelectArray(sourceNode => sourceNode.DuplicateFor(convertFunc)));
        return tree;
    }
}
