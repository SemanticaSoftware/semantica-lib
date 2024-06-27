using System.ComponentModel;
using System.Diagnostics;
using Semantica.Patterns;

namespace Semantica.Types;

/// <summary>
/// Represents a date. Each part of the date is optional and can be empty (0). No validation is done on the values, but each part has a maximum amount of digits and cannot be negative. 
/// </summary>
/// <remarks>
/// The value is only considered empty if all three parts are empty.
/// </remarks>
[DebuggerDisplay(@"PartitionDate:{ToString()}")]
public readonly struct PartitionDate : ICanBeEmpty
{
    private const uint c_dayMask = 0x0000_00FF;
    private const uint c_monthMask = 0x0000_FF00;
    private const uint c_yearMask = 0xFFFF_0000;
    private const int c_yearShift = 16;
    private const int c_monthShift = 8;
    public const byte DayMax = 99;
    public const byte MonthMax = 99;
    public const short YearMax = 9999;
    public const short YearMin = -9999;

    private readonly uint _value;
    
    /// <exception cref="InvalidCastException">
    /// throws if <paramref name="year"/> cannot be cast to <see langword="ushort"/>, or <paramref name="month"/>, <paramref name="day"/> cannot be cast to <see langword="byte"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// throws if <paramref name="year"/> is greater than <see name="YearMax"/>, <paramref name="month"/> is greater than <see name="MonthMax"/>,
    /// <paramref name="day"/> is greater than <see name="DayMax"/>.
    /// </exception>
    /// <param name="year">A positive year value smaller or equal to <see cref="YearMax"/>.</param>
    /// <param name="month">A positive month value smaller than <see cref="MonthMax"/>.</param>
    /// <param name="day">A positive day value smaller than <see cref="DayMax"/>.</param>
    public PartitionDate(int year = 0, int month = 0, int day = 0)
        : this((short) year, (byte) month, (byte) day)
    {
    }
    
    /// <exception cref="ArgumentException">
    /// throws if <paramref name="year"/> is greater than <see name="YearMax"/>, <paramref name="month"/> is greater than <see name="MonthMax"/>,
    /// <paramref name="day"/> is greater than <see name="DayMax"/>.
    /// </exception>
    /// <param name="year">A year value smaller or equal to <see cref="YearMax"/>.</param>
    /// <param name="month">A month value smaller than <see cref="MonthMax"/>.</param>
    /// <param name="day">A day value smaller than <see cref="DayMax"/>.</param>
    public PartitionDate(short year = 0, byte month = 0, byte day = 0)
        :this(year, month, day, true) 
    {
        if (day > DayMax) throw new ArgumentException($"Value {day} is larger than {nameof(DayMax)} ({DayMax})", nameof(day));
        if (month > MonthMax) throw new ArgumentException($"Value {month} is larger than {nameof(MonthMax)} ({MonthMax})", nameof(month));
        if (year > YearMax) throw new ArgumentException($"Value {year} is larger than {nameof(YearMax)} ({YearMax})", nameof(year));
    }

    public PartitionDate(DateTime dateTime)
        : this((short)dateTime.Year, (byte)dateTime.Month, (byte)dateTime.Day, true)
    {
    }

    private PartitionDate(short year, byte month, byte day, bool _)
    {
        var shiftedYear = ((uint)year) << c_yearShift;
        var shiftedMonth = ((uint)month) << c_monthShift;
        _value = shiftedYear + shiftedMonth + day;
    }

    private PartitionDate(uint value)
    {
        _value = value;
    }
    
    /// <value>The year-part of the date, or 0.</value>
    public short Year { get => (short)((_value & c_yearMask) >> c_yearShift); }
    
    /// <value>The month-part of the date, or 0.</value>
    public byte Month { get => (byte)((_value & c_monthMask) >> c_monthShift); }
    
    /// <value>The day-part of the date, or 0.</value>
    public byte Day { get => (byte)(_value & c_dayMask); }

    /// <value>The year-part of the date, or 0.</value>
    public int GetYear() => Year;

    /// <value>The month-part of the date, or 0.</value>
    public int GetMonth() => Month;

    /// <value>The day-part of the date, or 0.</value>
    public int GetDay() => Day;

    /// <returns><see langword="true"/> if the year-part of the date is not 0.</returns>
    public bool HasYear() => (_value & c_yearMask) != 0;
    
    /// <returns><see langword="true"/> if the month-part of the date is not 0.</returns>
    public bool HasMonth() => (_value & c_monthMask) != 0;

    /// <returns><see langword="true"/> if the day-part of the date is not 0.</returns>
    public bool HasDay() => (_value & c_dayMask) != 0;

    public bool IsEmpty() => _value == 0;

    public bool Equals(PartitionDate other)
    {
        return _value == other._value;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) { return false; }

        return obj is PartitionDate date && Equals(date);
    }

    public override int GetHashCode() => _value.GetHashCode();

    public string ToHumanCalendar()
    {
        return string.Format(@"{0}-{1}-{2}", 
            HasYear() ? (Year + 10000).ToString("D5") : "?", 
            HasMonth() ? Month.ToString("D2") : "?",
            HasDay() ? Day.ToString("D2") : "?");
    }

    public override string ToString()
    {
        return string.Format(@"{0}{3}-{1}-{2}", 
            HasYear() ? Math.Abs(Year).ToString("D4") : "?", 
            HasMonth() ? Month.ToString("D2") : "?",
            HasDay() ? Day.ToString("D2") : "?",
            HasYear() && Year < 0 ? " B.C." : string.Empty);
    }

    public static bool operator==(PartitionDate left, PartitionDate right) => left.Equals(right);

    public static bool operator!=(PartitionDate left, PartitionDate right) => !left.Equals(right);

    public static PartitionDate MakeSafe(short year, byte month, byte day)
    {
        return year is >= YearMin and <= YearMax && month <= MonthMax && day <= DayMax
            ? new PartitionDate(year, month, day, true)
            : default;
    }
}
