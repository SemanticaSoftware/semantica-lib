using Semantica.Types;

namespace Semantica.Lib.Tests.Core.Test._SomeData.Types;

public static class SomeDateSpan
{
    public const int Days = 13;
    public const int TotalMonths = 27; // 12 * 2 + 3
    public const int Months = 3;
    public const int Years = 2;

    public static DateSpan Create() => DateSpan.FromParts(Days, Months, Years);

    public static DateSpan CreateMonths() => DateSpan.FromMonths(TotalMonths);
    
    public static DateSpan CreateNegative() => DateSpan.FromParts(-Days, -Months, -Years);

    public static DateSpan CreateMonthsNegative() => DateSpan.FromMonths(-TotalMonths);
    
    public static DateSpan CreateLow() => DateSpan.FromParts(Days, Months);

    public static DateSpan CreateLowMonths() => DateSpan.FromMonths(Months);
    
    public static DateSpan CreateLowNegative() => DateSpan.FromParts(-Days, -Months);

    public static DateSpan CreateLowMonthsNegative() => DateSpan.FromMonths(-Months);

}
