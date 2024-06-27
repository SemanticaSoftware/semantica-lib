namespace Semantica.Patterns;

/// <summary>
/// A struct or class can implement <see cref="ICanSerialize"/> when it can be serialized to a string without losing any relevant information.
/// </summary>
public interface ICanSerialize
{
    /// <summary>
    /// Serializes the instance to a <see langword="string"/>.
    /// </summary>
    /// <returns>Een string-representation of the instance.</returns>
    [System.Diagnostics.Contracts.Pure]
    string Serialize();
}
