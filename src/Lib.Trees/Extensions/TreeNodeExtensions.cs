using JetBrains.Annotations;
using Semantica.Checks;
using Semantica.Trees.Implementations;

namespace Semantica.Trees.Extensions;

/// <summary>
/// Provides additional functionality to <see cref="ITreeNode{T}"/> and many of it's supertypes, as well as enumerations of these types.
/// </summary>
public static class TreeNodeExtensions
{
    /// <summary>
    /// Returns an enumeration of all ancestors of the given node.     
    /// </summary>
    /// <remarks>
    /// The enumeration starts with the first parent, and always ends at the root node.
    /// </remarks>
    /// <param name="node">The node for which to get ancestors.</param>
    /// <typeparam name="TNode">The Type of tree node, has to be a <see cref="IDescendantTreeNode{TTreeNode}"/></typeparam>
    /// <returns>An enumeration of treenodes.</returns>
    public static IEnumerable<TNode> EnumerateAncestors<TNode>(this TNode node)
        where TNode : IDescendantTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        var parent = node;
        while (! parent.IsRoot())
        {
            parent = parent.ParentNode;
            yield return parent;
        }
    }

    /// <summary>
    /// Returns an enumeration of all offspring of <paramref name="node"/> (not including the node itself).
    /// </summary>
    /// <remarks>
    /// Tree traversal is depth-first, and siblings are returned in order.
    /// </remarks>
    /// <param name="node">The node for which to get offspring.</param>
    /// <typeparam name="TNode">The Type of tree node, has to be a <see cref="IAscendantTreeNode{TTreeNode}"/></typeparam>
    /// <returns>An enumeration of treenodes.</returns>
    public static IEnumerable<TNode> EnumerateOffspring<TNode>(this TNode node)
        where TNode : IAscendantTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        if (node.IsLeaf()) { yield break; }

        foreach (var childNode in node.ChildNodes)
        {
            yield return childNode;

            if (! childNode.IsLeaf())
            {
                foreach (TNode offspring in childNode.EnumerateOffspring())
                {
                    yield return offspring;
                }
            }
        }
    }

    /// <summary>
    /// Returns an enumeration of offspring of <paramref name="node"/> (not including the node itself).
    /// If a node does not satisfy the <paramref name="predicate"/>, that node and it's offspring are not included in the enumration.
    /// </summary>
    /// <remarks>
    /// Tree traversal is depth-first, and siblings are returned in order.
    /// </remarks>
    /// <param name="node">The node for which to get offspring.</param>
    /// <param name="predicate">Is evaluated for every childnode. If it returns <see langword="false"/> the node and it's offspring are not enumerated.</param>
    /// <typeparam name="TNode">The Type of tree node, has to be a <see cref="IAscendantTreeNode{TTreeNode}"/></typeparam>
    /// <returns>A filtered depth-first enumeration of treenodes.</returns>
    public static IEnumerable<TNode> EnumerateOffspring<TNode>(this TNode node, Func<TNode, bool> predicate)
        where TNode : IAscendantTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        if (node.IsLeaf()) { yield break; }

        foreach (var childNode in node.ChildNodes.Where(predicate))
        {
            yield return childNode;

            if (! childNode.IsLeaf())
            {
                foreach (TNode offspring in childNode.EnumerateOffspring())
                {
                    yield return offspring;
                }
            }
        }
    }

    /// <summary>
    /// Returns an enumeration of offspring of <paramref name="node"/> (not including the node itself).
    /// When a node satisfies the <paramref name="predicate"/>, enumeration of its children wil stop.
    /// </summary>
    /// <remarks>
    /// Tree traversal is depth-first, and siblings are returned in order.
    /// </remarks>
    /// <param name="node">The node for which to get offspring.</param>
    /// <param name="predicate">Evaluated for every childnode, and when it returns <see langword="true"/>, the children of that node will not be enumerated.</param>
    /// <typeparam name="TNode">The Type of tree node, has to be a <see cref="IAscendantTreeNode{TTreeNode}"/></typeparam>
    /// <returns>A filtered depth-first enumeration of treenodes.</returns>
    public static IEnumerable<TNode> EnumerateOffspringUntil<TNode>(this TNode node, Func<TNode, bool> predicate)
        where TNode : IAscendantTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        if (node.IsLeaf())
        {
            yield break;
        }

        foreach (var childNode in node.ChildNodes)
        {
            yield return childNode;

            if (! predicate(childNode) && ! childNode.IsLeaf())
            {
                foreach (TNode offspring in childNode.EnumerateOffspringWhere(predicate))
                {
                    yield return offspring;
                }
            }
        }
    }

    /// <summary>
    /// Returns an enumeration of offspring of <paramref name="node"/> (not including the node itself).
    /// Only yields offspring that satisfies the <paramref name="predicate"/>, and when that happens enumeration of its children wil stop.
    /// </summary>
    /// <remarks>
    /// Tree traversal is depth-first, and siblings are returned in order.
    /// </remarks>
    /// <param name="node">The node for which to get offspring.</param>
    /// <param name="predicate">Evaluated for every childnode, and only when it returns <see langword="true"/> that node will be yielded, and the children of that node will not be enumerated.</param>
    /// <typeparam name="TNode">The Type of tree node, has to be a <see cref="IAscendantTreeNode{TTreeNode}"/></typeparam>
    /// <returns>A filtered depth-first enumeration of treenodes.</returns>
    public static IEnumerable<TNode> EnumerateOffspringWhere<TNode>(this TNode node, Func<TNode, bool> predicate)
        where TNode : IAscendantTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        if (node.IsLeaf())
        {
            yield break;
        }

        foreach (var childNode in node.ChildNodes)
        {
            if (predicate(childNode))
            {
                yield return childNode;
            }
            else if (! childNode.IsLeaf())
            {
                foreach (TNode offspring in childNode.EnumerateOffspringWhere(predicate))
                {
                    yield return offspring;
                }
            }
        }
    }

    /// <summary>
    /// Finds the index of the node in its parent. 
    /// </summary>
    /// <param name="node">A non-root node to get the index of.</param>
    /// <typeparam name="TNode">Type of treenode that implements <see cref="IMorphologicTreeNode{TNode}"/>.</typeparam>
    /// <returns>The index of the node in its parent.</returns>
    public static int IndexOf<TNode>(this TNode node)
        where TNode : IMorphologicTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        Check.Not(node.IsRoot()).Contract("Cannot call on root node.");
        return node.ParentNode.ChildNodes.IndexOf(node);
    }

    /// <summary>
    /// Determines if <paramref name="node"/> has no children. 
    /// </summary>
    /// <param name="node">Node to evaluate.</param>
    /// <typeparam name="TNode">Type of treenode that implements <see cref="IAscendantTreeNode{TNode}"/>.</typeparam>
    /// <returns><see langword="true"/> if there are no children.</returns>
    public static bool IsLeaf<TNode>(this TNode node)
        where TNode : IAscendantTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        return node.ChildNodes == null || node.ChildNodes.Count == 0;
    }

    /// <summary>
    /// Determines if <paramref name="node"/> is the root node of it's owner.
    /// </summary>
    /// <param name="node">Node to evaluate.</param>
    /// <typeparam name="TNode">Type of treenode that implements <see cref="IDescendantTreeNode{TNode}"/>.</typeparam>
    /// <returns><see langword="true"/> if the node has no parent.</returns>
    public static bool IsRoot<TNode>(this TNode node)
        where TNode : IDescendantTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        return node.ParentNode == null;
    }

    /// <summary>
    /// Creates a <see cref="IReadOnlyTreePath{T}"/> with <paramref name="node"/> as the ultimate node.
    /// </summary>
    /// <remarks>
    /// The rootnode of the path will be the <see cref="IMorphologicTree{T}.RootNode"/> of the <paramref name="node"/>'s <see cref="ITreeNode{T}.Owner"/>. 
    /// </remarks>
    /// <param name="node">Node to get the treepath to. This node will be the treepath's <see cref="IReadOnlyTreePath{T}.UltimateNode"/>.</param>
    /// <typeparam name="T">Type of the payload.</typeparam>
    /// <returns>A new <see cref="IReadOnlyTreePath{T}"/>.</returns>
    public static IReadOnlyTreePath<T> MakeTreePath<T>(this ITreeNode<T> node)
    {
        Check.NotNullOrDefault(node).Contract();
        var treePath = TreePath<T>.MakePathFromTreeNode<ITreeNode<T>, T>(node);
        return treePath;
    }

    /// <summary>
    /// Transforms an enumeration of nodes into an enumeration of the payload of those nodes.
    /// </summary>
    /// <param name="nodes">An enumeration of treenodes.</param>
    /// <typeparam name="T">Type of the payload.</typeparam>
    /// <returns>An enumeration of payloads.</returns>
    [LinqTunnel]
    public static IEnumerable<T> Payloads<T>(this IEnumerable<ITreeNodeProperties<T>> nodes)
    {
        Check.NotNullOrDefault(nodes).Contract();
        return nodes.Select(tn => tn.Payload);
    }

    /// <summary>
    /// Returns the amount of children of the provided node's parents, or put otherwise, the amount of siblings the node has (including itself).
    /// </summary>
    /// <param name="node">A non-root node to count the siblings of.</param>
    /// <typeparam name="TNode">Type of treenode that implements <see cref="IMorphologicTreeNode{TNode}"/>.</typeparam>
    /// <returns>An integer</returns>
    public static int SiblingCount<TNode>(this TNode node)
        where TNode : IMorphologicTreeNode<TNode>
    {
        Check.NotNullOrDefault(node).Contract();
        Check.Not(node.IsRoot()).Contract("Cannot call on root node.");
        return node.ParentNode.ChildNodes.Count;
    }

    /// <summary>
    /// Filters and enumeration of tree nodes where the payload satisfies the <paramref name="predicate"/>.
    /// </summary>
    /// <param name="nodes">An enumeration of nodes.</param>
    /// <param name="predicate">Predicate that the nodes should satisfy.</param>
    /// <typeparam name="TNode">Type of the node implementing <see cref="ITreeNodeProperties{TPayload}"/>.</typeparam>
    /// <typeparam name="TPayload">Type of the payload.</typeparam>
    /// <returns>Enumeration of nodes matching <paramref name="predicate"/>.</returns>
    [LinqTunnel]
    public static IEnumerable<TNode> Where<TPayload, TNode>(this IEnumerable<TNode> nodes, Func<TPayload, bool> predicate)
        where TNode : ITreeNodeProperties<TPayload>
    {
        Check.NotNullOrDefault(nodes).Contract();
        return nodes.Where(node => predicate(node.Payload));
    }
}
