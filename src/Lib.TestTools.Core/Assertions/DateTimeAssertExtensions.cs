using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Extensions;

namespace Semantica.TestTools.Core.Assertions;

public static class DateTimeAssertExtensions
{
    public static void AreEqualDate(this Assert _, DateTime expected, DateTime actual)
        => AreEqualDate(_, (expected.Year, expected.Month, expected.Day), actual);

    public static void AreEqualDate(this Assert _, (int Year, int Month, int Day) expected, DateOnly actual)
    {
        Assert.AreEqual(expected.Year, actual.Year, nameof(DateTime.Year));
        Assert.AreEqual(expected.Month, actual.Month, nameof(DateTime.Month));
        Assert.AreEqual(expected.Day, actual.Day, nameof(DateTime.Day));
    }

    public static void AreEqualDate(this Assert _, DateTime expected, DateOnly actual)
        => AreEqualDate(_, (expected.Year, expected.Month, expected.Day), actual);

    public static void AreEqualDate(this Assert _, (int Year, int Month, int Day) expected, DateTime actual)
    {
        Assert.AreEqual(expected.Year, actual.Year, nameof(DateTime.Year));
        Assert.AreEqual(expected.Month, actual.Month, nameof(DateTime.Month));
        Assert.AreEqual(expected.Day, actual.Day, nameof(DateTime.Day));
    }

    public static void AreEqualTime(this Assert _, (int Hour, int Minute) expected, DateTime actual)
        => AreEqualTime(_, (expected.Hour, expected.Minute, 0, 0, 0), actual);
    
    public static void AreEqualTime(this Assert _, (int Hour, int Minute, int Second) expected, DateTime actual)
        => AreEqualTime(_, (expected.Hour, expected.Minute, expected.Second, 0, 0), actual);
    
    public static void AreEqualTime(this Assert _, DateTime expected, DateTime actual)
#if NET7_0_OR_GREATER
        => AreEqualTime(_, (expected.Hour, expected.Minute, expected.Second, expected.Millisecond, expected.Microsecond), actual);
#else    
        => AreEqualTime(_, (expected.Hour, expected.Minute, expected.Second, expected.Millisecond, 0), actual);
#endif 
    
    public static void AreEqualTime(this Assert _, (int Hour, int Minute, int Second, int Millisecond, int Microsecond) expected, DateTime actual)
    {
        Assert.AreEqual(expected.Hour, actual.Hour, nameof(DateTime.Hour));
        Assert.AreEqual(expected.Minute, actual.Minute, nameof(DateTime.Minute));
        Assert.AreEqual(expected.Second, actual.Second, nameof(DateTime.Second));
        Assert.AreEqual(expected.Millisecond, actual.Millisecond, nameof(DateTime.Millisecond));
#if NET7_0_OR_GREATER
        Assert.AreEqual(expected.Microsecond, actual.Microsecond, nameof(DateTime.Microsecond));
#endif 
    }

    public static void AreNotEqualDate(this Assert _, DateTime expected, DateOnly actual)
        => Assert.AreNotEqual(expected.Date, actual.ToDateTime());

    public static void AreNotEqualDate(this Assert _, DateTime expected, DateTime actual)
        => Assert.AreNotEqual(expected.Date, actual.Date);

    public static void IsMidnight(this Assert _, DateTime actual)
        => AreEqualTime(_, (0, 0, 0, 0, 0), actual);
}
