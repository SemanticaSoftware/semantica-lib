namespace Semantica.Linq;

/// <summary>
/// Provides additional functionality for read-only dictionaries.
/// </summary>
public static class ReadOnlyDictionaryLinq
{
    /// <summary> Determines whether the read-only dictionary is <see langword="null"/> or empty. </summary>
    /// <param name="readOnlyDictionary"> The collection to check. </param>
    /// <typeparam name="TKey"> The type of keys in <paramref name="readOnlyDictionary"/>. </typeparam>
    /// <typeparam name="TValue"> The type of value in <paramref name="readOnlyDictionary"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="readOnlyDictionary"/> is <see langword="null"/> or does not contain any items;
    /// <see langword="false"/> otherwise.
    /// </returns>
    public static bool IsNullOrEmpty<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue>? readOnlyDictionary)
    {
        return readOnlyDictionary == null || readOnlyDictionary.Count == 0;
    }
}
