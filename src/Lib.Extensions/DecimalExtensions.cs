namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for decimal numbers.
/// </summary>
public static class DecimalExtensions
{
    /// <summary>
    /// Returns the nearest integer that is greater than or equal to this
    /// decimal number.
    /// </summary>
    /// <param name="value">The decimal number to round up.</param>
    /// <returns>
    /// An integer whose value is greater than or equal to <paramref name="value"/>.
    /// </returns>
    public static int IntegerAbove(this decimal value)
    {
        return Convert.ToInt32(Math.Ceiling(value));
    }

    /// <summary>
    /// Returns the nearest integer that is less than or equal to this
    /// decimal number.
    /// </summary>
    /// <param name="value">The decimal number to round down.</param>
    /// <returns>
    /// An integer whose value is less than or equal to <paramref name="value"/>.
    /// </returns>
    public static int IntegerBelow(this decimal value)
    {
        return Convert.ToInt32(Math.Floor(value));
    }
}