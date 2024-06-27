using Semantica.Checks;

namespace Semantica.Types;

/// <summary>
/// Represents a difference between two dates, considering months and days separately.
/// </summary>
public readonly struct DateSpan : IEquatable<DateSpan>
#if NET7_0_OR_GREATER
    , IMinMaxValue<DateSpan>, IUnaryNegationOperators<DateSpan,DateSpan>
#endif
{
    private const uint _fromDifferenceMask = 0b1000_0000_0000_0000_0000_0000_0000_0000;
    private const uint _signMask           = 0b0100_0000_0000_0000_0000_0000_0000_0000;
    private const uint _daysMask           = 0b0000_0000_0000_0000_0000_0000_0001_1111;
    private const uint _monthsMask         = 0b0000_0000_0011_1111_1111_1111_1110_0000;
    private const uint _daysInvertedMask   = 0b0000_0111_1100_0000_0000_0000_0000_0000;
    private const uint _weekDaySignMask    = 0b0011_1000_0000_0000_0000_0000_0000_0000;

    private const uint _valueMask = _daysMask | _monthsMask;
    private const uint _equalityMask = _valueMask | _signMask;

    public const byte MaxDays = 30; //31 - 1
    public const uint MaxMonths = 9999u * MonthsPerYear - 1u; //DateTime max years diff is 9999 - 1, max month diff is 12 - 1
    public const byte MaxWeekdays = 6;
    internal const uint MonthsPerYear = 12u;
    private const int _daysShift = 0;
    private const int _monthsShift = 5;
    private const int _daysInvertedShift = 22;
    private const int _weekdaysShift = 27;

    /// <summary>
    /// Value holding the number of days (5 bits: 1-5), the total number of months (17 bits: 6-22) the amount of days till
    /// the end of the month in case of month-rollover (5 bits: 23-27), difference in weekday (3 bits: 28-30) and the sign
    /// (bit 31), and whether or not the span was constructed as a full difference (bit 32).
    /// </summary>
    private readonly uint _value; 
    
    internal DateSpan(uint months, byte days, bool isNegative, byte weekdayDifference, byte daysInverted)
    {
        _value = _fromDifferenceMask 
                 | (isNegative ? _signMask : 0)
                 | ((months << _monthsShift) & _monthsMask)
                 | (((uint)days << _daysShift) & _daysMask)
                 | (((uint)daysInverted << _daysInvertedShift) & _daysInvertedMask)
                 | (((uint)weekdayDifference << _weekdaysShift) & _weekDaySignMask);
    }
    
    internal DateSpan(uint months, byte days, bool isNegative)
    {
        _value = (isNegative ? _signMask : 0)
                 | ((months << _monthsShift) & _monthsMask)
                 | (((uint)days << _daysShift) & _daysMask);
    }
    
    private DateSpan(uint value)
    {
        _value = value;
    }

    public DateSpan Abs() => new DateSpan(_value & _valueMask);

    private int ApplySign(uint value) => IsNegative ? -(int)value : (int)value;
    private uint DaysValue() => (_value & _daysMask) >> _daysShift;
    private uint MonthsValue() => (_value & _monthsMask) >> _monthsShift;

    public int Days => ApplySign(DaysValue());

    public int Months => ApplySign(MonthsValue() % MonthsPerYear);

    public bool IsNegative => (_value & _signMask) != 0;

    public int TotalMonths => ApplySign(MonthsValue());

    public int Years => ApplySign(MonthsValue() / MonthsPerYear);

    public bool Equals(DateSpan other)
    {
        return (_value & _equalityMask) == (other._value & _equalityMask);
    }

    public override bool Equals(object? obj)
    {
        return obj is DateSpan other && Equals(other);
    }

    public override int GetHashCode()
    {
        return (int)(_value & _valueMask);
    }

    public override string ToString() => $"{(IsNegative ? "-" : "")}{TotalMonths} months, {Days} days";

    public static DateOnly operator+ (DateOnly date, DateSpan span)
    {
        return DateOnly.FromDateTime(date.ToDateTime(TimeOnly.MinValue) + span);
    }
    
    public static DateTime operator+ (DateTime date, DateSpan span)
    {
        return date.AddMonths(span.TotalMonths).AddDays(span.Days);
    }

    public static DateSpan operator -(DateSpan span) => new DateSpan((span._value ^ _signMask) & _equalityMask);

    public static DateOnly operator -(DateOnly date, DateSpan span) => date + (-span);

    public static DateTime operator -(DateTime date, DateSpan span) => date + (-span);

    public static DateSpan FromMonths(int value)
    {
        var isNegative = value < 0;
        var months = (uint)(isNegative ? -value : value);
        return new DateSpan(months, 0, isNegative);
    }

    public static DateSpan FromParts(int days, int months)
    {
        Guard.For(days == 0 || months == 0 
            ? Check.None
            : Check.AreEqual(days < 0, months < 0).Fails("If months is negative, days has to be as well"));
        Guard.For(Check.MaxValueAbs(days, MaxDays));
        Guard.For(Check.MaxValueAbs(months, (int)MaxMonths));
        return new DateSpan((uint)(Math.Abs(months)), (byte)(Math.Abs(days)), months < 0);
    }

    public static DateSpan FromParts(int days, int months, int years)
    {
        return FromParts(days, years * ((int)MonthsPerYear) + months);
    }

    public static DateSpan MinValue => new DateSpan(0);
    public static DateSpan MaxValue => new DateSpan(MaxMonths, MaxDays, false);
    public static DateSpan MaxValueNegative => new DateSpan(MaxMonths, MaxDays, true);
    public static bool operator ==(DateSpan left, DateSpan right) => left.Equals(right);
    public static bool operator !=(DateSpan left, DateSpan right) => !left.Equals(right);
}
