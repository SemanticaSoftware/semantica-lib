using System.Collections;
using Semantica.Trees.Builders;

namespace Semantica.Trees.Implementations;

/// <inheritdoc cref="IPartialTreeNode{T}" />
/// <inheritdoc cref="IArrayTreeNode{T}" />
public class PartialTreeNode<T> : IPartialTreeNode<T>, IArrayTreeNode<T>
{
    internal PartialTreeNode()
    { }
    internal PartialTreeNode(IReadOnlyPartialTree<T> partialTree, IArrayTreeNode<T> arrayTreeNode)
    {
        ChildIndices = arrayTreeNode.IsLeaf() ? null : arrayTreeNode.ChildIndices;
        Index = arrayTreeNode.Index;
        Level = arrayTreeNode.Level;
        OffspringCount = arrayTreeNode.OffspringCount;
        ParentIndex = arrayTreeNode.ParentIndex;
        Payload = arrayTreeNode.Payload;
        Owner = partialTree;
        ChildNodes = null;
        ChildNodes = new ChildNodeList<T>(this);
    }

    public IReadOnlyList<int> ChildIndices { get; }

    public IReadOnlyList<IPartialTreeNode<T>> ChildNodes { get; }

    public int Index { get; }

    public int Level { get;  }

    public int OffspringCount { get; }
        
    public int ParentIndex { get; }

    public T Payload { get; }

    public IReadOnlyPartialTree<T> Owner { get; }
            
    public IPartialTreeNode<T> ParentNode => IsRoot() ? null : Owner[ParentIndex];

    public int GetAncestorCount() => Level;

    public int GetOffspringCount() => OffspringCount;
        
    public bool IsLeaf() => ChildIndices == null;
        
    public bool IsRoot() => Index == 0;

    internal static PartialTreeNode<T> Dummy { get; } = new PartialTreeNode<T>();

    internal IArrayTreeNode<TOut> DuplicateFor<TOut>(Func<IPartialTreeNode<T>, TOut> convertFunc)
    {
        return new PartialTreeBuilder.ProtoNode<TOut>(convertFunc(this), Index, Level, ParentIndex, ChildIndices, OffspringCount);
    }

    private class ChildNodeList<TT> : IReadOnlyList<IPartialTreeNode<TT>>
    {
        private readonly PartialTreeNode<TT> _node;

        public ChildNodeList(PartialTreeNode<TT> node)
        {
            _node = node;
        }

        public IEnumerator<IPartialTreeNode<TT>> GetEnumerator()
        {
            return (_node.IsLeaf() ? Enumerable.Empty<IPartialTreeNode<TT>>() : _node.ChildIndices.Select(i => _node.Owner[i])).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => _node.IsLeaf() ? 0 : _node.ChildIndices.Count;

        public IPartialTreeNode<TT> this[int index] => _node.IsLeaf() ? throw new IndexOutOfRangeException() : _node.Owner[_node.ChildIndices[index]];
    }
}