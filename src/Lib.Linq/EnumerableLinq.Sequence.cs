using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Semantica.Checks;
using Semantica.Core;

namespace Semantica.Linq;

/// <summary> Provides additional functionality to <see cref="IEnumerable{T}"/> collections. </summary>
public static partial class EnumerableLinq
{
    /// <summary> Appends one or multiple values to the end of a sequence. </summary>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> to append things to. </param>
    /// <param name="append"> An array of elements to append. </param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements in <paramref name="source"/> followed by those in
    /// <paramref name="append"/>.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> Append<T>(this IEnumerable<T> source, params T[] append)
    {
        foreach (var element in source)
        {
            yield return element;
        }

        foreach (var element in append)
        {
            yield return element;
        }
    }
    
    /// <summary> Concatenates two sequences if the second sequence is not <see langword="null"/>. </summary>
    /// <param name="enumerable"> The first sequence to concatenate. </param>
    /// <param name="second"> The sequence to concatenate to the first sequence, or <see langword="null"/>. </param>
    /// <typeparam name="T"> The type of elements in both sequences. </typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements of the two sequences, or the first sequence if
    /// <paramref name="second"/> is <see langword="null"/>.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConcatWhenNotNull<T>(this IEnumerable<T> enumerable, IEnumerable<T>? second)
    {
        Check.NotNull(enumerable).Contract();
        return second == null ? enumerable : enumerable.Concat(second);
    }

    /// <summary>Conditionally appends one or multiple values to the end of a sequence.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to append things to.</param>
    /// <param name="condition">If <see langword="false"/>, will just return <paramref name="source"/>.</param>
    /// <param name="append">An array of elements to append.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements in <paramref name="source"/> followed by those in
    /// <paramref name="append"/> if condition is <see langword="true"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalAppend<T>(this IEnumerable<T> source, bool condition, params T[] append)
    {
        return condition ? source.Append(append) : source;
    }

    /// <summary>Conditionally appends a value to the end of a sequence.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to append things to.</param>
    /// <param name="element">An element to append, or null.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements in <paramref name="source"/> followed by
    /// <paramref name="element"/> if not <see langword="null"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalAppend<T>(this IEnumerable<T> source, T? element)
        where T: class
    {
        return ReferenceEquals(element, null) ? source : source.Append(element);
    }

    /// <summary>Conditionally appends a value to the end of a sequence.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to append things to.</param>
    /// <param name="element">An element to append, or null.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements in <paramref name="source"/> followed by
    /// <paramref name="element"/> if not <see langword="null"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalAppend<T>(this IEnumerable<T> source, T? element)
        where T: struct
    {
        return element.HasValue ? source.Append(element.Value) : source;
    }

    /// <summary> Concatenates two sequences if the specified condition is met. </summary>
    /// <param name="source"> The first sequence to concatenate. </param>
    /// <param name="condition"> A value that determines whether the two sequences should be concatenated. </param>
    /// <param name="second"> The sequence to concatenate to the first sequence </param>
    /// <typeparam name="T"> The type of elements in both sequences. </typeparam>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IEnumerable{T}"/> that contains the elements
    /// of the two input sequences; otherwise, returns the first sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalConcat<T>(this IEnumerable<T> source, bool condition, IEnumerable<T>? second)
    {
        return condition && second != null ? source.Concat(second) : source;
    }

    /// <summary>
    /// Produces the set intersection of two sequences using the default equality comparer, if the specified condition is met.
    /// </summary>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> whose distinct elements that also appear in <paramref name="second"/> will be returned.
    /// </param>
    /// <param name="condition"> A value that determines whether the intersection of the two sequences is produced. </param>
    /// <param name="second">
    /// An <see cref="IEnumerable{T}"/> whose distinct elements that also appear in the first sequence will be returned.
    /// </param>
    /// <typeparam name="T"> The type of elements in both sequences. </typeparam>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IEnumerable{T}"/> that contains the distinct
    /// elements that appear in both sequences; otherwise, returns the first sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalIntersect<T>(this IEnumerable<T> source, bool condition, IEnumerable<T>? second)
        where T : struct
    {
        return condition && second != null ? source.Intersect(second) : source;
    }

