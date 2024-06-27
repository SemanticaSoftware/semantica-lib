using System.Collections;
using Semantica.Trees.Extensions;

namespace Semantica.Trees.Implementations;

/// <inheritdoc />
public class TreePath<T> : IReadOnlyTreePath<T>
{
    private readonly IReadOnlyList<TreePathNode<T>> _path;

    public TreePath(IReadOnlyList<ITreeNodeProperties<T>> nodes)
    {
        _path = null;
        _path = nodes.SelectArray(MakeProjectedNode);
    }

    public int Depth => Count - 1;

    public int Count => _path.Count;

    public IReadOnlyList<ITreePathNode<T>> Nodes => _path;

    public ITreePathNode<T> RootNode => _path[0];

    public ITreePathNode<T> UltimateNode => _path[Depth];

    public T this[int index] => _path[index].Payload;

    public IEnumerator<T> GetEnumerator()
    {
        return _path.Payloads().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private TreePathNode<T> MakeProjectedNode(ITreeNodeProperties<T> sourceNode, int index)
    {
        return new TreePathNode<T>(this, index, sourceNode.Payload, sourceNode.IsLeaf());
    }

    public static TreePath<TPayload> MakePathFromTreeNode<TNode, TPayload>(TNode ultimateNode)
        where TNode: ITreeNodeProperties<TPayload>, IDescendantTreeNode<TNode>
    {
        var path = ultimateNode.EnumerateAncestors().Reverse().Append(ultimateNode).Cast<ITreeNodeProperties<TPayload>>().ToReadOnlyList();
        return new TreePath<TPayload>(path);
    }
}