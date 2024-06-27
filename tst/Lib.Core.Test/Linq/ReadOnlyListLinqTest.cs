using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Linq;

[TestClass]
public class ReadOnlyListLinqTest
{
    private static readonly int[] c_integers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private IReadOnlyList<int> _readOnlyList = null!;

    [TestInitialize]
    public void Init()
    {
        //Initialize data
        _readOnlyList = ReadOnlyListLinq.ToReadOnlyList(c_integers);
    }

    [TestMethod]
    public void GetOrDefault_GetByIndex_ReturnsCorrectValue()
    {
        var index = 7;
        //ACT
        var result = ReadOnlyListLinq.GetOrDefault(_readOnlyList, index);
        //ASSERT
        Assert.AreEqual(index, result);
    }

    [TestMethod]
    public void GetOrDefault_NonExistantIndex_ReturnsDefaultInt()
    {
        var key = 42;
        //ACT
        var result = ReadOnlyListLinq.GetOrDefault(_readOnlyList, key);
        //ASSERT
        Assert.AreEqual(0, result);
    }
        
    [TestMethod]
    public void SkipEnd_SkipThreeElements_ReturnsRemainingSeven()
    {
        var elementsToSkip = 3;
        //ACT
        var result = ReadOnlyListLinq.SkipLast(_readOnlyList, elementsToSkip).Count();
        //ASSERT
        Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void SkipEnd_SkipThreeElements_RemovedLastThreeElements()
    {
        var elementsToSkip = 3;
        //ACT
        var result = ReadOnlyListLinq.SkipLast(_readOnlyList, elementsToSkip).Last();
        //ASSERT
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void SkipEnd_SkipMoreElementsThanPresent_ReturnsEmpty()
    {
        var elementsToSkip = 42;
        //ACT
        var result = ReadOnlyListLinq.SkipLast(_readOnlyList, elementsToSkip).Count();
        //ASSERT
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void IndexOf_ElementPresent_ReturnsCorrectIndex()
    {
        var element = 5;
        //ACT
        var result = ReadOnlyListLinq.IndexOf(_readOnlyList, element);
        //ASSERT
        Assert.AreEqual(element, result);
    }

    [TestMethod]
    public void IndexOf_ElementNotPresent_ReturnsNegativeOne()
    {
        var element = 42;
        //ACT
        var result = ReadOnlyListLinq.IndexOf(_readOnlyList, element);
        //ASSERT
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    public void IndexOf_PredicateElementPresent_ReturnsCorrectIndex()
    {
        bool findSeven(int i) => i == 7;
        //ACT
        var result = ReadOnlyListLinq.IndexOf(_readOnlyList, findSeven);
        //ASSERT
        Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void IndexOf_PredicateElementNotPresent_ReturnsNegativeOne()
    {
        bool findFortytwo(int i) => i.Equals(42);
        //ACT
        var result = ReadOnlyListLinq.IndexOf(_readOnlyList, findFortytwo);
        //ASSERT
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    public void ForEach_PerformActionOnAllItems_AddItemsToNewList()
    {
        var result = new List<int>();
        void actie(int item) => result.Add(item);
        //ACT
        ReadOnlyListLinq.ForEach(_readOnlyList, actie);
        //ASSERT
        CollectionAssert.AreEqual(c_integers, result);
    }

    [TestMethod]
    public void ForEach_PerformActionOnAllItemsWithIndexAvailable_AddItemsToNewList()
    {
        var result = new List<int>();
        void actie(int item, int index) => result.Add(item + index);
        //ACT
        ReadOnlyListLinq.ForEach(_readOnlyList, actie);
        //ASSERT
        CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 }, result);
    }

    [TestMethod]
    public void AreDistinct_WithDefaultComparer_ReturnsTrue()
    {
        var list = new[] { "abc", "ABC", "Abc" };

        var result = ReadOnlyListLinq.AreDistinct(list, x => x);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void AreDistinct_WithDuplicateElements_ReturnsFalse()
    {
        var list = new[] { 0, 0, 0, 1, 2, 3 };

        var result = ReadOnlyListLinq.AreDistinct(list, x => x);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void AreDistinct_WithCaseInsensitiveComparer_ReturnsFalse()
    {
        var list = new[] { "abc", "ABC", "Abc" };

        var result = ReadOnlyListLinq.AreDistinct(list, x => x, StringComparer.OrdinalIgnoreCase);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void AreDistinctOrDefault_WithDuplicateZeroes_ReturnsTrue()
    {
        var list = new[] { 0, 0, 0, 1, 2, 3 };

        var result = ReadOnlyListLinq.AreDistinctOrDefault(list, x => x);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void AreDistinctOrDefault_WithNullStrings_ReturnsTrue()
    {
        var list = new[] { "abc", "def", null, null };

        var result = ReadOnlyListLinq.AreDistinctOrDefault(list, x => x);

        Assert.IsTrue(result);
    }

    [TestMethod]
    public void AreDistinctOrDefault_WithDuplicateElements_ReturnsTrue()
    {
        var list = new[] { 0, 1, 1, 1, 2, 3 };

        var result = ReadOnlyListLinq.AreDistinctOrDefault(list, x => x);

        Assert.IsFalse(result);
    }

    [TestMethod]
    public void AreDistinctOrDefault_WithCaseInsensitiveComparer_ReturnsFalse()
    {
        var list = new[] { "abc", "ABC", null, null };

        var result = ReadOnlyListLinq.AreDistinctOrDefault(list, x => x, StringComparer.OrdinalIgnoreCase);

        Assert.IsFalse(result);
    }
}