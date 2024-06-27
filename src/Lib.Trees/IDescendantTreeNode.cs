namespace Semantica.Trees;

/// <summary>
/// Interface can be implemented by any type of tree node that either has a parent, or is a root node.
/// </summary>
/// <typeparam name="TTreeNode">The type of tree nodes. This type has to also implement <see cref="IAscendantTreeNode{TTreeNode}"/>.</typeparam>
public interface IDescendantTreeNode<out TTreeNode>
    where TTreeNode : IDescendantTreeNode<TTreeNode>
{
    /// <summary>
    /// Parent node of this node. Returns null if this is the root node (<see cref="IsRoot"/> returns <see langword="true"/>).
    /// </summary>
    TTreeNode ParentNode { get; }

    /// <summary>
    /// Gets the total amount of ancestor nodes of this node in the current structure. If the structure is a full tree, this is the same as the <see cref="ITreeNodeProperties{T}.Level"/> of the node.
    /// </summary>
    /// <returns>The count of the amount of times the <see cref="ParentNode"/> reference can be followed until it's value is <see langword="null"/>.</returns>
    int GetAncestorCount();
        
    /// <summary>
    /// <see langword="true"/> if this node is the root node of the tree, or local root of the partial tree. The root node will always have a <see cref="ParentNode"/> value of <see langword="null"/>,
    /// <see cref="GetAncestorCount"/> of 0, and will be the only root node in the current structure.
    /// </summary>
    bool IsRoot();
}
