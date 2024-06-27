using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Core.Test._Mocks;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Linq;

partial class EnumerableLinqTest
{
    private static int DifferenceFunc(int item, int prev) => item - prev;

    [TestMethod]
    public void SelectWithPrevious_TestEnumerator_EnumeratesAllItemsOnce()
    {
        var testEnumerator = new TestEnumerator(SomeEnumerables.Integers);
        //ACT
        EnumerableLinq.SelectWithPrevious(testEnumerator, DifferenceFunc).Enumerate();
        //ASSERT
        CollectionAssert.AreEqual(SomeArrays.Integers, testEnumerator.EnumeratedItems);
    }

    [TestMethod]
    public void SelectWithPrevious_Integers_ResultingEnumerationEqualCount()
    {
        //ACT
        var result = 0;
        foreach (var previou in EnumerableLinq.SelectWithPrevious(SomeEnumerables.Integers, DifferenceFunc)) result++;
        //ASSERT
        Assert.AreEqual(SomeArrays.Integers.Length, result);
    }

    [TestMethod]
    public void SelectWithPrevious_TestEnumeratorGetFirstValue_EnumeratesJustOneItem()
    {
        var testEnumerator = new TestEnumerator(SomeEnumerables.Integers);
        //ACT
        var result = EnumerableLinq.SelectWithPrevious(testEnumerator, DifferenceFunc).First();
        //ASSERT
        Assert.AreEqual(1, testEnumerator.EnumeratedItems.Count);
    }

    [TestMethod]
    public void SelectWithPrevious_Integers_AllDifferenceOne()
    {
        //ACT
        var result = EnumerableLinq.SelectWithPrevious(SomeArrays.Integers, DifferenceFunc).ToList();
        //ASSERT
        Assert.IsTrue(result.All(i => i == 1));
    }

    [TestMethod]
    public void SelectWithNext_TestEnumerator_EnumeratesAllItemsOnce()
    {
        var testEnumerator = new TestEnumerator(SomeEnumerables.Integers);
        //ACT
        EnumerableLinq.SelectWithNext(testEnumerator, DifferenceFunc).Enumerate();
        //ASSERT
        CollectionAssert.AreEqual(SomeArrays.Integers, testEnumerator.EnumeratedItems);
    }

    [TestMethod]
    public void SelectWithNext_TestEnumeratorGetFirstValue_EnumeratesTwoItems()
    {
        var testEnumerator = new TestEnumerator(SomeEnumerables.Integers);
        //ACT
        var result = EnumerableLinq.SelectWithNext(testEnumerator, DifferenceFunc).First();
        //ASSERT
        Assert.AreEqual(2, testEnumerator.EnumeratedItems.Count);
    }

    [TestMethod]
    public void SelectWithNext_Integers_AllDifferenceMinusOneExceptLast()
    {
        var expected = Enumerable.Repeat(-1, SomeArrays.Integers.Length - 1).ToList();
        expected.Add(SomeArrays.Integers.Last());
        //ACT
        var result = EnumerableLinq.SelectWithNext(SomeEnumerables.Integers, DifferenceFunc).ToList();
        //ASSERT
        CollectionAssert.AreEqual(expected, result);
    }

    [TestMethod]
    public void SelectWithNext_Integers_LastItemOfResultCombinedWithDefault()
    {
        //ACT
        var result = EnumerableLinq.SelectWithNext(SomeEnumerables.Integers, DifferenceFunc);
        //ASSERT
        Assert.AreEqual(SomeArrays.Integers.Last(), result.Last());
    }
}
