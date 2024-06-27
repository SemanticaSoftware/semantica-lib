namespace Semantica.Trees;

/// <summary>
/// Represents a node in a type of tree where all nodes of that tree are part of the same indexable list or array, and thus each node can be uniquely identified by it's index within that list or array.   
/// </summary>
/// <typeparam name="T">The type of payloads of the tree nodes</typeparam>
public interface IArrayTreeNode<out T> : ITreeNodeProperties<T>
{
    /// <summary>
    /// The indices of the children of the node within the node list.
    /// </summary>
    IReadOnlyList<int> ChildIndices { get; }

    /// <summary>
    /// The index of this node within the node list.
    /// </summary>
    int Index { get; }

    /// <summary>
    /// The index of the parent node within the node list.
    /// </summary>
    int ParentIndex { get; }

    /// <summary>
    /// The total amount of offspring of this node.
    /// </summary>
    int OffspringCount { get; }
}
