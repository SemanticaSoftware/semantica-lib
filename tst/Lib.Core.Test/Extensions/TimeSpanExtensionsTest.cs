using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class TimeSpanExtensionsTest
{
    private TimeSpan _timeSpan = SomeTimeSpan.Create();
    
    #region FloorToDays
    
    [TestMethod]
    public void FloorToDays_SomeTimeSpan_DaysIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToDays(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Days, actual.Days);
    }
    
    [TestMethod]
    public void FloorToDays_SomeTimeSpan_HoursIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToDays(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Hours);
    }
    
    [TestMethod]
    public void FloorToDays_SomeTimeSpan_MinutesIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToDays(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Minutes);
    }
    
    [TestMethod]
    public void FloorToDays_SomeTimeSpan_SecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToDays(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Seconds);
    }
    
    [TestMethod]
    public void FloorToDays_SomeTimeSpan_MillisecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToDays(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Milliseconds);
    }
    
    [TestMethod]
    public void FloorToDays_SomeTimeSpan_MicrosecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToDays(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Microseconds);
    }
    
    #endregion
    #region FloorToHours
    
    [TestMethod]
    public void FloorToHours_SomeTimeSpan_DaysIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToHours(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Days, actual.Days);
    }
    
    [TestMethod]
    public void FloorToHours_SomeTimeSpan_HoursIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToHours(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Hours, actual.Hours);
    }
    
    [TestMethod]
    public void FloorToHours_SomeTimeSpan_MinutesIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToHours(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Minutes);
    }
    
    [TestMethod]
    public void FloorToHours_SomeTimeSpan_SecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToHours(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Seconds);
    }
    
    [TestMethod]
    public void FloorToHours_SomeTimeSpan_MillisecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToHours(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Milliseconds);
    }
    
    [TestMethod]
    public void FloorToHours_SomeTimeSpan_MicrosecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToHours(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Microseconds);
    }
    
    #endregion
    #region FloorToMinutes
    
    [TestMethod]
    public void FloorToMinutes_SomeTimeSpan_DaysIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMinutes(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Days, actual.Days);
    }
    
    [TestMethod]
    public void FloorToMinutes_SomeTimeSpan_HoursNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMinutes(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Hours, actual.Hours);
    }
    
    [TestMethod]
    public void FloorToMinutes_SomeTimeSpan_MinutesNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMinutes(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Minutes, actual.Minutes);
    }
    
    [TestMethod]
    public void FloorToMinutes_SomeTimeSpan_SecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMinutes(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Seconds);
    }
    
    [TestMethod]
    public void FloorToMinutes_SomeTimeSpan_MillisecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMinutes(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Milliseconds);
    }
    
    [TestMethod]
    public void FloorToMinutes_SomeTimeSpan_MicrosecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMinutes(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Microseconds);
    }
    
    #endregion
    #region FloorToSeconds
    
    [TestMethod]
    public void FloorToSeconds_SomeTimeSpan_DaysIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToSeconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Days, actual.Days);
    }
    
    [TestMethod]
    public void FloorToSeconds_SomeTimeSpan_HoursNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToSeconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Hours, actual.Hours);
    }
    
    [TestMethod]
    public void FloorToSeconds_SomeTimeSpan_MinutesNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToSeconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Minutes, actual.Minutes);
    }
    
    [TestMethod]
    public void FloorToSeconds_SomeTimeSpan_SecondsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToSeconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Seconds, actual.Seconds);
    }
    
    [TestMethod]
    public void FloorToSeconds_SomeTimeSpan_MillisecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToSeconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Milliseconds);
    }
    
    [TestMethod]
    public void FloorToSeconds_SomeTimeSpan_MicrosecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToSeconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Microseconds);
    }
    
    #endregion
    #region FloorToMilliseconds
    
    [TestMethod]
    public void FloorToMilliseconds_SomeTimeSpan_DaysIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMilliseconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Days, actual.Days);
    }
    
    [TestMethod]
    public void FloorToMilliseconds_SomeTimeSpan_HoursIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMilliseconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Hours, actual.Hours);
    }
    
    [TestMethod]
    public void FloorToMilliseconds_SomeTimeSpan_MinutesIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMilliseconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Minutes, actual.Minutes);
    }
    
    [TestMethod]
    public void FloorToMilliseconds_SomeTimeSpan_SecondsIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMilliseconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Seconds, actual.Seconds);
    }
    
    [TestMethod]
    public void FloorToMilliseconds_SomeTimeSpan_MillisecondsIsNotChanged()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMilliseconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(SomeTimeSpan.Milliseconds, actual.Milliseconds);
    }
    
    [TestMethod]
    public void FloorToMilliseconds_SomeTimeSpan_MicrosecondsIs0()
    {
        //ACT
        var actual = TimeSpanExtensions.FloorToMilliseconds(_timeSpan);
        //ASSERT
        Assert.AreEqual(0, actual.Microseconds);
    }
    
    #endregion
}
