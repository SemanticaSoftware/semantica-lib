using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Checks.Exceptions;
using Semantica.Lib.Tests.Core.Test._SomeData;
using Semantica.Lib.Tests.Core.Test._SomeData.Types;
using Semantica.Types;

namespace Semantica.Lib.Tests.Core.Test.Types;

[TestClass]
public class DateSpanTest
{
    #region Abs

    [TestMethod]
    public void Abs_Positive_NotChanged()
    {
        var value = SomeDateSpan.Create();
        //ACT
        var actual = value.Abs();
        //ASSERT
        Assert.AreEqual(value, actual);
    }

    [TestMethod]
    public void Abs_Negative_InvertsValue()
    {
        //ACT
        var actual = SomeDateSpan.CreateNegative().Abs();
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Create(), actual);
    }
    
    #endregion
    #region FromMonths

    [TestMethod]
    public void FromMonths_LowMonths_CorrectMonths()
    {
        //ACT
        var actual = DateSpan.FromMonths(SomeDateSpan.Months).Months;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Months, actual);
    }

    [TestMethod]
    public void FromMonths_LowMonths_CorrectTotalMonths()
    {
        //ACT
        var actual = DateSpan.FromMonths(SomeDateSpan.Months).TotalMonths;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Months, actual);
    }

    [TestMethod]
    public void FromMonths_LowMonths_NotNegative()
    {
        //ACT
        var actual = DateSpan.FromMonths(SomeDateSpan.Months);
        //ASSERT
        Assert.That.IsFalse(actual.IsNegative);
    }

    [TestMethod]
    public void FromMonths_LowMonths_ZeroDays()
    {
        //ACT
        var actual = DateSpan.FromMonths(SomeDateSpan.Months).Days;
        //ASSERT
        Assert.AreEqual(0, actual);
    }

    [TestMethod]
    public void FromMonths_LowMonths_ZeroYears()
    {
        //ACT
        var actual = DateSpan.FromMonths(SomeDateSpan.Months).Years;
        //ASSERT
        Assert.AreEqual(0, actual);
    }

    [TestMethod]
    public void FromMonths_MonthsYears_CorrectMonths()
    {
        //ACT
        var actual = DateSpan.FromMonths(SomeDateSpan.TotalMonths).Months;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Months, actual);
    }

    [TestMethod]
    public void FromMonths_MonthsYears_CorrectTotalMonths()
    {
        //ACT
        var actual = DateSpan.FromMonths(SomeDateSpan.TotalMonths).TotalMonths;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.TotalMonths, actual);
    }

    [TestMethod]
    public void FromMonths_MonthsYears_CorrectYears()
    {
        //ACT
        var actual = DateSpan.FromMonths(SomeDateSpan.TotalMonths).Years;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Years, actual);
    }
    
    [TestMethod]
    public void FromMonths_NegativeMonths_IsNegative()
    {
        //ACT
        var actual = DateSpan.FromMonths(-SomeDateSpan.Months);
        //ASSERT
        Assert.That.IsTrue(actual.IsNegative);
    }
    
    [TestMethod]
    public void FromMonths_NegativeMonths_NegativeMonths()
    {
        //ACT
        var actual = DateSpan.FromMonths(-SomeDateSpan.Months).Months;
        //ASSERT
        Assert.That.IsTrue(actual < 0);
    }
    
    #endregion
    #region FromParts

    [TestMethod]
    public void FromParts_HighMonths_CorrectMonths()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.TotalMonths).Months;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Months, actual);
    }

    [TestMethod]
    public void FromParts_HighMonths_CorrectTotalMonths()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.TotalMonths).TotalMonths;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.TotalMonths, actual);
    }

    [TestMethod]
    public void FromParts_HighMonths_CorrectYears()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.TotalMonths).Years;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Years, actual);
    }

    [TestMethod]
    public void FromParts_HighMonths_NotIsNegative()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.TotalMonths);
        //ASSERT
        Assert.That.IsFalse(actual.IsNegative);
    }

    [TestMethod]
    public void FromParts_LowMonths_CorrectDays()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.Months).Days;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Days, actual);
    }

    [TestMethod]
    public void FromParts_LowMonths_CorrectMonths()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.Months).Months;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Months, actual);
    }

    [TestMethod]
    public void FromParts_LowMonths_ZeroYears()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.Months).Years;
        //ASSERT
        Assert.AreEqual(0, actual);
    }

    [TestMethod]
    public void FromParts_MonthsYears_CorrectMonths()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.Months, SomeDateSpan.Years).Months;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Months, actual);
    }

    [TestMethod]
    public void FromParts_MonthsYears_CorrectYears()
    {
        //ACT
        var actual = DateSpan.FromParts(SomeDateSpan.Days, SomeDateSpan.Months, SomeDateSpan.Years).Years;
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Years, actual);
    }
    
    [TestMethod]
    public void FromParts_Negative_DaysNegative()
    {
        //ACT
        var actual = DateSpan.FromParts(-SomeDateSpan.Days, -SomeDateSpan.TotalMonths).Days;
        //ASSERT
        Assert.That.IsTrue(actual < 0);
    }

    [TestMethod]
    public void FromParts_Negative_MonthsNegative()
    {
        //ACT
        var actual = DateSpan.FromParts(-SomeDateSpan.Days, -SomeDateSpan.TotalMonths).Months;
        //ASSERT
        Assert.That.IsTrue(actual < 0);
    }

    [TestMethod]
    public void FromParts_Negative_IsNegative()
    {
        //ACT
        var actual = DateSpan.FromParts(-SomeDateSpan.Days, -SomeDateSpan.TotalMonths);
        //ASSERT
        Assert.That.IsTrue(actual.IsNegative);
    }

    [TestMethod]
    public void FromParts_Negative_YearsNegative()
    {
        //ACT
        var actual = DateSpan.FromParts(-SomeDateSpan.Days, -SomeDateSpan.TotalMonths).Years;
        //ASSERT
        Assert.That.IsTrue(actual < 0);
    }

    [TestMethod]
    public void FromParts_NegativeMonthsPositiveDays_Throws()
    {
        //ACT & ASSERT
        Assert.ThrowsException<GuardArgumentException>(() => DateSpan.FromParts(SomeDateSpan.Days, -SomeDateSpan.TotalMonths));
    }

    [TestMethod]
    public void FromParts_NegativeDaysPositiveMonths_Throws()
    {
        //ACT & ASSERT
        Assert.ThrowsException<GuardArgumentException>(() => DateSpan.FromParts(-SomeDateSpan.Days, SomeDateSpan.TotalMonths));
    }

    [TestMethod]
    public void FromParts_NegativeMonthsZeroDays_NoException()
    {
        //ACT
        var actual = DateSpan.FromParts(0, -SomeDateSpan.TotalMonths).Days;
    }

    #endregion
    #region operator-
    

    [TestMethod]
    public void OperatorMinusUnary_SomeNegativeSpan_SpanIsInverted()
    {
        //ACT
        var actual = -SomeDateSpan.CreateNegative();
        //ASSERT
        Assert.AreEqual(SomeDateSpan.Create(), actual);
    }

    [TestMethod]
    public void OperatorMinusUnary_SomeSpan_SpanIsNegative()
    {
        //ACT
        var actual = -SomeDateSpan.Create();
        //ASSERT
        Assert.That.IsTrue(actual.IsNegative);
    }

    [TestMethod]
    public void OperatorMinus_SomeValue_SpanIsAdded()
    {
        //ACT
        var actual = SomeDateOnly.Create() - SomeDateSpan.Create();
        //ASSERT
        Assert.AreEqual(SomeDateOnly.CreateSpanSubtracted(), actual);
    }

    [TestMethod]
    public void OperatorMinus_SomeValueWithTime_SpanIsAdded()
    {
        //ACT
        var actual = SomeDateTime.Create() - SomeDateSpan.Create();
        //ASSERT
        Assert.AreEqual(SomeDateTime.CreateSpanSubtracted(), actual);
    }

    [TestMethod]
    public void OperatorMinus_Zero_SameDateOnly()
    {
        var date = SomeDateOnly.Create();
        //ACT
        var actual = date - DateSpan.MinValue;
        //ASSERT
        Assert.AreEqual(date, actual);
    }

    [TestMethod]
    public void OperatorMinus_Zero_SameDateTime()
    {
        var date = SomeDateTime.Create();
        //ACT
        var actual = date - DateSpan.MinValue;
        //ASSERT
        Assert.AreEqual(date, actual);
    }

    #endregion
    #region operator+

    [TestMethod]
    public void OperatorPlus_SomeValue_SpanIsAdded()
    {
        //ACT
        var actual = SomeDateOnly.CreateSpanSubtracted() + SomeDateSpan.Create();
        //ASSERT
        Assert.AreEqual(SomeDateOnly.Create(), actual);
    }

    [TestMethod]
    public void OperatorPlus_SomeValueWithTime_SpanIsAdded()
    {
        //ACT
        var actual = SomeDateTime.CreateSpanSubtracted() + SomeDateSpan.Create();
        //ASSERT
        Assert.AreEqual(SomeDateTime.Create(), actual);
    }

    [TestMethod]
    public void OperatorPlus_Zero_SameDateOnly()
    {
        var date = SomeDateOnly.Create();
        //ACT
        var actual = date + DateSpan.MinValue;
        //ASSERT
        Assert.AreEqual(date, actual);
    }

    [TestMethod]
    public void OperatorPlus_Zero_SameDateTime()
    {
        var date = SomeDateTime.Create();
        //ACT
        var actual = date + DateSpan.MinValue;
        //ASSERT
        Assert.AreEqual(date, actual);
    }

    #endregion
}
