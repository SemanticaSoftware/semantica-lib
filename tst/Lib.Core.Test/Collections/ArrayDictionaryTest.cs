using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Collections;

namespace Semantica.Lib.Tests.Core.Test.Collections;

[TestClass]
public class ArrayDictionaryTest
{
    //SUT
    private ArrayDictionary<int,int> _arrayDictionary = null!;
    //data
    private List<int> _keys = null!;
    private List<int> _values = null!;
    private int _count;

    [TestInitialize]
    public void Init()
    {
        //Initialize data
        _count = 16;
        //Initialize SUT
        _arrayDictionary = new ArrayDictionary<int, int>(SomeData(_count));
        //Common setup
    }

    [TestMethod]
    public void Count_SomeData_ReturnsCorrectCount()
    {
        //ACT
        var result = _arrayDictionary.Count;
        //ASSERT
        Assert.AreEqual(_count, result);
    }

    [TestMethod]
    public void Keys_SomeData_ReturnsAllKeys()
    {            
        //ACT
        var result = _arrayDictionary.Keys.ToList();
        //ASSERT
        CollectionAssert.AreEqual(_keys, result);
    }

    [TestMethod]
    public void Values_SomeData_ReturnsAllKeys()
    {
        //ACT
        var result = _arrayDictionary.Values.ToList();
        //ASSERT
        CollectionAssert.AreEqual(_values, result);
    }

    [TestMethod]
    public void Indexer_ExisingKey_ReturnsValue()
    {            
        //ACT
        var result = _arrayDictionary[5];
        //ASSERT
        Assert.AreEqual(int.MinValue + 5, result);
    }

    [TestMethod]
    [ExpectedException(typeof(KeyNotFoundException))]
    public void Indexer_NonExisingKey_ThrowsException()
    {
        //ACT
        var result = _arrayDictionary[4];
    }

    [TestMethod]
    public void ContainsKey_ExistingKey_ReturnsTrue()
    {            
        //ACT
        var result = _arrayDictionary.ContainsKey(7);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ContainsKey_NonExistingKey_ReturnsFalse()
    {
        //ACT
        var result = _arrayDictionary.ContainsKey(6);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TryGetValue_ExistingKey_ReturnsTrue()
    {
        //ACT
        var result = _arrayDictionary.TryGetValue(7, out var value);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TryGetValue_ExistingKey_FindsCorrectValue()
    {
        //ACT
        var result = _arrayDictionary.TryGetValue(7, out var value);
        //ASSERT
        Assert.AreEqual(int.MinValue + 7, value);
    }

    [TestMethod]
    public void TryGetValue_NonExistingKey_ReturnsFalse()
    {
        //ACT
        var result = _arrayDictionary.TryGetValue(6, out var value);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void GetEnumerator_Generic_EnumeratesAll()
    {
        //ACT
        var result = _arrayDictionary.Select(x => x).Count();
        //ASSERT
        Assert.AreEqual(_count, result);
    }

    [TestMethod]
    public void GetEnumerator_Generic_EnumeratesAllItems()
    {
        //ACT
        var result = _arrayDictionary.Select(x => x).ToList();
        //ASSERT
        CollectionAssert.AreEqual(SomeData(_count).ToList(), result);
    }

    [TestMethod]
    public void GetEnumerator_NonGeneric_EnumeratesItem()
    {
        //ACT
        var result = ((IEnumerable)_arrayDictionary).GetEnumerator();
        result.MoveNext();
        //ASSERT
        Assert.AreEqual(SomeData(1).First(), result.Current);
    }

    private IEnumerable<KeyValuePair<int, int>> SomeData(int count)
    {            
        _keys = new List<int>(count);
        _values = new List<int>(count);
        for (var i = 0; i < count; i++)
        {
            yield return MakePair(i); 
        }
    }

    private KeyValuePair<int, int> MakePair(int i)
    {
        var key = (i * 2) + 1; //alleen oneven keys!
        var value = int.MinValue + key; //alleen negatieve values!
        _keys.Add(key);
        _values.Add(value);
        return new KeyValuePair<int, int>(key, value);
    }
}