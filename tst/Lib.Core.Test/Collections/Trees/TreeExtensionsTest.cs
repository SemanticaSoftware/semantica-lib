using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Trees;
using Semantica.Trees.Extensions;
using Semantica.Trees.Implementations;

namespace Semantica.Lib.Tests.Core.Test.Collections.Trees;

/// <summary>
/// Test zowel Tree als TreeNode extensionmethods.
/// </summary>
[TestClass]
public class TreeExtensionsTest
{
    //SUT
    private IGrowingTree<int> _tree = null!;
    private ITreeNode<int> _node2 = null!;
    private ITreeNode<int> _node5 = null!;
    private ITreeNode<int> _node7 = null!;
    private ITreeNode<int> _node8 = null!;
    private ITreeNode<int> _node9 = null!;

    [TestInitialize]
    public void Init()
    {
        //Initialize SUT
        CreateTreeAndSaveChildNodes();
    }

    private void CreateTreeAndSaveChildNodes()
    {
        _tree = new GrowingTree<int>(0);
        var node1 = _tree.AddChildNode(_tree.RootNode, 1);
        _node2 = _tree.AddChildNode(node1, 2);
        _tree.AddChildNode(_node2, 3);
        var node4 = _tree.AddChildNode(_tree.RootNode, 4);
        _node5 = _tree.AddChildNode(_tree.RootNode, 5);
        var node6 = _tree.AddChildNode(node4, 6);
        _node7 = _tree.AddChildNode(_node5, 7);
        _node8 = _tree.AddChildNode(_node5, 8);
        _node9 = _tree.AddChildNode(node6, 9);
    }

    #region TreeExtensions

    [TestMethod]
    public void TryDepthFirst_PredicateSatisfied_ReturnsNodeWithCorrectPayload()
    {
        //ACT
        var result = _tree.TryDepthFirst((int i) => i == 5, out var resultNode);
        //ASSERT
        Assert.IsTrue(result);
        Assert.AreEqual(5, resultNode?.Payload);
    }

    [TestMethod]
    public void TryDepthFirst_PredicateSatisfied_ReturnsNodeWithCorrectParent()
    {
        //ACT
        var result = _tree.TryDepthFirst((int i) => i == 5, out var resultNode);
        //ASSERT
        Assert.IsTrue(result);
        Assert.AreSame(_tree.RootNode, resultNode?.ParentNode);
    }

    [TestMethod]
    public void TryDepthFirst_PredicateNotSatisfied_ReturnsNull()
    {
        //ACT
        var result = _tree.TryDepthFirst((int i) => i == 42, out var resultNode);
        //ASSERT
        Assert.IsFalse(result);
        Assert.IsNull(resultNode);
    }

    [TestMethod]
    public void DepthFirstOrDefault_NodePresent_ReturnsNodeWithCorrectPayload()
    {
        //ACT
        var result = _tree.DepthFirstOrDefault((int i) => i == 8)?.Payload;
        //ASSERT
        Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void DepthFirstOrDefault_NodePresent_ReturnsNodeWithCorrectNumberOfChildren()
    {
        //ACT
        var result = _tree.DepthFirstOrDefault((int i) => i == 8)?.ChildNodes.Count;
        //ASSERT
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void DepthFirstOrDefault_NodeNotPresent_ReturnsNull()
    {
        //ACT
        var result = _tree.DepthFirstOrDefault((int i) => i == 42);
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void EnumerateDepthFirst_SomeTree_ContainsAllNodes()
    {
        //ACT
        var result = _tree.EnumerateDepthFirst().Count();
        //ASSERT
        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void EnumerateDepthFirst_SomeTree_RootNodeIsFirstElement()
    {
        //ACT
        var result = _tree.EnumerateDepthFirst().ToList().First();
        //ASSERT
        Assert.AreSame(_tree.RootNode, result);
    }

    [TestMethod]
    public void EnumerateDepthFirst_SomeTree_DepthFirstOrderingCorrect()
    {
        //ACT
        var result = _tree.EnumerateDepthFirst().Select(node => node.Payload).ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { 0, 1, 2, 3, 4, 6, 9, 5, 7, 8 }, result);
    }

    #endregion TreeExtensions

    #region TreeNodeExtensions

    [TestMethod]
    public void Payloads_SomeTree_ReturnsCorrectCount()
    {
        //ACT
        var result = _tree.RootNode.ChildNodes.Payloads().Count();
        //ASSERT
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Payloads_SomeTree_ReturnsCorrectPayloadsValues()
    {
        //ACT
        var result = _tree.RootNode.ChildNodes.Payloads().ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { 1, 4, 5 }, result);
    }

    [TestMethod]
    public void EnumerateAncestors_SomeTreeRootNode_ReturnsEmpty()
    {
        //ACT
        var result = _tree.RootNode.EnumerateAncestors().ToList().HasCount(0);
        //ASSERT
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void EnumerateAncestors_SomeTreeNode_ReturnsCorrectAncestorsDepthFirst()
    {
        //ACT
        var result = _node2.EnumerateAncestors().Select(n => n.Payload).ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { 1, 0 }, result);
    }

    [TestMethod]
    public void EnumerateAncestors_SomeTreeLeafNode_ReturnsCorrectAncestorsDepthFirst()
    {
        //ACT
        var result = _node9.EnumerateAncestors().Select(n => n.Payload).ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { 6, 4, 0 }, result);
    }

    [TestMethod]
    public void EnumerateOffspring_SomeTreeRootNode_ReturnsAllOffspringDepthFirst()
    {
        //ACT
        var result = _tree.RootNode.EnumerateOffspring().Select(node => node.Payload).ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 6, 9, 5, 7, 8 }, result);
    }

    [TestMethod]
    public void EnumerateOffspring_SomeTreeNode_ReturnsAllOffspringDepthFirst()
    {
        //ACT
        var result = _node2.EnumerateOffspring().Select(node => node.Payload).ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { 3 }, result);
    }

    [TestMethod]
    public void EnumerateOffspring_SomeTreeLeafNode_ReturnsEmpty()
    {
        //ACT
        var result = _node9.EnumerateOffspring().ToList().HasCount(0);
        //ASSERT
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void SiblingCount_SomeTreeNodeWithSiblings_ReturnsCorrectCount()
    {
        //ACT
        var result = _node8.SiblingCount();
        //ASSERT
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void SiblingCount_SomeTreeNodeWithoutSiblings_ReturnsCorrectCount()
    {
        //ACT
        var result = _node2.SiblingCount();
        //ASSERT
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void IndexOf_NodeWithSiblingAddedAfter_ReturnsCorrectValue()
    {
        //ACT
        var result = _node7.IndexOf();
        //ASSERT
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void IndexOf_NodeWithSiblingAddedFirst_ReturnsCorrectValue()
    {
        //ACT
        var result = _node8.IndexOf();
        //ASSERT
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void IndexOf_NodeWithoutSiblings_ReturnsCorrectValue()
    {
        //ACT
        var result = _node2.IndexOf();
        //ASSERT
        Assert.AreEqual(0, result);
    }

    #endregion TreeNodeExtensions
}