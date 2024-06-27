using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Core.Test._Mocks;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Linq;

partial class EnumerableLinqTest
{
    [TestMethod]
    public void ToReadOnlyList_TestEnumerator_EnumeratesAllItemsOnce()
    {
        var testEnumerator = new TestEnumerator(SomeArrays.Integers);
        //ACT
        EnumerableLinq.ToReadOnlyList(testEnumerator);
        //ASSERT
        CollectionAssert.AreEqual(SomeArrays.Integers, testEnumerator.EnumeratedItems);
    }

    [TestMethod]
    public void ToReadOnlyList_Integers_ResultContainsSameItems()
    {
        //ACT
        var result = EnumerableLinq.ToReadOnlyList(SomeArrays.Integers);
        //ASSERT
        CollectionAssert.AreEqual(SomeArrays.Integers, Enumerable.ToList(result));
    }
}
