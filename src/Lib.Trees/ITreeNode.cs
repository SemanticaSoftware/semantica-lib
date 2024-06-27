namespace Semantica.Trees;

/// <summary>
/// Represents a node in the accompanying tree.
/// </summary>
/// <typeparam name="T">Type of payload that is present in each node.</typeparam>
public interface ITreeNode<out T> : IMorphologicTreeNode<ITreeNode<T>>, ITreeNodeProperties<T>
{
    /// <summary>
    /// Gets the tree that this node is part of. Nodes only have meaning in context of their accompanying tree, and cannot exist without it.
    /// </summary>
    IReadOnlyTree<T> Owner { get; }
}
