using JetBrains.Annotations;

namespace Semantica.Patterns;

/// <summary>
/// Provides additional functionality for collections of <see cref="IDeterminable"/> elements.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static class DeterminableCollectionExtensions
{
    /// <summary>
    /// yields all determined elements in the enumeration.
    /// </summary>
    /// <param name="enumerable">An <see cref="IEnumerable{T}"/> of elements that implement <see cref="IDeterminable"/>. </param>
    /// <returns>Only detemined elements from <paramref name="enumerable"/></returns>
    [LinqTunnel]
    public static IEnumerable<T> WhereDetermined<T>(this IEnumerable<T> enumerable)
        where T : IDeterminable
    {
        return enumerable.Where(static element => element.IsDetermined);
    }
}
