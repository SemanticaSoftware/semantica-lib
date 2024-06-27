namespace Semantica.Collections;

public static class CollectionExtensions
{
    public static MappedReadOnlyList<TIn, TOut> SelectMapped<TIn, TOut>(this IReadOnlyList<TIn> sourceList, Func<TIn, TOut> transformFunc)
    {
        return new MappedReadOnlyList<TIn, TOut>(sourceList, transformFunc);
    }

    public static IRetrievalCollection<T> ToRetrievalCollection<T>(this IEnumerable<T> enumerable)
    {
        return new RetrievalCollection<T>(enumerable);
    }

    /// <summary>
    ///     Zet de enumerable om in een <see cref="ArrayDictionary{TKey,TValue}" />.
    ///     Duplicate keys worden niet verworpen, en niet geretourneerd.
    /// </summary>
    /// <typeparam name="TKey">The type of the dictionary's keys.</typeparam>
    /// <typeparam name="TValue">The type of the dictionary's values. The generic type of the elements of the enumerable.</typeparam>
    /// <param name="enumerable">An enumerable of type <typeparamref name="TValue">TValue</typeparamref></param>
    /// <param name="keyFunc">
    ///     Function that can retrieve a <typeparamref name="TKey">key</typeparamref> from an
    ///     <typeparamref name="TValue">element</typeparamref>
    /// </param>
    /// <returns>An ArrayDictionary implementation of an IReadOnlyDictionary</returns>
    public static IReadOnlyDictionary<TKey, TValue> ToArrayDictionary<TKey, TValue>(
            this IEnumerable<TValue> enumerable,
            Func<TValue, TKey> keyFunc)
        where TKey : IEquatable<TKey>
    {
        var keyValuePairs = enumerable.Select(item => new KeyValuePair<TKey, TValue>(keyFunc(item), item));
        return new ArrayDictionary<TKey, TValue>(keyValuePairs);
    }

    /// <summary>
    ///     Zet de enumerable om in een ArrayDictionary<see cref="ArrayDictionary{TKey,TValue}" />
    ///     Duplicate keys worden niet verworpen, en niet geretourneerd.
    /// </summary>
    /// <typeparam name="TIn">The generic type of the elements of the enumerable.</typeparam>
    /// <typeparam name="TKey">The type of the dictionary's keys.</typeparam>
    /// <typeparam name="TValue">The type of the dictionary's values.</typeparam>
    /// <param name="enumerable">An enumerable of type <typeparamref name="TIn" />TIn</param>
    /// <param name="keyFunc">
    ///     Function that can retrieve a <typeparamref name="TKey">key</typeparamref> from an
    ///     <typeparamref name="TIn">element</typeparamref>
    /// </param>
    /// <param name="valueFunc">
    ///     Function that can retrieve a <typeparamref name="TValue">value</typeparamref> from an
    ///     <typeparamref name="TIn">element</typeparamref>
    /// </param>
    /// <returns>An ArrayDictionary implementation of an IReadOnlyDictionary</returns>
    public static IReadOnlyDictionary<TKey, TValue> ToArrayDictionary<TIn, TKey, TValue>(
            this IEnumerable<TIn> enumerable,
            Func<TIn, TKey> keyFunc,
            Func<TIn, TValue> valueFunc)
        where TKey : IEquatable<TKey>
    {
        var keyValuePairs = enumerable.Select(item => new KeyValuePair<TKey, TValue>(keyFunc(item), valueFunc(item)));
        return new ArrayDictionary<TKey, TValue>(keyValuePairs);
    }
}
