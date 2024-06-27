using System.Diagnostics.Contracts;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for GUIDs.
/// </summary>
[Pure]
public static class GuidExtensions
{
    /// <summary>
    /// Determines whether the specified GUID is the empty GUID.
    /// </summary>
    /// <param name="guid">The GUID to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="guid"/> is the empty GUID;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsEmpty(this Guid guid)
    {
        return Guid.Empty.Equals(guid);
    }
    
    /// <summary>
    /// Converts a regular <see cref="Guid"/> into a <see cref="Nullable{T}"/>. <see cref="Guid.Empty"/> will be interpreted
    /// as no value.
    /// </summary>
    /// <param name="guid">The guid to convert.</param>
    /// <returns> A <see cref="Nullable{T}"/> of <see cref="Guid"/>. </returns>
    public static Guid? NullOnEmpty(this Guid guid)
    {
        return guid == Guid.Empty ? default(Guid?) : guid;
    }
}
