namespace Semantica.Lib.Tests.Core.Test._SomeData;

public static class SomeTimeSpan
{
    public const int Days = 11;
    public const int Hours = 22;
    public const int Minutes = 33;
    public const int Seconds = 44;
    public const int Milliseconds = 555;
    public const int Microseconds = 666;

    public static TimeSpan Create() => new TimeSpan(Days, Hours, Minutes, Seconds, Milliseconds, Microseconds);
}
