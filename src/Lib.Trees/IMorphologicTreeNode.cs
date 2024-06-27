namespace Semantica.Trees;

/// <summary>
/// Represents a node of any tree or partial tree, that has both a parent node, and, if the node is not a leaf, child nodes.
/// </summary>
/// <typeparam name="TNode">Type of node.</typeparam>
public interface IMorphologicTreeNode<out TNode> : IDescendantTreeNode<TNode>, IAscendantTreeNode<TNode>
    where TNode : IAscendantTreeNode<TNode>, IDescendantTreeNode<TNode>
{
}
