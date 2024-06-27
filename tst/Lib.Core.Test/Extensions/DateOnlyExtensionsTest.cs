using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class DateOnlyExtensionsTest
{
    private static readonly DateOnly _someDateOnly = new (2021, 6, 6);
    private static readonly DateTime _someDateTime = new (_someDateOnly.Year, _someDateOnly.Month, _someDateOnly.Day);
    private static readonly DateTimeOffset _someDateTimeOffset = new(_someDateOnly.ToDateTime(), default);
    
    #region FirstOfMonth
    
    [TestMethod]
    public void FirstOfMonth_SomeDate_EqualsFloorToMonth()
    {
        //ACT
        var actual = DateOnlyExtensions.FirstOfMonth(_someDateOnly);
        //ASSERT
        Assert.AreEqual(_someDateOnly.FloorToMonth(), actual);
    }

    #endregion
    #region FloorToMonth

    [TestMethod]
    public void FloorToMonth_SomeDate_SameMonth()
    {
        //ACT
        var actual = DateOnlyExtensions.FloorToMonth(_someDateOnly);
        //ASSERT
        Assert.AreEqual(_someDateOnly.Month, actual.Month);
    }

    [TestMethod]
    public void FloorToMonth_SomeDate_SameYear()
    {
        //ACT
        var actual = DateOnlyExtensions.FloorToMonth(_someDateOnly);
        //ASSERT
        Assert.AreEqual(_someDateOnly.Year, actual.Year);
    }
    
    [TestMethod]
    public void FloorToMonth_SomeDate_DayIsFirst()
    {
        //ACT
        var actual = DateOnlyExtensions.FloorToMonth(_someDateOnly);
        //ASSERT
        Assert.AreEqual(1, actual.Day);
    }

    #endregion
    #region IsSameMonth

    [TestMethod]
    public void IsSameMonth_DateOnly__SameDates_True()
    {
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, _someDateTime);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__SameMonth_True()
    {
        var right = new DateOnly(_someDateOnly.Year, _someDateOnly.Month, _someDateOnly.Day - 1);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__DifferentMonth_False()
    {
        var right = new DateOnly(_someDateOnly.Year, _someDateOnly.Month - 1, _someDateOnly.Day);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateOnly__DifferentYear_False()
    {
        var right = new DateOnly(_someDateOnly.Year - 1, _someDateOnly.Month, _someDateOnly.Day);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsFalse(actual);
    }

    #endregion
    #region IsSameMonth - DateTimeOffset

    [TestMethod]
    public void IsSameMonth_DateTimeOffset__SameDates_True()
    {
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, _someDateTimeOffset);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTimeOffset__SameMonth_True()
    {
        var right = new DateTimeOffset(_someDateOnly.Year, _someDateOnly.Month, _someDateOnly.Day - 1, 0, 0, 0, _someDateTimeOffset.Offset);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTimeOffset__DifferentMonth_False()
    {
        var right = new DateTimeOffset(_someDateOnly.Year, _someDateOnly.Month - 1, _someDateOnly.Day, 0, 0, 0, _someDateTimeOffset.Offset);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTimeOffset__DifferentYear_False()
    {
        var right = new DateTimeOffset(_someDateOnly.Year - 1, _someDateOnly.Month, _someDateOnly.Day, 0, 0, 0, _someDateTimeOffset.Offset);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsFalse(actual);
    }    

    #endregion
    #region IsSameMonth DateTime

    [TestMethod]
    public void IsSameMonth_DateTime__SameDates_True()
    {
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, _someDateTime);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTime__SameMonth_DateTime__True()
    {
        var right = new DateTime(_someDateOnly.Year, _someDateOnly.Month, _someDateOnly.Day - 1);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTime__DifferentMonth_DateTime__False()
    {
        var right = new DateTime(_someDateOnly.Year, _someDateOnly.Month - 1, _someDateOnly.Day);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    [TestMethod]
    public void IsSameMonth_DateTime__DifferentYear_False()
    {
        var right = new DateTime(_someDateOnly.Year - 1, _someDateOnly.Month, _someDateOnly.Day);
        //ACT
        var actual = DateOnlyExtensions.IsSameMonth(_someDateOnly, right);
        //ASSERT
        Assert.IsFalse(actual);
    }

    #endregion
    #region ToDateTime Nullable

    [TestMethod]
    public void ToDateTime_Nullable__Null_Null()
    {
        var someDateTime = default(DateOnly?);
        //ACT
        var actual = DateOnlyExtensions.ToDateTime(someDateTime);
        //ASSERT
        Assert.IsNull(actual);
    }

    [TestMethod]
    public void ToDateTime_Nullable__SomeDate_DatePart()
    {
        var someDateTime = (DateOnly?)_someDateOnly;
        //ACT
        var actual = DateOnlyExtensions.ToDateTime(someDateTime);
        //ASSERT
        Assert.AreEqual(_someDateTime, actual);
    }

    #endregion
    #region ToDateOnly

    [TestMethod]
    public void ToDateTime_SomeDate_DatePart()
    {
        //ACT
        var actual = DateOnlyExtensions.ToDateTime(_someDateOnly);
        //ASSERT
        Assert.AreEqual(_someDateTime, actual);
    }

    #endregion

}
