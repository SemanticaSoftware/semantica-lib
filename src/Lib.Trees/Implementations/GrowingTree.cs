#nullable enable
using System.Collections;
using Semantica.Checks;

namespace Semantica.Trees.Implementations;

public class GrowingTree<T> : IGrowingTree<T>
{
    private readonly List<TreeNode<T>> _nodes;

    public GrowingTree(T root, int expectedChildren = 0)
    {
        Check.NotNegative(expectedChildren).Contract();
        _nodes = new List<TreeNode<T>> { Capacity = expectedChildren + 1 };
        _nodes.Add(new TreeNode<T>(this, root, 0, 0, expectedChildren));
    }

    private GrowingTree(int nodeCount)
    {
        Check.NotNegative(nodeCount).Contract();
        _nodes = new List<TreeNode<T>> { Capacity = nodeCount };
    }

    public ITreeNode<T> AddChildNode(ITreeNode<T> parentNode, T payload)
    {
        Guard.Contract(parentNode is TreeNode<T>,"Not compatible. Make sure the node was created by this tree.", nameof(parentNode));
        Guard.For(this == parentNode.Owner, "Provided node isn't part of this tree.", nameof(parentNode));
        var newIndex = _nodes.Count;
        var parentConcrete = (TreeNode<T>)parentNode;
        var newNode = new TreeNode<T>(this, payload, newIndex, parentConcrete.Index);
        _nodes.Add(newNode);
        if (parentConcrete.IsLeaf())
        {
            parentConcrete.Unleaf();
        }
        parentConcrete.ChildIndices.Add(newIndex);
        return newNode;
    }

    public ITreeNode<T> RootNode => _nodes[0];

    public int Count => _nodes.Count;

    public ITreeNode<T> this[int index] => _nodes[index];

    /// <summary>
    /// A tree is concidered empty when the root node has no children.
    /// </summary>
    public bool IsEmpty()
    {
        return Count == 1;
    }

    public IEnumerator<ITreeNode<T>> GetEnumerator()
    {
        return _nodes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <summary>
    /// Creates a new tree with the same shape as the current instance, but with all node payloads converted to <typeparamref name="TOut"/> using the provided <paramref name="convertFunc"/>.
    /// This method is used by <see cref="Converters.TreeConverter"/>. 
    /// </summary>
    internal GrowingTree<TOut> CopyToNew<TOut>(Func<ITreeNode<T>, TOut> convertFunc)
    {
        var tree = new GrowingTree<TOut>(Count);
        tree._nodes.AddRange(_nodes.Select(sourceNode => sourceNode.DuplicateFor(tree, convertFunc(sourceNode))));
        return tree;
    }
}
