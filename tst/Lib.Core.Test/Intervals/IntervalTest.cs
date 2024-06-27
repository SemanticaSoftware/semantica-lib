using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Intervals;

namespace Semantica.Lib.Tests.Core.Test.Intervals;

[TestClass]
public class IntervalTest
{
    private const double _leftBound = Double.E;
    private const double _rightBound = Double.Pi;
    private readonly Interval<double> _intervalBoundClosed = new Interval<double>(_leftBound, _rightBound, IntervalOpenKind.Closed);
    private readonly Interval<double> _intervalBoundLeftOpen = new Interval<double>(_leftBound, _rightBound, IntervalOpenKind.LeftOpen);
    private readonly Interval<double> _intervalBoundOpen = new Interval<double>(_leftBound, _rightBound, IntervalOpenKind.Open);
    private readonly Interval<double> _intervalBoundRightOpen = new Interval<double>(_leftBound, _rightBound);
    private readonly Interval<double> _intervalRightUnbound = new Interval<double>(_leftBound, default, boundKind: IntervalBoundKind.RightUnbound);
    private readonly Interval<double> _intervalLeftUnbound = new Interval<double>(default, _rightBound, boundKind: IntervalBoundKind.LeftUnbound);
    private readonly Interval<double> _intervalUnbound = new Interval<double>(default, default, boundKind: IntervalBoundKind.Unbound);

    [TestMethod]
    public void BoundKind_IntervalBoundRightOpen_Bound()
    {
        //ACT
        var actual = _intervalBoundRightOpen.BoundKind;
        //ASSERT
        Assert.AreEqual(IntervalBoundKind.Bound, actual);
    }

    [TestMethod]
    public void BoundKind_IntervalLeftUnbound_LeftUnbound()
    {
        //ACT
        var actual = _intervalLeftUnbound.BoundKind;
        //ASSERT
        Assert.AreEqual(IntervalBoundKind.LeftUnbound, actual);
    }

    [TestMethod]
    public void BoundKind_IntervalRightUnbound_RightUnbound()
    {
        //ACT
        var actual = _intervalRightUnbound.BoundKind;
        //ASSERT
        Assert.AreEqual(IntervalBoundKind.RightUnbound, actual);
    }

    [TestMethod]
    public void BoundKind_IntervalUnbound_Unbound()
    {
        //ACT
        var actual = _intervalUnbound.BoundKind;
        //ASSERT
        Assert.AreEqual(IntervalBoundKind.Unbound, actual);
    }
    
    [TestMethod]
    public void IsDegenerate_DegenerateInterval_True()
    {
        //ACT
        var actual = new Interval<double>(_leftBound, _leftBound, IntervalOpenKind.Closed).IsDegenerate();
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsDegenerate_HalfOpenIntervalEqualBounds_False()
    {
        //ACT
        var actual = new Interval<double>(_leftBound, _leftBound).IsDegenerate();
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsDegenerate_Interval_False()
    {
        //ACT
        var actual = _intervalBoundRightOpen.IsDegenerate();
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsEmpty_EmptyInterval_True()
    {
        //ACT
        var actual = Interval<double>.Empty.IsEmpty();
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsEmpty_HalfOpenIntervalEqualBounds_True()
    {
        //ACT
        var actual = new Interval<double>(_leftBound, _leftBound).IsEmpty();
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsEmpty_Interval_False()
    {
        //ACT
        var actual = _intervalBoundRightOpen.IsEmpty();
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Left_Interval_Left()
    {
        //ACT
        var actual = _intervalBoundRightOpen.Left;
        //ASSERT
        Assert.That.AreWithinEpsilon(_leftBound, actual, double.Epsilon);
    }

    [TestMethod]
    public void OpenKind_IntervalClosed_Closed()
    {
        //ACT
        var actual = _intervalBoundClosed.OpenKind;
        //ASSERT
        Assert.AreEqual(IntervalOpenKind.Closed, actual);
    }

    [TestMethod]
    public void OpenKind_IntervalLeftOpen_LeftOpen()
    {
        //ACT
        var actual = _intervalBoundLeftOpen.OpenKind;
        //ASSERT
        Assert.AreEqual(IntervalOpenKind.LeftOpen, actual);
    }

    [TestMethod]
    public void OpenKind_IntervalOpen_Open()
    {
        //ACT
        var actual = _intervalBoundOpen.OpenKind;
        //ASSERT
        Assert.AreEqual(IntervalOpenKind.Open, actual);
    }

    [TestMethod]
    public void OpenKind_IntervalRightOpen_RightOpen()
    {
        //ACT
        var actual = _intervalBoundRightOpen.OpenKind;
        //ASSERT
        Assert.AreEqual(IntervalOpenKind.RightOpen, actual);
    }

    [TestMethod]
    public void Right_Interval_Right()
    {
        //ACT
        var actual = _intervalBoundRightOpen.Right;
        //ASSERT
        Assert.That.AreWithinEpsilon(_rightBound, actual, double.Epsilon);
    }
}
