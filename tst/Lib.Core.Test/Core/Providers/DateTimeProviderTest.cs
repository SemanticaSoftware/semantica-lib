using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Core.Providers;
using Semantica.Lib.Tests.Core.Test._Mocks;
using Semantica.TestTools.Core.Mocks;

namespace Semantica.Lib.Tests.Core.Test.Core.Providers;

[TestClass]
public class DateTimeProviderTest
{
    //SUT
    private DateTimeProvider _sut = null!;
    //data 
    private DateTime _localDateTime;
    private static readonly DateTime _utcDateTime = new DateTime(2021, 1, 1, 1, 1, 1, DateTimeKind.Utc);
    private TimeSpan _localOffset;

    #region Arrange

    [TestInitialize]
    public void Init()
    {
        _sut = new TestDateTimeProvider(_utcDateTime);
        _localOffset = _sut.TimeZoneInfo().GetUtcOffset(_utcDateTime);
        _localDateTime = DateTime.SpecifyKind(_utcDateTime + _localOffset, DateTimeKind.Local);
    }

    private void ArrangeWithOffset(int hours, int minutes = 0)
    {
        _localOffset = new TimeSpan(hours, minutes, 0);
        _sut = new TestDateTimeProvider(_utcDateTime, _localOffset);
        _localDateTime = DateTime.SpecifyKind(_utcDateTime + _localOffset, DateTimeKind.Unspecified);
    }
    
    [TestMethod]
    public void ArrangeWithOffset_ChangesLocalTime()
    {
        var oldLocal = _localDateTime;
        //ACT
        ArrangeWithOffset(-9, -15);
        //ASSERT
        Assert.AreNotEqual(oldLocal, _localDateTime);
    }

    [TestMethod]
    public void ArrangeWithOffset_OffsetGreaterThatTime_LocalDateChanges()
    {
        //ACT
        ArrangeWithOffset(-9, -15);
        //ASSERT
        Assert.That.AreNotEqualDate(_utcDateTime, _localDateTime);
    }

    #endregion
    #region ConvertLocalToOffset

    [TestMethod]
    public void ConvertLocalToOffset_SomeLocalTime_UtcTime()
    {
        //ACT
        var actual = _sut.ConvertLocalToOffset(_localDateTime);
        //ASSERT
        Assert.AreEqual(_utcDateTime, actual.UtcDateTime);
    }

    [TestMethod]
    public void ConvertLocalToOffset_UtcTime_Throws()
    {
        //ACT
        var act = () => { _sut.ConvertLocalToOffset(_utcDateTime); };
        //ASSERT
        Assert.ThrowsException<ArgumentException>(act);
    }

    #endregion
    #region ConvertUtcToOffset

    [TestMethod]
    public void ConvertUtcToOffset_NonUtcTime_Throws()
    {
        //ACT
        var act = () => { _sut.ConvertUtcToOffset(_localDateTime); };
        //ASSERT
        Assert.ThrowsException<ArgumentException>(act);
    }
    
    [TestMethod]
    public void ConvertUtcToOffset_SomeUtcTime_KindNotUtc()
    {
        //ACT
        var actual = _sut.ConvertUtcToOffset(_utcDateTime);
        //ASSERT
        Assert.AreNotEqual(DateTimeKind.Utc, actual.DateTime.Kind);
    }

    [TestMethod]
    public void ConvertUtcToOffset_SomeUtcTime_LocalTime()
    {
        //ACT
        var actual = _sut.ConvertUtcToOffset(_utcDateTime);
        //ASSERT
        Assert.AreEqual(_localDateTime, actual.DateTime);
    }

    [TestMethod]
    public void ConvertUtcToOffset_SomeUtcTime_Offset()
    {
        //ACT
        var actual = _sut.ConvertUtcToOffset(_utcDateTime);
        //ASSERT
        Assert.AreEqual(_localOffset, actual.Offset);
    }
    
    #endregion
    #region MidnightToday

