#nullable enable
using Semantica.Trees.Implementations;

namespace Semantica.Trees.Converters;

public static class TreeConverter
{
    /// <summary>
    /// Makes a new <see cref="GrowingTree{TOut}"/>, with the same shape as <paramref name="source"/>, but each node is converted using <paramref name="convertFunc"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="source"/> is an instance of <see cref="GrowingTree{T}"/>, the whole tree is copied efficiently without having to enumerate the tree and growing the new tree.
    /// </remarks>
    /// <param name="source">The <see cref="IReadOnlyTree{TIn}"/> to be converted.</param>
    /// <param name="convertFunc">The function that convertes the payloads.</param>
    /// <typeparam name="TIn">The type of payload of <paramref name="source"/>.</typeparam>
    /// <typeparam name="TOut">The type of payload of the output.</typeparam>
    /// <returns>A new instance of <see cref="GrowingTree{TOut}"/>.</returns>
    public static GrowingTree<TOut> ConvertTree<TIn, TOut>(IReadOnlyTree<TIn> source, Func<ITreeNode<TIn>, TOut> convertFunc)
    {
        return source is GrowingTree<TIn> sourceTree 
            ? sourceTree.CopyToNew(convertFunc) 
            : ConvertTree(source, convertFunc, null);
    }

    /// <summary>
    /// Makes a new <see cref="IGrowingTree{TOut}"/>, based on the <paramref name="source"/>, but each node is converted using <paramref name="convertFunc"/>.
    /// If a <paramref name="predicate"/> is provided, it's called for all children and only included in the output tree if it returns <see langword="true"/>.  
    /// </summary>
    /// <remarks>
    /// If a child is not included, it's children aren't included in the output either. 
    /// </remarks>
    /// <param name="source">The <see cref="IReadOnlyTree{TIn}"/> to be converted.</param>
    /// <param name="convertFunc">The function that convertes the payloads.</param>
    /// <param name="predicate">
    /// The predicate to be used on each childnode to see if is included in the output tree.
    /// A value of <see langword="false"/> for a node will cause that node (and subtree) not to be added to the output tree.
    /// </param>
    /// <typeparam name="TIn">The type of payload of <paramref name="source"/>.</typeparam>
    /// <typeparam name="TOut">The type of payload of the output.</typeparam>
    /// <returns>A new instance of <see cref="GrowingTree{TOut}"/>.</returns>
    public static GrowingTree<TOut> ConvertTree<TIn, TOut>(IReadOnlyTree<TIn> source, Func<ITreeNode<TIn>, TOut> convertFunc, Func<ITreeNode<TIn>, bool>? predicate)
    {
        var result = new GrowingTree<TOut>(convertFunc(source.RootNode), source.Count);
        AddChildNodesRecursive(source.RootNode, result.RootNode);
        return result;

        void AddChildNodesRecursive(ITreeNode<TIn> sourceParentNode, ITreeNode<TOut> outputParentNode)
        {
            foreach (var childSourceNode in sourceParentNode.ChildNodes.ConditionalWhere(predicate))
            {
                var childResultNode = result.AddChildNode(outputParentNode, convertFunc(childSourceNode));
                AddChildNodesRecursive(childSourceNode, childResultNode);
            }
        }
    }

    /// <summary>
    /// Makes a new <see cref="PartialTree{TOut}"/>, with the same shape as <paramref name="source"/>, but each node is converted using <paramref name="convertFunc"/>.
    /// </summary>
    /// <remarks>
    /// If <paramref name="source"/> is an instance of <see cref="PartialTree{T}"/>, the whole tree is copied efficiently without having to enumerate the tree and growing the new tree.
    /// </remarks>
    /// <param name="source">The <see cref="IReadOnlyPartialTree{TIn}"/> to be converted.</param>
    /// <param name="convertFunc">The function that convertes the payloads.</param>
    /// <typeparam name="TIn">The type of payload of <paramref name="source"/>.</typeparam>
    /// <typeparam name="TOut">The type of payload of the output.</typeparam>
    /// <returns>A new instance of <see cref="PartialTree{TOut}"/>.</returns>
    /// <exception cref="NotSupportedException">If the <paramref name="source"/> is not an instance of <see cref="PartialTree{TIn}"/>. Other types of partial trees are not yet supported.</exception>
    public static PartialTree<TOut> ConvertTree<TIn, TOut>(IReadOnlyPartialTree<TIn> source, Func<IPartialTreeNode<TIn>, TOut> convertFunc)
    {
        return source is PartialTree<TIn> sourceTree 
            ? sourceTree.CopyToNew(convertFunc) 
            : throw new NotSupportedException();
    }        
}