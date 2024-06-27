using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Intervals;
using Semantica.Lib.Tests.Core.Test._Mocks;
using Semantica.TestTools.Core.ValueTypes;
using IntervalEnumerationExtensions = Semantica.Intervals.IntervalEnumerationExtensions;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Intervals;

[TestClass]
public class IntervalExtensionsTest
{
    private TestInterval _someInterval;
    private TestInterval _emptyInterval;

    [TestInitialize]
    public void Init()
    {
        _someInterval = TestInterval.GetSome();
        _emptyInterval = TestInterval.GetEmpty();
    }

    #region IsAnyLeftOf
    [TestMethod]
    public void IsAnyLeftOf_SameBounds_LeftClosed_OtherLeftOpen_True()
    {
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftOpen(_someInterval.Left)
                            .WithRightOpen(_someInterval.Right)
                            .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyLeftOf<decimal>(_someInterval, otherInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsAnyLeftOf_SameBounds_LeftOpen_OtherLeftClosed_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .WithRightOpen(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyLeftOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsAnyLeftOf_OverlapToLeft_LeftClosed_OtherLeftOpen_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left - 3m)
                       .WithRightOpen(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyLeftOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsAnyLeftOf_LeftNoOverlap_LeftClosed_OtherLeftOpen_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left - 3m)
                       .WithRightOpen(_someInterval.Left - 1m)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyLeftOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsAnyLeftOf_OverlapToRightNotLeft_RightOpen_OtherRightClosed_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left + 1m)
                       .WithRightClosed(_someInterval.Right + 3m)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyLeftOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsAnyLeftOf_RightNoOverlap_RightOpen_OtherRightClosed_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Right + 1m)
                       .WithRightClosed(_someInterval.Right + 3m)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyLeftOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }
    #endregion

    #region IsAnyLeftOf_Value
    [TestMethod]
    public void IsAnyLeftOf_Value_OnClosedBound_False()
    {
        // ACT
        var actual = IntervalExtensions.IsAnyLeftOf<decimal>(_someInterval, _someInterval.Left);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsAnyLeftOf_Value_OnOpenBound_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyLeftOf<decimal>(interval, _someInterval.Left);
        // ASSERT
        Assert.IsFalse(actual);
    }
    #endregion

    #region IsAnyRightOf
    [TestMethod]
    public void IsAnyRightOf_SameBounds_RightClosed_OtherRightOpen_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .WithRightClosed(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsAnyRightOf_SameBounds_RightOpen_OtherRightClosed_False()
    {
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftOpen(_someInterval.Left)
                            .WithRightOpen(_someInterval.Right)
                            .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(_someInterval, otherInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsAnyRightOf_OverlapRight_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .WithRightClosed(_someInterval.Right + 5)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsAnyRightOf_OverlapOnRightBoundClosed_OtherIntervalRightOpen_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left + 1m)
                       .WithRightClosed(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsAnyRightOf_RightOfOtherInterval_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Right + 1m)
                       .WithRightClosed(_someInterval.Right + 5m)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsAnyRightOf_LeftOnBoundOpen_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left - 5m)
                       .WithRightOpen(_someInterval.Right - 5m)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsAnyRightOf_Left_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left - 5m)
                       .WithRightOpen(_someInterval.Left - 2m)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(interval, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }
    #endregion

    #region IsAnyRightOf_Value
    [TestMethod]
    public void IsAnyRightOf_Value_OnClosedBound_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithRightClosed(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(interval, _someInterval.Right);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsAnyRightOf_Value_OnOpenBound_False()
    {
        // ACT
        var actual = IntervalExtensions.IsAnyRightOf<decimal>(_someInterval, _someInterval.Right);
        // ASSERT
        Assert.IsFalse(actual);
    }
    #endregion

    #region IsLeftOf_Value
    [TestMethod]
    public void IsLeftOf_ValueLeft_True()
    {
        var value = _someInterval.Left - 2m;
        // ACT
        var actual = IntervalExtensions.IsLeftOf<decimal>(value, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsLeftOf_ValueRight_False()
    {
        var value = _someInterval.Right + 2m;
        // ACT
        var actual = IntervalExtensions.IsLeftOf<decimal>(value, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsLeftOf_ValueOnLeftBound_LeftBoundClosed_False()
    {
        var value = _someInterval.Left;
        // ACT
        var actual = IntervalExtensions.IsLeftOf<decimal>(value, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsLeftOf_ValueOnLeftBound_LeftBoundOpen_True()
    {
        var value = _someInterval.Left;
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .WithRightOpen(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsLeftOf<decimal>(value, interval);
        // ASSERT
        Assert.IsTrue(actual);
    }
    #endregion

    #region IsLeftOf_Interval
    [TestMethod]
    public void IsLeftOf_EmptyInterval_False()
    {
        // ACT
        var actual = IntervalExtensions.IsLeftOf<decimal>(_emptyInterval, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsLeftOf_EmptyOtherInterval_False()
    {
        // ACT
        var actual = IntervalExtensions.IsLeftOf<decimal>(_someInterval, _emptyInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [DataTestMethod]
    [DataRow(-2, 0, DisplayName = "UnderLowerBound")]
    [DataRow(-1, 1, DisplayName = "ExactlyLowerBound")]
    [DataRow(0, 2, DisplayName = "PartlyOverlapsLower")]
    [DataRow(2, 4, DisplayName = "FallsWithin")]
    [DataRow(8, 10, DisplayName = "PartlyOverlapsUpper")]
    public void IsLeftOf_SomeInterval_False(int otherLeft, int otherRight)
    {
        var testInterval = new TestInterval(Convert.ToDecimal(otherLeft), Convert.ToDecimal(otherRight));
        // ACT
        var actual = IntervalExtensions.IsLeftOf<decimal>(_someInterval, testInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [DataTestMethod]
    [DataRow(9, 11, DisplayName = "ExactlyUpperBound")]
    [DataRow(10, 12, DisplayName = "AboveUpperBound")]
    public void IsLeftOf_SomeInterval_True(int otherLeft, int otherRight)
    {
        var testInterval = new TestInterval(Convert.ToDecimal(otherLeft), Convert.ToDecimal(otherRight));
        // ACT
        var actual = IntervalExtensions.IsLeftOf<decimal>(_someInterval, testInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    #endregion

    #region IsRightOf_Value
    [TestMethod]
    public void IsRightOf_SomeNumberWithEmptyInterval_False()
    {
        const decimal numberToTest = 10m;
        // ACT
        var actual = IntervalExtensions.IsRightOf(numberToTest, _emptyInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsRightOf_SomeNumberOnRightBoundOpen_True()
    {
        var numberToTest = _someInterval.Right;
        // ACT
        var actual = IntervalExtensions.IsRightOf(numberToTest, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsRightOf_SomeNumberOnRightBoundClosed_False()
    {
        var numberToTest = _someInterval.Right;
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .WithRightClosed(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsRightOf(numberToTest, interval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsRightOf_SomeNumberRight_True()
    {
        var numberToTest = _someInterval.Right + 2m;
        // ACT
        var actual = IntervalExtensions.IsRightOf(numberToTest, _someInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsRightOf_SomeNumberLeftOnBoundOpen_False()
    {
        var numberToTest = _someInterval.Left;
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .WithRightClosed(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsRightOf(numberToTest, interval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsRightOf_SomeNumberLeftOnBoundClosed_False()
    {
        var numberToTest = _someInterval.Left;
        var interval = new TestIntervalBuilder()
                       .WithLeftClosed(_someInterval.Left)
                       .WithRightClosed(_someInterval.Right)
                       .Build();
        // ACT
        var actual = IntervalExtensions.IsRightOf(numberToTest, interval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsRightOf_SomeNumberLeft_False()
    {
        var numberToTest = _someInterval.Left - 2m;
        // ACT
        var actual = IntervalExtensions.IsRightOf(numberToTest, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }
    #endregion

    #region IsRightOf_Interval
    [TestMethod]
    public void IsRightOf_EmptyInterval_False()
    {
        // ACT
        var actual = IntervalExtensions.IsRightOf<decimal>(_emptyInterval, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsRightOf_EmptyOtherInterval_False()
    {
        // ACT
        var actual = IntervalExtensions.IsRightOf<decimal>(_someInterval, _emptyInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [DataTestMethod]
    [DataRow(0, 2, DisplayName = "PartlyOverlapsLower")]
    [DataRow(2, 4, DisplayName = "FallsWithin")]
    [DataRow(8, 10, DisplayName = "PartlyOverlapsUpper")]
    [DataRow(9, 11, DisplayName = "ExactlyUpperBound")]
    [DataRow(10, 12, DisplayName = "AboveUpperBound")]
    public void IsRightOf_SomeInterval_False(int otherLeft, int otherRight)
    {
        var testInterval = new TestInterval(Convert.ToDecimal(otherLeft), Convert.ToDecimal(otherRight));
        // ACT
        var actual = IntervalExtensions.IsRightOf<decimal>(_someInterval, testInterval);
        // ACT
        Assert.IsFalse(actual);
    }

    [DataTestMethod]
    [DataRow(-2, 0, DisplayName = "UnderLowerBound")]
    [DataRow(-1, 1, DisplayName = "ExactlyLowerBound")]
    public void IsRightOf_SomeInterval_True(int otherLeft, int otherRight)
    {
        var testInterval = new TestInterval(Convert.ToDecimal(otherLeft), Convert.ToDecimal(otherRight));
        // ACT
        var actual = IntervalExtensions.IsRightOf<decimal>(_someInterval, testInterval);
        // ACT
        Assert.IsTrue(actual);
    }
    #endregion

    #region IsWithin_Value
    [TestMethod]
    public void IsWithin_SomeValueEmptyInterval_False()
    {
        const decimal numberToTest = 2m;
        //ACT
        var actual = IntervalExtensions.IsWithin(numberToTest, _emptyInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [DataTestMethod]
    [DataRow(0, DisplayName = "UnderLowerBound")]
    [DataRow(9, DisplayName = "ExactlyUpperBound")]
    [DataRow(10, DisplayName = "AboveUpperBound")]
    public void IsWithin_SomeInterval_False(int numberToTest)
    {
        //ACT
        var actual = IntervalExtensions.IsWithin(Convert.ToDecimal(numberToTest), _someInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [DataTestMethod]
    [DataRow(1, DisplayName = "ExactlyLowerBound")]
    [DataRow(2, DisplayName = "WithinBounds")]
    public void IsWithin_SomeInterval_True(int numberToTest)
    {
        //ACT
        var actual = IntervalExtensions.IsWithin(Convert.ToDecimal(numberToTest), _someInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsWithin_ClosedRange_ValueAbove_False()
    {
        var interval = SomeOpenRange.CreateClosed();
        var value = new ComparableCanBeEmpty(SomeOpenRange.UpperBound);
        //ACT
        var actual = value.IsWithin(interval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsWithin_ClosedRange_ValueBelow_False()
    {
        var interval = SomeOpenRange.CreateClosed();
        var value = new ComparableCanBeEmpty(-1);
        //ACT
        var actual = value.IsWithin(interval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsWithin_ClosedRange_ValueWithin_True()
    {
        var interval = SomeOpenRange.CreateClosed();
        var value = new ComparableCanBeEmpty(SomeOpenRange.UpperBound - 1);
        //ACT
        var actual = value.IsWithin(interval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsWithin_OpenRange_SomeHighValue_True()
    {
        var interval = SomeOpenRange.CreateUpperOpen();
        var value = new ComparableCanBeEmpty(100);
        //ACT
        var actual = value.IsWithin(interval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsWithin_OpenRange_ValueBelow_False()
    {
        var interval = SomeOpenRange.CreateUpperOpen();
        var value = new ComparableCanBeEmpty(-1);
        //ACT
        var actual = value.IsWithin(interval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsWithin_OpenRangeLower_SomeLowValue_True()
    {
        var interval = SomeOpenRange.CreateLowerOpen();
        var value = new ComparableCanBeEmpty(-100);
        //ACT
        var actual = value.IsWithin(interval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsWithin_OpenRangeLower_ValueAbove_False()
    {
        var interval = SomeOpenRange.CreateLowerOpen();
        var value = new ComparableCanBeEmpty(SomeOpenRange.UpperBound);
        //ACT
        var actual = value.IsWithin(interval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    #endregion

    #region IsWithin_Interval
    [TestMethod]
    public void IsWithin_EmptyInterval_SomeInterval()
    {
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(_emptyInterval, _someInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsWithin_SomeInterval_EmptyInterval()
    {
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(_someInterval, _emptyInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [DataTestMethod]
    [DataRow(-2, 0, DisplayName = "LeftOfBounds")]
    [DataRow(10, 12, DisplayName = "RightOfBounds")]
    [DataRow(3, 5, DisplayName = "EnclosedByBounds")]
    public void IsWithin_SomeInterval_False(decimal otherLeft, decimal otherRight)
    {
        var otherInterval = new TestInterval(otherLeft, otherRight);
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(_someInterval, otherInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [DataTestMethod]
    [DataRow(0, 10, DisplayName = "WithinBounds")]
    [DataRow(1, 10, DisplayName = "LeftOnBound")]
    public void IsWithin_SomeInterval_True(decimal otherLeft, decimal otherRight)
    {
        var otherInterval = new TestInterval(otherLeft, otherRight);
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(_someInterval, otherInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsWithin_SomeInterval_LowerBoundsMatch_True()
    {
        const decimal otherLeft = 1m;
        const decimal otherRight = 10m;
        var otherInterval = new TestInterval(otherLeft, otherRight);
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(_someInterval, otherInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsWithin_SomeInterval_UpperOpenBoundsMatch_True()
    {
        const decimal otherLeft = 0m;
        const decimal otherRight = 9m;
        var otherInterval = new TestInterval(otherLeft, otherRight);
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(_someInterval, otherInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsWithin_SomeInterval_BoundsMatch_OtherIntervalLeftClosedRightClosed_True()
    {
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftClosed(_someInterval.Left)
                            .WithRightClosed(_someInterval.Right)
                            .Build();
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(_someInterval, otherInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsWithin_SomeInterval_BoundsMatch_IntervalRightClosedAndOtherIntervalRightOpen_False()
    {
        var someIntervalRightClosed = new TestIntervalBuilder()
                                      .WithLeftClosed(_someInterval.Left)
                                      .WithRightClosed(_someInterval.Right)
                                      .Build();
        var otherIntervalRightOpen = _someInterval;
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(someIntervalRightClosed, otherIntervalRightOpen);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsWithin_SomeInterval_BoundsMatch_OtherIntervalLeftOpenRightClosed_False()
    {
        var otherIntervalLeftOpen = new TestIntervalBuilder()
                                    .WithLeftOpen(_someInterval.Left)
                                    .WithRightClosed(_someInterval.Right)
                                    .Build();
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(_someInterval, otherIntervalLeftOpen);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsWithin_SomeInterval_BoundsMatch_IntervalLeftClosedRightClosedAndOtherIntervalLeftOpenRightOpen_False()
    {
        var someIntervalLeftClosed = new TestIntervalBuilder()
                                     .WithLeftClosed(_someInterval.Left)
                                     .WithRightClosed(_someInterval.Right)
                                     .Build();
        var otherIntervalLeftOpen = new TestIntervalBuilder()
                                    .WithLeftOpen(_someInterval.Left)
                                    .WithRightOpen(_someInterval.Right)
                                    .Build();
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(someIntervalLeftClosed, otherIntervalLeftOpen);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsWithin_SomeInterval_BoundsMatch_IntervalLeftOpenRightOpenAndOtherIntervalLeftClosedRightClosed_False()
    {
        var someIntervalLeftClosed = new TestIntervalBuilder()
                                     .WithLeftClosed(_someInterval.Left)
                                     .WithRightClosed(_someInterval.Right)
                                     .Build();
        var otherIntervalLeftOpen = new TestIntervalBuilder()
                                    .WithLeftOpen(_someInterval.Left)
                                    .WithRightOpen(_someInterval.Right)
                                    .Build();
        // ACT
        var actual = IntervalExtensions.IsWithin<decimal>(someIntervalLeftClosed, otherIntervalLeftOpen);
        // ASSERT
        Assert.IsFalse(actual);
    }
    #endregion

    #region Overlaps
    [TestMethod]
    public void Overlaps_EmptyInterval_False()
    {
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(_emptyInterval, _someInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_EmptyOtherInterval_False()
    {
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(_someInterval, _emptyInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_LeftUnbounded_True()
    {
        var otherInterval = new TestIntervalBuilder()
                            .WithRightOpen(_someInterval.Right)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(_someInterval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_RightUnbounded_True()
    {
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftClosed(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(_someInterval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_BothLeftUnbounded_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithRightOpen(_someInterval.Right)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithRightOpen(_someInterval.Right)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_LeftUnbounded_OtherRightUnbounded_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithRightOpen(_someInterval.Right)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftOpen(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_LeftUnboundedRightUnbounded_True()
    {
        var interval = new TestIntervalBuilder().Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, _someInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_OtherLeftUnboundedRightUnbounded_True()
    {
        var otherInterval = new TestIntervalBuilder().Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(_someInterval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_RightUnbounded_OtherLeftUnbounded_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithRightOpen(_someInterval.Right)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_LeftOtherRightSameValueBothClosed_RightUnbounded_OtherLeftUnbounded_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftClosed(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithRightClosed(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_LeftOtherRightSameValueBothOpen_RightUnbounded_OtherLeftUnbounded_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithRightOpen(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_LeftOtherRightSameValue_LeftOpenOtherRightClosed_RightUnbounded_OtherLeftUnbounded_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftOpen(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithRightClosed(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_LeftOtherRightSameValue_LeftClosedOtherRightOpen_RightUnbounded_OtherLeftUnbounded_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftClosed(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithRightOpen(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_RightOtherLeftSameValueBothClosed_RightUnbounded_OtherLeftUnbounded_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithRightClosed(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftClosed(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_RightOtherLeftSameValueBothOpen_RightUnbounded_OtherLeftUnbounded_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithRightOpen(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftOpen(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_RightOtherLeftSameValue_RightOpenOtherLeftClosed_RightUnbounded_OtherLeftUnbounded_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithRightOpen(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftClosed(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_RightOtherLeftSameValue_RightClosedOtherLeftOpen_RightUnbounded_OtherLeftUnbounded_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithRightClosed(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftOpen(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_BothRightUnbounded_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftClosed(_someInterval.Left)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftClosed(_someInterval.Left)
                            .Build();
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [DataTestMethod]
    [DataRow(-2, 0, DisplayName = "UnderLowerBound")]
    [DataRow(-1, 1, DisplayName = "ExactlyLowerBound")]
    [DataRow(9, 11, DisplayName = "ExactlyUpperBound")]
    [DataRow(10, 12, DisplayName = "AboveUpperBound")]
    public void Overlaps_SomeInterval_False(int otherLeft, int otherRight)
    {
        var otherInterval = new TestInterval(Convert.ToDecimal(otherLeft), Convert.ToDecimal(otherRight));
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(_someInterval, otherInterval);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_LeftOnBoundClosed_True()
    {
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftClosed(_someInterval.Left - 6m)
                            .WithRightClosed(_someInterval.Left)
                            .Build();
        // ACT
        var actual = IntervalExtensions.Overlaps<decimal>(_someInterval, otherInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }

    [DataTestMethod]
    [DataRow(0, 2, DisplayName = "PartlyOverlapsLower")]
    [DataRow(2, 4, DisplayName = "FallsWithin")]
    [DataRow(8, 10, DisplayName = "PartlyOverlapsUpper")]
    public void Overlaps_SomeInterval_True(int otherLeft, int otherRight)
    {
        var otherInterval = new TestInterval(Convert.ToDecimal(otherLeft), Convert.ToDecimal(otherRight));
        //ACT
        var actual = IntervalExtensions.Overlaps<decimal>(_someInterval, otherInterval);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Overlaps_SharedBoundClosedOpen_False()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftClosed(_someInterval.Left)
                       .WithRightClosed(_someInterval.Right)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftOpen(_someInterval.Right)
                            .WithRightClosed(_someInterval.Right + 2m)
                            .Build();
        // ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        // ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Overlaps_SameBounds_BothClosed_LeftOpenRightClosed_True()
    {
        var interval = new TestIntervalBuilder()
                       .WithLeftClosed(_someInterval.Left)
                       .WithRightClosed(_someInterval.Right)
                       .Build();
        var otherInterval = new TestIntervalBuilder()
                            .WithLeftOpen(_someInterval.Left)
                            .WithRightClosed(_someInterval.Right)
                            .Build();
        // ACT
        var actual = IntervalExtensions.Overlaps<decimal>(interval, otherInterval);
        // ASSERT
        Assert.IsTrue(actual);
    }
    #endregion

    #region ToLowerboundIntervals
    [TestMethod]
    public void ToLowerboundIntervalPairs_EmptyEnumerable_EmptyResult()
    {
        var values = Enumerable.Empty<decimal>();
        //ACT
        var actual = IntervalEnumerationExtensions.ToLowerboundIntervalPairs(values, i => i, decimal.MaxValue).Count();
        //ASSERT
        Assert.AreEqual(0, actual);
    }

    [TestMethod]
    public void ToLowerboundIntervalPairs_OneItemEnumerable_CorrectInterval()
    {
        const decimal left = 1m;
        const decimal right = decimal.MaxValue;
        IEnumerable<decimal> values = new[] { left };
        //ACT
        var actual = IntervalEnumerationExtensions.ToLowerboundIntervalPairs(values, i => i, right).First().Key;
        //ASSERT
        Assert.AreEqual(new Interval<decimal>(left, right), actual);
    }

    [TestMethod]
    public void ToLowerboundIntervalPairs_OneItemEnumerable_CorrectValue()
    {
        const decimal left = 1m;
        const decimal right = decimal.MaxValue;
        IEnumerable<decimal> values = new[] { left };
        //ACT
        var actual = IntervalEnumerationExtensions.ToLowerboundIntervalPairs(values, i => i, right).First().Value;
        //ASSERT
        Assert.AreEqual(left, actual);
    }

    [TestMethod]
    public void ToLowerboundIntervalPairs_OneItemEnumerable_OneInterval()
    {
        const decimal left = 1m;
        const decimal right = decimal.MaxValue;
        IEnumerable<decimal> values = new[] { left };
        //ACT
        var actual = IntervalEnumerationExtensions.ToLowerboundIntervalPairs(values, i => i, right).Count();
        //ASSERT
        Assert.AreEqual(values.Count(), actual);
    }

    [TestMethod]
    public void ToLowerboundIntervalPairs_ThreeItemEnumerable_CorrectFirstInterval()
    {
        const decimal left = 1m;
        const decimal from2 = 22m;
        const decimal from3 = 333m;
        const decimal right = decimal.MaxValue;
        IEnumerable<decimal> values = new[] {
            left,
            from2,
            from3
        };
        //ACT
        var actual = IntervalEnumerationExtensions.ToLowerboundIntervalPairs(values, i => i, right).First().Key;
        //ASSERT
        Assert.AreEqual(new Interval<decimal>(left, from2), actual);
    }

    [TestMethod]
    public void ToLowerboundIntervalPairs_ThreeItemEnumerable_CorrectMiddleInterval()
    {
        const decimal left = 1m;
        const decimal from2 = 22m;
        const decimal from3 = 333m;
        const decimal right = decimal.MaxValue;
        IEnumerable<decimal> values = new[] {
            left,
            from2,
            from3
        };
        //ACT
        var actual = IntervalEnumerationExtensions.ToLowerboundIntervalPairs(values, i => i, right).ElementAt(1).Key;
        //ASSERT
        Assert.AreEqual(new Interval<decimal>(from2, from3), actual);
    }

    [TestMethod]
    public void ToLowerboundIntervalPairs_ThreeItemEnumerable_CorrectLastInterval()
    {
        const decimal left = 1m;
        const decimal from2 = 22m;
        const decimal from3 = 333m;
        const decimal right = decimal.MaxValue;
        IEnumerable<decimal> values = new[] {
            left,
            from2,
            from3
        };
        //ACT
        var actual = IntervalEnumerationExtensions.ToLowerboundIntervalPairs(values, i => i, right).Last().Key;
        //ASSERT
        Assert.AreEqual(new Interval<decimal>(from3, right), actual);
    }

    [TestMethod]
    public void ToLowerboundIntervalPairs_ThreeItemEnumerable_CorrectCount()
    {
        const decimal left = 1m;
        const decimal from2 = 22m;
        const decimal from3 = 333m;
        const decimal right = decimal.MaxValue;
        IEnumerable<decimal> values = new[] {
            left,
            from2,
            from3
        };
        //ACT
        var actual = IntervalEnumerationExtensions.ToLowerboundIntervalPairs(values, i => i, right).Count();
        //ASSERT
        Assert.AreEqual(values.Count(), actual);
    }
    #endregion
}