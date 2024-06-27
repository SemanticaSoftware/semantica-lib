using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Linq;

[TestClass]
public class QueryableExtensionsTest
{
    private static Expression<Func<int, bool>> PredicateExpression => i => i > 3;
    private static IQueryable<int> Integers => SomeArrays.Integers.AsQueryable();

    [TestMethod]
    public void ConditionalWhere_ConditionTrue_FilteredItems()
    {
        //ACT
        var result = QueryableLinq.ConditionalWhere(Integers, true, PredicateExpression);
        //ASSERT
        Assert.IsTrue(result.All(PredicateExpression));
    }

    [TestMethod]
    public void ConditionalWhere_ConditionFalse_DoesNotFilterItems()
    {
        //ACT
        var result = QueryableLinq.ConditionalWhere(Integers, false, PredicateExpression);
        //ASSERT
        Assert.IsFalse(result.All(PredicateExpression));
    }
}