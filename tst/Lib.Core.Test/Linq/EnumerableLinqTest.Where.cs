using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Linq;

partial class EnumerableLinqTest
{

    [TestMethod]
    public void WhereNotNull_ArrayOfObjects_SkipsNulls()
    {            
        //ACT
        var result = EnumerableLinq.WhereNotNull(_SomeData.SomeEnumerables.ObjectsNullable);
        //ASSERT
        Assert.AreEqual(6, result.Count());
    }

    [TestMethod]
    public void WhereNotNullOrEmpty_ArrayOfObjects_SkipsNulls()
    {
        //ACT
        var result = EnumerableLinq.WhereNotNullOrEmpty(_SomeData.SomeEnumerables.StringsNullable);
        //ASSERT
        Assert.AreEqual(6, result.Count());
    }

    [TestMethod]
    public void ConditionalWhere_ConditionTrue_FilteredItems()
    {
        bool Predicate(int i) => i > 3;
        //ACT
        var result = EnumerableLinq.ConditionalWhere(_SomeData.SomeEnumerables.Integers, true, Predicate).ToList();
        //ASSERT
        Assert.IsTrue(Enumerable.All(result, Predicate));
    }

    [TestMethod]
    public void ConditionalWhere_ConditionFalse_DoesNotFilterItems()
    {
        bool Predicate(int i) => i > 3;
        //ACT
        var result = EnumerableLinq.ConditionalWhere(_SomeData.SomeEnumerables.Integers, false, Predicate).ToList();
        //ASSERT
        Assert.IsFalse(Enumerable.All(result, Predicate));
    }

    [TestMethod]
    public void PrecedeBy_Enumerable_PrecedesEnumerableByItem()
    {
        var item = 0;
        var expectedList = new List<int>() {item};
        expectedList.AddRange(_SomeData.SomeEnumerables.Integers);
        //ACT
        var result = EnumerableLinq.PrecedeBy(_SomeData.SomeEnumerables.Integers, item).ToList();
        //ASSERT
        CollectionAssert.AreEqual(expectedList, result);
    }
}
