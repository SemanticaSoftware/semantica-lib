namespace Semantica.Extensions;

public static class DateOnlyExtensions
{
    /// <summary>
    /// Returns a new <see cref="DateOnly"/> representing the first day of the month and year that the input represents.
    /// Effectively an alias to <see cref="FloorToMonth"/>  
    /// </summary>
    /// <param name="date"> The <see cref="DateOnly"/> value to use the month and year from. </param>
    /// <returns> A <see cref="DateOnly"/> value that is always the first of the month. </returns>
    public static DateOnly FirstOfMonth(this DateOnly date)
        => new DateOnly(date.Year, date.Month, 1);
    
    /// <summary>
    /// Returns a new <see cref="DateOnly"/> representing the first day of the month and year that the input represents.  
    /// </summary>
    /// <param name="date"> The <see cref="DateOnly"/> value to use the month and year from. </param>
    /// <returns> A <see cref="DateOnly"/> value that is always the first of the month. </returns>
    public static DateOnly FloorToMonth(this DateOnly date)
        => new DateOnly(date.Year, date.Month, 1);

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateOnly"/> value. </param>
    /// <param name="right"> Right side <see cref="DateOnly"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateOnly left, DateOnly right)
        => left.Year == right.Year && left.Month == right.Month;

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateOnly"/> value. </param>
    /// <param name="right"> Right side <see cref="DateTimeOffset"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateOnly left, DateTimeOffset right)
        => left.Year == right.Year && left.Month == right.Month;

    /// <summary>
    /// Determines if the two input are within the same month and year.
    /// </summary>
    /// <param name="left"> Left side <see cref="DateOnly"/> value. </param>
    /// <param name="right"> Right side <see cref="DateTime"/> value. </param>
    /// <returns> <see langword="true"/> if the two compared values are within the same month and year. </returns>
    public static bool IsSameMonth(this DateOnly left, DateTime right)
        => left.Year == right.Year && left.Month == right.Month;
    
    /// <summary>
    /// Returns the the input as a <see cref="DateTime"/> value. The time part is set to midnight.
    /// </summary>
    /// <param name="dateOnly"> The <see cref="DateOnly"/> value to convert. </param>
    /// <returns> A <see cref="DateTime"/> value with the same value as the input. </returns>
    public static DateTime ToDateTime(this DateOnly dateOnly) => dateOnly.ToDateTime(TimeOnly.MinValue);
    
    /// <inheritdoc cref="ToDateTime(System.DateOnly)"/>
    public static DateTime? ToDateTime(this DateOnly? dateOnly)
        => dateOnly.HasValue ? dateOnly.Value.ToDateTime() : default(DateTime?);
}
