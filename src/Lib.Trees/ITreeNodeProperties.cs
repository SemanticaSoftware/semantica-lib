namespace Semantica.Trees;

/// <summary>
/// Represents any tree node with a <see cref="Payload"/>
/// </summary>
/// <typeparam name="T">The type of <see cref="Payload"/></typeparam>
public interface ITreeNodeProperties<out T>
{
    /// <summary>
    /// Payload of the tree node.
    /// </summary>
    T Payload { get; }

    /// <summary>
    /// The level of the node in the tree.
    /// </summary>
    int Level { get; }

    /// <summary>
    /// <see langword="true"/> if this node has no children.
    /// </summary>
    bool IsLeaf();
}
