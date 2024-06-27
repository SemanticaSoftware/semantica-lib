using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class DateTimeOffsetExtensionsTest
{
    private static readonly TimeSpan _offset = TimeSpan.FromHours(-10);
    private static readonly DateTime _someDateTime = new (2021, 6, 6, 6, 6, 6, 66, 666, DateTimeKind.Unspecified);
    private static readonly DateTimeOffset _someDateTimeOffset = new (_someDateTime, _offset);
    private static readonly DateOnly _someDate = new (_someDateTime.Year, _someDateTime.Month, _someDateTime.Day);
    private static readonly TimeOnly _someTime = new (_someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _someDateTime.Millisecond, _someDateTime.Microsecond);

    #region FirstOfMonth
    
    [TestMethod]
    public void FirstOfMonth_SomeDateTimeOffset_EqualsFloorToMonth()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FirstOfMonth(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(_someDateTimeOffset.FloorToMonth(), actual);
    }

    #endregion
    #region FloorToDay

    [TestMethod]
    public void FloorToDay_SomeDateTimeOffset_SameDate()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToDay(_someDateTimeOffset);
        //ASSERT
        Assert.That.AreEqualDate(_someDateTime, actual.DateTime);
    }

    [TestMethod]
    public void FloorToDay_SomeDateTimeOffset_TimeIsMidnight()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToDay(_someDateTimeOffset);
        //ASSERT
        Assert.That.IsMidnight(actual.DateTime);
    }

    #endregion
    #region FloorToHour

    [TestMethod]
    public void FloorToHour_SomeDateTimeOffset_MinuteZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToHour(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Minute);
    }

    [TestMethod]
    public void FloorToHour_SomeDateTimeOffset_MicrosecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToHour(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Microsecond);
    }

    [TestMethod]
    public void FloorToHour_SomeDateTimeOffset_MillisecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToHour(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Millisecond);
    }

    [TestMethod]
    public void FloorToHour_SomeDateTimeOffset_SameDate()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToHour(_someDateTimeOffset);
        //ASSERT
        Assert.That.AreEqualDate(_someDateTime, actual.DateTime);
    }
    
    [TestMethod]
    public void FloorToHour_SomeDateTimeOffset_SameHour()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToHour(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(_someDateTime.Hour, actual.Hour);
    }
    
    [TestMethod]
    public void FloorToHour_SomeDateTimeOffset_SecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToHour(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Second);
    }

    #endregion
    #region FloorToMillisecond

    [TestMethod]
    public void FloorToMillisecond_SomeDateTimeOffset_MicrosecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMillisecond(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Microsecond);
    }
    
    [TestMethod]
    public void FloorToMillisecond_SomeDateTimeOffset_SameDate()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMillisecond(_someDateTimeOffset);
        //ASSERT
        Assert.That.AreEqualDate(_someDateTime, actual.DateTime);
    }
    
    [TestMethod]
    public void FloorToMillisecond_SomeDateTimeOffset_SameTimeDownToMillisecond()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMillisecond(_someDateTimeOffset);
        //ASSERT
        Assert.That.AreEqualTime((_someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _someDateTime.Millisecond, 0), actual.DateTime);
    }

    #endregion
    #region FloorToMinute

    [TestMethod]
    public void FloorToMinute_SomeDateTimeOffset_MicrosecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMinute(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Microsecond);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTimeOffset_MillisecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMinute(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Millisecond);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTimeOffset_SameDate()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMinute(_someDateTimeOffset);
        //ASSERT
        Assert.That.AreEqualDate(_someDateTime, actual.DateTime);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTimeOffset_SameHour()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMinute(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(_someDateTime.Hour, actual.Hour);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTimeOffset_SameMinute()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMinute(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(_someDateTime.Minute, actual.Minute);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTimeOffset_SecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMinute(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Second);
    }

    #endregion
    #region FloorToMonth

    [TestMethod]
    public void FloorToMonth_SomeDateTimeOffset_SameMonth()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMonth(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(_someDateTime.Month, actual.Month);
    }

    [TestMethod]
    public void FloorToMonth_SomeDateTimeOffset_SameYear()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMonth(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(_someDateTime.Year, actual.Year);
    }
    
    [TestMethod]
    public void FloorToMonth_SomeDateTimeOffset_DayIsFirst()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMonth(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(1, actual.Day);
    }

    [TestMethod]
    public void FloorToMonth_SomeDateTimeOffset_TimeIsMidnight()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToMonth(_someDateTimeOffset);
        //ASSERT
        Assert.That.IsMidnight(actual.DateTime);
    }
    #endregion
    #region FloorToSecond

    [TestMethod]
    public void FloorToSecond_SomeDateTimeOffset_MicrosecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToSecond(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Microsecond);
    }

    [TestMethod]
    public void FloorToSecond_SomeDateTimeOffset_MillisecondZero()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToSecond(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(0, actual.Millisecond);
    }

    [TestMethod]
    public void FloorToSecond_SomeDateTimeOffset_SameTimeDownToSecond()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.FloorToSecond(_someDateTimeOffset);
        //ASSERT
        Assert.That.AreEqualTime((_someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, 0, 0), actual.DateTime);
    }

    #endregion
    #region IsSameMonth - DateOnly

    [TestMethod]
    public void IsSameMonth_DateOnly__SameDates_True()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, _someDate);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__SameMonth_True()
    {
        var right = new DateOnly(_someDateTime.Year, _someDateTime.Month, _someDateTime.Day - 1);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__DifferentMonth_False()
    {
        var right = new DateOnly(_someDateTime.Year, _someDateTime.Month - 1, _someDateTime.Day);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__DifferentYear_False()
    {
        var right = new DateOnly(_someDateTime.Year - 1, _someDateTime.Month, _someDateTime.Day);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsFalse(actual);
    }

    #endregion
    #region IsSameMonth

    [TestMethod]
    public void IsSameMonth_SameDates_True()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, _someDateTimeOffset);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_SameMonth_True()
    {
        var right = new DateTimeOffset(_someDateTime.Year, _someDateTime.Month, _someDateTime.Day - 1, _someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _offset);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DifferentMonth_False()
    {
        var right = new DateTimeOffset(_someDateTime.Year, _someDateTime.Month - 1, _someDateTime.Day, _someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _offset);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DifferentYear_False()
    {
        var right = new DateTimeOffset(_someDateTime.Year - 1, _someDateTime.Month, _someDateTime.Day, _someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _offset);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsFalse(actual);
    }    

    #endregion
    #region IsSameMonth DateTime

    [TestMethod]
    public void IsSameMonth_DateTime__SameDates_True()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, _someDateTime);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTime__SameMonth_DateTime__True()
    {
        var right = new DateTime(_someDateTime.Year, _someDateTime.Month, _someDateTime.Day - 1);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTime__DifferentMonth_DateTime__False()
    {
        var right = new DateTime(_someDateTime.Year, _someDateTime.Month - 1, _someDateTime.Day);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTime__DifferentYear_False()
    {
        var right = new DateTime(_someDateTime.Year - 1, _someDateTime.Month, _someDateTime.Day);
        //ACT
        var actual = DateTimeOffsetExtensions.IsSameMonth(_someDateTimeOffset, right);
        //ASSERT
        Assert.IsFalse(actual);
    }

    #endregion
    #region ToDateOnly Nullable

    [TestMethod]
    public void ToDateOnly_Nullable__Null_Null()
    {
        var someDateTime = default(DateTimeOffset?);
        //ACT
        var actual = DateTimeOffsetExtensions.ToDateOnly(someDateTime);
        //ASSERT
        Assert.IsNull(actual);
    }

    [TestMethod]
    public void ToDateOnly_Nullable__SomeDateTimeOffset_DatePart()
    {
        var someDateTime = (DateTimeOffset?)_someDateTimeOffset;
        //ACT
        var actual = DateTimeOffsetExtensions.ToDateOnly(someDateTime);
        //ASSERT
        Assert.AreEqual(_someDate, actual);
    }

    #endregion
    #region ToDateOnly

    [TestMethod]
    public void ToDateOnly_SomeDateTimeOffset_DatePart()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.ToDateOnly(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(_someDate, actual);
    }

    #endregion
    #region ToTimeOnly Nullable

    [TestMethod]
    public void ToTimeOnly_Nullable__Null_Null()
    {
        var someDateTime = default(DateTimeOffset?);
        //ACT
        var actual = DateTimeOffsetExtensions.ToTimeOnly(someDateTime);
        //ASSERT
        Assert.IsNull(actual);
    }
    
    [TestMethod]
    public void ToTimeOnly_Nullable__SomeDateTimeOffset_TimePart()
    {
        var someDateTime = (DateTimeOffset?)_someDateTimeOffset;
        //ACT
        var actual = DateTimeOffsetExtensions.ToTimeOnly(someDateTime);
        //ASSERT
        Assert.AreEqual(_someTime, actual);
    }

    #endregion
    #region ToTimeOnly

    [TestMethod]
    public void ToTimeOnly_SomeDateTimeOffset_TimePart()
    {
        //ACT
        var actual = DateTimeOffsetExtensions.ToTimeOnly(_someDateTimeOffset);
        //ASSERT
        Assert.AreEqual(_someTime, actual);
    }

    #endregion
}
