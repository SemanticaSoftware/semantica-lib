namespace Semantica.Core.Providers;

/// <summary>
/// Provides methods to get the current date and time.
/// </summary>
/// <remarks>
/// The implementation is just a wrapper around the <see cref="DateTime"/>'s static <see cref="DateTime.Now"/>,
/// <see cref="DateTime.UtcNow"/> and <see cref="DateTime.Today"/> members in order to be able to mock it in tests.
/// </remarks>
public interface IDateTimeProvider
{
    /// <summary>
    /// Will convert a non-UTC datetime to <see cref="DateTimeOffset"/> with an explicit offset of the local timezone.
    /// </summary>
    /// <param name="dateTime">Input (non-UTC) <see cref="DateTime"/> to convert <see cref="DateTimeOffset"/>.</param>
    /// <exception cref="ArgumentException">
    /// If the kind of the input is <see cref="DateTimeKind.Utc"/> and local timezone is not.
    /// </exception>
    /// <returns>A local <see cref="DateTimeOffset"/>.</returns>
    DateTimeOffset ConvertLocalToOffset(DateTime dateTime);

    /// <summary>
    /// Will convert a UTC datetime to the local timezone, and return it as a <see cref="DateTimeOffset"/>.
    /// </summary>
    /// <param name="dateTime">Input UTC <see cref="DateTime"/> to adjust to local time.</param>
    /// <exception cref="ArgumentException">If the kind of the input is not <see cref="DateTimeKind.Utc"/>.</exception>
    /// <returns>A local <see cref="DateTimeOffset"/>.</returns>
    DateTimeOffset ConvertUtcToOffset(DateTime dateTime);
    
    /// <summary>
    /// Returns a <see cref="DateTime"/> representing the current date. The date part of the returned value is the current date,
    /// and the time-of-day part of the returned value is zero (midnight).
    /// </summary>
    /// <remarks>The value wil have <see cref="DateTimeKind"/>.<see cref="DateTimeKind.Local"/>.</remarks>
    DateTime MidnightToday();
    
    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> representing the current date. The date part of the returned value is the current date,
    /// and the time-of-day part of the returned value is zero (midnight).
    /// </summary>
    DateTimeOffset MidnightTodayOffset();

    /// <summary>Returns a <see cref="DateTime"/> representing the current date and time.</summary>
    /// <remarks>
    /// The resolution of the returned value depends on the system timer. The value wil have
    /// <see cref="DateTimeKind"/>.<see cref="DateTimeKind.Local"/>, unless <see cref="OffsetKind"/> is overridden.
    /// </remarks>
    DateTime Now();

    /// <summary>Returns a <see cref="DateTimeOffset"/> representing the current date and time.</summary>
    /// <remarks>The resolution of the returned value depends on the system timer.</remarks>
    DateTimeOffset NowOffset();

    /// <summary>
    /// Returns a <see cref="TimeSpan"/> containing the local offset compared to UTC. Non-constant for locations that have
    /// daylight-savings time (DST).
    /// </summary>
    /// <param name="dateTime">
    /// The date and time for wich the offset needs to be determined, according to the <see cref="TimeZoneInfo()"/>.
    /// </param>
    /// <remarks>
    /// Override this or <see cref="TimeZoneInfo()"/> to make methods return non-local time. When doing so,
    /// <see cref="OffsetKind"/> should also be overridden to return <see cref="DateTimeKind.Unspecified"/>.
    /// </remarks>
    TimeSpan Offset(DateTime dateTime);

    /// <summary>Returns the <see cref="DateTimeKind"/> used for all DateTimes returned.</summary>
    /// <remarks><see cref="DateTimeKind.Local"/>, unless the default implementation is overridden.</remarks>
    DateTimeKind OffsetKind();

    /// <summary>Returns a <see cref="TimeOnly"/> representing the current time of day.</summary>
    /// <remarks>The resolution of the returned value depends on the system timer.</remarks>
    TimeOnly Time();

    /// <summary>Returns the <see cref="TimeZoneInfo"/> used for all non-utc methods.</summary>
    /// <remarks>
    /// Will use the local timezone unless overridden. When doing so, <see cref="OffsetKind"/> should also be overridden to
    /// return <see cref="DateTimeKind.Unspecified"/>.
    /// </remarks>
    TimeZoneInfo TimeZoneInfo();
    
    /// <summary>Returns a <see cref="DateOnly"/> representing the current date.</summary>
    DateOnly Today();
    
    /// <summary>
    /// Returns a <see cref="DateTime"/> representing the current date in Utc-time. The date part of the returned value is the
    /// current date, and the time-of-day part of the returned value is zero (midnight).
    /// </summary>
    /// <remarks>The value wil have <see cref="DateTimeKind"/>.<see cref="DateTimeKind.Utc"/>.</remarks>
    DateTime UtcMidnightToday();
    
    /// <summary>
    /// Returns a <see cref="DateTimeOffset"/> representing the current date in Utc-time. The date part of the returned value is the
    /// current date, and the time-of-day part of the returned value is zero (midnight).
    /// </summary>
    DateTimeOffset UtcMidnightTodayOffset();

    /// <summary>Returns a <see cref="DateTime"/> representing the current date and time in Utc-time.</summary>
    /// <remarks>
    /// The resolution of the returned value depends on the system timer. The value wil have
    /// <see cref="DateTimeKind"/>.<see cref="DateTimeKind.Utc"/>.
    /// </remarks>
    DateTime UtcNow();

    /// <summary>Returns a <see cref="DateTime"/> representing the current date and time in Utc-time.</summary>
    /// <remarks>The resolution of the returned value depends on the system timer.</remarks>
    DateTimeOffset UtcNowOffset();

    /// <summary>Returns a <see cref="TimeOnly"/> representing the current time of day in Utc-time.</summary>
    /// <remarks>The resolution of the returned value depends on the system timer.</remarks>
    TimeOnly UtcTime();

    /// <summary>Returns a <see cref="DateOnly"/> representing the current date in Utc-time.</summary>
    DateOnly UtcToday();
}
