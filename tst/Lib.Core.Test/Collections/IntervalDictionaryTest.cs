using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Intervals;
using Semantica.Lib.Tests.Core.Test._Mocks;

namespace Semantica.Lib.Tests.Core.Test.Collections;

[TestClass]
public class IntervalDictionaryTest
{
    private IntervalDictionary<decimal, object> _intervalDictionary = null!;
    private object _value = null!;
    private object _newValue = null!;

    [TestInitialize]
    public void Init()
    {
        _value = new {Id = "someValue"};
        _newValue = new { Id = "someNewValue" };
        _intervalDictionary = new IntervalDictionary<decimal, object>();
        Assert.IsTrue(_intervalDictionary.Add(TestInterval.GetSome(), _value), "Initialize");
    }

    [TestMethod]
    public void Add_NewRange_ReturnsTrue()
    {
        var newInterval = new TestInterval(10m, 15m);
        //ACT
        var result = _intervalDictionary.Add(newInterval, _newValue);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Add_NewRange_ValueIsAdded()
    {
        var newInterval = new TestInterval(10m, 15m);
        //ACT
        var result = _intervalDictionary.Add(newInterval, _newValue);
        //ASSERT
        Assert.IsTrue(_intervalDictionary.Values.Contains(_newValue));
    }

    [TestMethod]
    public void Add_NewAdjacentRange_ReturnsTrue()
    {
        var newInterval = new TestInterval(9m, 15m);
        //ACT
        var result = _intervalDictionary.Add(newInterval, _newValue);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Add_OverlappingNewRange_ReturnsFalse()
    {
        var newInterval = new TestInterval(4m, 13m);
        //ACT
        var result = _intervalDictionary.Add(newInterval, _newValue);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Add_OverlappingNewRange_ValueIsNotAdded()
    {
        var newInterval = new TestInterval(4m, 13m);
        //ACT
        var result = _intervalDictionary.Add(newInterval, _newValue);
        //ASSERT
        Assert.IsFalse(_intervalDictionary.Values.Contains(_newValue));
    }

    [DataTestMethod]
    [DataRow(-1, false, DisplayName = "Negative key")]
    [DataRow(0, false, DisplayName = "Zero key")]
    [DataRow(1, true, DisplayName = "Lower bound key")]
    [DataRow(4, true, DisplayName = "Key within interval")]
    [DataRow(9, false, DisplayName = "Upper bound key")]
    [DataRow(10, false, DisplayName = "Above upper bound key")]
    public void TryGet_Keys_ReturnsExpected(int key, bool expectedResult)
    {
        //ACT
        var result = _intervalDictionary.TryGet(key, out var foundValue);
        //ASSERT
        Assert.AreEqual(expectedResult, result);
    }

    [DataTestMethod]
    [DataRow(-1, false, DisplayName = "Negative key")]
    [DataRow(0, false, DisplayName = "Zero key")]
    [DataRow(1, true, DisplayName = "Lower bound key")]
    [DataRow(4, true, DisplayName = "Key within interval")]
    [DataRow(9, false, DisplayName = "Upper bound key")]
    [DataRow(10, false, DisplayName = "Above upper bound key")]
    public void TryGet_Keys_ReturnsCorrectValue(int key, bool returnsObject)
    {
        var expectedValue = returnsObject ? _value : default(object);
        //ACT
        var result = _intervalDictionary.TryGet(key, out var foundValue);
        //ASSERT
        Assert.AreEqual(expectedValue, foundValue);
    }

    [DataTestMethod]
    [DataRow(10)]
    [DataRow(11)]
    public void TryGet_MultipleEntries_KeyInNewRange_ReturnsNewValue(int key)
    {
        _intervalDictionary.Add(new TestInterval(12m, 15m), _value); //extra interval
        _intervalDictionary.Add(new TestInterval(10m, 12m), _newValue); //interval to look for
        //ACT
        var result = _intervalDictionary.TryGet(key, out var foundValue);
        //ASSERT
        Assert.AreEqual(_newValue, foundValue);
    }

    [DataTestMethod]
    [DataRow(-1)]
    [DataRow(8)]
    [DataRow(9)]
    [DataRow(12)]
    [DataRow(14)]
    [DataRow(16)]
    public void TryGet_MultipleEntries_OtherKeys_DoesNotReturnNewValue(int key)
    {
        _intervalDictionary.Add(new TestInterval(12m, 15m), _value); //extra interval
        _intervalDictionary.Add(new TestInterval(10m, 12m), _newValue); //interval to look for
        //ACT
        var result = _intervalDictionary.TryGet(key, out var foundValue);
        //ASSERT
        Assert.AreNotEqual(_newValue, foundValue);
    }

    [TestMethod]
    public void IndexOperator_KnownIndex_ReturnsValue()
    {
        //ACT
        var result = _intervalDictionary[2m];
        //ASSERT
        Assert.AreEqual(_value, result);
    }

    [TestMethod]
    [ExpectedException(typeof(KeyNotFoundException))]
    public void IndexOperator_UnknownIndex_ThrowsException()
    {
        //ACT
        var result = _intervalDictionary[-1m];
    }
}