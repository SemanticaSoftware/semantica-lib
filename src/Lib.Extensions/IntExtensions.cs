using System.Diagnostics.Contracts;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for integers.
/// </summary>
[Pure]
public static class IntExtensions
{
    /// <summary>
    /// Divides the number by another integer and returns the result rounded
    /// up towards the nearest integer.
    /// </summary>
    /// <param name="divident">The number to divide.</param>
    /// <param name="divisor">The number to divide by.</param>
    /// <returns>
    /// The result of the division rounded up towards the nearest integer.
    /// </returns>
    public static int DivideRoundingUp(this int divident, int divisor)
    {
        return (divident + divisor - 1) / divisor;
    }
    
    /// <summary>
    /// Returns the positive remainder of a division.
    /// </summary>
    /// <param name="numerator">The number to divide.</param>
    /// <param name="denominator">The number to divide by.</param>
    /// <returns>
    /// The remainder of the division. This value is made positive, even if
    /// <paramref name="numerator"/> is negative.
    /// </returns>
    public static int Modulo(this int numerator, int denominator)
    {
        var remainder = numerator % denominator;
        return remainder < 0 ? (remainder + denominator) : remainder;
    }

    /// <summary>
    /// Determines whether the integer is a power of two.
    /// </summary>
    /// <param name="value">The integer to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="value"/> is a power of two;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsPowerOfTwo(this int value)
    {
        return value > 0 && (value & (value - 1)) == 0;
    }
}
