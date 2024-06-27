using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Core.Test._Mocks;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Linq;

[TestClass]
public partial class EnumerableLinqTest
{

    [TestMethod]
    public void Enumerate_TestEnumerator_EnumeratesAllItemsOnce()
    {
        var testEnumerator = new TestEnumerator(_SomeData.SomeEnumerables.Integers);
        //ACT
        EnumerableLinq.Enumerate(testEnumerator.AsEnumerable);
        //ASSERT
        CollectionAssert.AreEqual(_SomeData.SomeArrays.Integers, testEnumerator.EnumeratedItems);
    }

    [TestMethod]
    public void HasCount_Integers_ReturnsTrue()
    {
        //ACT
        var result = EnumerableLinq.HasCount(_SomeData.SomeEnumerables.Integers, 6);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void HasCount_ArrayOfObjects_ReturnsTrue()
    {
        //ACT
        var result = EnumerableLinq.HasCount(_SomeData.SomeEnumerables.ObjectsNullable, 8);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void HasCount_Integers_ReturnsFalse()
    {
        //ACT
        var result = EnumerableLinq.HasCount(_SomeData.SomeEnumerables.Integers, 2);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void HasCount_ArrayOfObjects_ReturnsFalse()
    {
        //ACT
        var result = EnumerableLinq.HasCount(_SomeData.SomeEnumerables.ObjectsNullable, 6);
        //ASSERT
        Assert.IsFalse(result);
    }

    public void tst()
    {
        SomeEnumerables.Integers.Select(x => x);
    }
}