using System.Threading.Tasks;

namespace Semantica.Linq;

partial class ReadOnlyListLinq
{
    /// <summary> Projects each element in the list into a new form and returns the results as an array. </summary>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of element returned by <paramref name="selectFunc"/>. </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="selectFunc"> A transform function to apply to each source element. </param>
    /// <returns>
    /// A new array containing the elements from the input list transformed by <paramref name="selectFunc"/>.
    /// </returns>
    public static TOut[] SelectArray<TSource, TOut>(this IReadOnlyList<TSource> source, Func<TSource, TOut> selectFunc)
    {
        var result = new TOut[source.Count];
        for (var i = 0; i < source.Count; i++)
        {
            result[i] = selectFunc(source[i]);
        }
        return result;
    }

    /// <summary> Projects each element in the list into a new form and returns the results as an array. </summary>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of element returned by <paramref name="selectFunc"/>. </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="selectFunc">
    /// A transform function to apply to each source element. The second parameter is the zero-based index of the element in
    /// <paramref name="source"/>.
    /// </param>
    /// <returns>
    /// A new array containing the elements from the input list transformed by <paramref name="selectFunc"/>.
    /// </returns>
    public static TOut[] SelectArray<TSource, TOut>(this IReadOnlyList<TSource> source, Func<TSource, int, TOut> selectFunc)
    {
        var result = new TOut[source.Count];
        for (var i = 0; i < source.Count; i++)
        {
            result[i] = selectFunc(source[i], i);
        }
        return result;
    }

    /// <summary>
    /// Transforms all elements of <paramref name="source"/> using the selectFunction, returns a new array of equal length.
    /// Transformation function <paramref name="selectFunc"/> has three arguments: the element, a boolean that indicates if the
    /// element is the first of the sequence, and a boolean that indicates if the element is the last of the sequence.
    /// </summary>
    /// <typeparam name="TSource"> Input element type. </typeparam>
    /// <typeparam name="TOut"> Output element type. </typeparam>
    /// <param name="source"> A IReadOnlyList with elements of type <typeparamref name="TSource"/> </param>
    /// <param name="selectFunc">
    /// Function used to transform the elements of <paramref name="source"/>. Should have three arguments: an element of type
    /// <typeparamref name="TSource"/>, a boolean that indicates if the element is the first of the sequence, and a boolean that
    /// indicates if the element is the last of the sequence.
    /// </param>
    /// <returns>
    /// A new array containing the elements from the input list transformed by <paramref name="selectFunc"/>.
    /// </returns>
    public static TOut[] SelectArray<TSource, TOut>(this IReadOnlyList<TSource> source,
        Func<TSource, bool, bool, TOut> selectFunc)
    {
        var count = source.Count;
        var result = new TOut[count];
        if (count == 1)
        {
            result[0] = selectFunc(source[0], true, true);
        }
        else if (count > 0)
        {
            var lastItem = count - 1;
            result[0] = selectFunc(source[0], true, false);
            for (var i = 1; i < lastItem; ++i)
            {
                result[i] = selectFunc(source[i], false, false);
            }
            result[lastItem] = selectFunc(source[lastItem], false, true);
        }

        return result;
    }

    /// <summary>
    /// Asynchronously projects each element in the list into a new form and returns the results as an array.
    /// </summary>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of element returned by <paramref name="selectFunc"/>. </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="selectFunc"> An asynchronous transform function to apply to each source element. </param>
    /// <returns>
    /// A task that returns a new array containing the elements from the input list transformed by <paramref name="selectFunc"/>.
    /// </returns>
    public static async Task<TOut[]> SelectArrayAsync<TSource, TOut>(this IReadOnlyList<TSource> source,
        Func<TSource, Task<TOut>> selectFunc)
    {
        var result = new TOut[source.Count];
        for (var i = 0; i < source.Count; i += 1)
        {
            result[i] = await selectFunc(source[i]);
        }

        return result;
    }

    /// <summary>
    /// Asynchronously projects each element in the list into a new form and returns the results as an array.
    /// </summary>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of element returned by <paramref name="selectFunc"/>. </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="selectFunc">
    /// An asynchronous transform function to apply to each source element. The second parameter is the zero-based index of the
    /// element in <paramref name="source"/>.
    /// </param>
    /// <returns>
    /// A task that returns a new array containing the elements from the input list transformed by <paramref name="selectFunc"/>.
    /// </returns>
    public static async Task<TOut[]> SelectArrayAsync<TSource, TOut>(this IReadOnlyList<TSource> source,
        Func<TSource, int, Task<TOut>> selectFunc)
    {
        var result = new TOut[source.Count];
        for (var i = 0; i < source.Count; i += 1)
        {
            result[i] = await selectFunc(source[i], i);
        }

        return result;
    }

