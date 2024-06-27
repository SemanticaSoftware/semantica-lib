using System.Collections;
using Semantica.Checks;

namespace Semantica.Trees.Implementations;

public class TreeNode<T> : ITreeNode<T>
{
    internal TreeNode(IReadOnlyTree<T> tree, T content, int index, int parentIndex, int expectedChildren = 0)
    {
        Index = index;
        ParentIndex = parentIndex;
        Owner = tree;
        Level = index == 0 ? 0 : tree[parentIndex].Level + 1;
        Payload = content;
        ChildIndices = null;
        ChildNodes = new ChildNodeList<T>(this);
        if (expectedChildren > 0)
        {
            Unleaf(expectedChildren);
        }
    }

    public IReadOnlyTree<T> Owner { get; }

    public T Payload { get; }
        
    public IReadOnlyList<ITreeNode<T>> ChildNodes { get; }

    public int Level { get; }

    public ITreeNode<T> ParentNode => IsRoot() ? null : Owner[ParentIndex];

    public int GetAncestorCount() => Level;

    public int GetOffspringCount() => IsLeaf() ? 0 : ChildIndices.Count + ChildNodes.Sum(child => child.GetOffspringCount());

    public bool IsLeaf() => ChildIndices == null;
        
    public bool IsRoot() => Index == 0;
        

    /// <summary>
    /// Index of this node in the tree.
    /// </summary>
    internal int Index { get; }

    /// <summary>
    /// Index of the parent node in the tree.
    /// </summary>
    internal int ParentIndex { get; }

    /// <summary>
    /// Indices of the children of the node.
    /// </summary>
    internal List<int> ChildIndices { get; private set; }
        
    /// <summary>
    /// Makes the node ready to have children added. For non-root nodes this should only be called if a child is added immediately after.
    /// </summary>
    /// <param name="expectedChildren">Initial capacity of the child index list</param>
    internal void Unleaf(int expectedChildren = 1)
    {
        Guard.State(IsLeaf(), "Already unleafed", nameof(IsLeaf));
        ChildIndices = new List<int> { Capacity = expectedChildren };
    }

    /// <summary>
    /// Makes a duplicate of the node for a copy of the tree.
    /// </summary>
    internal TreeNode<TOut> DuplicateFor<TOut>(GrowingTree<TOut> tree, TOut newPayload)
    {
        var newNode = new TreeNode<TOut>(tree, newPayload, Index, ParentIndex) {
            ChildIndices = ChildIndices?.ToList()
        };
        return newNode;
    }

    private class ChildNodeList<TT> : IReadOnlyList<ITreeNode<TT>>
    {
        private readonly TreeNode<TT> _node;

        public ChildNodeList(TreeNode<TT> node)
        {
            _node = node;
        }

        public IEnumerator<ITreeNode<TT>> GetEnumerator()
        {
            return (_node.IsLeaf() ? Enumerable.Empty<TreeNode<TT>>() : _node.ChildIndices.Select(i => _node.Owner[i])).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => _node.IsLeaf() ? 0 : _node.ChildIndices.Count;

        public ITreeNode<TT> this[int index] => _node.IsLeaf() ? throw new IndexOutOfRangeException() : _node.Owner[_node.ChildIndices[index]];
    }
}
