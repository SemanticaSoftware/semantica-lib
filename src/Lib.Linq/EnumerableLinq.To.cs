using JetBrains.Annotations;

namespace Semantica.Linq;

partial class EnumerableLinq
{
    /// <summary> Creates an array from the sequence and returns a value indicating whether it contains any items. </summary>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to convert.</param>
    /// <param name="array"> When this method returns, contains an array with the elements from the input sequence. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="array"/> contains at least one element; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool AnyToArray<T>(this IEnumerable<T> source, out T[] array)
    {
        array = source.ToArray();
        return array.Length > 0;
    }

    /// <summary>
    /// Creates a <see cref="List{T}"/> from the sequence and returns a value indicating whether it contains any items.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to convert. </param>
    /// <param name="list">
    /// When this method returns, contain a new <see cref="List{T}"/> with the elements from the input sequence.
    /// </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="list"/> contains at least one element; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool AnyToList<T>(this IEnumerable<T> source, out List<T> list)
    {
        list = source.ToList();
        return list.Count > 0;
    }

    /// <summary>
    /// Creates an <see cref="IReadOnlyList{T}"/> from the sequence and returns a value indicating whether it contains any items.
    /// </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to convert. </param>
    /// <param name="list">
    /// When this method returns, contain an <see cref="IReadOnlyList{T}"/> with the elements from the input sequence.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="list"/> contains at least one element; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool AnyToReadOnlyList<T>(this IEnumerable<T> source, out IReadOnlyList<T> list)
    {
        list = source.ToReadOnlyList();
        return list.Count > 0;
    }

    /// <summary> Creates an array with the specified length from the sequence. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to convert. </param>
    /// <param name="length"> The size of the new array. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns> A new array with <paramref name="length"/> items taken from <paramref name="source"/>. </returns>
    /// <remarks>
    /// If the input sequence contains fewer items than <paramref name="length"/>, the remaining elements in the array are
    /// padded with default values.
    /// </remarks>
    public static T?[] ToArray<T>(this IEnumerable<T> source, int length)
    {
        var result = new T?[length];
        using (var enumerator = source.GetEnumerator())
        {
            for (var i = 0; i < length; i++)
            {
                var hasElements = enumerator.MoveNext();
                if (hasElements)
                {
                    result[i] = enumerator.Current;
                }
                else
                {
                    result[i] = default(T);
                }
            }
        }

        return result;
    }

    /// <summary> Creates an array with the specified length from the sequence. </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to convert. </param>
    /// <param name="length"> The size of the new array. </param>
    /// <param name="defaultValue">
    /// The value pad the the array with when the sequence contains fewer than <paramref name="length"/> items.
    /// </param>
    /// <returns> A new array with <paramref name="length"/> items taken from <paramref name="source"/>. </returns>
    /// <remarks>
    /// If the input sequence contains fewer items than <paramref name="length"/>, the remaining elements in the array are
    /// padded with <paramref name="defaultValue"/>.
    /// </remarks>
    public static T[] ToArray<T>(this IEnumerable<T> source, int length, T defaultValue)
    {
        var result = new T[length];
        using (var enumerator = source.GetEnumerator())
        {
            for (var i = 0; i < length; i++)
            {
                var hasElements = enumerator.MoveNext();
                if (hasElements)
                {
                    result[i] = enumerator.Current;
                }
                else
                {
                    result[i] = defaultValue;
                }
            }
        }

        return result;
    }

