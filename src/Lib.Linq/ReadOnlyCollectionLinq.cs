using System.Diagnostics.CodeAnalysis;
using Semantica.Checks;

namespace Semantica.Linq;

/// <summary> Provides additional functionality for collections. </summary>
[System.Diagnostics.Contracts.Pure]
public static class ReadOnlyCollectionLinq
{
    /// <summary> Determines whether a collection contains any elements. </summary>
    /// <param name="source"> The collection to evaluate. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns> <see langword="true"/> if input contains any elements; <see langword="false"/> otherwise. </returns>
    public static bool Any<T>(this IReadOnlyCollection<T> source)
    {
        Check.NotNull(source).Contract();
        return source.Count != 0;
    }

    /// <summary> Determines whether the collection is <see langword="null"/> or empty. </summary>
    /// <param name="source"> The collection to check.</param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// <see langword="true"/> if input is <see langword="null"/> or does not contain any items; <see langword="false"/>
    /// otherwise.
    /// </returns>
    public static bool IsNullOrEmpty<T>([NotNullWhen(returnValue: false)] this IReadOnlyCollection<T>? source)
    {
        return source == null || source.Count == 0;
    }

    /// <summary> Returns the collection, or <see langword="null"/> if it is empty. </summary>
    /// <param name="source"> The collection to return. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <returns> <see langword="null"/> if input contains no items; otherwise the input is returned unchanged. </returns>
    public static IReadOnlyCollection<T>? NullIfEmpty<T>(this IReadOnlyCollection<T>? source)
    {
        return source == null || source.Count == 0 ? null : source;
    }

    /// <summary> Converts the collection to an array using the specified transformation function. </summary>
    /// <param name="source"> The collection to convert. </param>
    /// <param name="transformFunc">
    /// A function that selects the items to be returned in the converted array based on each element in
    /// <paramref name="source"/>.
    /// </param>
    /// <typeparam name="TIn"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of elements in the array to be returned. </typeparam>
    /// <returns> A new array with the elements of the input passed through the transformation function. </returns>
    public static TOut[] SelectArray<TIn, TOut>(this IReadOnlyCollection<TIn> source, Func<TIn, TOut> transformFunc)
    {
        return source.SelectArray(source.Count, transformFunc);
    }

    /// <summary> Converts the collection to an array using the specified transformation function. </summary>
    /// <param name="source">The collection to convert.</param>
    /// <param name="transformFunc">
    /// A function that selects the items to be returned in the converted array based on each element in
    /// <paramref name="source"/> and its zero-based index in the new array.
    /// </param>
    /// <typeparam name="TIn"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of elements in the array to be returned. </typeparam>
    /// <returns> A new array with the elements of the input passed through a transformation function. </returns>
    [System.Diagnostics.Contracts.Pure]
    public static TOut[] SelectArray<TIn, TOut>(this IReadOnlyCollection<TIn> source, Func<TIn, int, TOut> transformFunc)
    {
        return source.SelectArray(source.Count, transformFunc);
    }

    /// <summary>
    /// Eagerly enumerates <paramref name="source"/> and applies <paramref name="transformFunc"/> but skips the last
    /// <paramref name="count"/> elements. Returns an array of type <typeparamref name="TOut"/>.
    /// </summary>
    /// <param name="source"> Collection to enumerate. </param>
    /// <param name="transformFunc"> Transformation function applied to elements of <paramref name="source"/>. </param>
    /// <param name="count"> Amount of elements to skip at end. </param>
    /// <typeparam name="TIn"> Type of the elements of <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> Type of the elements of the returned array. </typeparam>
    /// <returns>
    /// array of type <typeparamref name="TOut"/> of length <paramref name="source"/>.Count - <paramref name="count"/>
    /// </returns>
    public static TOut[] SelectArraySkipLast<TIn, TOut>(
        this IReadOnlyCollection<TIn> source,
        Func<TIn, TOut> transformFunc,
        int count = 1)
    {
        return source.SkipLast(count).SelectArray(source.Count - count, transformFunc);
    }
}