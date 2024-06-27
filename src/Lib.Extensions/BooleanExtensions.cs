using System.Diagnostics.Contracts;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for Boolean values.
/// </summary>
[Pure]
public static class BooleanExtensions
{
    /// <summary>
    /// Determines whether the Boolean value is <see langword="false"/> but not
    /// <see langword="null"/>.
    /// </summary>
    /// <param name="nullableBln">The nullable Boolean value to check.</param>
    /// <returns>
    /// <see langword="true"/> if the Boolean value is <see langword="false"/>;
    /// if the Boolean value is <see langword="true"/> or <see
    /// langword="null"/>, returns <see langword="false"/>.
    /// </returns>
    public static bool IsExplicitFalse(this bool? nullableBln)
    {
        return nullableBln.HasValue && !nullableBln.Value;
    }
}
