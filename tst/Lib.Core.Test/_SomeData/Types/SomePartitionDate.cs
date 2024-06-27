using Semantica.Types;

namespace Semantica.Lib.Tests.Core.Test._SomeData.Types;

public static class SomePartitionDate
{
    public const int Year = 2022;
    public const int Month = 4;
    public const int Day = 13;

    public static readonly string ValueSerialized = "2022|04|13"; 
        //= $"{Year}{PartitionDateTypeConverter.Separator}{Month:D2}{PartitionDateTypeConverter.Separator}{Day:D2}";

    public static PartitionDate Create(int day = Day, int month = Month, int year = Year) => new(year, month, day);
    public static PartitionDate CreateOnlyDayPart() => new PartitionDate(day: Day);
    public static PartitionDate CreateOnlyMonthPart() => new PartitionDate(month: Month);
    public static PartitionDate CreateOnlyYearPart() => new PartitionDate(year: Year);
}
