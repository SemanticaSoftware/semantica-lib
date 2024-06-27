using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Collections;
using Semantica.Lib.Tests.Core.Test._Mocks;

namespace Semantica.Lib.Tests.Core.Test.Collections;

[TestClass]
public class SingleItemListTest
{
    //SUT
    private SingleItemList<int> _singleItemList = null!;
    //data
    private int _item;
    private const int _index = 2;

    [TestInitialize]
    public void Init()
    {
        //Initialize data
        _item = nameof(_item).GetHashCode();
        //Initialize SUT
        _singleItemList = new SingleItemList<int>(_item, _index);
        //Common setup
    }

    [TestMethod]
    public void Count_ReturnsOneMoreThenIndexOfItem()
    {
        //ACT
        var result = _singleItemList.Count;
        //ASSERT
        Assert.AreEqual(_index + 1, result);
    }

    [TestMethod]
    public void IsReadOnly_Always_ReturnsTrue()
    {           
        //ACT
        var result = _singleItemList.IsReadOnly;
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Contains_SameItem_ReturnsTrue()
    {            
        //ACT
        var result = _singleItemList.Contains(_item);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Contains_DifferentItem_ReturnsFalse()
    {
        //ACT
        var result = _singleItemList.Contains(_item + 1);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IndexOf_SameItem_ReturnsIndex()
    {            
        //ACT
        var result = _singleItemList.IndexOf(_item);
        //ASSERT
        Assert.AreEqual(_index, result);
    }

    [TestMethod]
    public void IndexOf_DefaultItem_Returns0()
    {
        //ACT
        var result = _singleItemList.IndexOf(0);
        //ASSERT
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void IndexOf_DifferentItem_ReturnsMinus1()
    {            
        //ACT
        var result = _singleItemList.IndexOf(_item + 1);
        //ASSERT
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    public void IndexerGet_CorrectIndex_ReturnsItem()
    {            
        //ACT
        var result = _singleItemList[_index];
        //ASSERT
        Assert.AreEqual(_item, result);
    }

    [TestMethod]
    public void IndexerGet_DifferentIndex_ReturnsDefault()
    {            
        //ACT
        var result = _singleItemList[_index - 1];
        //ASSERT
        Assert.AreEqual(default(int), result);
    }

    [TestMethod]
    public void CopyTo_EmptyArray_CopiesItem()
    {
        var array = new int[_singleItemList.Count + 1];
        //ACT
        _singleItemList.CopyTo(array, 1);
        var result = array.Last();
        //ASSERT
        Assert.AreEqual(_item, result);
    }

    [TestMethod]
    public void CopyTo_EmptyArray_CopiesDefaults()
    {
        var startIndex = 1;
        var array = new int[_singleItemList.Count + startIndex];
        //ACT
        _singleItemList.CopyTo(array, startIndex);
        //ASSERT
        Assert.IsTrue(array.Skip(startIndex).Take(_singleItemList.Count - startIndex - 1).All(i => i == 0));
    }

    [TestMethod]
    public void GetEnumerator_Generic_EnumeratesIndexItems()
    {            
        //ACT
        var result = _singleItemList.ActGetEnumeratorGeneric().Count();
        //ASSERT
        Assert.AreEqual(_index, result);
    }

    [TestMethod]
    public void GetEnumerator_Generic_CorrectNumberOfLeadingZero()
    {
        //ACT
        var result = _singleItemList.ActGetEnumeratorGeneric().Count(i => i == 0);
        //ASSERT
        Assert.AreEqual(_index - 1, result);
    }

    [TestMethod]
    public void GetEnumerator_Generic_EnumeratesItem()
    {
        //ACT
        var result = _singleItemList.ActGetEnumeratorGeneric().Last();
        //ASSERT
        Assert.AreEqual(_item, result);
    }

    [TestMethod]
    public void GetEnumerator_NonGeneric_EnumeratesItem()
    {
        //ACT
        var result = _singleItemList.ActGetEnumeratorNonGeneric().Last();
        //ASSERT
        Assert.AreEqual(_item, result);
    }
        
    [ExpectedException(typeof(NotSupportedException))]
    [TestMethod]
    public void Add_ThrowsNotSupportedException()
    {            
        //ACT
        _singleItemList.Add(_item);
    }

    [ExpectedException(typeof(NotSupportedException))]
    [TestMethod]
    public void Clear_ThrowsNotSupportedException()
    {
        //ACT
        _singleItemList.Clear();
    }

    [ExpectedException(typeof(NotSupportedException))]
    [TestMethod]
    public void Insert_ThrowsNotSupportedException()
    {
        //ACT
        _singleItemList.Insert(_item, 0);
    }

    [ExpectedException(typeof(NotSupportedException))]
    [TestMethod]
    public void Remove_ThrowsNotSupportedException()
    {
        //ACT
        _singleItemList.Remove(_item);
    }

    [ExpectedException(typeof(NotSupportedException))]
    [TestMethod]
    public void RemoveAt_ThrowsNotSupportedException()
    {
        //ACT
        _singleItemList.RemoveAt(0);
    }

    [ExpectedException(typeof(NotSupportedException))]
    [TestMethod]
    public void IndexerSet_ThrowsNotSupportedException()
    {
        //ACT
        _singleItemList[0] = _item;
    }

    [ExpectedException(typeof(IndexOutOfRangeException))]
    [TestMethod]
    public void IndexerGet_IndexTooHigh_ThrowsIndexOutOfRangeException()
    {
        //ACT
        var result = _singleItemList[_index + 10];
    }
}