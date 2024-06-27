namespace Semantica.Trees.Builders;

/// <summary>
/// Can identify a payload as the root node for a tree, or as a child of another payload.
/// Implement this interface for DI support for <see cref="ITreeBuilder{T}"/>
/// </summary>
/// <typeparam name="T">Type of payload.</typeparam>
public interface ITreeBuildPredicateProvider<in T>
{
    /// <summary>
    /// Determines if a payload should be the root of a tree.
    /// </summary>
    /// <param name="payload">Payload to test</param>
    /// <returns>True if the payload is the root of the tree.</returns>
    bool IsRoot(T payload);

    /// <summary>
    /// Determines if <paramref name="payload"/> should be a child node of <paramref name="parent"/>
    /// </summary>
    /// <param name="payload">Payload to test</param>
    /// <param name="parent">Payload of parent</param>
    /// <returns>True if payload is child of parent</returns>
    bool IsChildOf(T payload, T parent);

    /// <summary>
    /// Determines if children should be ordered before they are added to the parent.
    /// If this method returns false, OrderChildenBy is not utilized.
    /// </summary>
    /// <returns>True if the implement</returns>
    bool UseOrdering();

    /// <summary>
    /// Determines the value of the child, to be used for ordering the child and its siblings.
    /// </summary>
    /// <param name="payload">Payload to order</param>
    /// <returns>An IComparable value</returns>
    IComparable OrderChildrenBy(T payload);
}
