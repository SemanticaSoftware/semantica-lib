using Semantica.Checks;

namespace Semantica.Linq;

/// <summary>
/// Provides additional functionality for read-only lists.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static partial class ReadOnlyListLinq
{
    /// <summary>
    /// Determines whether all elements in the list are unique by comparing specific properties using the specified
    /// <see cref="IEqualityComparer{T}"/>.
    /// </summary>
    /// <param name="list"> The list whose uniqueness to determine. </param>
    /// <param name="propFunc"> A function to select the property whose values to compare. </param>
    /// <param name="equalityComparer"> An <see cref="IEqualityComparer{T}"/> used to compare values. </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    /// <typeparam name="TProp"> The type of property to compare. </typeparam>
    /// <returns>
    /// <see langword="true"/> if all elements in the list are unique according to <paramref name="propFunc"/> and
    /// <paramref name="equalityComparer"/>; <see langword="false"/> otherwise.
    /// </returns>
    public static bool AreDistinct<T, TProp>(this IReadOnlyList<T> list, Func<T, TProp> propFunc, IEqualityComparer<TProp> equalityComparer)
    {
        Check.NotNull(list).Contract();
        return list.Count == list.Select(propFunc).Distinct(equalityComparer).Count();
    }

    /// <summary>
    /// Determines whether all elements in the list are unique by comparing specific properties using the default equality
    /// comparer.
    /// </summary>
    /// <param name="list"> The list whose uniqueness to determine. </param>
    /// <param name="propFunc"> A function to select the property whose values to compare. </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    /// <typeparam name="TProp"> The type of property to compare. </typeparam>
    /// <returns>
    /// <see langword="true"/> if all elements in the list are unique according to <paramref name="propFunc"/>;
    /// <see langword="false"/> otherwise.
    /// </returns>
    public static bool AreDistinct<T, TProp>(this IReadOnlyList<T> list, Func<T, TProp> propFunc)
    {
        Check.NotNull(list).Contract();
        return list.AreDistinct(propFunc, EqualityComparer<TProp>.Default);
    }

    /// <summary>
    /// Determines whether all elements in the list are unique by comparing specific properties using the specified
    /// <see cref="IEqualityComparer{T}"/>. Default values are ignored.
    /// </summary>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    /// <typeparam name="TProp"> The type of property to compare. </typeparam>
    /// <param name="list"> The list whose uniqueness to determine. </param>
    /// <param name="propFunc"> A function to select the property whose values to compare. </param>
    /// <param name="equalityComparer"> An <see cref="IEqualityComparer{T}"/> used to compare values. </param>
    /// <returns>
    /// <see langword="true"/> if all elements with a non-default value in the list are unique according to
    /// <paramref name="propFunc"/> and <paramref name="equalityComparer"/>; <see langword="false"/> otherwise.
    /// </returns>
    public static bool AreDistinctOrDefault<T, TProp>(this IReadOnlyList<T> list, Func<T, TProp> propFunc, IEqualityComparer<TProp> equalityComparer)
    {
        Check.NotNull(list).Contract();
        Check.NotNull(propFunc).Contract();
        Check.NotNull(equalityComparer).Contract();        
        var nonDefaultList = list.Select(propFunc).Where(prop => !equalityComparer.Equals(prop, default(TProp))).ToList();
        return nonDefaultList.Count == nonDefaultList.Distinct(equalityComparer).Count();
    }

    /// <summary>
    /// Determines whether all elements in the list are unique by comparing specific properties using the default equality
    /// comparer. Default values are ignored.
    /// </summary>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    /// <typeparam name="TProp"> The type of property to compare. </typeparam>
    /// <param name="list"> The list whose uniqueness to determine. </param>
    /// <param name="propFunc"> A function to select the property whose values to compare. </param>
    /// <returns>
    /// <see langword="true"/> if all elements that have a non-default value in the list are unique according to
    /// <paramref name="propFunc"/>; <see langword="false"/> otherwise.
    /// </returns>
    public static bool AreDistinctOrDefault<T, TProp>(this IReadOnlyList<T> list, Func<T, TProp> propFunc)
    {
        return list.AreDistinctOrDefault(propFunc, EqualityComparer<TProp>.Default);
    }

    /// <summary> Concatenates two lists and returns the result as an array. </summary>
    /// <param name="list"> The first list to concatenate. </param>
    /// <param name="concatList"> The list to concatenate with the first list. </param>
    /// <typeparam name="T"> The type of elements in the input lists. </typeparam>
    /// <returns>
    /// A new array that contains the elements of <paramref name="list"/> followed by the elements from
    /// <paramref name="concatList"/>.
    /// </returns>
    public static T[] ConcatArray<T>([System.Diagnostics.CodeAnalysis.NotNull] this IReadOnlyList<T> list, IReadOnlyList<T> concatList)
    {
        Check.NotNull(list).Contract();
        Check.NotNull(concatList).Contract();
        var result = new T[list.Count + (concatList?.Count ?? 0)];
        list.CopyTo(result);
        concatList?.CopyTo(result, list.Count);
        return result;
    }
    
    /// <summary>
    /// Returns the element at a specified index in a sequence or a default value if the index is out of range.
    /// </summary>
    /// <typeparam name="T"> The type of the elements of <paramref name="source"/>. </typeparam>
    /// <param name="source"> The <see cref="IReadOnlyList{T}"/> to return the first element of. </param>
    /// <param name="index"> The index of the element to retrieve. </param>
    /// <returns>
    /// The element at the specified position in <paramref name="source"/>; or <see langword="default"/> if
    /// <paramref name="index"/> is outside the bounds of the <paramref name="source"/> sequence;
    /// </returns>
    public static T? ElementAtOrDefault<T>(this IReadOnlyList<T> source, int index)
    {
        Check.NotNull(source).Contract();
        return source.Count > index ? source[index] : default;
    }

    /// <summary> Invokes an action on each element in the list. </summary>
    /// <param name="list"> An <see cref="IReadOnlyList{T}"/> that contains the elements to invoke the action on. </param>
    /// <param name="action"> A delegate to invoke on each element in <paramref name="list"/>. </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    public static void ForEach<T>(this IReadOnlyList<T> list, Action<T> action)
    {
        Check.NotNull(list).Contract();
        Check.NotNull(action).Contract();
        for (var i = 0; i < list.Count; i++)
        {
            action(list[i]);
        }
    }

    /// <summary> Invokes an action on each element in the list and its index. </summary>
    /// <param name="list"> An <see cref="IReadOnlyList{T}"/> that contains the elements to invoke the action on. </param>
    /// <param name="action">
    /// A delegate to invoke on each element in <paramref name="list"/>. The second parameter contains the index of the
    /// corresponding element in the list.
    /// </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    public static void ForEach<T>(this IReadOnlyList<T> list, Action<T, int> action)
    {
        Check.NotNull(list).Contract();
        Check.NotNull(action).Contract();
        for (var i = 0; i < list.Count; i++)
        {
            action(list[i], i);
        }
    }

    /// <summary>
    /// Returns the element at the specified index in the list, or a default value if the index would be out of bounds.
    /// </summary>
    /// <param name="list"> An <see cref="IReadOnlyList{T}"/> that contains the element to retrieve. </param>
    /// <param name="index"> The zero-based index of the element to retrieve. </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    /// <returns>
    /// The element at the specified index, or a default value if the index is not valid for the <paramref name="list"/>.
    /// </returns>
    public static T? GetOrDefault<T>(this IReadOnlyList<T> list, int index)
    {
        Check.NotNull(list).Contract();
        Check.NotNegative(index).Contract();
        return index >= list.Count ? default(T) : list[index];
    }

    /// <summary> Indicates whether the input list is null or empty. </summary>
    /// <param name="list"> An <see cref="IReadOnlyList{T}"/> to check. </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    /// <returns>
    /// <see langword="true"/> if the list is <see langword="null"/> or contains no elements; <see langword="false"/> otherwise.
    /// </returns>
    public static bool IsNullOrEmpty<T>(this IReadOnlyList<T>? list)
    {
        return list == null || list.Count == 0;
    }

    /// <summary> Returns the list, or <see langword="null"/> if it does not contain any elements. </summary>
    /// <param name="list"> An <see cref="IReadOnlyList{T}"/> to return. </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    /// <returns>
    /// <paramref name="list"/>, or <see langword="null"/> if it is <see langword="null"/> or empty.
    /// </returns>
    public static IReadOnlyList<T>? NullIfEmpty<T>(this IReadOnlyList<T>? list)
    {
        return list == null || list.Count == 0 ? null : list;
    }

    public static IEnumerable<T> Reverse<T>(this IReadOnlyList<T> source)
    {
        Check.NotNull(source).Contract();
        for (var i = source.Count - 1; i >= 0; --i)
        {
            yield return source[i];
        }
    }

    /// <summary>
    /// Enumerates the elements in the list except for the specified number of elements at the end of the list.
    /// </summary>
    /// <param name="list"> An <see cref="IReadOnlyList{T}"/> to enumerate. </param>
    /// <param name="numOfElementsToSkip"> The number of elements at the end of the list to not enumerate. </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements from the input list but does not include the last
    /// <paramref name="numOfElementsToSkip"/> elements.
    /// </returns>
    public static IEnumerable<T> SkipLast<T>(this IReadOnlyList<T> list, int numOfElementsToSkip)
    {
        Check.NotNull(list).Contract();
        Check.NotNegative(numOfElementsToSkip).Contract();
        for (var i = 0; i < list.Count - numOfElementsToSkip; i++)
        {
            yield return list[i];
        }
    }
}
