using JetBrains.Annotations;
using Semantica.Checks;
using Semantica.Core;

namespace Semantica.Linq;

/// <summary>
/// Provides additional LINQ functionality for <see cref="IEnumerable{T}"/> collections.
/// </summary>
partial class EnumerableLinq
{
    /// <summary> Filters a sequence based on a predicate, if the specified condition is met. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to filter. </param>
    /// <param name="condition"> A value that determines whether the filter is applied. </param>
    /// <param name="predicate"> A function to test each element for a condition. </param>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IEnumerable{T}"/> that contains elements from
    /// the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalWhere<T>(this IEnumerable<T> source, bool condition, Func<T, bool> predicate)
    {
        return condition ? source.Where(predicate) : source;
    }

    /// <summary> Filters a sequence based on a predicate, if the specified condition is met. </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to filter. </param>
    /// <param name="predicate"> A function to test each element for a condition. </param>
    /// <returns>
    /// If <paramref name="predicate"/> is not <see langword="null"/>, an <see cref="IEnumerable{T}"/> that contains elements from
    /// the input sequence that satisfy the predicate; otherwise, returns the input sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalWhere<T>(this IEnumerable<T> source, Func<T, bool>? predicate)
    {
        return predicate != null ? source.Where(predicate) : source;
    }

    /// <summary> Filters elements that satisfy a predicate from the sequence. </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to filter. </param>
    /// <param name="predicate"> A function to test each element for a condition (or lack thereof). </param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains only elements from the input sequence that do not satisfy
    /// <paramref name="predicate"/>.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        return source.Where(element => !predicate(element));
    }

    /// <summary> Filters the default values from a sequence of values. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to filter. </param>
    /// <typeparam name="T"> The value type of elements of <paramref name="source"/>. </typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains elements from the input sequence that are not equal to
    /// <see langword="default"/>(<typeparamref name="T"/>).
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> WhereNotDefault<T>(this IEnumerable<T> source)
        where T: struct
    {
        var equalityComparer = EqualityComparer<T>.Default;
        var defaultValue = default(T);
        return source.Where(value => !equalityComparer.Equals(value, defaultValue));
    }

    /// <summary> Filters the specified items from the sequence. </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to return. </param>
    /// <param name="compareCollection"> A collection of items to filter from the input sequence. </param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains all elements from the input sequence that are not also in
    /// <paramref name="compareCollection"/>.
    /// </returns>
    /// <remarks>
    /// This method preserves duplicate values, unlike <see cref="Enumerable.Except{T}(IEnumerable{T}, IEnumerable{T})"/>, and
    /// leverages any existing collection.
    /// </remarks>
    [LinqTunnel]
    public static IEnumerable<T> WhereNotIn<T>(this IEnumerable<T> source, IReadOnlyCollection<T> compareCollection)
    {
        return source.Where(element => !compareCollection.Contains<T>(element));
    }

    /// <summary> Filters NUL (<c>\0</c>) characters from the sequence. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> of characters to filter. </param>
    /// <returns> An <see cref="IEnumerable{T}"/> that contains all non-NUL characters in the input sequence. </returns>
    [LinqTunnel]
    public static IEnumerable<char> WhereNotNul(this IEnumerable<char> source)
    {
        return source.Where(static element => element != Char.MinValue);
    }

    /// <summary> Filters <see langword="null"/> elements from a sequence of values. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> with the values to return. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns> An <see cref="IEnumerable{T}"/> that contains all non-null values from the input sequence. </returns>
    [LinqTunnel]
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source)
        where T: class
    {
        return source.Where(static element => element != null)
                         .Select(StaticSelectors.SelfNotNull);
    }

    /// <summary>
    /// Filters <see langword="null"/> elements from a sequence of values.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> with the values to return. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns> An <see cref="IEnumerable{T}"/> that contains all non-null values from the input sequence. </returns>
    [LinqTunnel]
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source)
        where T: struct
    {
        return source.Where(static element => element.HasValue)
                         .Select(StaticSelectors.SelfNotNull);
    }

    /// <summary>
    /// Filters <see langword="null"/> and empty strings from the sequence.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> with strings to return. </param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains all non-null and non-empty strings from the input sequence.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<string> WhereNotNullOrEmpty(this IEnumerable<string?> source)
    {
        return source.Where(static element => !String.IsNullOrEmpty(element))
                         .Select(StaticSelectors.SelfNotNull);
    }
}
