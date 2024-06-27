using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Collections;

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class DictionaryExtensionsTest
{
    private static int ToEven(int i) => i * 2;
    private static int ToOdd(int i) => i * 2 + 1;
    private static readonly int[] c_integers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    private static readonly int[] c_even = c_integers.Select(ToEven).ToArray();
    private static readonly int[] c_odd = c_integers.Select(ToOdd).ToArray();

    private IReadOnlyDictionary<int, int> _dictionary = null!;

    [TestInitialize]
    public void Init()
    {
        //Initialize data
        _dictionary = c_integers.ToArrayDictionary(ToEven, ToOdd);
    }

    [TestMethod]
    public void GetValueOrDefault_ExistingKey_ReturnsCorrectValue()
    {
        const int key = 2;
        //ACT
        var result = _dictionary.GetValueOrDefault(key);
        //ASSERT
        Assert.AreEqual(key + 1, result);
    }

    [TestMethod]
    public void GetValueOrDefault_NonExistingKey_ReturnsDefaultInt()
    {
        const int key = 3;
        //ACT
        var result = _dictionary.GetValueOrDefault(key);
        //ASSERT
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetValueOrDefault_ExplicitDefault_ExistingKey_ReturnsCorrectValue()
    {
        const int key = 2;
        //ACT
        var result = _dictionary.GetValueOrDefault(key, int.MinValue);
        //ASSERT
        Assert.AreEqual(key + 1, result);
    }

    [TestMethod]
    public void GetValueOrDefault_ExplicitDefault_NonExistingKey_ReturnsDefaultInt()
    {
        const int key = 3;
        //ACT
        var result = _dictionary.GetValueOrDefault(key, int.MinValue);
        //ASSERT
        Assert.AreEqual(int.MinValue, result);
    }

    [TestMethod]
    public void GetValueOrNull_ExistingKey_ReturnsCorrectValue()
    {
        const int key = 2;
        //ACT
        var result = _dictionary.GetValueOrNull(key);
        //ASSERT
        Assert.AreEqual(key + 1, result);
    }

    [TestMethod]
    public void GetValueOrNull_NonExistingKey_ReturnsNullInt()
    {
        const int key = 3;
        //ACT
        var result = _dictionary.GetValueOrNull(key);
        //ASSERT
        Assert.IsFalse(result.HasValue);
    }

    [TestMethod]
    public void SelectIfDictionaryContains_Integers_SelectsEvenValues()
    {
        //ACT
        var result = c_integers.SelectIfDictionaryContains(_dictionary).Select(kvp => kvp.Key).ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] {0, 2, 4, 6, 8}, result);
    }

    [TestMethod]
    public void SelectIfDictionaryContains_KeyFunc_Integers_SelectsEvenValues()
    {
        //ACT
        var result = c_integers.SelectIfDictionaryContains(i => i, _dictionary).Select(kvp => kvp.Key).ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] {0, 2, 4, 6, 8}, result);
    }
}