namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for dictionary types.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static class DictionaryExtensions
{
    /// <summary>
    /// Returns the value that is associated with the specified key.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    /// <param name="dict">The dictionary to search.</param>
    /// <param name="key">The key to find.</param>
    /// <returns>
    /// The value associated with the specified key, or a default value if the
    /// dictionary does not contain the specified key.
    /// </returns>
    public static TValue? GetValueOrNull<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> dict, TKey key)
        where TValue : struct
    {
        return dict.TryGetValue(key, out var obj) ? obj : default(TValue?);
    }
}
