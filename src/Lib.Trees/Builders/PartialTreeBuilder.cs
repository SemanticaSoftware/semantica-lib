using Semantica.Trees.Implementations;

namespace Semantica.Trees.Builders;

public static class PartialTreeBuilder
{
    /// <summary>
    /// Will make a partial treee.
    /// </summary>
    /// <typeparam name="TIn">Type of payloads of the input nodes.</typeparam>
    /// <typeparam name="TOut">Types of payloads of the output.</typeparam>
    /// <typeparam name="TNode">The type of nodes of the input.</typeparam>
    /// <param name="root"></param>
    /// <param name="upperboundCapacity"></param>
    /// <param name="payloadConverter"></param>
    /// <returns></returns>
    public static PartialTree<TOut> MakeSubTree<TIn, TOut, TNode>(TNode root, int upperboundCapacity, Func<TNode, TOut> payloadConverter)
        where TNode : IAscendantTreeNode<TNode>, IDescendantTreeNode<TNode>, ITreeNodeProperties<TIn>
    {
        var protoNodes = new IArrayTreeNode<TOut>[upperboundCapacity];
        var nodeIndexCounter = 0;
        (var nodeCount, var rootIndex) = TraverseChildNodesRecursive(root, -1);

        return new PartialTree<TOut>(protoNodes, nodeCount);

        (int, int) TraverseChildNodesRecursive(TNode sourceNode, int parentIndex)
        {
            var nodeIndex = nodeIndexCounter;
            //reserve a spot in the array for the node.
            nodeIndexCounter += 1;
            var offspringCounter = 0;
            int[] childnodeIndexArray = null;
            if (! sourceNode.IsLeaf())
            {
                var childNodesCount = sourceNode.ChildNodes.Count;
                childnodeIndexArray = new int[childNodesCount];
                for (var childArrayIndex = 0; childArrayIndex < childNodesCount; childArrayIndex++)
                {
                    var sourceChildNode = sourceNode.ChildNodes[childArrayIndex];
                    (var childOffspringCount, var childGlobalIndex) = TraverseChildNodesRecursive(sourceChildNode, nodeIndex);
                    childnodeIndexArray[childArrayIndex] = childGlobalIndex;
                    offspringCounter += childOffspringCount;
                }
            }

            var newPayload = payloadConverter(sourceNode);
            protoNodes[nodeIndex] = new ProtoNode<TOut>(newPayload, nodeIndex, sourceNode.Level, parentIndex, childnodeIndexArray, offspringCounter);
            return (1 + offspringCounter, nodeIndex);
        }
    }

    internal readonly struct ProtoNode<T> : IArrayTreeNode<T>
    {

        public ProtoNode(T payload, int index, int level, int parentIndex, IReadOnlyList<int> childIndices, int offspringCount)
        {
            ParentIndex = parentIndex;
            ChildIndices = childIndices;
            Level = level;
            OffspringCount = offspringCount;
            Index = index;
            Payload = payload;
        }

        public IReadOnlyList<int> ChildIndices { get; }

        public int Index { get; }

        public int Level { get; }
        public bool IsLeaf()
        {
            return ChildIndices == null;
        }

        public int OffspringCount { get; }

        public int ParentIndex { get; }

        public T Payload { get; }
    }
}
