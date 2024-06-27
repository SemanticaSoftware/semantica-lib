using System;
using Semantica.Core.Providers;

namespace Semantica.TestTools.Core.Mocks;

/// <summary>
/// Provides an implementation of <see cref="IDateTimeProvider"/> that can be set fixed to a specific time. Can be used as a
/// mock in other tests.
/// </summary>
public class TestDateTimeProvider : DateTimeProvider
{
    public const string WEuropeStandardTime = "W. Europe Standard Time";
    
    private DateTime _utcNow;
    private readonly TimeSpan? _offset;
    private readonly DateTimeKind _offsetKind;
    private readonly TimeZoneInfo? _timezone;

    /// <summary>
    /// Initializes <see cref="UtcNow"/> with the provided value, and a fixed timezone "W. Europe Standard Time".
    /// </summary>
    /// <param name="utcNow">The fixed value for <see cref="UtcNow"/>.</param>
    public TestDateTimeProvider(DateTime utcNow) :this(utcNow, WEuropeStandardTime)
    { }

    /// <summary>
    /// Initializes <see cref="UtcNow"/> with the provided value, and a timezone identified by <paramref name="timezoneId"/>.
    /// </summary>
    /// <param name="utcNow">The fixed value for <see cref="UtcNow"/>.</param>
    /// <param name="timezoneId">The id (an OS-specific identifier string) of the time zone to be used.</param>
    public TestDateTimeProvider(DateTime utcNow, string timezoneId)
    {
        SetUtcNow(utcNow);
        var timezone = System.TimeZoneInfo.FindSystemTimeZoneById(timezoneId);
        _timezone = timezone;
        _offsetKind = System.TimeZoneInfo.Local.Id == timezoneId ? DateTimeKind.Local : DateTimeKind.Unspecified;
    }
        
    /// <summary>
    /// Initializes <see cref="UtcNow"/> with the provided value, and a fixed timezone offset (no DST).
    /// </summary>
    /// <param name="utcNow">The fixed value for <see cref="UtcNow"/>.</param>
    /// <param name="fixedOffset">The fixed value for <see cref="Offset"/>.</param>
    public TestDateTimeProvider(DateTime utcNow, TimeSpan fixedOffset)
        : this(utcNow)
    {
        _offset = fixedOffset;
        _offsetKind = DateTimeKind.Unspecified;
    }
        
    /// <summary>
    /// Initializes <see cref="UtcNow"/> with the provided value, and a provided timezone.
    /// </summary>
    /// <param name="utcNow">The fixed value for <see cref="UtcNow"/>.</param>
    /// <param name="timezone">An instance of <see cref="TimeZoneInfo"/> to be used.</param>
    public TestDateTimeProvider(DateTime utcNow, TimeZoneInfo timezone)
    {
        SetUtcNow(utcNow);
        _timezone = timezone;
        _offsetKind = DateTimeKind.Unspecified;
    }

    /// <summary>
    /// Not part of <see cref="IDateTimeProvider"/> interface implementation. Can set Now after construction.
    /// </summary>
    /// <param name="dateTime">The new value of <see cref="UtcNow"/></param>
    public DateTime SetUtcNow(DateTime dateTime) => _utcNow = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);

    public override DateTime UtcNow() => _utcNow;
    public override TimeSpan Offset(DateTime dateTime) => _offset ?? base.Offset(dateTime);
    public override TimeZoneInfo TimeZoneInfo() => _timezone ?? base.TimeZoneInfo();
    public override DateTimeKind OffsetKind() => _offsetKind;
}
