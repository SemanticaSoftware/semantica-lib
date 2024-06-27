using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Intervals;

namespace Semantica.Lib.Tests.Core.Test._Mocks;

[TestClass]
public class TestIntervalBuilderTests
{
    [TestMethod]
    public void TestInterBuilder_NoValues_SpansDomain()
    {
        // ACT
        var result = new TestIntervalBuilder().Build();
        // ASSERT
        Assert.IsTrue(result.IsUnbound());
    }
        
    [TestMethod]
    public void TestInterBuilder_NoRightSet_RightUnbounded()
    {
        // ACT
        var result = new TestIntervalBuilder()
                     .WithLeftClosed(1)
                     .Build();
        // ASSERT
        Assert.IsFalse(result.IsRightBounded());
    }
        
    [TestMethod]
    public void TestInterBuilder_NoLeftSet_LeftUnbounded()
    {
        // ACT
        var result = new TestIntervalBuilder()
                     .WithRightOpen(9)
                     .Build();
        // ASSERT
        Assert.IsFalse(result.IsLeftBounded());
    }
        
    [TestMethod]
    public void TestInterBuilder_ValuesSet()
    {
        // ACT
        var testInterval = new TestIntervalBuilder()
                           .WithLeftOpen(1)
                           .WithRightOpen(9)
                           .Build();
        // ASSERT
        Assert.AreEqual(1, testInterval.Left);
        Assert.AreEqual(9, testInterval.Right);
    }
        
    [TestMethod]
    public void TestInterBuilder_LeftOpenRightOpen()
    {
        // ACT
        var testInterval = new TestIntervalBuilder()
                           .WithLeftOpen(1)
                           .WithRightOpen(9)
                           .Build();
        // ASSERT
        Assert.IsTrue(testInterval.IsLeftOpen());
        Assert.IsTrue(testInterval.IsLeftBounded());
        Assert.IsTrue(testInterval.IsRightOpen());
        Assert.IsTrue(testInterval.IsRightBounded());
    }
        
    [TestMethod]
    public void TestInterBuilder_LeftClosedRightClosed()
    {
        // ACT
        var testInterval = new TestIntervalBuilder()
                           .WithLeftClosed(1)
                           .WithRightClosed(9)
                           .Build();
        // ASSERT
        Assert.IsFalse(testInterval.IsLeftOpen());
        Assert.IsTrue(testInterval.IsLeftBounded());
        Assert.IsFalse(testInterval.IsRightOpen());
        Assert.IsTrue(testInterval.IsRightBounded());
    }
}