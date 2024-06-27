namespace Semantica.Trees;

/// <summary>
/// Interface can be implemented by any type of tree node that can have offspring.
/// </summary>
/// <typeparam name="TTreeNode">The type of tree nodes. This type has to also implement <see cref="IAscendantTreeNode{TTreeNode}"/></typeparam>
public interface IAscendantTreeNode<out TTreeNode>
    where TTreeNode : IAscendantTreeNode<TTreeNode>
{
        
    /// <summary>
    /// The list of all child nodes of this tree node. If the tree node is a leaf, this returns an empty list that can be enumerated, but has no elements.
    /// </summary>
    IReadOnlyList<TTreeNode> ChildNodes { get; }

    /// <summary>
    /// Gets the total amount of offspring nodes of this node (children, children of children, etc.) 
    /// </summary>
    /// <returns>The count of all offspring nodes of this node.</returns>
    int GetOffspringCount();
}
