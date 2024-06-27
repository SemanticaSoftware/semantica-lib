using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Collections;
using Semantica.Lib.Tests.Core.Test._Mocks;

namespace Semantica.Lib.Tests.Core.Test.Collections;

[TestClass]
public class RetrievalCollectionTest
{
    //SUT
    private RetrievalCollection<int> _retrievalCollection = null!;
    //data
    private int _count;
    private List<int> _items = null!;
    private int _someItem;

    [TestInitialize]
    public void Init()
    {
        //Initialize data
        _count = 16;
        //Initialize SUT
        _retrievalCollection = new RetrievalCollection<int>(SomeData(_count));
        //Common setup
        _someItem = _items.Skip(_count / 2).First();
    }

    [TestMethod]
    public void Count_SomeData_ReturnsCount()
    {            
        //ACT
        var result = _retrievalCollection.Count;
        //ASSERT
        Assert.AreEqual(_count, result);
    }

    [TestMethod]
    public void RetrieveFirstOrDefault_MatchAnItem_RetrievesItem()
    {
        //ACT
        var result = _retrievalCollection.RetrieveFirstOrDefault(i => i == _someItem);
        //ASSERT
        Assert.AreEqual(_someItem, result);
    }

    [TestMethod]
    public void RetrieveFirstOrDefault_MatchAnItem_CollectionHasShrunk()
    {
        //ACT
        var result = _retrievalCollection.RetrieveFirstOrDefault(i => i == _someItem);
        //ASSERT
        Assert.AreEqual(_count - 1, _retrievalCollection.Count);
    }

    [TestMethod]
    public void RetrieveFirstOrDefault_MatchAnItem_ItemNoLongerInCollection()
    {
        //ACT
        var result = _retrievalCollection.RetrieveFirstOrDefault(i => i == _someItem);
        //ASSERT
        Assert.IsFalse(_retrievalCollection.Contains(_someItem));
    }

    [TestMethod]
    public void Retrieve_MatchAllButOneItem_ReturnsAllButThatItem()
    {
        var expected = _items.Where(i => i != _someItem).ToList();
        //ACT
        var result = _retrievalCollection.Retrieve(i => i != _someItem).ToList();
        //ASSERT
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void Retrieve_MatchAllButOneItem_ItemRemainsInCollection()
    {                        
        //ACT
        var result = _retrievalCollection.Retrieve(i => i != _someItem).ToList();
        //ASSERT
        Assert.IsTrue(_retrievalCollection.Contains(_someItem));
    }

    [TestMethod]
    public void Retrieve_MatchAllButOneItem_OneItemRemains()
    {
        //ACT
        var result = _retrievalCollection.Retrieve(i => i != _someItem).ToList();
        //ASSERT
        Assert.AreEqual(1, _retrievalCollection.Count);
    }
        
    [TestMethod]
    public void Retrieve_EnumerateTen_RestOfItemsRemain()
    {
        var numOfItemsToEnumerate = 10;
        //ACT
        var result = _retrievalCollection.Retrieve(i => true).Take(numOfItemsToEnumerate).ToList();
        //ASSERT
        Assert.AreEqual(_count - numOfItemsToEnumerate, _retrievalCollection.Count);
    }

    [TestMethod]
    public void IsEmpty_NonEmptyCollection_ReturnsFalse()
    {            
        //ACT
        var result = _retrievalCollection.IsEmpty();
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsEmpty_EmptyCollection_ReturnsTrue()
    {
        var emptyCollection = new RetrievalCollection<int>(Enumerable.Empty<int>());
        //ACT
        var result = emptyCollection.IsEmpty();
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void GetEnumerator_Generic_ReturnsAllItems()
    {            
        //ACT
        var result = _retrievalCollection.ActGetEnumeratorGeneric().ToList();
        //ASSERT
        CollectionAssert.AreEqual(_items, result);
    }

    [TestMethod]
    public void GetEnumerator_Generic_DoesNotRemoveItems()
    {
        //ACT
        _retrievalCollection.ActGetEnumeratorGeneric().Enumerate();
        //ASSERT
        Assert.AreEqual(_count, _retrievalCollection.Count);
    }

    [TestMethod]
    public void GetEnumerator_NonGeneric_ReturnsAllItems()
    {
        //ACT
        var result = _retrievalCollection.ActGetEnumeratorNonGeneric().ToList();
        //ASSERT
        CollectionAssert.AreEqual(_items, result);
    }

    private IEnumerable<int> SomeData(int count)
    {
        _items = new List<int>(count);
        for (var i = 0; i < count; i++)
        {
            yield return CreateItem(i);
        }
    }

    private int CreateItem(int i)
    {
        var item = i * 2 + 1;
        _items.Add(item);
        return item;
    }
}