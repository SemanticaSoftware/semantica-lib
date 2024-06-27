using JetBrains.Annotations;
using Semantica.Core;

namespace Semantica.Linq;

/// <summary>
/// Provides additional projection functionality for <see cref="IEnumerable{T}"/> collections.
/// </summary>
partial class EnumerableLinq
{
    /// <summary>
    /// Overload of Select that expects a transformation function <paramref name="selectFunc"/> with two additional boolean
    /// parameters: The first boolean will be set to true if the transformed item is the first item in the source. The
    /// second boolean will be set to true if the transformed item is the last item in the source.
    /// </summary>
    /// <param name="source"> An enumeration of items of type <typeparamref name="TSource"/>. </param>
    /// <param name="selectFunc"> A transformation function that creates elements of type <typeparamref name="TOut"/>. </param>
    /// <typeparam name="TSource"> Input element type. </typeparam>
    /// <typeparam name="TOut"> Output element type. </typeparam>
    /// <returns> An enumeration of items of type <typeparamref name="TOut"/>. </returns>
    [LinqTunnel]
    public static IEnumerable<TOut> Select<TSource, TOut>(
            this IEnumerable<TSource> source,
            Func<TSource, bool, bool, TOut> selectFunc
        )
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                yield break;
            }

            var current = enumerator.Current;
            var hasNext = enumerator.MoveNext();
            yield return selectFunc(current, true, !hasNext);

            while (hasNext)
            {
                current = enumerator.Current;
                hasNext = enumerator.MoveNext();
                yield return selectFunc(current, false, !hasNext);
            }
        }
    }

    /// <summary>
    /// Projects each element of a sequence into a new form, with an additional parameter to be passed to the transform
    /// function.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to transform. </param>
    /// <param name="transformFunc">
    /// A transform function to apply to each source element; the second parameter of the function is <paramref name="param"/>.
    /// </param>
    /// <param name="param">A value that is passed to <paramref name="transformFunc"/>.</param>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of values returned by <paramref name="transformFunc"/>. </typeparam>
    /// <typeparam name="TParam"> The type of parameter passed to <paramref name="transformFunc"/>. </typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> whose elements are the result of invoking the transform function on each element of the
    /// input sequence.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<TOut> SelectAndPass<TSource, TOut, TParam>(this IEnumerable<TSource> source,
        Func<TSource, TParam, TOut> transformFunc, TParam param)
    {
        return source.Select(element => transformFunc(element, param));
    }

    /// <summary>
    /// Projects each element of a sequence into a new form, with two additional parameters to be passed to the transform
    /// function.
    /// </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to transform. </param>
    /// <param name="selectFunc">
    /// A transform function to apply to each source element; the second and third parameters of the function are
    /// <paramref name="param1"/> and <paramref name="param2"/>, respectively.
    /// </param>
    /// <param name="param1">A value that is passed to <paramref name="selectFunc"/>.</param>
    /// <param name="param2">A second value that is passed to <paramref name="selectFunc"/>.</param>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of values returned by <paramref name="selectFunc"/>. </typeparam>
    /// <typeparam name="TParam1"> The type of first parameter passed to <paramref name="selectFunc"/>. </typeparam>
    /// <typeparam name="TParam2"> The type of the second parameter passed to <paramref name="selectFunc"/>. </typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> whose elements are the result of invoking the transform function on each element of the
    /// input sequence.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<TOut> SelectAndPass<TSource, TOut, TParam1, TParam2>(this IEnumerable<TSource> source,
        Func<TSource, TParam1, TParam2, TOut> selectFunc, TParam1 param1, TParam2 param2)
    {
        return source.Select(element => selectFunc(element, param1, param2));
    }

    /// <summary>
    /// Returns a new array with the specified number of items from the sequence, and applies a transformation function to each
    /// item.
    /// </summary>
    /// <param name="source"> The sequence to source elements from. </param>
    /// <param name="length"> The size of the new array. </param>
    /// <param name="selectFunc"> A function that selects the items to be returned in the new array based on each element in
    /// <paramref name="source"/>.
    /// </param>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of elements in the array to be returned. </typeparam>
    /// <returns>
    /// A new array with up to <paramref name="length"/> elements from <paramref name="source"/> after applying a
    /// transformation function.
    /// </returns>
    public static TOut[] SelectArray<TSource, TOut>([InstantHandle] this IEnumerable<TSource> source,
        int length, [InstantHandle] Func<TSource, TOut> selectFunc)
    {
        var result = new TOut[length];
        var i = 0;
        foreach (var elm in source)
        {
            result[i] = selectFunc(elm);
            ++i;
            if (i > length)
            {
                break;
            }
        }

        return result;
    }

    /// <summary>
    /// Returns a new array with the specified number of items from the sequence, and applies a transformation function to each
    /// item.
    /// </summary>
    /// <param name="source"> The sequence to source elements from. </param>
    /// <param name="length"> The size of the created array. </param>
    /// <param name="selectFunc">
    /// A function that selects the items to be returned in the new array based on each element in <paramref name="source"/>
    /// and its zero-based index in the new array.
    /// </param>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of elements in the array to be returned. </typeparam>
    /// <returns>
    /// A new array with up to <paramref name="length"/> elements from <paramref name="source"/> after applying a
    /// transformation function.
    /// </returns>
    public static TOut[] SelectArray<TSource, TOut>([InstantHandle] this IEnumerable<TSource> source, 
        int length, [InstantHandle] Func<TSource, int, TOut> selectFunc)
    {
        var result = new TOut[length];
        var i = 0;
        foreach (var elm in source)
        {
            result[i] = selectFunc(elm, i);
            ++i;
            if (i > length)
            {
                break;
            }
        }

        return result;
    }

    /// <summary>
    /// Returns a new array with the specified number of items from the sequence, and applies a transformation function to each
    /// item.
    /// </summary>
    /// <param name="source"> The sequence to source elements from. </param>
    /// <param name="length"> The size of the new array. </param>
    /// <param name="selectFunc">
    /// A function that selects the items to be returned in the new array based on each element in <paramref name="source"/>.
    /// The second parameter is <paramref name="param"/>.
    /// </param>
    /// <param name="param"> A value passed to <paramref name="selectFunc"/>. </param>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of elements in the array to be returned. </typeparam>
    /// <typeparam name="TParam"> The type of value to be passed along to <paramref name="selectFunc"/>. </typeparam>
    /// <returns>
    /// A new array with up to <paramref name="length"/> elements from <paramref name="source"/> after applying a
    /// transformation function.
    /// </returns>
    public static TOut[] SelectArrayAndPass<TSource, TParam, TOut>([InstantHandle] this IEnumerable<TSource> source, 
        int length, [InstantHandle] Func<TSource, TParam, TOut> selectFunc, TParam param)
    {
        var result = new TOut[length];
        var i = 0;
        foreach (var elm in source)
        {
            result[i] = selectFunc(elm, param);
            ++i;
            if (i > length)
            {
                break;
            }
        }

        return result;
    }
    
    /// <summary> Projects each element of a sequence into a key/value pair based on the specified dictionary. </summary>
    /// <remarks>
    /// Elements from <paramref name="source"/> that are not found in <paramref name="dict"/> will not be returned.
    /// </remarks>
    /// <param name="source"> The collection to transform. </param>
    /// <param name="keyFunc">
    /// A function to select matching dictionary keys from items in <paramref name="source"/>.
    /// </param>
    /// <param name="dict"> The dictionary whose values to use in the projected sequence. </param>
    /// <typeparam name="TObj"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TKey"> The type of keys in <paramref name="dict"/>. </typeparam>
    /// <typeparam name="TValue"> The type of values in <paramref name="dict"/>. </typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of key/value pairs with values from <paramref name="dict"/> based on the
    /// <paramref name="keyFunc"/>.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<KeyValuePair<TObj, TValue>> SelectIfDictionaryContains<TObj, TKey, TValue>(
        this IEnumerable<TObj> source,
        Func<TObj, TKey> keyFunc,
        IReadOnlyDictionary<TKey, TValue> dict)
    {
        using (var enumerator = source.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                if (dict.TryGetValue(keyFunc(enumerator.Current), out var value))
                {
                    yield return new KeyValuePair<TObj, TValue>(enumerator.Current, value);
                }
            }
        }
    }

    /// <summary> Projects each element of a sequence into a key/value pair based on the specified dictionary. </summary>
    /// <remarks>
    /// Elements from <paramref name="enumerable"/> that are not found in <paramref name="dict"/> will not be returned.
    /// </remarks>
    /// <param name="enumerable"> The collection to transform. </param>
    /// <param name="dict"> The dictionary whose values to use in the projected sequence. </param>
    /// <typeparam name="TKey"> The type of keys in <paramref name="dict"/>. </typeparam>
    /// <typeparam name="TValue"> The type of values in <paramref name="dict"/>. </typeparam>
    /// <returns> An <see cref="IEnumerable{T}"/> of key/value pairs with values from <paramref name="dict"/>. </returns>
    [LinqTunnel]
    public static IEnumerable<KeyValuePair<TKey, TValue>> SelectIfDictionaryContains<TKey, TValue>(
        this IEnumerable<TKey> enumerable,
        IReadOnlyDictionary<TKey, TValue> dict)
    {
        using (var enumerator = enumerable.GetEnumerator())
        {
            while (enumerator.MoveNext())
            {
                if (dict.TryGetValue(enumerator.Current!, out var value))
                {
                    yield return new KeyValuePair<TKey, TValue>(enumerator.Current, value);
                }
            }
        }
    }

    /// <summary> Flattens the sequences into a single sequence. </summary>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> that contains the <see cref="IEnumerable{T}"/> objects to flatten.
    /// </param>
    /// <typeparam name="T"> The type of elements in each sequence in <paramref name="source"/>. </typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains the elements from each sequence in <paramref name="source"/>.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<T> SelectMany<T>(this IEnumerable<IEnumerable<T>> source)
    {
        return source.SelectMany(StaticSelectors.Self<IEnumerable<T>>);
    }

    /// <summary> Flattens the sequences into a single sequence. </summary>
    /// <param name="enumerable"> An <see cref="IEnumerable{T}"/> that contains sequences to flatten. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="enumerable"/>. </typeparam>
    /// <typeparam name="TSourcener"> The type of elements in <typeparamref name="T"/>. </typeparam>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> that contains tuples where the second item is each element in the flattened list, and
    /// the first item is the list that contained it.
    /// </returns>
    [LinqTunnel]
    public static IEnumerable<(T, TSourcener)> SelectManyTuples<T, TSourcener>(this IEnumerable<T> enumerable)
        where T : IEnumerable<TSourcener>
    {
        return enumerable.SelectMany(static element => element.Select(innerElement => (element, innerElement)));
    }

    /// <summary>
    /// A Select-variant that expects a transformation function <paramref name="combineWithContext"/> that accepts three input
    /// items. The transformation will be called with each element as the second parameter, the previous element as the first
    /// parameter, and the next element in the enumeration as the third parameter. Then the enumeration reaches the last
    /// element, the transformation is called with default( <typeparamref name="TSource"/>) as second parameter.
    /// </summary>
    /// <param name="source"> An enumeration of items of type <typeparamref name="TSource"/>. </param>
    /// <param name="combineWithContext">
    /// A transformation function that creates elements of type <typeparamref name="TOut"/>.
    /// </param>
    /// <typeparam name="TSource"> Input element type. </typeparam>
    /// <typeparam name="TOut"> Output element type. </typeparam>
    /// <returns> An enumeration of items of type <typeparamref name="TOut"/>. </returns>
    [LinqTunnel]
    public static IEnumerable<TOut> SelectWithContext<TSource, TOut>(
            this IEnumerable<TSource> source,
            Func<TSource?, TSource, TSource?, TOut> combineWithContext
        )
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                yield break;
            }

            var previous = default(TSource);
            var current = enumerator.Current;
            while (enumerator.MoveNext())
            {
                var next = enumerator.Current;
                yield return combineWithContext(previous, current, next);

                previous = current;
                current = next;
            }

            yield return combineWithContext(previous, current, default);
        }
    }

    /// <summary>
    /// A Select-variant that expects a transformation function <paramref name="combineWithNextFunc"/> that accepts two input
    /// items. The transformation will be called with each element as the first parameter, and the next element in the
    /// enumeration as the second parameter. Then the enumeration reaches the last element, the transformation is called
    /// with default( <typeparamref name="TSource"/>) as second parameter.
    /// </summary>
    /// <param name="source"> An enumeration of items of type <typeparamref name="TSource"/>. </param>
    /// <param name="combineWithNextFunc">
    /// A transformation function that creates elements of type <typeparamref name="TOut"/>.
    /// </param>
    /// <typeparam name="TSource"> Input element type. </typeparam>
    /// <typeparam name="TOut"> Output element type. </typeparam>
    /// <returns> An enumeration of items of type <typeparamref name="TOut"/>. </returns>
    [LinqTunnel]
    public static IEnumerable<TOut> SelectWithNext<TSource, TOut>(
            this IEnumerable<TSource> source,
            Func<TSource, TSource?, TOut> combineWithNextFunc
        )
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                yield break;
            }

            var current = enumerator.Current;
            while (enumerator.MoveNext())
            {
                var next = enumerator.Current;
                yield return combineWithNextFunc(current, next);

                current = next;
            }

            yield return combineWithNextFunc(current, default);
        }
    }

    /// <summary>
    /// A Select-variant that expects a transformation function <paramref name="combineWithNextFunc"/> that accepts two input
    /// items. The transformation will be called with each element as the first parameter, and the next element in the
    /// enumeration as the second parameter. Then the enumeration reaches the last element, the transformation is called with
    /// default( <typeparamref name="TSource"/>) as second parameter.
    /// </summary>
    /// <param name="source"> An enumeration of items of type <typeparamref name="TSource"/>. </param>
    /// <param name="combineWithNextFunc">
    /// A transformation function that creates elements of type <typeparamref name="TOut"/>.
    /// </param>
    /// <param name="skipLast"> When true, the enumeration will skipped for the last element. </param>
    /// <typeparam name="TSource"> Input element type. </typeparam>
    /// <typeparam name="TOut"> Output element type. </typeparam>
    /// <returns> An enumeration of items of type <typeparamref name="TOut"/>. </returns>
    [LinqTunnel]
    public static IEnumerable<TOut> SelectWithNext<TSource, TOut>(
            this IEnumerable<TSource> source,
            Func<TSource, TSource?, TOut> combineWithNextFunc,
            bool skipLast
        )
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                while (enumerator.MoveNext())
                {
                    var next = enumerator.Current;
                    yield return combineWithNextFunc(current, next);

                    current = next;
                }

                if (!skipLast)
                {
                    yield return combineWithNextFunc(current, default);
                }
            }
        }
    }

    /// <summary>
    /// A Select-variant that expects a transformation function <paramref name="combineWithPreviousFunc"/> that accepts two
    /// input items. The transformation will be called with each element as the first parameter, and the previous element in
    /// the enumeration as the second parameter. For the first element in the enumeration the transformation is called with
    /// default( <typeparamref name="TSource"/>) as second parameter.
    /// </summary>
    /// <param name="source"> An enumeration of items of type <typeparamref name="TSource"/>. </param>
    /// <param name="combineWithPreviousFunc">
    /// A transformation function that creates elements of type <typeparamref name="TOut"/>.
    /// </param>
    /// <typeparam name="TSource"> Input element type. </typeparam>
    /// <typeparam name="TOut"> Output element type. </typeparam>
    /// <returns> An enumeration of items of type <typeparamref name="TOut"/>. </returns>
    [LinqTunnel]
    public static IEnumerable<TOut> SelectWithPrevious<TSource, TOut>(
            this IEnumerable<TSource> source,
            Func<TSource, TSource?, TOut> combineWithPreviousFunc
        )
    {
        using (var enumerator = source.GetEnumerator())
        {
            TSource? previous = default;
            while (enumerator.MoveNext())
            {
                yield return combineWithPreviousFunc(enumerator.Current, previous);

                previous = enumerator.Current;
            }
        }
    }
}
