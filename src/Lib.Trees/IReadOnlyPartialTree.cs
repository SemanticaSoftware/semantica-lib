using Semantica.Patterns;

namespace Semantica.Trees;

/// <summary>
/// Represents a tree data structure where each node can have a payload of type <typeparamref name="T"/>.
/// </summary>
/// <remarks>
/// Implements ICanBeEmpty: the tree is considered empty if the root node has no children. The tree ALWAYS has a root node.
/// Also implements IReadOnlyList, and contains all nodes in the order they were added.
/// </remarks>
/// <typeparam name="T">Type of payload of the nodes.</typeparam>
public interface IReadOnlyPartialTree<out T> : ICanBeEmpty, IReadOnlyList<IPartialTreeNode<T>>, IReadOnlyMorphologicTree<IPartialTreeNode<T>, T>
{
}
