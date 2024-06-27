namespace Semantica.Trees;

/// <summary>
/// Represents a tree data structure where each node has a payload.
/// </summary>
/// <typeparam name="TNode">Type of the nodes.</typeparam>
/// <typeparam name="TPayload">Type of payload of the nodes.</typeparam>
public interface IReadOnlyMorphologicTree<out TNode, out TPayload> : IMorphologicTree<TNode>
    where TNode: IMorphologicTreeNode<TNode>, ITreeNodeProperties<TPayload>
{
}