    /// <summary>
    /// Projects each element in the list into a new form with an additional parameter passed to the transform function, and
    /// returns the results as an array.
    /// </summary>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of element returned by <paramref name="transformFunc"/>. </typeparam>
    /// <typeparam name="TParam"> The type of the additional parameter passed to <paramref name="transformFunc"/>. </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="transformFunc">
    /// A transform function to apply to each source element. The second parameter is the value passed by
    /// <paramref name="param"/>.
    /// </param>
    /// <param name="param"> The parameter to pass to <paramref name="transformFunc"/>. </param>
    /// <returns>
    /// A new array containing the elements from the input list transformed by <paramref name="transformFunc"/>.
    /// </returns>
    public static TOut[] SelectArrayAndPass<TSource, TOut, TParam>(this IReadOnlyList<TSource> source,
        Func<TSource, TParam, TOut> transformFunc, TParam param)
    {
        return source.SelectArray(element => transformFunc(element, param));
    }

    /// <summary>
    /// Projects each element in the list into a new form with two additional parameters passed to the transform function, and
    /// returns the results as an array.
    /// </summary>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of element returned by <paramref name="transformFunc"/>. </typeparam>
    /// <typeparam name="TParam">
    /// The type of the first additional parameter passed to <paramref name="transformFunc"/>.
    /// </typeparam>
    /// <typeparam name="TParam2">
    /// The type of the second additional parameter passed to <paramref name="transformFunc"/>.
    /// </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="transformFunc">
    /// A transform function to apply to each source element. The second and third parameters are the values passed by
    /// <paramref name="param"/> and <paramref name="param2"/>, respectively.
    /// </param>
    /// <param name="param"> The first parameter to pass to <paramref name="transformFunc"/>. </param>
    /// <param name="param2"> The second parameter to pass to <paramref name="transformFunc"/>. </param>
    /// <returns>
    /// A new array containing the elements from the input list transformed by <paramref name="transformFunc"/>.
    /// </returns>
    public static TOut[] SelectArrayAndPass<TSource, TOut, TParam, TParam2>(this IReadOnlyList<TSource> source,
        Func<TSource, TParam, TParam2, TOut> transformFunc, TParam param, TParam2 param2)
    {
        return source.SelectArray(element => transformFunc(element, param, param2));
    }

    /// <summary>
    /// Projects each element in the list into a new form and returns the results as an array, or <see langword="null"/> if the
    /// list is empty.
    /// </summary>
    /// <typeparam name="TSource"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> The type of element returned by <paramref name="transformFunc"/>. </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="transformFunc"> A transform function to apply to each source element. </param>
    /// <returns>
    /// A new array containing the elements from the input list transformed by <paramref name="transformFunc"/>, or
    /// <see langword="null"/> if the input list contains no elements.
    /// </returns>
    public static TOut[]? SelectArrayOrNull<TSource, TOut>(this IReadOnlyList<TSource> source,
        Func<TSource, TOut> transformFunc)
    {
        return source.Count == 0 ? null : source.SelectArray(transformFunc);
    }

    /// <summary>
    /// Eagerly enumerates <paramref name="source"/> and applies <paramref name="transformFunc"/> but skips the last element.
    /// Returns an array of type <typeparamref name="TOut"/>.
    /// </summary>
    /// <typeparam name="TSource"> Type of the elements of <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> Type of the elements of the returned array. </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="transformFunc"> Transformation function applied to elements of <paramref name="source"/>. </param>
    /// <returns> A new array of type <typeparamref name="TOut"/> of length <paramref name="source"/>.Count - 1. </returns>
    public static TOut[] SelectArraySkipLast<TSource, TOut>(this IReadOnlyList<TSource> source,
        Func<TSource, TOut> transformFunc)
    {
        return SelectArraySkipLast(source, transformFunc, 1);
    }

    /// <summary>
    /// Eagerly enumerates <paramref name="source"/> and applies <paramref name="transformFunc"/> but skips the last
    /// <paramref name="count"/> elements. Returns an array of type <typeparamref name="TOut"/>.
    /// </summary>
    /// <typeparam name="TSource"> Type of the elements of <paramref name="source"/>. </typeparam>
    /// <typeparam name="TOut"> Type of the elements of the returned array. </typeparam>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> containing the elements to transform. </param>
    /// <param name="transformFunc"> Transformation function applied to elements of <paramref name="source"/>. </param>
    /// <param name="count"> Amount of elements to skip at end. </param>
    /// <returns>
    /// A new array of type <typeparamref name="TOut"/> of length <paramref name="source"/>.Count - <paramref name="count"/>.
    /// </returns>
    public static TOut[] SelectArraySkipLast<TSource, TOut>(this IReadOnlyList<TSource> source,
        Func<TSource, TOut> transformFunc, int count)
    {
        var newCount = source.Count - count;
        var result = new TOut[newCount];
        for (var i = 0; i < newCount; i++)
        {
            result[i] = transformFunc(source[i]);
        }
        return result;
    }
}
