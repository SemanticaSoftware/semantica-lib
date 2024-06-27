namespace Semantica.Patterns;

/// <summary>
/// A struct or class can implement <see cref="IDeterminable"/> when it has no clear undetermined state, but there is need for one.
/// This can be particularly useful for value types when an explicit undetermined state is more clear than or functionally useful besides having a <see cref="System.Nullable"/> or <see langword="null"/> value.   
/// </summary>
public interface IDeterminable
{
    /// <summary>
    /// Indicates whether the instance's value has been determined.
    /// </summary>
    bool IsDetermined { get; }
}
