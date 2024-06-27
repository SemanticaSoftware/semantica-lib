using System.Diagnostics.Contracts;
using Semantica.Core;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for dates and times.
/// </summary>
[Pure]
public static class DateTimeExtensions
{
    /// <summary>
    /// Returns a <see cref="DateTime"/> value that is based on <paramref name="datetime"/> rounded down to the first day of the
    /// month. Effectively an alias to <see cref="FloorToMonth"/>.  
    /// </summary>
    /// <param name="datetime">The <see cref="DateTime"/> value to floor.</param>
    /// <returns>A <see cref="DateTime"/> value with the year and month value equal to <paramref name="datetime"/>.</returns>
    public static DateTime FirstOfMonth(this DateTime datetime) => FloorToMonth(datetime);
    
    /// <summary>
    /// Returns a <see cref="DateTime"/> value that is based on <paramref name="datetime"/> rounded down to the day.
    /// </summary>
    /// <param name="datetime">The <see cref="DateTime"/> value to floor.</param>
    /// <returns>A <see cref="DateTime"/> value with the date value equal to <paramref name="datetime"/>.</returns>
    public static DateTime FloorToDay(this DateTime datetime)
    {
        return datetime.Date;
    }

    /// <summary>
    /// Returns a <see cref="DateTime"/> value that is based on <paramref name="datetime"/> rounded down to the hour.
    /// </summary>
    /// <param name="datetime">The <see cref="DateTime"/> value to floor.</param>
    /// <returns>A <see cref="DateTime"/> value with the date and hour value equal to <paramref name="datetime"/>.</returns>
    public static DateTime FloorToHour(this DateTime datetime)
    {
        var ticks = datetime.Ticks;
        return new DateTime((ticks - ticks % DateTimeConstants.TicksPerHour), datetime.Kind);
    }

    /// <summary>
    /// Returns a <see cref="DateTime"/> value that is based on <paramref name="datetime"/> rounded down to the millisecond.
    /// </summary>
    /// <param name="datetime">The <see cref="DateTime"/> value to floor.</param>
    /// <returns>A <see cref="DateTime"/> value with the date and time value down to the millisecond equal to <paramref name="datetime"/>.</returns>
    public static DateTime FloorToMillisecond(this DateTime datetime)
    {
        var ticks = datetime.Ticks;
        return new DateTime((ticks - ticks % DateTimeConstants.TicksPerMillisecond), datetime.Kind);
    }

    /// <summary>
    /// Returns a <see cref="DateTime"/> value that is based on <paramref name="datetime"/> rounded down to the minute.
    /// </summary>
    /// <param name="datetime">The <see cref="DateTime"/> value to floor.</param>
    /// <returns>A <see cref="DateTime"/> value with the date and time value down to the minute equal to <paramref name="datetime"/>.</returns>
    public static DateTime FloorToMinute(this DateTime datetime)
    {
        var ticks = datetime.Ticks;
        return new DateTime((ticks - ticks % DateTimeConstants.TicksPerMinute), datetime.Kind);
    }

    /// <summary>
    /// Returns a <see cref="DateTime"/> value that is based on <paramref name="datetime"/> rounded down to the first day of the
    /// month.
    /// </summary>
    /// <param name="datetime">The <see cref="DateTime"/> value to floor.</param>
    /// <returns>A <see cref="DateTime"/> value with the year and month value equal to <paramref name="datetime"/>.</returns>
    public static DateTime FloorToMonth(this DateTime datetime)
    {
        return new DateTime(datetime.Year, datetime.Month, 1, 0, 0, 0, datetime.Kind);
    }

    /// <summary>
    /// Returns a <see cref="DateTime"/> value that is based on <paramref name="datetime"/> rounded down to the second.
    /// </summary>
    /// <param name="datetime"> The <see cref="DateTime"/> value to floor. </param>
    /// <returns>
    /// A <see cref="DateTime"/> value with the date and time value down to the second equal to <paramref name="datetime"/>.
    /// </returns>
    public static DateTime FloorToSecond(this DateTime datetime)
    {
        var ticks = datetime.Ticks;
        return new DateTime((ticks - ticks % DateTimeConstants.TicksPerSecond), datetime.Kind);
    }

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateTime"/> value. </param>
    /// <param name="right"> Right side <see cref="DateOnly"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateTime left, DateOnly right)
        => left.Year == right.Year && left.Month == right.Month;

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateTime"/> value. </param>
    /// <param name="right"> Right side <see cref="DateTimeOffset"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateTime left, DateTimeOffset right)
        => left.Year == right.Year && left.Month == right.Month;

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateTime"/> value. </param>
    /// <param name="right"> Right side <see cref="DateTime"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateTime left, DateTime right)
        => left.Year == right.Year && left.Month == right.Month;

    /// <summary>
    /// Returns the date part of the input as a <see cref="DateOnly"/> value.
    /// </summary>
    /// <param name="dateTime"> The <see cref="DateTime"/> value to convert. </param>
    /// <returns> A <see cref="DateOnly"/> value with the same date value as the input. </returns>
    public static DateOnly ToDateOnly(this DateTime dateTime)
        => DateOnly.FromDateTime(dateTime);

    /// <inheritdoc cref="ToDateOnly(System.DateTime)"/>
    public static DateOnly? ToDateOnly(this DateTime? dateTime)
        => dateTime.HasValue ? DateOnly.FromDateTime(dateTime.Value) : default(DateOnly?);

    /// <summary>
    /// Returns the time part of the input as a <see cref="TimeOnly"/> value.
    /// </summary>
    /// <param name="dateTime"> The <see cref="DateTime"/> value to convert. </param>
    /// <returns> A <see cref="TimeOnly"/> value with the same date value as the input. </returns>
    public static TimeOnly ToTimeOnly(this DateTime dateTime)
        => TimeOnly.FromDateTime(dateTime);

    /// <inheritdoc cref="ToTimeOnly(System.DateTime)"/>
    public static TimeOnly? ToTimeOnly(this DateTime? dateTime)
        => dateTime.HasValue ? TimeOnly.FromDateTime(dateTime.Value) : default(TimeOnly?);
}
