using Semantica.Collections;
using Semantica.Trees.Implementations;

namespace Semantica.Trees.Builders;

/// <summary>
/// Provides a way to grow a tree from the root down.
/// Can be used by either instantiating a builder and injecting a <see cref="ITreeBuildPredicateProvider{T}"/>, or by using the static methods with root and child predicates. 
/// </summary>
/// <typeparam name="T">Type of payloads</typeparam>
public class TreeBuilder<T> : ITreeBuilder<T>
{
    private readonly ITreeBuildPredicateProvider<T> _predicateProvider;

    /// <param name="provider">The <see cref="ITreeBuildPredicateProvider{T}"/> that will be used to identify the root of the tree, and children of each node.</param>
    public TreeBuilder(ITreeBuildPredicateProvider<T> provider)
    {
        _predicateProvider = provider;
    }

    /// <summary>
    /// Can build an <see cref="IGrowingTree{T}"/> from a collection of payloads.
    /// </summary>
    /// <remarks>
    /// Uses the injected <see cref="ITreeBuildPredicateProvider{T}"/> for the root and child predicates, and optional ordering predicates.
    /// </remarks>
    /// <returns>A <see cref="IGrowingTree{T}"/> with <typeparamref name="T"/> as payload.</returns> 
    public IGrowingTree<T> GrowTree(IRetrievalCollection<T> collection)
    {
        if (_predicateProvider.UseOrdering())
        {
            return GrowTree(collection, _predicateProvider.IsRoot, _predicateProvider.IsChildOf, _predicateProvider.OrderChildrenBy);
        }
        return GrowTree(collection, _predicateProvider.IsRoot, _predicateProvider.IsChildOf);
    }

    /// <summary>
    /// Can build an <see cref="IGrowingTree{T}"/> from a collection of payloads.
    /// </summary>
    /// <remarks>
    /// Will retrieve nodes from the collection, starting with the root node, and adding children recursively.
    /// </remarks>
    /// <param name="collection">Retrievalcollection that contains payloads.</param>
    /// <param name="isRootPredicate">Function to determine if a payload should be the root of a tree.</param>
    /// <param name="isChildOfFunc">Function to determine if a payload should be a child node of a parent payload.</param>
    /// <returns>A <see cref="IGrowingTree{T}"/> with <typeparamref name="T"/> as payload.</returns>
    public static IGrowingTree<T> GrowTree(IRetrievalCollection<T> collection, Func<T, bool> isRootPredicate, Func<T, T, bool> isChildOfFunc)
    {
        var root = GetRoot(collection, isRootPredicate);
        var tree = new GrowingTree<T>(root, collection.Count);
        AddChildNodesRecursive<object>(tree, tree.RootNode, collection, isChildOfFunc, null);
        return tree;
    }

    /// <summary>
    /// Can build an <see cref="IGrowingTree{T}"/> from a collection of payloads.
    /// </summary>
    /// <remarks>
    /// Will retrieve nodes from the collection, starting with the root node, and adding children recursively. Childen are ordered by the result of the <paramref name="orderFunc"/>.
    /// </remarks>
    /// <param name="collection">Retrievalcollection that contains payloads.</param>
    /// <param name="isRootPredicate">Function to determine if a payload should be the root of a tree.</param>
    /// <param name="isChildOfFunc">Function to determine if a payload should be a child node of a parent payload.</param>
    /// <param name="orderFunc">Function to use to order children by.</param>
    /// <returns>A <see cref="IGrowingTree{T}"/> with <typeparamref name="T"/> as payload.</returns>
    public static IGrowingTree<T> GrowTree(IRetrievalCollection<T> collection, Func<T, bool> isRootPredicate, Func<T, T, bool> isChildOfFunc, Func<T, IComparable> orderFunc)
    {
        var root = GetRoot(collection, isRootPredicate);
        var tree = new GrowingTree<T>(root, collection.Count);
        AddChildNodesRecursive(tree, tree.RootNode, collection, isChildOfFunc, orderFunc);
        return tree;
    }

    private static void AddChildNodesRecursive<TKey>(IGrowingTree<T> tree, ITreeNode<T> parentNode, IRetrievalCollection<T> collection, Func<T, T, bool> isChildOfFunc, Func<T, TKey> orderFunc)
    {
        IEnumerable<T> children = collection.Retrieve(child => isChildOfFunc(child, parentNode.Payload)).ToList();
        if (orderFunc != null)
        {
            children = children.OrderBy(orderFunc);
        }
        foreach (var child in children)
        {
            var childNode = tree.AddChildNode(parentNode, child);
            AddChildNodesRecursive(tree, childNode, collection, isChildOfFunc, orderFunc);
        }
    }

    private static T GetRoot(IRetrievalCollection<T> collection, Func<T, bool> isRootPredicate)
    {
        if (collection.Any(isRootPredicate))
        {
            return collection.RetrieveFirstOrDefault(isRootPredicate);
        }

        throw new TreeBuilderException("No payload found in the collection that satisfies the root predicate.");
    }
}
