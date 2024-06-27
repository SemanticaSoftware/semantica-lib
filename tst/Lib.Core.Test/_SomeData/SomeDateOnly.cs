namespace Semantica.Lib.Tests.Core.Test._SomeData;

public static class SomeDateOnly
{
    public const int Year = 2023;
    public const int Month = 4;
    public const int Day = 15;

    public static DateOnly Create() => new DateOnly(Year, Month, Day);

    public static DateOnly CreateSpanSubtracted() => new DateOnly(
        Year - SomeDateSpan.Years,
        Month - SomeDateSpan.Months,
        Day - SomeDateSpan.Days);
}