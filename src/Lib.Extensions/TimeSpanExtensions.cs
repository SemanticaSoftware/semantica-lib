using System.Diagnostics.Contracts;
using Semantica.Core;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for timespans.
/// </summary>
[Pure]
public static class TimeSpanExtensions
{
    /// <summary>
    /// Returns a <see cref="TimeSpan"/> value that is based on <paramref name="timespan"/> rounded down to the day.
    /// </summary>
    /// <param name="timespan">The <see cref="TimeSpan"/> value to floor.</param>
    /// <returns>A <see cref="TimeSpan"/> value with the days value equal to <paramref name="timespan"/>.</returns>
    public static TimeSpan FloorToDays(this TimeSpan timespan)
    {
        //return new TimeSpan(timespan.Ticks - (timespan.Ticks % TimeSpan.TicksPerDay));
        return new TimeSpan(timespan.Days, 0, 0, 0);
    }

    /// <summary>
    /// Returns a <see cref="TimeSpan"/> value that is based on <paramref name="timespan"/> rounded down to the hour.
    /// </summary>
    /// <param name="timespan">The <see cref="TimeSpan"/> value to floor.</param>
    /// <returns>A <see cref="TimeSpan"/> value with the days and hours values equal to <paramref name="timespan"/>.</returns>
    public static TimeSpan FloorToHours(this TimeSpan timespan)
    {
        //return new TimeSpan(timespan.Ticks - (timespan.Ticks % TimeSpan.TicksPerHour));
        return new TimeSpan(timespan.Days, timespan.Hours, 0, 0);
    }

    /// <summary>
    /// Returns a <see cref="TimeSpan"/> value that is based on <paramref name="timespan"/> rounded down to the minute.
    /// </summary>
    /// <param name="timespan">The <see cref="TimeSpan"/> value to floor.</param>
    /// <returns>A <see cref="TimeSpan"/> value with the days, hours and minutes values equal to <paramref name="timespan"/>.</returns>
    public static TimeSpan FloorToMinutes(this TimeSpan timespan)
    {
        // return new TimeSpan(timespan.Ticks - (timespan.Ticks % TimeSpan.TicksPerMinute));
        return new TimeSpan(timespan.Days, timespan.Hours, timespan.Minutes, 0);
    }

    /// <summary>
    /// Returns a <see cref="TimeSpan"/> value that is based on <paramref name="timespan"/> rounded down to the millisecond.
    /// </summary>
    /// <param name="timespan">The <see cref="TimeSpan"/> value to floor.</param>
    /// <returns>A <see cref="TimeSpan"/> value with the days, hours, minutes, second and millisecond values equal to <paramref name="timespan"/>.</returns>
    public static TimeSpan FloorToMilliseconds(this TimeSpan timespan)
    {
        // return new TimeSpan(timespan.Ticks - (timespan.Ticks % TimeSpan.TicksPerMillisecond));
        return new TimeSpan(timespan.Days, timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
    }

    /// <summary>
    /// Returns a <see cref="TimeSpan"/> value that is based on <paramref name="timespan"/> rounded down to the second.
    /// </summary>
    /// <param name="timespan">The <see cref="TimeSpan"/> value to floor.</param>
    /// <returns>A <see cref="TimeSpan"/> value with the days, hours, minutes and seconds values equal to <paramref name="timespan"/>.</returns>
    public static TimeSpan FloorToSeconds(this TimeSpan timespan)
    {
        //return new TimeSpan(timespan.Ticks - (timespan.Ticks % TimeSpan.TicksPerSecond));
        return new TimeSpan(timespan.Days, timespan.Hours, timespan.Minutes, timespan.Seconds);
    }
}
