using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class DateTimeExtensionsTest
{
    private static readonly DateTime _someDateTime = new (2021, 6, 6, 6, 6, 6, 66, 666, DateTimeKind.Utc);
    private static readonly DateOnly _someDate = new (_someDateTime.Year, _someDateTime.Month, _someDateTime.Day);
    private static readonly TimeOnly _someTime = new (_someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _someDateTime.Millisecond, _someDateTime.Microsecond);
    private static readonly DateTimeOffset _someDateTimeOffset = new(_someDateTime, default);
    
    #region FirstOfMonth
    
    [TestMethod]
    public void FirstOfMonth_SomeDateTime_EqualsFloorToMonth()
    {
        //ACT
        var actual = DateTimeExtensions.FirstOfMonth(_someDateTime);
        //ASSERT
        Assert.AreEqual(_someDateTime.FloorToMonth(), actual);
    }

    #endregion
    #region FloorToDay

    [TestMethod]
    public void FloorToDay_SomeDateTime_SameDate()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToDay(_someDateTime);
        //ASSERT
        Assert.That.AreEqualDate(_someDateTime, actual);
    }

    [TestMethod]
    public void FloorToDay_SomeDateTime_TimeIsMidnight()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToDay(_someDateTime);
        //ASSERT
        Assert.That.IsMidnight(actual);
    }

    #endregion
    #region FloorToHour
    
    [TestMethod]
    public void FloorToHour_SomeDateTime_MinuteZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToHour(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Minute);
    }

    [TestMethod]
    public void FloorToHour_SomeDateTime_MicrosecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToHour(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Microsecond);
    }

    [TestMethod]
    public void FloorToHour_SomeDateTime_MillisecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToHour(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Millisecond);
    }

    [TestMethod]
    public void FloorToHour_SomeDateTime_SameDate()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToHour(_someDateTime);
        //ASSERT
        Assert.That.AreEqualDate(_someDateTime, actual);
    }
    
    [TestMethod]
    public void FloorToHour_SomeDateTime_SameHour()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToHour(_someDateTime);
        //ASSERT
        Assert.AreEqual(_someDateTime.Hour, actual.Hour);
    }
    
    [TestMethod]
    public void FloorToHour_SomeDateTime_SecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToHour(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Second);
    }

    #endregion
    #region FloorToMillisecond

    [TestMethod]
    public void FloorToMillisecond_SomeDateTime_MicrosecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMillisecond(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Microsecond);
    }
    
    [TestMethod]
    public void FloorToMillisecond_SomeDateTime_SameDate()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMillisecond(_someDateTime);
        //ASSERT
        Assert.That.AreEqualDate(_someDateTime, actual);
    }
    
    [TestMethod]
    public void FloorToMillisecond_SomeDateTime_SameTimeDownToMillisecond()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMillisecond(_someDateTime);
        //ASSERT
        Assert.That.AreEqualTime((_someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _someDateTime.Millisecond, 0), actual);
    }

    #endregion
    #region FloorToMinute

    [TestMethod]
    public void FloorToMinute_SomeDateTime_MicrosecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMinute(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Microsecond);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTime_MillisecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMinute(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Millisecond);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTime_SameDate()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMinute(_someDateTime);
        //ASSERT
        Assert.That.AreEqualDate(_someDateTime, actual);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTime_SameHour()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMinute(_someDateTime);
        //ASSERT
        Assert.AreEqual(_someDateTime.Hour, actual.Hour);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTime_SameMinute()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMinute(_someDateTime);
        //ASSERT
        Assert.AreEqual(_someDateTime.Minute, actual.Minute);
    }
    
    [TestMethod]
    public void FloorToMinute_SomeDateTime_SecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMinute(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Second);
    }

    #endregion
    #region FloorToMonth

    [TestMethod]
    public void FloorToMonth_SomeDateTime_SameMonth()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMonth(_someDateTime);
        //ASSERT
        Assert.AreEqual(_someDateTime.Month, actual.Month);
    }

    [TestMethod]
    public void FloorToMonth_SomeDateTime_SameYear()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMonth(_someDateTime);
        //ASSERT
        Assert.AreEqual(_someDateTime.Year, actual.Year);
    }
    
    [TestMethod]
    public void FloorToMonth_SomeDateTime_DayIsFirst()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMonth(_someDateTime);
        //ASSERT
        Assert.AreEqual(1, actual.Day);
    }

    [TestMethod]
    public void FloorToMonth_SomeDateTime_TimeIsMidnight()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToMonth(_someDateTime);
        //ASSERT
        Assert.That.IsMidnight(actual);
    }
    #endregion
    #region FloorToSecond

    [TestMethod]
    public void FloorToSecond_SomeDateTime_MicrosecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToSecond(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Microsecond);
    }

    [TestMethod]
    public void FloorToSecond_SomeDateTime_MillisecondZero()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToSecond(_someDateTime);
        //ASSERT
        Assert.AreEqual(0, actual.Millisecond);
    }

    [TestMethod]
    public void FloorToSecond_SomeDateTime_SameTimeDownToSecond()
    {
        //ACT
        var actual = DateTimeExtensions.FloorToSecond(_someDateTime);
        //ASSERT
        Assert.That.AreEqualTime((_someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, 0, 0), actual);
    }

    #endregion
    #region IsSameMonth - DateOnly

    [TestMethod]
    public void IsSameMonth_DateOnly__SameDates_True()
    {
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, _someDate);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__SameMonth_True()
    {
        var right = new DateOnly(_someDateTime.Year, _someDateTime.Month, _someDateTime.Day - 1);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__DifferentMonth_False()
    {
        var right = new DateOnly(_someDateTime.Year, _someDateTime.Month - 1, _someDateTime.Day);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__DifferentYear_False()
    {
        var right = new DateOnly(_someDateTime.Year - 1, _someDateTime.Month, _someDateTime.Day);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsFalse(actual);
    }

    #endregion
    #region IsSameMonth - DateTimeOffset

    [TestMethod]
    public void IsSameMonth_DateTimeOffset__SameDates_True()
    {
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, _someDateTimeOffset);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTimeOffset__SameMonth_True()
    {
        var right = new DateTimeOffset(_someDateTime.Year, _someDateTime.Month, _someDateTime.Day - 1, _someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _someDateTimeOffset.Offset);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTimeOffset__DifferentMonth_False()
    {
        var right = new DateTimeOffset(_someDateTime.Year, _someDateTime.Month - 1, _someDateTime.Day, _someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _someDateTimeOffset.Offset);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTimeOffset__DifferentYear_False()
    {
        var right = new DateTimeOffset(_someDateTime.Year - 1, _someDateTime.Month, _someDateTime.Day, _someDateTime.Hour, _someDateTime.Minute, _someDateTime.Second, _someDateTimeOffset.Offset);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsFalse(actual);
    }    

    #endregion
    #region IsSameMonth

    [TestMethod]
    public void IsSameMonth_SameDates_True()
    {
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, _someDateTime);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_SameMonth_True()
    {
        var right = new DateTime(_someDateTime.Year, _someDateTime.Month, _someDateTime.Day - 1);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DifferentMonth_False()
    {
        var right = new DateTime(_someDateTime.Year, _someDateTime.Month - 1, _someDateTime.Day);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DifferentYear_False()
    {
        var right = new DateTime(_someDateTime.Year - 1, _someDateTime.Month, _someDateTime.Day);
        //ACT
        var actual = DateTimeExtensions.IsSameMonth(_someDateTime, right);
        //ASSERT
        Assert.IsFalse(actual);
    }

    #endregion
    #region ToDateOnly Nullable

    [TestMethod]
    public void ToDateOnly_Nullable__Null_Null()
    {
        var someDateTime = default(DateTime?);
        //ACT
        var actual = DateTimeExtensions.ToDateOnly(someDateTime);
        //ASSERT
        Assert.IsNull(actual);
    }

    [TestMethod]
    public void ToDateOnly_Nullable__SomeDateTime_DatePart()
    {
        var someDateTime = (DateTime?)_someDateTime;
        //ACT
        var actual = DateTimeExtensions.ToDateOnly(someDateTime);
        //ASSERT
        Assert.AreEqual(_someDate, actual);
    }

    #endregion
    #region ToDateOnly

    [TestMethod]
    public void ToDateOnly_SomeDateTime_DatePart()
    {
        //ACT
        var actual = DateTimeExtensions.ToDateOnly(_someDateTime);
        //ASSERT
        Assert.AreEqual(_someDate, actual);
    }

    #endregion
    #region ToTimeOnly Nullable

    [TestMethod]
    public void ToTimeOnly_Nullable__Null_Null()
    {
        var someDateTime = default(DateTime?);
        //ACT
        var actual = DateTimeExtensions.ToTimeOnly(someDateTime);
        //ASSERT
        Assert.IsNull(actual);
    }
    
    [TestMethod]
    public void ToTimeOnly_Nullable__SomeDateTime_TimePart()
    {
        var someDateTime = (DateTime?)_someDateTime;
        //ACT
        var actual = DateTimeExtensions.ToTimeOnly(someDateTime);
        //ASSERT
        Assert.AreEqual(_someTime, actual);
    }

    #endregion
    #region ToTimeOnly

    [TestMethod]
    public void ToTimeOnly_SomeDateTime_TimePart()
    {
        //ACT
        var actual = DateTimeExtensions.ToTimeOnly(_someDateTime);
        //ASSERT
        Assert.AreEqual(_someTime, actual);
    }

    #endregion

}
