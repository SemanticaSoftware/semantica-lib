namespace Semantica.Trees;

/// <summary>
/// Represents a tree data structure with nodes of type <typeparamref name="TNode"></typeparamref>.
/// </summary>
/// <remarks>
/// Implements ICanBeEmpty: the tree is considered empty if the root node has no children. The tree ALWAYS has a root node.
/// Can be enumerated to retrieve all nodes of the tree.
/// </remarks>
/// <typeparam name="TNode">Type of nodes of the tree.</typeparam>
public interface IMorphologicTree<out TNode>: IEnumerable<TNode>
    where TNode: IMorphologicTreeNode<TNode>
{
    /// <summary>
    /// The root node of the tree.
    /// </summary>
    TNode RootNode { get; }
}
