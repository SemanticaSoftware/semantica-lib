using Semantica.Collections;

namespace Semantica.Trees.Builders;

/// <summary>
/// Used to build a <see cref="IGrowingTree{T}"/> from a collection of payloads.
/// Implementation requires an instance of <see cref="ITreeBuildPredicateProvider{T}"/> to identify payloads as root or children.
/// </summary>
/// <typeparam name="T">Type of payload for the tree.</typeparam>
public interface ITreeBuilder<T>
{
    /// <summary>
    /// Builds the tree. Will retrieve nodes from the collection, starting with the root node, and adding children recursively.
    /// </summary>
    /// <param name="collection"><see cref="IRetrievalCollection{T}"/> containing the payloads.</param>
    /// <exception cref="TreeBuilderException">If there is no root node in the collection.</exception>
    /// <returns>A <see cref="IGrowingTree{T}"/> with <typeparamref name="T"/> as payload.</returns>
    IGrowingTree<T> GrowTree(IRetrievalCollection<T> collection);
}
