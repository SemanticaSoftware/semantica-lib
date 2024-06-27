using Semantica.Checks;

namespace Semantica.Linq;

partial class ReadOnlyListLinq
{
    /// <summary> Returns the first element of a list. </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to return the first element of. </param>
    /// <returns> The first element in <paramref name="source"/>. </returns>
    /// <exception cref="IndexOutOfRangeException"><paramref name="source"/> has no elements. </exception>
    public static T First<T>(this IReadOnlyList<T> source)
    {
        Check.NotNull(source).Contract();
        return source[0];
    }

    /// <summary>
    /// Returns the index of the first occurrence of a given value in the source. The list is searched forwards, and the
    /// elements are compared to the given value using the default <see cref="EqualityComparer{T}"/>.
    /// </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to search in. </param>
    /// <param name="element"> The element to find. </param>
    /// <returns>
    /// The zero-based index of the <paramref name="element"/> in <paramref name="source"/>; or -1 if not found.
    /// </returns>
    public static int IndexOf<T>(this IReadOnlyList<T> source, T element)
    {
        return IndexOf(source, element, 0);
    }

    /// <summary>
    /// Returns the index of the first occurrence of a given value in the source. The list is searched forwards, and the
    /// elements are compared to the given value using the default <see cref="EqualityComparer{T}"/>.
    /// </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to search in. </param>
    /// <param name="element"> The element to find. </param>
    /// <param name="startIndex"> Elements up to this index are skipped when starting the search. </param>
    /// <returns>
    /// The zero-based index of the <paramref name="element"/> in <paramref name="source"/>; or -1 if not found.
    /// </returns>
    public static int IndexOf<T>(this IReadOnlyList<T> source, T element, int startIndex)
    {
        Check.NotNull(source).Contract();
        var comparer = EqualityComparer<T>.Default;
        for (var i = startIndex; i < source.Count; i++)
        {
            if (comparer.Equals(source[i], element))
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// Returns the index of the first occurrence of a value satisfying <paramref name="predicate"/> in the source. The list is
    /// searched forwards.
    /// </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to search in. </param>
    /// <param name="predicate"> The predicate function used to evaluate elements. </param>
    /// <returns>
    /// The zero-based index of the first element that satisfies the predicate in <paramref name="source"/>; or -1 if none
    /// are found.
    /// </returns>
    public static int IndexOf<T>(this IReadOnlyList<T> source, Func<T, bool> predicate)
    {
        return IndexOf(source, predicate, 0);
    }

    /// <summary>
    /// Returns the index of the first occurrence of a value satisfying <paramref name="predicate"/> in the source. The list is
    /// searched forwards.
    /// </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to search in. </param>
    /// <param name="predicate"> The predicate function used to evaluate elements. </param>
    /// <param name="startIndex"> Elements up to this index are skipped when starting the search. </param>
    /// <returns>
    /// The zero-based index of the first element that satisfies the predicate in <paramref name="source"/>; or -1 if none
    /// are found.
    /// </returns>
    public static int IndexOf<T>(this IReadOnlyList<T> source, Func<T, bool> predicate, int startIndex)
    {
        Check.NotNull(source).Contract();
        Check.NotNull(predicate).Contract();
        for (var i = startIndex; i < source.Count; i++)
        {
            if (predicate(source[i]))
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary> Returns the last element of a list. </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to return the last element of. </param>
    /// <returns> The last element in <paramref name="source"/>. </returns>
    /// <exception cref="IndexOutOfRangeException"><paramref name="source"/> has no elements. </exception>
    public static T Last<T>(this IReadOnlyList<T> source)
    {
        Check.NotNull(source).Contract();
        return source[^1];
    }

    /// <summary>
    /// Returns the index of the last occurrence of a value satisfying <paramref name="predicate"/> in the source. The list is
    /// searched from back to front.
    /// </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to search in. </param>
    /// <param name="predicate"> The predicate function used to evaluate elements. </param>
    /// <returns>
    /// The zero-based index of the last element that satisfies the predicate in <paramref name="source"/>; or -1 if none
    /// are found.
    /// </returns>
    public static int LastIndexOf<T>(this IReadOnlyList<T> source, Func<T, bool> predicate)
    {
        return LastIndexOf(source, predicate, source.Count - 1);
    }

    /// <summary>
    /// Returns the index of the last occurrence of a value satisfying <paramref name="predicate"/> in the source. The list is
    /// searched from back to front.
    /// </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to search in. </param>
    /// <param name="predicate"> The predicate function used to evaluate elements. </param>
    /// <param name="startIndex"> Elements beyond this index are skipped when starting the search. </param>
    /// <returns>
    /// The zero-based index of the last element that satisfies the predicate in <paramref name="source"/>; or -1 if none
    /// are found.
    /// </returns>
    public static int LastIndexOf<T>(this IReadOnlyList<T> source, Func<T, bool> predicate, int startIndex)
    {
        Check.NotNull(source).Contract();
        for (var i = startIndex; i >= 0; i--)
        {
            if (predicate(source[i])) return i;
        }

        return -1;
    }
}
