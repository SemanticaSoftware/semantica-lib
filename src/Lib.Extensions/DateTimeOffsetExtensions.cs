using System.Diagnostics.Contracts;
using Semantica.Core;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for <see cref="DateTimeOffset"/> instances.
/// </summary>
[Pure]
public static class DateTimeOffsetExtensions
{
    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> value that is based on <paramref name="datetimeOffset"/> rounded down to the first day of the
    /// month. Effectively an alias to <see cref="FloorToMonth"/>  
    /// </summary>
    /// <param name="datetimeOffset">The <see cref="DateTimeOffset"/> value to floor.</param>
    /// <returns>A <see cref="DateTimeOffset"/> value with the year and month value equal to <paramref name="datetimeOffset"/>.</returns>
    public static DateTimeOffset FirstOfMonth(this DateTimeOffset datetimeOffset) => FloorToMonth(datetimeOffset);
    
    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> value that is based on <paramref name="datetimeOffset"/> rounded down to the day.
    /// </summary>
    /// <param name="datetimeOffset">The <see cref="DateTimeOffset"/> value to floor.</param>
    /// <returns>A <see cref="DateTimeOffset"/> value with the date value equal to <paramref name="datetimeOffset"/>.</returns>
    public static DateTimeOffset FloorToDay(this DateTimeOffset datetimeOffset)
    {
        var clockTicks = datetimeOffset.Ticks;
        return new DateTimeOffset(clockTicks - clockTicks % DateTimeConstants.TicksPerDay, datetimeOffset.Offset);
    }

    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> value that is based on <paramref name="datetimeOffset"/> rounded down to the hour.
    /// </summary>
    /// <param name="datetimeOffset">The <see cref="DateTimeOffset"/> value to floor.</param>
    /// <returns>A <see cref="DateTimeOffset"/> value with the date and hour value equal to <paramref name="datetimeOffset"/>.</returns>
    public static DateTimeOffset FloorToHour(this DateTimeOffset datetimeOffset)
    {
        var clockTicks = datetimeOffset.Ticks;
        return new DateTimeOffset(clockTicks - clockTicks % DateTimeConstants.TicksPerHour, datetimeOffset.Offset);
    }

    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> value that is based on <paramref name="datetimeOffset"/> rounded down to the minute.
    /// </summary>
    /// <param name="datetimeOffset">The <see cref="DateTimeOffset"/> value to floor.</param>
    /// <returns>A <see cref="DateTimeOffset"/> value with the date and time value down to the millisecond equal to <paramref name="datetimeOffset"/>.</returns>
    public static DateTimeOffset FloorToMillisecond(this DateTimeOffset datetimeOffset)
    {
        var clockTicks = datetimeOffset.Ticks;
        return new DateTimeOffset(clockTicks - clockTicks % DateTimeConstants.TicksPerMillisecond, datetimeOffset.Offset);
    }

    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> value that is based on <paramref name="datetimeOffset"/> rounded down to the minute.
    /// </summary>
    /// <param name="datetimeOffset">The <see cref="DateTimeOffset"/> value to floor.</param>
    /// <returns>A <see cref="DateTimeOffset"/> value with the date and time value down to the minute equal to <paramref name="datetimeOffset"/>.</returns>
    public static DateTimeOffset FloorToMinute(this DateTimeOffset datetimeOffset)
    {
        var clockTicks = datetimeOffset.Ticks;
        return new DateTimeOffset(clockTicks - clockTicks % DateTimeConstants.TicksPerMinute, datetimeOffset.Offset);
    }

    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> value that is based on <paramref name="datetimeOffset"/> rounded down to the first day of the
    /// month.
    /// </summary>
    /// <param name="datetimeOffset">The <see cref="DateTimeOffset"/> value to floor.</param>
    /// <returns>A <see cref="DateTimeOffset"/> value with the year and month value equal to <paramref name="datetimeOffset"/>.</returns>
    public static DateTimeOffset FloorToMonth(this DateTimeOffset datetimeOffset)
    {
        return new DateTimeOffset(datetimeOffset.DateTime.FloorToMonth(), datetimeOffset.Offset);
    }

    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> value that is based on <paramref name="datetimeOffset"/> rounded down to the second.
    /// </summary>
    /// <param name="datetimeOffset"> The <see cref="DateTimeOffset"/> value to floor. </param>
    /// <returns>
    /// A <see cref="DateTimeOffset"/> value with the date and time value down to the second equal to <paramref name="datetimeOffset"/>.
    /// </returns>
    public static DateTimeOffset FloorToSecond(this DateTimeOffset datetimeOffset)
    {
        var clockTicks = datetimeOffset.Ticks;
        return new DateTimeOffset(clockTicks - clockTicks % DateTimeConstants.TicksPerSecond, datetimeOffset.Offset);
    }

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateTimeOffset"/> value. </param>
    /// <param name="right"> Right side <see cref="DateOnly"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateTimeOffset left, DateOnly right)
        => left.Year == right.Year && left.Month == right.Month;

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateTimeOffset"/> value. </param>
    /// <param name="right"> Right side <see cref="DateTime"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateTimeOffset left, DateTime right)
        => left.Year == right.Year && left.Month == right.Month;

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateTimeOffset"/> value. </param>
    /// <param name="right"> Right side <see cref="DateTimeOffset"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateTimeOffset left, DateTimeOffset right)
        => left.Year == right.Year && left.Month == right.Month;

    /// <summary>
    /// Returns the date part of the input as a <see cref="DateOnly"/> value.
    /// </summary>
    /// <param name="dateTime"> The <see cref="DateTimeOffset"/> value to convert. </param>
    /// <returns> A <see cref="DateOnly"/> value with the same date value as the input. </returns>
    public static DateOnly ToDateOnly(this DateTimeOffset dateTime)
        => DateOnly.FromDateTime(dateTime.DateTime);

    /// <inheritdoc cref="ToDateOnly(System.DateTimeOffset)"/>
    public static DateOnly? ToDateOnly(this DateTimeOffset? dateTime)
        => dateTime.HasValue ? DateOnly.FromDateTime(dateTime.Value.DateTime) : default(DateOnly?);

    /// <summary>
    /// Returns the time part of the input as a <see cref="TimeOnly"/> value.
    /// </summary>
    /// <param name="dateTime"> The <see cref="DateTimeOffset"/> value to convert. </param>
    /// <returns> A <see cref="TimeOnly"/> value with the same date value as the input. </returns>
    public static TimeOnly ToTimeOnly(this DateTimeOffset dateTime)
        => TimeOnly.FromDateTime(dateTime.DateTime);

    /// <inheritdoc cref="ToTimeOnly(System.DateTimeOffset)"/>
    public static TimeOnly? ToTimeOnly(this DateTimeOffset? dateTime)
        => dateTime.HasValue ? TimeOnly.FromDateTime(dateTime.Value.DateTime) : default(TimeOnly?);
}
