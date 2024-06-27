using Semantica.Core;
using Semantica.Extensions;

namespace Semantica.Types;

public static class DateSpanExtensions
{
    public static DateOnly Add(this DateOnly date, DateSpan span) => date + span;

    public static DateTime Add(this DateTime date, DateSpan span) => date + span;
    
    public static DateSpan Difference(this DateOnly date, DateOnly referenceDate)
    {
        var isNegative = date < referenceDate;
        var difference = isNegative 
            ? MonthsDifference(referenceDate.ToDateLike(), date.ToDateLike()) 
            : MonthsDifference(date.ToDateLike(), referenceDate.ToDateLike());
        return new DateSpan(difference.months, difference.days, isNegative, difference.weekdays, difference.daysInverted);
    }
    
    public static DateSpan Difference(this DateTime date, DateTime referenceDate)
    {
        var isNegative = date < referenceDate.Date;
        var difference = isNegative 
            ? MonthsDifference(referenceDate.ToDateLike(), date.ToDateLike()) 
            : MonthsDifference(date.ToDateLike(), referenceDate.ToDateLike());
        return new DateSpan(difference.months, difference.days, isNegative, difference.weekdays, difference.daysInverted);
    }

    public static (uint months, byte days, byte weekdays, byte daysInverted) MonthsDifference(DateLike left, DateLike right)
    {
        var monthsFromYear = ((int)DateSpan.MonthsPerYear) * (left.Year - right.Year); 
        var dayDifference = left.Day - right.Day;
        var weekdayDifference = (byte)(left.DayOfWeek - right.DayOfWeek).Modulo(7);
        if (dayDifference >= 0)
        {
            return (months: (uint)(monthsFromYear + left.Month - right.Month),
                days: (byte)dayDifference,
                weekdays: weekdayDifference,
                daysInverted: 0);
        }
        var daysInMonth = DateTimeConstants.GetDaysInMonth(left.Year, DateTimeConstants.MonthNumberBefore(left.Month));
        return (months: (uint)(monthsFromYear + left.Month - right.Month - 1),
            days: (byte)(daysInMonth + dayDifference),
            weekdays: weekdayDifference,
            daysInverted: (byte)(daysInMonth - left.Day));
    }

    public readonly record struct DateLike(int Day, int Month, int Year, DayOfWeek DayOfWeek);
    
    internal static DateLike ToDateLike(this DateOnly date) => new(date.Day, date.Month, date.Year, date.DayOfWeek);

    internal static DateLike ToDateLike(this DateTime date) => new(date.Day, date.Month, date.Year, date.DayOfWeek);
    
}
