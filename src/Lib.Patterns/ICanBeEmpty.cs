namespace Semantica.Patterns;

/// <summary>
/// A struct or class can implement <see cref="ICanBeEmpty"/> when there is some (inescapable) default value that can be thought of as empty.  
/// </summary>
public interface ICanBeEmpty
{
    /// <summary>
    /// Determines whether the object is empty.
    /// </summary>
    /// <returns><see langword="true"/> if the represented value is empty (or default); otherwise, <see langword="false"/>.</returns>
    /// <example>
    /// In most cases, the following implementation should suffice:
    /// <code>=> Equals(default(T))</code>
    /// </example>
    [System.Diagnostics.Contracts.Pure]
    bool IsEmpty();
}