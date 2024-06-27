namespace Semantica.Trees;

/// <summary>
/// Represents a tree node of a partial tree.
/// </summary>
/// <typeparam name="T">Type of payload that is present in each node.</typeparam>
public interface IPartialTreeNode<out T> : IMorphologicTreeNode<IPartialTreeNode<T>>, ITreeNodeProperties<T>
{
    /// <summary>
    /// Gets the partial tree that this node is part of. Nodes only have meaning in context of their accompanying tree, and cannot exist without it.
    /// </summary>
    IReadOnlyPartialTree<T> Owner { get; }
}
