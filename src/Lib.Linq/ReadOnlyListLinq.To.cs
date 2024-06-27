using Semantica.Checks;
using Semantica.Core;

namespace Semantica.Linq;

public static partial class ReadOnlyListLinq
{

    /// <summary>
    /// Copies all the elements of the list to the target array, optionally starting at the specified destination index.
    /// </summary>
    /// <param name="source"> An <see cref="IReadOnlyList{T}"/> whose elements to copy. </param>
    /// <param name="target"> The array to copy the elements to. </param>
    /// <param name="index"> The zero-based index in <paramref name="target"/> at which copying begins. </param>
    /// <typeparam name="T"> The type of elements in the list. </typeparam>
    public static void CopyTo<T>(this IReadOnlyList<T> source, T[] target, int index = 0)
    {
        Check.NotNull(source).Contract();
        Check.NotNull(target).Contract();
        Check.That(source.Count + index <= target.Length).Contract(@"target array length is insufficient");
        for (var i = 0; i < source.Count; ++i)
        {
            target[i + index] = source[i];
        }
    }

    /// <summary> Returns a new array (T[]) containing all elements of the source. </summary>
    /// <param name="source"> Source list. </param>
    /// <typeparam name="T"> Type of the elements. </typeparam>
    /// <returns> A new T[] instance. </returns>
    public static T[] ToArray<T>(this IReadOnlyList<T> source)
    {
        Check.NotNull(source).Contract();
        var result = new T[source.Count];
        source.CopyTo(result);
        return result;
    }

    /// <summary> Returns a new <see cref="IReadOnlyList{T}"/> containing all elements of the source. </summary>
    /// <param name="source"> Source list. </param>
    /// <typeparam name="T"> Type of the elements. </typeparam>
    /// <returns> A new instance implementing <see cref="IReadOnlyList{T}"/>. </returns>
    public static IReadOnlyList<T> ToReadOnlyList<T>(this List<T> source)
    {
        Check.NotNull(source).Contract();
        var result = new T[source.Count];
        source.CopyTo(result, 0);
        return result;
    }

    /// <summary> Returns a new <see cref="IReadOnlyList{T}"/> containing all elements of the source. </summary>
    /// <param name="source"> Source array. </param>
    /// <typeparam name="T"> Type of the elements. </typeparam>
    /// <returns> A new instance implementing <see cref="IReadOnlyList{T}"/>. </returns>
    public static IReadOnlyList<T> ToReadOnlyList<T>(this T[] source)
    {
        Check.NotNull(source).Contract();
        var result = new T[source.Length];
        source.CopyTo(result, 0);
        return result;
    }

    /// <summary> Returns a new <see cref="IReadOnlyList{T}"/> containing all elements of the source. </summary>
    /// <param name="source"> Source list. </param>
    /// <typeparam name="T"> Type of the elements. </typeparam>
    /// <returns> A new instance implementing <see cref="IReadOnlyList{T}"/>. </returns>
    public static IReadOnlyList<T> ToReadOnlyList<T>(this IReadOnlyList<T> source)
    {
        Check.NotNull(source).Contract();
        switch (source)
        {
            case List<T> list:
                return list.ToReadOnlyList();

            case T[] array:
                return array.ToReadOnlyList();

            default:
                var count = source.Count;
                var result = new T[count];
                source.CopyTo(result);
                return result;
        }
    }

    /// <summary>
    /// Creates a dictionary from an <see cref="IReadOnlyList{T}"/> by putting values into lists according to a list of keys and
    /// a key selector function.
    /// </summary>
    /// <param name="source"> The list that contains the values to put into the dictionary. </param>
    /// <param name="keysToCollate">
    /// An <see cref="IReadOnlyList{T}"/> that contains the keys to create a dictionary from.
    /// </param>
    /// <param name="keyFunc"> A function that selects the dictionary key to sort values from the list into. </param>
    /// <typeparam name="TKey"> The type of keys in the dictionary to create. </typeparam>
    /// <typeparam name="TValue"> The type of elements in the list. </typeparam>
    /// <returns>
    /// A <see cref="Dictionary{TKey, TValue}"/> that contains values from the input list sorted into keys from
    /// <paramref name="keysToCollate"/> according to <paramref name="keyFunc"/>.
    /// </returns>
    public static IReadOnlyDictionary<TKey, IReadOnlyList<TValue>> ToBucketDictionary<TKey, TValue>(
            this IReadOnlyList<TValue> source,
            IReadOnlyList<TKey> keysToCollate,
            Func<TValue, TKey> keyFunc
        )
        where TKey : IEquatable<TKey>
    {
        Check.NotNull(source).Contract();
        IReadOnlyDictionary<TKey, IReadOnlyList<TValue>> results = keysToCollate.ToDictionary(
            StaticSelectors.Self, 
            key => source.Where(item => keyFunc(item).Equals(key)).ToReadOnlyList());
        return results;
    }
}