    /// <summary>
    /// Produces the set intersection of two sequences using the specified <see cref="IEqualityComparer{T}"/>, if the specified
    /// condition is met.
    /// </summary>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> whose distinct elements that also appear in <paramref name="second"/> will be returned.
    /// </param>
    /// <param name="condition"> A value that determines whether the intersection of the two sequences is produced. </param>
    /// <param name="second">
    /// An <see cref="IEnumerable{T}"/> whose distinct elements that also appear in the first sequence will be returned.
    /// </param>
    /// <param name="equalityComparer"> An <see cref="IEqualityComparer{T}"/> used to compare values. </param>
    /// <typeparam name="T"> The type of elements in both sequences. </typeparam>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IEnumerable{T}"/> that contains the distinct
    /// elements that appear in both sequences; otherwise, returns the first sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalIntersect<T>(this IEnumerable<T> source,
        bool condition,
        IEnumerable<T>? second,
        IEqualityComparer<T> equalityComparer)
        where T : struct
    {
        return condition && second != null ? source.Intersect(second, equalityComparer) : source;
    }

    /// <summary>
    /// Produces the set intersection of two sequences according to a specified key selector function, if the specified
    /// condition is met.
    /// </summary>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> whose distinct elements that also appear in <paramref name="second"/> will be returned.
    /// </param>
    /// <param name="condition"> A value that determines whether the intersection of the two sequences is produced. </param>
    /// <param name="second">
    /// An <see cref="IEnumerable{T}"/> whose distinct elements that also appear in the first sequence will be returned.
    /// </param>
    /// <param name="keySelector"> A function to extract the key for each element in <paramref name="source"/>. </param>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TKey"> The type of elements in <paramref name="second"/>. </typeparam>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IEnumerable{T}"/> that contains the distinct
    /// elements that appear in both sequences; otherwise, returns the first sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<TSource> ConditionalIntersectBy<TSource, TKey>(this IEnumerable<TSource> source,
        bool condition,
        IEnumerable<TKey>? second,
        Func<TSource, TKey> keySelector)
    {
        return condition && second != null ? source.IntersectBy(second, keySelector) : source;
    }

    /// <summary>
    /// Produces the set intersection of two sequences according to a specified key selector function, if the specified
    /// condition is met.
    /// </summary>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> whose distinct elements that also appear in <paramref name="second"/> will be returned.
    /// </param>
    /// <param name="condition"> A value that determines whether the intersection of the two sequences is produced. </param>
    /// <param name="second">
    /// An <see cref="IEnumerable{T}"/> whose distinct elements that also appear in the first sequence will be returned.
    /// </param>
    /// <param name="keySelector"> A function to extract the key for each element in <paramref name="source"/>. </param>
    /// <param name="equalityComparer"> An <see cref="IEqualityComparer{T}"/> used to compare keys. </param>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TKey"> The type of elements in <paramref name="second"/>. </typeparam>
    /// <returns>
    /// If <paramref name="condition"/> is <see langword="true"/>, an <see cref="IEnumerable{T}"/> that contains the distinct
    /// elements that appear in both sequences; otherwise, returns the first sequence unchanged.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<TSource> ConditionalIntersectBy<TSource, TKey>(this IEnumerable<TSource> source,
        bool condition,
        IEnumerable<TKey>? second,
        Func<TSource, TKey> keySelector,
        IEqualityComparer<TKey> equalityComparer)
    {
        return condition && second != null ? source.IntersectBy(second, keySelector, equalityComparer) : source;
    }

    /// <summary>Conditionally prepends one or multiple values to the end of a sequence.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to prepend things to.</param>
    /// <param name="condition">If <see langword="false"/>, will just return <paramref name="source"/>.</param>
    /// <param name="prepend">An array of elements to prepend.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements in <paramref name="source"/> followed by those in
    /// <paramref name="prepend"/> if condition is <see langword="true"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalPrepend<T>(this IEnumerable<T> source, bool condition, params T[] prepend)
    {
        return condition ? source.Prepend(prepend) : source;
    }

    /// <summary>Conditionally prepends a value to the end of a sequence.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to prepend things to.</param>
    /// <param name="element">An element to prepend, or null.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements in <paramref name="source"/> followed by
    /// <paramref name="element"/> if not <see langword="null"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalPrepend<T>(this IEnumerable<T> source, T? element)
        where T: class
    {
        return ReferenceEquals(element, null) ? source : source.Prepend(element);
    }

    /// <summary>Conditionally prepends a value to the end of a sequence.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> to prepend things to.</param>
    /// <param name="element">An element to prepend, or null.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements in <paramref name="source"/> followed by
    /// <paramref name="element"/> if not <see langword="null"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalPrepend<T>(this IEnumerable<T> source, T? element)
        where T: struct
    {
        return element.HasValue ? source.Prepend(element.Value) : source;
    }
    
    /// <summary>
    /// Bypasses a specified number of elements in a sequence and then returns the remaining elements, if the specified
    /// condition is met.
    /// </summary>
    /// <param name="source">An <see cref="IEnumerable{T}"/>.</param>
    /// <param name="condition"></param>
    /// <param name="count">The number of elements to skip before returning the remaining elements.</param>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements that occur after the specified index in the input sequence,
    /// or <paramref name="source"/> if <paramref name="condition"/> is <see langword="false"/>.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalSkip<T>(this IEnumerable<T> source, bool condition, int count)
    {
        return condition ? source.Skip(count) : source;
    }
    
    /// <summary>
    /// Bypasses a specified number of elements in a sequence and then returns the remaining elements, if the specified
    /// count has a value.
    /// </summary>
    /// <param name="source">An <see cref="IEnumerable{T}"/>.</param>
    /// <param name="count">The number of elements to skip before returning the remaining elements, or <see langword="null"/>.</param>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements that occur after the specified index in the input sequence,
    /// or <paramref name="source"/> if count has no value.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalSkip<T>(this IEnumerable<T> source, int? count)
    {
        return count.HasValue ? source.Skip(count.Value) : source;
    }

    /// <summary>Conditionally produces the set union of two sequences by using the default equality comparer.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> whose distinct elements form the first set for the union.</param>
    /// <param name="condition">If <see langword="false"/>, will just return <paramref name="source"/>.</param>
    /// <param name="second">An <see cref="IEnumerable{T}"/> whose distinct elements form the second set for the union.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements from both input sequences, excluding duplicates, if
    /// condition is <see langword="true"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalUnion<T>(this IEnumerable<T> source, bool condition, IEnumerable<T> second)
    {
        return condition ? source.Union(second) : source;
    }

    /// <summary>
    /// Conditionally produces the set union of two sequences by using a specified <see cref="IEqualityComparer{TKey}"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> whose distinct elements form the first set for the union.</param>
    /// <param name="condition">If <see langword="false"/>, will just return <paramref name="source"/>.</param>
    /// <param name="second">An <see cref="IEnumerable{T}"/> whose distinct elements form the second set for the union.</param>
    /// <param name="comparer">The <see cref="IEqualityComparer{T}"/> to compare values.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements from both input sequences, excluding duplicates, if
    /// condition is <see langword="true"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalUnion<T>(
        this IEnumerable<T> source,
        bool condition,
        IEnumerable<T> second,
        IEqualityComparer<T> comparer)
    {
        return condition ? source.Union(second, comparer) : source;
    }

    /// <summary>Conditionally produces the set union of two sequences according to a specified key selector function.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <typeparam name="TKey">The type of key to identify elements by.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> whose distinct elements form the first set for the union.</param>
    /// <param name="condition">If <see langword="false"/>, will just return <paramref name="source"/>.</param>
    /// <param name="second">An <see cref="IEnumerable{T}"/> whose distinct elements form the second set for the union.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements from both input sequences, excluding duplicates, if
    /// condition is <see langword="true"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalUnionBy<T, TKey>(
        this IEnumerable<T> source,
        bool condition,
        IEnumerable<T> second,
        Func<T, TKey> keySelector)
    {
        return condition ? source.UnionBy(second, keySelector) : source;
    }

    /// <summary>Conditionally produces the set union of two sequences according to a specified key selector function.</summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <typeparam name="TKey">The type of key to identify elements by.</typeparam>
    /// <param name="source">An <see cref="IEnumerable{T}"/> whose distinct elements form the first set for the union.</param>
    /// <param name="condition">If <see langword="false"/>, will just return <paramref name="source"/>.</param>
    /// <param name="second">An <see cref="IEnumerable{T}"/> whose distinct elements form the second set for the union.</param>
    /// <param name="keySelector">A function to extract the key for each element.</param>
    /// <param name="comparer">The <see cref="IEqualityComparer{TKey}"/> to compare key values.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements from both input sequences, excluding duplicates, if
    /// condition is <see langword="true"/>; <paramref name="source"/> otherwise.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> ConditionalUnionBy<T, TKey>(
        this IEnumerable<T> source,
        bool condition,
        IEnumerable<T> second,
        Func<T, TKey> keySelector,
        IEqualityComparer<TKey> comparer)
    {
        return condition ? source.UnionBy(second, keySelector, comparer) : source;
    }
    
    /// <summary> Adds a value to the beginning of the sequence. </summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> that contains the elements to return after <paramref name="startItem"/>.
    /// </param>
    /// <param name="startItem"> The value to prepend to <paramref name="source"/>. </param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains <paramref name="startItem"/> followed by the input sequence.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> PrecedeBy<T>(this IEnumerable<T> source, T startItem)
    {
        yield return startItem;

        foreach (var element in source)
        {
            yield return element;
        }
    }

    /// <summary> Adds multiple values to the beginning of the sequence. </summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> that contains the elements to return after the elements in <paramref name="prepend"/>.
    /// </param>
    /// <param name="prepend"> An array of values to prepend to <paramref name="source"/>. </param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements in <paramref name="prepend"/> followed by the input sequence.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, params T[] prepend)
    {
        foreach (var element in prepend)
        {
            yield return element;
        }

        foreach (var element in source)
        {
            yield return element;
        }
    }
}
