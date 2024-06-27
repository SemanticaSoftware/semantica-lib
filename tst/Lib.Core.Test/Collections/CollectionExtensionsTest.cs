using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Core.Test._Mocks;
using CollectionExtensions = Semantica.Collections.CollectionExtensions;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Collections;

[TestClass]
public class CollectionExtensionsTest
{
    private static int KeyFunc(int i) => i * 2 - 1;
    private static int ValueFunc(int i) => i * 2;

    [TestMethod]
    public void ToArrayDictionary_TestEnumerator_EnumeratesAllItemsOnce()
    {
        var testEnumerator = new TestEnumerator(SomeEnumerables.Integers);
        //ACT
        CollectionExtensions.ToArrayDictionary(testEnumerator, i => i);
        //ASSERT
        CollectionAssert.AreEqual(SomeArrays.Integers, testEnumerator.EnumeratedItems);
    }

    [TestMethod]
    public void ToArrayDictionary_Integers_ResultContainsAllItemsAsValues()
    {
        //ACT
        var result = CollectionExtensions.ToArrayDictionary(SomeEnumerables.Integers, i => i);
        //ASSERT
        CollectionAssert.AreEqual(SomeArrays.Integers, Enumerable.ToList(result.Values));
    }

    [TestMethod]
    public void ToArrayDictionary_Integers_ResultContainsCorrectKeys()
    {
        //ACT
        var result = CollectionExtensions.ToArrayDictionary(SomeEnumerables.Integers, i => i);
        //ASSERT
        CollectionAssert.AreEqual(SomeArrays.Integers, Enumerable.ToList(result.Keys));
    }

    [TestMethod]
    public void ToArrayDictionary_ValueFunc_Integers_ResultContainsCorrectKeys()
    {
        var expected = SomeEnumerables.Integers.Select(KeyFunc).ToList();
        //ACT
        var result = CollectionExtensions.ToArrayDictionary(SomeEnumerables.Integers, KeyFunc, ValueFunc);
        //ASSERT
        CollectionAssert.AreEqual(expected, Enumerable.ToList(result.Keys));
    }

    [TestMethod]
    public void ToArrayDictionary_ValueFunc_Integers_ResultContainsCorrectValues()
    {
        var expected = SomeEnumerables.Integers.Select(ValueFunc).ToList();
        //ACT
        var result = CollectionExtensions.ToArrayDictionary(SomeEnumerables.Integers, KeyFunc, ValueFunc);
        //ASSERT
        CollectionAssert.AreEqual(expected, result.Values.ToList());
    }

    [TestMethod]
    public void ToArrayDictionary_ValueFunc_Integers_MapsCorrectly()
    {
        //ACT
        var result = CollectionExtensions.ToArrayDictionary(SomeEnumerables.Integers, KeyFunc, ValueFunc);
        //ASSERT
        foreach (var key in SomeEnumerables.Integers.Select(KeyFunc))
        {
            Assert.AreEqual(key + 1, result[key]);
        }
    }
}
