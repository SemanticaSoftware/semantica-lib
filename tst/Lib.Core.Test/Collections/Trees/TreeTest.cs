using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Core.Test._SomeData.Trees;
using Semantica.Trees;

namespace Semantica.Lib.Tests.Core.Test.Collections.Trees;

/// <summary>
/// Test zowel Tree als TreeNode methodes en properties.
/// </summary>
[TestClass]
public class TreeTest
{
    //SUT
    private IGrowingTree<int> _tree = null!;

    [TestInitialize]
    public void Init()
    {
        //Initialize SUT
        _tree = SomeTree.CreateEmpty();
    }


    [TestMethod]
    public void Count_SomeEmptyTree_ReturnsCorrectValue()
    {
        //ACT
        var result = _tree.Count;
        //ASSERT
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Count_SomeTree_ReturnsCorrectValue()
    {
        _tree = SomeTree.CreateWithChildNodes();
        //ACT
        var result = _tree.Count;
        //ASSERT
        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void IsEmpty_SomeEmptyTree_ReturnsTrue()
    {
        //ACT
        var result = _tree.IsEmpty();
        //ASSERT
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void Payload_SomeEmptyTree_ReturnsCorrectValue()
    {
        //ACT
        var result = _tree.RootNode.Payload;
        //ASSERT
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void IsRoot_SomeEmptyTree_ReturnsTrueForRootNode()
    {
        //ACT
        var result = _tree.RootNode.IsRoot();
        //ASSERT
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void IsLeaf_SomeEmptyTreeRootNode_ReturnsTrue()
    {
        //ACT
        var result = _tree.RootNode.IsLeaf();
        //ASSERT
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void AddChildNode_SomeEmptyTree_RootNodeIsNotLeaf()
    {
        _tree.AddChildNode(_tree.RootNode, 1);
        //ACT
        var result = _tree.RootNode.IsLeaf();
        //ASSERT
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void AddChildNode_SomeEmptyTree_ChildNodeIsNotRoot()
    {
        //ACT
        var result = _tree.AddChildNode(_tree.RootNode, 1).IsRoot();
        //ASSERT
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void AddChildNode_SomeEmptyTree_ReturnsChildNodeWithRootAsParent()
    {
        //ACT
        var result = _tree.AddChildNode(_tree.RootNode, 1).ParentNode;
        //ASSERT
        Assert.AreSame(_tree.RootNode, result);
    }

    [TestMethod]
    public void AddChildNode_SomeEmptyTree_ParentNodeUnleafed()
    {
        _tree.AddChildNode(_tree.RootNode, 1);
        //ACT
        var result = _tree.RootNode.IsLeaf();
        //ASSERT
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void AddChildNode_SomeEmptyTree_ChildNodeIsLeaf()
    {
        //ACT
        var result = _tree.AddChildNode(_tree.RootNode, 1).IsLeaf();
        //ASSERT
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void AddChildNode_SomeEmptyTreeWithGrandChild_ChildIsNotLeaf()
    {
        var childNode = _tree.AddChildNode(_tree.RootNode, 1);
        _tree.AddChildNode(childNode, 2);
        //ACT
        var result = childNode.IsLeaf();
        //ASSERT
        Assert.AreEqual(false, result);
    }

    [DataTestMethod]
    [DataRow(42)]
    [DataRow(-42)]
    [DataRow(42424242)]
    public void AddChildNode_SomeEmptyTree_ReturnsChildNodeWithCorrectValuet(int content)
    {
        //ACT
        var result = _tree.AddChildNode(_tree.RootNode, content).Payload;
        //ASSERT
        Assert.AreEqual(content, result);
    }

    [TestMethod]
    public void AddChildNode_SomeEmptyTree_TreeNotEmptyAfterAddingChild()
    {
        _tree.AddChildNode(_tree.RootNode, 1);
        //ACT
        var result = _tree.IsEmpty();
        //ASSERT
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void AddChildNode_SomeEmptyTree_NodeBelongsToSameTree()
    {
        //ACT
        var result = _tree.AddChildNode(_tree.RootNode, 1).Owner;
        //ASSERT
        Assert.AreSame(_tree.RootNode.Owner, result);
    }

    [TestMethod]
    public void ParentNode_SomeEmptyTreeWithChildNode_ReturnsCorrectParent()
    {
        //ACT
        var result = _tree.AddChildNode(_tree.RootNode, 1).ParentNode;
        //ASSERT
        Assert.AreSame(_tree.RootNode, result);
    }

    [TestMethod]
    public void ParentNode_SomeEmptyTreeWithGrandchildNode_ReturnsCorrectGrandParent()
    {
        //ACT
        var result = _tree.AddChildNode(_tree.AddChildNode(_tree.RootNode, 1), 2).ParentNode.ParentNode;
        //ASSERT
        Assert.AreSame(_tree.RootNode, result);
    }

    [TestMethod]
    public void NodesFromDifferentTrees_BelongToDifferentTrees()
    {
        //ACT
        var result = SomeTree.CreateEmpty().RootNode.Owner;
        //ASSERT
        Assert.AreNotSame(_tree.RootNode.Owner, result);
    }

    [TestMethod]
    public void ChildNodesCount_SomeTree_ReturnsCorrectValue()
    {
        _tree = SomeTree.CreateWithChildNodes();
        //ACT
        var result = _tree.RootNode.ChildNodes.Count;
        //ASSERT
        Assert.AreEqual(3, result);
    }
}