    [TestMethod]
    public void MidnightToday_DatePartToday()
    {
        //ACT
        var actual = _sut.MidnightToday();
        //ASSERT
        Assert.That.AreEqualDate(_localDateTime, actual);
    }

    [TestMethod]
    public void MidnightToday_Midnight()
    {
        //ACT
        var actual = _sut.MidnightToday();
        //ASSERT
        Assert.That.IsMidnight(actual);
    }

    #endregion
    #region MidnightTodayOffset

    [TestMethod]
    public void MidnightTodayOffset_DatePartToday()
    {
        //ACT
        var actual = _sut.MidnightTodayOffset();
        //ASSERT
        Assert.That.AreEqualDate(_localDateTime, actual.DateTime);
    }

    [TestMethod]
    public void MidnightTodayOffset_Midnight()
    {
        //ACT
        var actual = _sut.MidnightTodayOffset();
        //ASSERT
        Assert.That.IsMidnight(actual.DateTime);
    }

    [TestMethod]
    public void MidnightTodayOffset_Offset()
    {
        //ACT
        var actual = _sut.MidnightTodayOffset();
        //ASSERT
        Assert.AreEqual(_localOffset, actual.Offset);
    }

    #endregion
    #region Now

    [TestMethod]
    public void Now_KindNotUtc()
    {
        //ACT
        var actual = _sut.Now();
        //ASSERT
        Assert.AreNotEqual(DateTimeKind.Utc, actual.Kind);
    }

    [TestMethod]
    public void Now_LocalTime()
    {
        //ACT
        var actual = _sut.Now();
        //ASSERT
        Assert.AreEqual(_localDateTime, actual);
    }

    #endregion
    #region NowOffset

    [TestMethod]
    public void NowOffset_KindNotUtc()
    {
        //ACT
        var actual = _sut.NowOffset();
        //ASSERT
        Assert.AreNotEqual(DateTimeKind.Utc, actual.DateTime.Kind);
    }

    [TestMethod]
    public void NowOffset_LocalTime()
    {
        //ACT
        var actual = _sut.NowOffset();
        //ASSERT
        Assert.AreEqual(_localDateTime, actual.DateTime);
    }

    [TestMethod]
    public void NowOffset_Offset()
    {
        //ACT
        var actual = _sut.NowOffset();
        //ASSERT
        Assert.AreEqual(_localOffset, actual.Offset);
    }

    #endregion
    #region Offset

    [TestMethod]
    public void Offset_OffsetCorrect()
    {
        //ACT
        var actual = _sut.Offset(_localDateTime);
        //ASSERT
        Assert.AreEqual(_localOffset, actual);
    }

    #endregion
    #region OffsetKind

    [TestMethod]
    public void OffsetKind_Local()
    {
        var sut = new DateTimeProvider();
        //ACT
        var actual = sut.OffsetKind();
        //ASSERT
        Assert.AreEqual(DateTimeKind.Local, actual);
    }

    #endregion
    #region Time

    [TestMethod]
    public void Time_LocalTime()
    {
        //ACT
        var actual = _sut.Time();
        //ASSERT
        Assert.AreEqual(_localDateTime.ToTimeOnly(), actual);
    }

    #endregion
    #region TimeZoneInfo

    [TestMethod]
    public void TimeZoneInfo_CompToSystemLocal_SameBaseUtcOffset()
    {
        var sut = new DateTimeProvider();
        //ACT
        var actual = sut.TimeZoneInfo();
        //ASSERT
        Assert.AreEqual(TimeZoneInfo.Local.BaseUtcOffset, actual.BaseUtcOffset);
    }

    #endregion
    #region Today

    [TestMethod]
    public void Today_DatePartCorrect()
    {
        //ACT
        var actual = _sut.Today();
        //ASSERT
        Assert.That.AreEqualDate(_localDateTime, actual);
    }
    
