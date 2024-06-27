namespace Semantica.Patterns;

/// <summary>
/// Provides additional functionality for types that implement <see cref="IDeterminable"/>.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static class DeterminableExtensions
{
    /// <summary>
    /// Returns the value as a <see cref="System.Nullable"/>, with the value <see langword="null"/> if <paramref name="value"/> is not determined. 
    /// </summary>
    /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
    /// <param name="value">The instance to be evaluated.</param>
    /// <returns><paramref name="value"/> as a <see cref="System.Nullable"/>, or <see langword="null"/> if <paramref name="value"/> is not determined.</returns>
    public static T? DeterminableToNullable<T>(this T value)
        where T : struct, IDeterminable
    {
        return value.IsDetermined ? value : default(T?);
    }
}
