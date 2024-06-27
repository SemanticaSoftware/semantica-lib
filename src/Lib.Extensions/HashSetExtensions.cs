namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for <see cref="HashSet{T}"/> objects.
/// </summary>
public static class HashSetExtensions
{
    /// <summary>
    /// Adds the specified items to the set.
    /// </summary>
    /// <typeparam name="T">The type of items in <paramref name="set"/>.</typeparam>
    /// <param name="set">The set to add items to.</param>
    /// <param name="itemsEnumerable">The items to add.</param>
    public static void AddRange<T>(this HashSet<T> set, IEnumerable<T> itemsEnumerable)
    {
        foreach (var item in itemsEnumerable)
        {
            set.Add(item);
        }
    }

    /// <summary>
    /// Adds the specified items to the set.
    /// </summary>
    /// <remarks>
    /// Items that already exist in <paramref name="set"/> are added to
    /// <paramref name="duplicates"/>.
    /// </remarks>
    /// <typeparam name="T">The type of items in <paramref name="set"/>.</typeparam>
    /// <param name="set">The set to add items to.</param>
    /// <param name="itemsEnumerable">The items to add.</param>
    /// <param name="duplicates">
    /// A collection to which duplicate items should be added.
    /// </param>
    public static void AddRange<T>(this HashSet<T> set, IEnumerable<T> itemsEnumerable, ICollection<T> duplicates)
    {
        foreach (var item in itemsEnumerable)
        {
            if (!set.Add(item))
            {
                duplicates.Add(item);
            }
        }
    }

    /// <summary>
    /// Returns elements of <paramref name="other"/> if they are also present in
    /// <paramref name="collection"/>
    /// </summary>
    public static IEnumerable<T> Intersect<T>(this HashSet<T> collection, IEnumerable<T> other)
    {
        return other.Where(collection.Contains);
    }

    /// <summary>
    /// Returns a new array containing the items in the set.
    /// </summary>
    /// <typeparam name="T">The type of elements in <paramref name="collection"/>.</typeparam>
    /// <param name="collection">The collection whose items to copy.</param>
    /// <returns>
    /// A new array of <typeparamref name="T"/> with the items from <paramref name="collection"/>.
    /// </returns>
    public static T[] ToArray<T>(this HashSet<T> collection)
    {
        var result = new T[collection.Count];
        collection.CopyTo(result);
        return result;
    }

    /// <summary>
    /// Returns a new array containing the items in the set, or <see
    /// langword="null"/> if the set is empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in <paramref name="collection"/>.</typeparam>
    /// <param name="collection">The collection whose items to copy.</param>
    /// <returns>
    /// A new array of <typeparamref name="T"/> with the items from <paramref
    /// name="collection"/>, or <see langword="null"/> if the set is empty.
    /// </returns>
    public static T[]? ToArrayOrNull<T>(this HashSet<T> collection)
    {
        if (collection.Count == 0)
        {
            return null;
        }
        return ToArray(collection);
    }

    /// <summary>
    /// Returns a new read-only collection of elements in the set.
    /// </summary>
    /// <typeparam name="T">The type of elements in <paramref name="collection"/>.</typeparam>
    /// <param name="collection">The collection whose items to copy.</param>
    /// <returns>
    /// A new <see cref="IReadOnlyList{T}"/> with the items from <paramref name="collection"/>.
    /// </returns>
    public static IReadOnlyList<T> ToReadOnlyList<T>(this HashSet<T> collection)
    {
        return ToArray(collection);
    }

    /// <summary>
    /// Returns a new read-only collection of elements in the set, or <see
    /// langword="null"/> if the set is empty.
    /// </summary>
    /// <typeparam name="T">The type of elements in <paramref name="collection"/>.</typeparam>
    /// <param name="collection">The collection whose items to copy.</param>
    /// <returns>
    /// A new <see cref="IReadOnlyList{T}"/> with the items from <paramref
    /// name="collection"/>, or <see langword="null"/> if the set is empty.
    /// </returns>
    public static IReadOnlyList<T>? ToReadOnlyListOrNull<T>(this HashSet<T> collection)
    {
        if (collection.Count == 0)
        {
            return null;
        }
        return ToArray(collection);
    }
}