    [TestMethod]
    public void Today_OffsetToOtherDate_DatePartCorrect()
    {
        ArrangeWithOffset(-6);
        //ACT
        var actual = _sut.Today();
        //ASSERT
        Assert.That.AreEqualDate(_localDateTime, actual);
    }
    

    #endregion
    #region UtcMidnightToday

    [TestMethod]
    public void UtcMidnightToday_DatePartToday()
    {
        //ACT
        var actual = _sut.UtcMidnightToday();
        //ASSERT
        Assert.That.AreEqualDate(_utcDateTime, actual);
    }
    
    [TestMethod]
    public void UtcMidnightToday_KindUtc()
    {
        //ACT
        var actual = _sut.UtcMidnightToday();
        //ASSERT
        Assert.AreEqual(DateTimeKind.Utc, actual.Kind);
    }
    
    [TestMethod]
    public void UtcMidnightToday_Midnight()
    {
        //ACT
        var actual = _sut.UtcMidnightToday();
        //ASSERT
        Assert.That.IsMidnight(actual);
    }

    #endregion
    #region UtcMidnightTodayOffset

    [TestMethod]
    public void UtcMidnightTodayOffset_DatePartToday()
    {
        //ACT
        var actual = _sut.UtcMidnightTodayOffset();
        //ASSERT
        Assert.That.AreEqualDate(_utcDateTime, actual.DateTime);
    }
    
    [TestMethod]
    public void UtcMidnightTodayOffset_Midnight()
    {
        //ACT
        var actual = _sut.UtcMidnightTodayOffset();
        //ASSERT
        Assert.That.IsMidnight(actual.DateTime);
    }
    
    [TestMethod]
    public void UtcMidnightTodayOffset_UtcOffset()
    {
        //ACT
        var actual = _sut.UtcMidnightTodayOffset();
        //ASSERT
        Assert.That.IsDefault(actual.Offset);
    }

    #endregion
    #region UtcNow

    [TestMethod]
    public void UtcNow_KindUtc()
    {
        var sut = new DateTimeProvider();
        //ACT
        var actual = sut.UtcNow();
        //ASSERT
        Assert.AreEqual(DateTimeKind.Utc, actual.Kind);
    }

    [TestMethod]
    public void UtcNow_UtcTime()
    {
        var sut = new DateTimeProvider();
        //ACT
        var actual = sut.UtcNow();
        var staticNow = DateTime.UtcNow;
        //ASSERT
        Assert.IsTrue((staticNow - actual).TotalMilliseconds < 1,
            $"Time returned by provider ({actual}) is more than 1ms off from static call ({staticNow})");
    }

    #endregion
    #region UtcNowOffset

    [TestMethod]
    public void UtcNowOffset_UtcOffset()
    {
        //ACT
        var actual = _sut.UtcNowOffset();
        //ASSERT
        Assert.That.IsDefault(actual.Offset);
    }
    
    [TestMethod]
    public void UtcNowOffset_UtcTime()
    {
        //ACT
        var actual = _sut.UtcNowOffset();
        //ASSERT
        Assert.AreEqual(_utcDateTime, actual.DateTime);
    }

    #endregion
    #region UtcTime

    [TestMethod]
    public void UtcTime_UtcTime()
    {
        //ACT
        var actual = _sut.UtcTime();
        //ASSERT
        Assert.AreEqual(_utcDateTime.ToTimeOnly(), actual);
    }

    #endregion
    #region UtcToday

    [TestMethod]
    public void UtcToday_DatePartCorrect()
    {
        //ACT
        var actual = _sut.UtcToday();
        //ASSERT
        Assert.That.AreEqualDate(_utcDateTime, actual);
    }
    
    [TestMethod]
    public void UtcToday_OffsetToOtherDate_DatePartCorrect()
    {
        ArrangeWithOffset(-6);
        //ACT
        var actual = _sut.UtcToday();
        //ASSERT
        Assert.That.AreEqualDate(_utcDateTime, actual);
    }

    #endregion

}
