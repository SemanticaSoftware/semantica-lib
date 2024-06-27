namespace Semantica.Core.Providers;

public class DateTimeProvider : IDateTimeProvider
{
    public virtual DateTimeOffset ConvertLocalToOffset(DateTime dateTime)
    {
        if (dateTime.Kind == DateTimeKind.Utc && Offset(dateTime) != TimeSpan.Zero) throw new ArgumentException(
            $"{nameof(ConvertLocalToOffset)} cannot be called on {nameof(DateTimeKind)}.{nameof(DateTimeKind.Utc)} values.");

        return OffsetFromLocal(dateTime);
    }
    
    public virtual DateTimeOffset ConvertUtcToOffset(DateTime dateTime)
    {
        if (dateTime.Kind != DateTimeKind.Utc) throw new ArgumentException(
            $"{nameof(ConvertUtcToOffset)} can only be called on {nameof(DateTimeKind)}.{nameof(DateTimeKind.Utc)} values.");
        
        return OffsetFromUtc(dateTime);
    }

    public DateTime MidnightToday() => NowOffset().Date;
    
    public DateTimeOffset MidnightTodayOffset() => OffsetFromLocal(MidnightToday());

    public DateTime Now() => NowOffset().DateTime;
    
    public DateTimeOffset NowOffset() => OffsetFromUtc(UtcNow());
    
    public virtual TimeSpan Offset(DateTime dateTime) => TimeZoneInfo().GetUtcOffset(dateTime);
    
    public virtual DateTimeKind OffsetKind() => DateTimeKind.Local;

    protected virtual DateTimeOffset OffsetFromLocal(DateTime dateTime) 
        => new (DateTime.SpecifyKind(dateTime, OffsetKind()), Offset(dateTime));
    
    protected virtual DateTimeOffset OffsetFromUtc(DateTime dateTime)
    {
        var offset = Offset(dateTime);
        return new (DateTime.SpecifyKind(dateTime + offset, OffsetKind()), offset);
    }

    public TimeOnly Time() => TimeOnly.FromDateTime(Now());

    public virtual TimeZoneInfo TimeZoneInfo() => System.TimeZoneInfo.Local;

    public DateOnly Today() => DateOnly.FromDateTime(MidnightToday());

    public DateTime UtcMidnightToday() => UtcNow().Date;

    public DateTimeOffset UtcMidnightTodayOffset() => new (UtcMidnightToday(), default);
    
    public virtual DateTime UtcNow() => DateTime.UtcNow;
    
    public DateTimeOffset UtcNowOffset() => new (UtcNow(), default);
    
    public DateOnly UtcToday() => DateOnly.FromDateTime(UtcNow());
    
    public TimeOnly UtcTime() => TimeOnly.FromDateTime(UtcNow());
}
