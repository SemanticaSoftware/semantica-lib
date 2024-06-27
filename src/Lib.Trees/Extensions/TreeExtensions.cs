#nullable enable
namespace Semantica.Trees.Extensions;

/// <summary>
/// Provides additional functionality to <see cref="IMorphologicTree{T}"/>, which is a supertype of <see cref="IReadOnlyTree{T}"/> and <see cref="IReadOnlyPartialTree{T}"/>
/// </summary>
public static class TreeExtensions
{
    /// <summary>
    /// Finds the first treenode for which the payload satisfies the <paramref name="predicate"/>.
    /// </summary>
    /// <remarks>
    /// Nodes are evaluated depth-first. If you want to evaluate more efficiently, enumerate the tree directly. 
    /// </remarks>
    /// <param name="tree">Tree to search.</param>
    /// <param name="predicate">Predicate that the node should satisfy.</param>
    /// <typeparam name="TNode">Type of the node.</typeparam>
    /// <typeparam name="TPayload">Type of the payload.</typeparam>
    /// <returns>The first node that matches <paramref name="predicate"/>, null otherwise.</returns>
    public static TNode? DepthFirstOrDefault<TPayload, TNode>(this IMorphologicTree<TNode> tree, Func<TPayload, bool> predicate)
        where TNode : IMorphologicTreeNode<TNode>, ITreeNodeProperties<TPayload>
    {
        return tree.EnumerateDepthFirst()
                   .FirstOrDefault(node => predicate(node.Payload));
    }

    /// <summary>
    /// Enumerate all nodes in the tree, traversing it depth-first.
    /// </summary>
    /// <remarks>
    /// Enumerating nodes depth-first is probably not the most efficient way to evaluate all tree nodes. Enumerate the tree directly if the order of enumeration does not have to be depth-first. 
    /// </remarks>
    /// <param name="tree"><see cref="IMorphologicTree{TNode}"/> to enumerate.</param>
    /// <typeparam name="TNode">Type of node.</typeparam>
    /// <returns>An enumeration of all tree nodes. This enumration will always contain at least one node.</returns>
    public static IEnumerable<TNode> EnumerateDepthFirst<TNode>(this IMorphologicTree<TNode> tree)
        where TNode : IMorphologicTreeNode<TNode>
    {
        return tree.RootNode.EnumerateOffspring().PrecedeBy(tree.RootNode);
    }
    
    /// <summary>
    /// Finds the first node for which the payload satisfies the <paramref name="predicate"/>.
    /// </summary>
    /// <remarks>
    /// Nodes are evaluated depth-first. If you want to evaluate more efficiently, enumerate the tree directly. 
    /// </remarks>
    /// <param name="tree">Tree to search.</param>
    /// <param name="predicate">Predicate that the node should satisfy.</param>
    /// <param name="matchingNode">Out parameter that contains the matching node.</param>
    /// <typeparam name="TNode">Type of the node.</typeparam>
    /// <typeparam name="TPayload">Type of the payload.</typeparam>
    /// <returns>True if a node satisfying <paramref name="predicate"/> was found, false otherwise.</returns>
    public static bool TryDepthFirst<TPayload, TNode>(this IMorphologicTree<TNode> tree, Func<TPayload, bool> predicate, out TNode? matchingNode)
        where TNode : IMorphologicTreeNode<TNode>, ITreeNodeProperties<TPayload>
    {
        return tree.EnumerateDepthFirst()
                   .Where(predicate)
                   .TryFirst(out matchingNode);
    }
    
    /// <summary>
    /// Finds the first treenode for which the payload satisfies the <paramref name="predicate"/>.
    /// </summary>
    /// <remarks>
    /// Nodes are evaluated depth-first. If you want to evaluate more efficiently, enumerate the tree directly. 
    /// </remarks>
    /// <param name="tree"><see cref="IMorphologicTree{TNode}"/> to search.</param>
    /// <param name="predicate">Predicate that the node should satisfy.</param>
    /// <param name="matchingNode">Out parameter that contains the matching node.</param>
    /// <typeparam name="TNode">Type of the node.</typeparam>
    /// <returns>True if a payload satisfying <paramref name="predicate"/> was found, false otherwise.</returns>
    public static bool TryDepthFirst<TNode>(this IMorphologicTree<TNode> tree, Func<TNode, bool> predicate, out TNode? matchingNode)
        where TNode : IMorphologicTreeNode<TNode>
    {
        return tree.EnumerateDepthFirst()
                   .Where(predicate)
                   .TryFirst(out matchingNode);
    }
}
