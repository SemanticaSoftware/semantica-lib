namespace Semantica.Core;

/// <summary>
/// Contains many useful constants used in date/time calculations, that are private in <see cref="DateTime"/>. 
/// </summary>
public static class DateTimeConstants
{
        ///<value>Number of 100ns ticks per millisecond</value>
        public const long TicksPerMillisecond = 10000;
        ///<value>Number of 100ns ticks per second</value>
        public const long TicksPerSecond = TicksPerMillisecond * 1000;
        ///<value>Number of 100ns ticks per minute</value>
        public const long TicksPerMinute = TicksPerSecond * 60;
        ///<value>Number of 100ns ticks per hour</value>
        public const long TicksPerHour = TicksPerMinute * 60;
        ///<value>Number of 100ns ticks per day</value>
        public const long TicksPerDay = TicksPerHour * 24;

        ///<value>Number of milliseconds per second</value>
        public const int MillisPerSecond = 1000;
        ///<value>Number of milliseconds per minute</value>
        public const int MillisPerMinute = MillisPerSecond * 60;
        ///<value>Number of milliseconds per hour</value>
        public const int MillisPerHour = MillisPerMinute * 60;
        ///<value>Number of milliseconds per day</value>
        public const int MillisPerDay = MillisPerHour * 24;

        ///<value>Number of days in a non-leap year</value>
        public const int DaysPerYear = 365;
        ///<value>Number of days in 4 years</value>
        public const int DaysPer4Years = DaysPerYear * 4 + 1;       // 1461
        ///<value>Number of days in 100 years</value>
        public const int DaysPer100Years = DaysPer4Years * 25 - 1;  // 36524
        ///<value>Number of days in 400 years</value>
        public const int DaysPer400Years = DaysPer100Years * 4 + 1; // 146097

        ///<value>Number of days in a year before the month with index</value>
        public static readonly uint[] DaysToMonth365 = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365 };
        ///<value>Number of days in a leap year before the month with index</value>
        public static readonly uint[] DaysToMonth366 = { 0, 31, 60, 91, 121, 152, 182, 213, 244, 274, 305, 335, 366 };

        ///<value>Number of days in the month with index</value>
        public static ReadOnlySpan<byte> DaysInMonth365 => new byte[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        ///<value>Number of days in the month with index in a leap year</value>
        public static ReadOnlySpan<byte> DaysInMonth366 => new byte[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        /// <summary>
        /// Returns the number of days in the month represented by that <paramref name="month"/> and <paramref name="year"/>.
        /// </summary>
        /// <returns> A <see langword="byte"/> value between 28 and 31. </returns>
        public static byte GetDaysInMonth(int year, int month) 
            => DateTime.IsLeapYear(year) ? DaysInMonth366[month] : DaysInMonth365[month];

        /// <summary>
        /// Returns the number of days in the month that <paramref name="date"/> is in.
        /// </summary>
        /// <returns> A <see langword="byte"/> value between 28 and 31. </returns>
        public static byte GetDaysInMonth(DateOnly date) => GetDaysInMonth(date.Year, date.Month);
        /// <inheritdoc cref="GetDaysInMonth(DateOnly)"/>>
        public static byte GetDaysInMonth(DateTime date) => GetDaysInMonth(date.Year, date.Month);
        
        /// <summary>
        /// Returns the monthnumber of the month that follows <paramref name="month"/>. If the input value is invalid, the
        /// output is invalid too. 
        /// </summary>
        /// <param name="month"> A month number (1-12). </param>
        /// <returns> A month number (1-12). </returns>
        public static int MonthNumberAfter(int month) => (month += 1) == 13 ? 1 : month;
        /// <summary>
        /// Returns the monthnumber of the month that precedes <paramref name="month"/>. If the input value is invalid, the
        /// output is invalid too. 
        /// </summary>
        /// <param name="month"> A month number (1-12). </param>
        /// <returns> A month number (1-12). </returns>
        public static int MonthNumberBefore(int month) => (month -= 1) == 0 ? 12 : month;
}
