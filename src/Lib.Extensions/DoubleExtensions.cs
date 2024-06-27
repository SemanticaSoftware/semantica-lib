namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for double-precision floating-point numbers.
/// </summary>
public static class DoubleExtensions
{
    /// <summary>
    /// Returns the nearest integer that is greater than or equal to this
    /// <see langword="double"/>.
    /// </summary>
    /// <param name="value">The <see langword="double"/> to round up.</param>
    /// <returns>
    /// An integer whose value is greater than or equal to <paramref name="value"/>.
    /// </returns>
    public static int IntegerAbove(this double value)
    {
        return Convert.ToInt32(Math.Ceiling(value));
    }

    /// <summary>
    /// Returns the nearest integer that is less than or equal to this <see langword="double"/>.
    /// </summary>
    /// <param name="value">The <see langword="double"/> to round down.</param>
    /// <returns>
    /// An integer whose value is less than or equal to <paramref name="value"/>.
    /// </returns>
    public static int IntegerBelow(this double value)
    {
        return Convert.ToInt32(Math.Floor(value));
    }
}