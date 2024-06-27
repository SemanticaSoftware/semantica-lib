namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for types implementing <see cref="IComparable"/>.
/// </summary>
public static class ComparableExtensions
{
    /// <summary>
    /// Returns the maximum value in a collection according to the specified
    /// selector function and predicate, using a tiebreaker function for values
    /// that would otherwise be considered equal.
    /// </summary>
    /// <typeparam name="T">
    /// The type of elements in <paramref name="enumerable"/> and the type of
    /// value to return.
    /// </typeparam>
    /// <typeparam name="TValue">
    /// The type of values to compare elements by.
    /// </typeparam>
    /// <typeparam name="TValue2">
    /// The type of values to compare by in tie breakers.
    /// </typeparam>
    /// <param name="enumerable">The collection whose maximum to determine.</param>
    /// <param name="selector">A function that selects the value used in comparisons.</param>
    /// <param name="predicate">
    /// A function that determines which values are included in comparisons.
    /// </param>
    /// <param name="tiebreaker">
    /// A function that selects a secondary value used in comparisons when the
    /// <paramref name="selector"/> function results in equal comparisons.
    /// </param>
    /// <returns>
    /// The maximum value in <paramref name="enumerable"/> according to the
    /// specified <paramref name="selector"/>, <paramref name="predicate"/> and
    /// <paramref name="tiebreaker"/> functions.
    /// </returns>
    public static T? MaxBy<T, TValue, TValue2>(this IEnumerable<T> enumerable, Func<T, TValue> selector, Func<TValue, bool> predicate, Func<T, TValue2> tiebreaker)
        where TValue : IComparable<TValue>
        where TValue2 : IComparable<TValue2>
    {
        using (var enumerator = enumerable.GetEnumerator())
        {
            T currentMax;
            TValue currentMaxValue;
            do
            {
                if (!enumerator.MoveNext())
                {
                    return default;
                }
                currentMax = enumerator.Current;
                currentMaxValue = selector(currentMax);
            } while (!predicate(currentMaxValue));

            while (enumerator.MoveNext())
            {
                var newValue = selector(enumerator.Current);
                if (predicate(newValue))
                {
                    var comparison = newValue.CompareTo(currentMaxValue);
                    if (comparison > 0 || (comparison == 0 && tiebreaker(enumerator.Current).CompareTo(tiebreaker(currentMax)) > 0))
                    {
                        currentMaxValue = newValue;
                        currentMax = enumerator.Current;
                    }
                }
            }

            return currentMax;
        }
    }

    /// <summary>
    /// Finds the maximum value in an enumeration of values and returns it.
    /// Returns null if the enumeration was empty.
    /// </summary>
    /// <typeparam name="T">Has to be struct and <see cref="IComparable"/></typeparam>
    /// <param name="enumerable">An enumerable of type <typeparamref name="T">T</typeparamref></param>
    /// <returns>
    /// null if enumerable is empty, otherwise the max value of the enumerable
    /// </returns>
    public static T? MaxOrNull<T>(this IEnumerable<T> enumerable)
        where T : struct, IComparable<T>
    {
        using (var enumerator = enumerable.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return default(T?);
            }

            var max = enumerator.Current;
            while (enumerator.MoveNext())
            {
                var candidate = enumerator.Current;
                if (max.CompareTo(candidate) < 0)
                {
                    max = candidate;
                }
            }

            return max;
        }
    }

    /// <summary>
    /// Finds the maximum value in an enumeration of values and returns it.
    /// Returns null if the enumeration was empty.
    /// </summary>
    /// <typeparam name="T">Has to be struct and <see cref="IComparable"/></typeparam>
    /// <typeparam name="TOut">
    /// The type of value selected by <paramref name="valueFunc"/>.
    /// </typeparam>
    /// <param name="enumerable">An enumerable of type <typeparamref name="T">T</typeparamref></param>
    /// <param name="valueFunc">
    /// A projection function used to select the value to compare and return.
    /// </param>
    /// <returns>
    /// null if enumerable is empty, otherwise the max value of the enumerable
    /// </returns>
    public static TOut? MaxByOrNull<T, TOut>(this IEnumerable<T> enumerable, Func<T, TOut> valueFunc)
        where TOut : struct, IComparable<TOut>
    {
        return MaxOrNull<TOut>(enumerable.Select(valueFunc));
    }
}