    /// <summary> Creates an array from the sequence only if it contains any elements. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to convert. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// A new array containing elements from the input sequence, or <see langword="null"/> if the input sequence is empty.
    /// </returns>
    public static T[]? ToArrayOrNull<T>(this IEnumerable<T> source)
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return null;
            }

            var list = new List<T>() { enumerator.Current };
            while (enumerator.MoveNext())
            {
                list.Add(enumerator.Current);
            }

            return list.ToArray();
        }
    }

    /// <summary> Creates a <see cref="List{T}"/> from the sequence only if it contains any elements. </summary>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to convert.</param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// A new <see cref="List{T}"/> containing elements from the input sequence, or <see langword="null"/> if the input sequence
    /// is empty.
    /// </returns>
    public static List<T>? ToListOrNull<T>(this IEnumerable<T> source)
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return null;
            }

            var list = new List<T>() { enumerator.Current };
            while (enumerator.MoveNext())
            {
                list.Add(enumerator.Current);
            }

            return list;
        }
    }

    /// <summary> Creates a <see cref="IReadOnlyList{T}"/> from the sequence only if it contains any elements. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to convert. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// A new <see cref="IReadOnlyList{T}"/> containing elements from the input sequence, or <see langword="null"/> if the input
    /// sequence is empty.
    /// </returns>
    public static IReadOnlyList<T>? ToReadOnlyListOrNull<T>(this IEnumerable<T> source)
    {
        return source.ToListOrNull();
    }

    /// <summary>
    /// Creates a <see cref="IReadOnlyDictionary{TKey, TValue}"/> from an <see cref="IEnumerable{T}"/> according to specified
    /// key selector and element selector functions.
    /// </summary>
    /// <param name="enumerable">
    /// An <see cref="IEnumerable{T}"/> to create a <see cref="IReadOnlyDictionary{TKey, TValue}"/> from.
    /// </param>
    /// <param name="keySelector"> A function to extract a key from each element. </param>
    /// <param name="elementSelector"> A transform function to produce a result element value from each element. </param>
    /// <typeparam name="T"> The type of the elements of <paramref name="enumerable"/>. </typeparam>
    /// <typeparam name="TKey"> The type of the key returned by <paramref name="keySelector"/>. </typeparam>
    /// <typeparam name="TElement"> The type of the value returned by <paramref name="elementSelector"/>. </typeparam>
    /// <returns>
    /// A <see cref="IReadOnlyDictionary{TKey, TValue}"/> that contains values of type <typeparamref name="TElement"/> selected
    /// from the input sequence.
    /// </returns>
    public static IReadOnlyDictionary<TKey, TElement> ToReadOnlyDictionary<T, TKey, TElement>(this IEnumerable<T> enumerable,
        [InstantHandle] Func<T, TKey> keySelector, [InstantHandle] Func<T, TElement> elementSelector)
        where TKey : notnull
    {
        return enumerable.ToDictionary(keySelector, elementSelector);
    }

    /// <summary> Creates a <see cref="IReadOnlyList{T}"/> from the sequence. </summary>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to convert.</param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns> A <see cref="IReadOnlyList{T}"/> that contains elements from the input sequence. </returns>
    public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> source)
    {
        switch (source)
        {
            case IReadOnlyList<T> list:
                return list.ToReadOnlyList();
            default:
                return source.ToList();
        }
    }

    /// <summary> Creates a <see cref="IReadOnlyList{T}"/> with the specified amount of items from the sequence. </summary>
    /// <remarks>
    /// If the input sequence contains fewer items than <paramref name="length"/>, the resulting list will be padded with nulls
    /// or default values.
    /// </remarks>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to convert. </param>
    /// <param name="length"> The size of the read-only list to create. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// A <see cref="IReadOnlyList{T}"/> that contains exactly <paramref name="length"/> elements from the input sequence.
    /// </returns>
    public static IReadOnlyList<T?> ToReadOnlyList<T>(this IEnumerable<T> source, int length)
    {
        return source.ToArray(length);
    }

    /// <summary>
    /// Creates a <see cref="IReadOnlyList{T}"/> with the specified amount of items from the sequence.
    /// </summary>
    /// <remarks>
    /// If the input sequence contains fewer items than <paramref name="length"/>, the resulting list will be padded with
    /// <paramref name="defaultValue"/>.
    /// </remarks>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to convert. </param>
    /// <param name="length"> The size of the read-only list to create. </param>
    /// <param name="defaultValue">
    /// The value pad the the output with when the sequence contains fewer than <paramref name="length"/> items.
    /// </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// A <see cref="IReadOnlyList{T}"/> that contains exactly <paramref name="length"/> elements from the input sequence.
    /// </returns>
    public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> source, int length, T defaultValue)
    {
        return source.ToArray(length, defaultValue);
    }
}
