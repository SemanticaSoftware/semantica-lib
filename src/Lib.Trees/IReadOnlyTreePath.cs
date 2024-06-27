namespace Semantica.Trees;

/// <summary>
/// Represents a path in a tree from a node to the root node where each node can have a payload of type <typeparamref name="T"/>.
/// </summary>
/// <remarks>
/// Implements <see cref="IReadOnlyList{T}"/>, this lists all node payloads in the path from the root node to the ultimate node.
/// </remarks>
/// <typeparam name="T">Type of payloads of the nodes.</typeparam>
public interface IReadOnlyTreePath<out T> : IReadOnlyList<T>
{
    /// <summary>
    /// The amount of parent-child relations in the path, equal to <see cref="Nodes"/>.<see cref="IReadOnlyCollection{T}.Count"/> - 1. 
    /// </summary>
    int Depth { get; }
        
    /// <summary>
    /// The list of all nodes in the path, from the root node till the ultimate node.
    /// </summary>
    IReadOnlyList<ITreePathNode<T>> Nodes { get; }

    /// <summary>
    /// Returns the root node of the <see cref="IReadOnlyTreePath{T}"/>. Which is also the first of the <see cref="Nodes"/>, and the node with the lowest level.
    /// </summary>
    ITreePathNode<T> RootNode { get; }

    /// <summary>
    /// Returns the final node of the <see cref="IReadOnlyTreePath{T}"/>. Which is also the last of the <see cref="Nodes"/>, and the node with the highest level.
    /// </summary>
    ITreePathNode<T> UltimateNode { get; }
        
}
