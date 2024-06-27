using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class ComparableExtensionsTest
{
    private record struct TestValue(int A, int B);

    [TestMethod]
    public void MaxBy_Predicate_ReturnsOnlyMatchingItems()
    {
        var values = new List<int> { 10, 9, 8 };

        var result = values.MaxBy(x => x, x => x < 10, x => x);

        Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void MaxBy_Tiebreaker_UsedWhenValuesAreEqual()
    {
        var values = new List<TestValue> { new(1, 1), new(1, 999), new(1, 2) };

        var result = values.MaxBy(x => x.A, _ => true, x => x.B);

        Assert.AreEqual(999, result.B);
    }
}
