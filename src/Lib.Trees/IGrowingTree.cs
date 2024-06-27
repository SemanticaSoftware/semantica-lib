namespace Semantica.Trees;

/// <summary>
/// Represents a tree data structure that has nodes with payloads, that can be grown by adding child nodes to the root node, or other earlier added nodes.
/// </summary>
/// <typeparam name="T">The type of the payloads of the nodes.</typeparam>
public interface IGrowingTree<T> : IReadOnlyTree<T>
{
    /// <summary>
    /// Creates a new node and adds it to the tree, as a child of the provided <paramref name="parentNode"/>.
    /// </summary>
    /// <param name="parentNode">Node to which to add the new node. Has to be part of, and created by this tree.</param>
    /// <param name="payload">Payload of the new node.</param>
    /// <returns>Returns the created <see cref="ITreeNode{T}"/>.</returns>
    ITreeNode<T> AddChildNode(ITreeNode<T> parentNode, T payload);
}
