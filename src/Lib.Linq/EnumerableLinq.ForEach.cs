using System.Threading.Tasks;

namespace Semantica.Linq;

/// <summary>
/// Provides additional enumeration functionality to <see
/// cref="IEnumerable{T}"/> collections.
/// </summary>
partial class EnumerableLinq
{
    /// <summary> Invokes an action on each element in the sequence. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to perform an action on. </param>
    /// <param name="action"> A delegate to invoke on each element of <paramref name="source"/>. </param>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
        {
            action(item);
        }
    }

    /// <summary> Asynchronously invokes an action on each element in the sequence. </summary>
    /// <typeparam name="T">The type of elements in <paramref name="source"/>.</typeparam>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the element to perform an action on. </param>
    /// <param name="asyncAction">
    /// A delegate that returns a task to await for each element in <paramref name="source"/>.
    /// </param>
    /// <returns> A task representing the asynchronous operation. </returns>
    public static async Task ForEachAsync<T>(this IEnumerable<T> source, Func<T, Task> asyncAction)
    {
        foreach (var item in source)
        {
            await asyncAction(item);
        }
    }

    /// <summary> Invokes an action on each element in the sequence with an additional parameter. </summary>
    /// <param name="source">
    /// An <see cref="IEnumerable{T}"/> that contains the elements to invoke an
    /// action on.
    /// </param>
    /// <param name="action">
    /// A delegate to invoke on each element of <paramref name="source"/>. <paramref name="param"/> is passed as second
    /// argument to this method.
    /// </param>
    /// <param name="param"> A value to pass as the second argument of <paramref name="action"/>. </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    /// <typeparam name="TParam"> The type of parameter to pass to <paramref name="action"/>. </typeparam>
    public static void ForEachAndPass<T, TParam>(this IEnumerable<T> source, Action<T, TParam> action, TParam param)
    {
        foreach (var item in source)
        {
            action(item, param);
        }
    }

    /// <summary> Invokes an action on each element in the sequence, along with the element that follows it. </summary>
    /// <param name="source"> An <see cref="IEnumerable{T}"/> that contains the elements to invoke an action on. </param>
    /// <param name="action">
    /// A delegate to invoke on each element in <paramref name="source"/>. The second argument contains the element that
    /// follows the first argument in the collection.
    /// </param>
    /// <param name="skipLast">
    /// <see langword="true"/> to skip the last invocation, or <see langword="false"/> to invoke <paramref name="action"/> on
    /// the last element with the second argument set to a default value.
    /// </param>
    /// <typeparam name="T"> The type of elements in <paramref name="source"/>. </typeparam>
    public static void ForEachWithNext<T>(this IEnumerable<T> source, Action<T, T?> action, bool skipLast)
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return;
            }

            var previous = enumerator.Current;
            while (enumerator.MoveNext())
            {
                action(previous, enumerator.Current);
                previous = enumerator.Current;
            }

            if (!skipLast)
            {
                action(previous, default);
            }
        }
    }
}
