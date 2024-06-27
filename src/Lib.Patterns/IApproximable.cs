namespace Semantica.Patterns;

/// <summary>
/// Provides functionality for types that represent values that can be approximately 
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IApproximable<in T>
{
    /// <summary>
    /// Determines if <paramref name="other"/> is approximate to <see langword="this"/>.
    /// </summary>
    /// <param name="other">Instance to compare this to.</param>
    /// <returns>True if the value of <see langword="this"/> is approximately the same as other's value</returns>
    bool IsApproximateTo(T other);
}
