using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Collections;
using Semantica.Lib.Tests.Core.Test._SomeData.Trees;
using Semantica.Trees.Builders;
using Semantica.Trees.Extensions;

namespace Semantica.Lib.Tests.Core.Test.Collections.Trees;

[TestClass]
public class TreeBuilderTest
{
    //SUT
    private ITreeBuildPredicateProvider<int> _treeBuildPredicateProvider = null!;
    private IRetrievalCollection<int> _collection = null!;
    private IRetrievalCollection<int> _collectionToFilter = null!;
    private ITreeBuilder<int> _treeBuilder = null!;

    [TestInitialize]
    public void Init()
    {
        //Initialize SUT
        _treeBuildPredicateProvider = new SomeTreeBuilderPredicateEvenUneven();
        _collection = SomeTreeBuilderData.CreateTreeBuilderCollection();
        _collectionToFilter = SomeTreeBuilderData.CreateTreeBuilderCollectionWithValuesToFilter();
        _treeBuilder = new TreeBuilder<int>(_treeBuildPredicateProvider);
    }

    [TestMethod]
    public void GrowTree_SomeTreeBuilderData_ReturnsCorrectCount()
    {
        var result = _treeBuilder.GrowTree(_collection).Count;
        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void GrowTree_SomeTreeBuilderData_ReturnsCorrectTree()
    {
        var result = _treeBuilder.GrowTree(_collection).EnumerateDepthFirst().Payloads().ToList();
        CollectionAssert.AreEqual(new[] { 0, 1, 3, 5, 7, 9, 2, 4, 6, 8 }, result);
    }

    [TestMethod]
    public void GrowTree_SomeTreeBuilderDataWithValuesToFilter_ReturnsCorrectCount()
    {
        var result = _treeBuilder.GrowTree(_collectionToFilter).Count;
        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void GrowTree_SomeTreeBuilderDataWithValuesToFilter_ReturnsCorrectTree()
    {
        var result = _treeBuilder.GrowTree(_collectionToFilter).EnumerateDepthFirst().Payloads().ToList();
        CollectionAssert.AreEqual(new[] { 0, 1, 3, 5, 7, 9, 2, 4, 6, 8 }, result);
    }
}