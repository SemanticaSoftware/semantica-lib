using Semantica.Patterns;

namespace Semantica.Trees;

/// <summary>
/// Represents a tree data structure consisting of nodes of type <see cref="ITreeNode{T}"/> where each node can have a payload of type <typeparamref name="T"/>.
/// </summary>
/// <remarks>
/// Implements <see cref="ICanBeEmpty"/>: the tree is considered empty if the root node has no children. The tree *always* has a root node.
/// Also implements <see cref="IReadOnlyList{TNode}"/>, and contains all nodes in the order they were added.
/// </remarks>
/// <typeparam name="T">Type of payload of the nodes.</typeparam>
public interface IReadOnlyTree<out T> : ICanBeEmpty, IReadOnlyList<ITreeNode<T>>, IReadOnlyMorphologicTree<ITreeNode<T>, T>
{
}
