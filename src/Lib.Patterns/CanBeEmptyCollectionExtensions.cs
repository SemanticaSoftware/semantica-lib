using JetBrains.Annotations;

namespace Semantica.Patterns;

/// <summary>
/// Provides additional functionality for collections of <see cref="ICanBeEmpty"/> elements.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static class CanBeEmptyCollectionExtensions
{

    /// <summary>
    /// Returns the first non-empty element in the enumeration.
    /// </summary>
    /// <typeparam name="T">The type of elements in <paramref name="enumerable"/>.</typeparam>
    /// <param name="enumerable">An <see cref="IEnumerable{T}"/> of elements that implements <see cref="ICanBeEmpty"/>.</param>
    /// <returns>A non-empty element from the enumeration, or default if there is no non-empty element.</returns>
    public static T? FirstNonEmpty<T>(this IEnumerable<T> enumerable)
        where T : ICanBeEmpty
    {
        return enumerable.FirstOrDefault(static element => ! element.IsEmpty());
    }

    /// <summary>
    /// Retrieves the value for any non-empty key in a dictionary, or the default of <typeparamref name="TValue"/> if the key is empty.
    /// </summary>
    /// <param name="dictionary">A <see cref="IReadOnlyDictionary{TKey,TValue}"/> to perform the lookup in.</param>
    /// <param name="key">The key to search for.</param>
    /// <typeparam name="TKey">The type of keys in the read-only dictionary that implement <see cref="ICanBeEmpty"/>.</typeparam>
    /// <typeparam name="TValue">The type of values in the read-only dictionary.</typeparam>
    /// <returns>The value corresponding to <paramref name="key"/>, or default of the key is empty.</returns>
    /// <exception cref="KeyNotFoundException">When a non-empty <paramref name="key"/> cannot be found in the dictionary.</exception>
    public static TValue? GetValue<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dictionary, TKey key)
        where TKey : ICanBeEmpty
    {
        if (key.IsEmpty())
        {
            return default(TValue);
        }
        if (dictionary.TryGetValue(key, out var obj))
        {
            return obj;
        }
        throw new KeyNotFoundException($"Expected key [{key}] not found in dictionary.");
    }

    /// <summary>
    /// Yields all non-empty elements in the enumeration.
    /// </summary>
    /// <typeparam name="T">The type of elements in <paramref name="enumerable"/>.</typeparam>
    /// <param name="enumerable">An <see cref="IEnumerable{T}"/> of elements that implement <see cref="ICanBeEmpty"/>.</param>
    /// <returns>A <see cref="IEnumerable{T}"/> what yields only the non-empty elements from <paramref name="enumerable"/>.</returns>
    [LinqTunnel]
    public static IEnumerable<T> WhereNotEmpty<T>(this IEnumerable<T> enumerable)
        where T : ICanBeEmpty
    {
        return enumerable.Where(static element => ! element.IsEmpty());
    }
}
