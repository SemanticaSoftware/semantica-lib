using System.Diagnostics.CodeAnalysis;

namespace Semantica.Linq;

/// <summary>
/// Provides additional functionality for enumerators.
/// </summary>
public static class EnumeratorExtensions
{
    /// <summary> Attemps to advance the enumerator to the next element in the collection. </summary>
    /// <typeparam name="T"> The type of elements in the collection. </typeparam>
    /// <param name="enumerator"> An <see cref="IEnumerator{T}"/>. </param>
    /// <param name="element">
    /// When this method returns <see langword="true"/>, contains the element at the new position in the collection.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the enumerator was successfully advanced to the next element; <see langword="false"/> if the
    /// enumerator has passed the end of the collection.
    /// </returns>
    public static bool TryMoveNext<T>(this IEnumerator<T> enumerator, [NotNullWhen(returnValue: true)] out T? element)
    {
        if (enumerator.MoveNext())
        {
            element = enumerator.Current!;
            return true;
        }
        element = default;
        return false;
    }
}