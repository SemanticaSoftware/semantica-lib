namespace Semantica.Trees;

/// <summary>
/// Represents a node in a <see cref="IReadOnlyTreePath{T}"/>.
/// Can be enumerated to get all nodes from this node to the <see cref="IReadOnlyTreePath{T}.UltimateNode"/> of the <see cref="IReadOnlyTreePath{T}"/>
/// </summary>
/// <typeparam name="T">Type of <see cref="ITreeNodeProperties{T}.Payload"/>.</typeparam>
public interface ITreePathNode<out T> : ITreeNodeProperties<T>, IDescendantTreeNode<ITreePathNode<T>>, IEnumerable<ITreePathNode<T>>
{
    /// <summary>
    /// Gets the treepath that this node is part of. Nodes only have meaning in context of their accompanying treepath, and cannot exist without it.
    /// </summary>
    IReadOnlyTreePath<T> Owner { get; }

    /// <summary>
    /// Gets the next node in the treepath. The next node is always a child of the current node. 
    /// </summary>
    ITreePathNode<T> NextNode { get; }
}
