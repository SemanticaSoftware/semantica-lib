namespace Semantica.Lib.Tests.Core.Test._SomeData;

public static class SomeDateTime
{
    public const int Year = SomeDateOnly.Year;
    public const int Month = SomeDateOnly.Month;
    public const int Day = SomeDateOnly.Day;
    public const int Hours = 10;
    public const int Minutes = 36;
    public const int Seconds = 12;

    public static DateTime Create() => new DateTime(Year, Month, Day, Hours, Minutes, Seconds);

    public static DateTime CreateSpanSubtracted() => new DateTime(
        Year - SomeDateSpan.Years,
        Month - SomeDateSpan.Months,
        Day - SomeDateSpan.Days, Hours, Minutes, Seconds);
}
