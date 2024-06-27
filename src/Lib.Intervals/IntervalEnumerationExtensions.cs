using JetBrains.Annotations;
using Semantica.Patterns;

namespace Semantica.Intervals;

/// <summary>
/// Provides extension methods of various types of enumerations pertaining to intervals.
/// </summary>
public static class IntervalEnumerationExtensions
{
    /// <summary>
    /// Creates an <see cref="EmptyUnbindsInterval{T}"/> with the left (lower) bound taken from the minimal value in any of the input
    /// intervals, and the right (upper) bound taken from the maximal value in any of the input intervals. 
    /// </summary>
    /// <param name="intervals"> An enumeration of intervals. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// New instance of <see cref="EmptyUnbindsInterval{T}"/> spanning all the values within any of the input intervals, and all values in
    /// between.
    /// </returns>
    public static EmptyUnbindsInterval<T>? Extend<T>([InstantHandle] this IEnumerable<EmptyUnbindsInterval<T>> intervals)
        where T : IComparable<T>, ICanBeEmpty
    {
        return intervals.Extend<T, EmptyUnbindsInterval<T>>(EmptyUnbindsInterval<T>.Make);
    }

    /// <summary>
    /// Creates an <see cref="Interval{T}"/> with the left (lower) bound taken from the minimal value in any of the input
    /// intervals, and the right (upper) bound taken from the maximal value in any of the input intervals. 
    /// </summary>
    /// <param name="intervals"> An enumeration of intervals. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// New instance of <see cref="Interval{T}"/> spanning all the values within any of the input intervals, and all values in
    /// between.
    /// </returns>
    public static Interval<T>? Extend<T>([InstantHandle] this IEnumerable<Interval<T>> intervals)
        where T : IComparable<T>
    {
        return intervals.Extend<T, Interval<T>>(Interval.Make);
    }

    /// <summary>
    /// Creates an <see cref="Interval{T}"/> with the left (lower) bound taken from the minimal value in any of the input
    /// intervals, and the right (upper) bound taken from the maximal value in any of the input intervals. 
    /// </summary>
    /// <param name="intervals"> An enumeration of intervals. </param>
    /// <param name="factory"> A function that can create a new interval of the appropriate type. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <typeparam name="TInterval"> Type of intervals. </typeparam>
    /// <returns>
    /// New instance of <see cref="Interval{T}"/> spanning all the values within any of the input intervals, and all values in
    /// between.
    /// </returns>
    public static TInterval? Extend<T, TInterval>(
        [InstantHandle] this IEnumerable<TInterval> intervals,
        [InstantHandle] Func<T, T, IntervalOpenKind, IntervalBoundKind, TInterval> factory)
        where T : IComparable<T>
        where TInterval : IReadOnlyInterval<T>
    {
        using (var enumerator = intervals.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                return default;
            }

            var current = enumerator.Current;
            if (!enumerator.MoveNext())
            {
                return current;
            }

            var minLeft = current.Left;
            var maxRight = current.Right;
            var isLeftOpen = current.IsLeftOpen();
            var isLeftBounded = current.IsLeftBounded();
            var isRightOpen = current.IsRightOpen();
            var isRightBounded = current.IsRightBounded();
            do
            {
                current = enumerator.Current;
                if (isLeftBounded)
                {
                    if (current.IsLeftUnbound())
                    {
                        minLeft = current.Left;
                        isLeftBounded = false;
                        isLeftOpen = true;
                    }
                    else if (minLeft.CompareTo(current.Left) > 0)
                    {
                        minLeft = current.Left;
                        isLeftOpen = current.IsLeftOpen();
                    }
                }

                if (isRightBounded)
                {
                    if (current.IsRightUnbound())
                    {
                        maxRight = current.Right;
                        isRightBounded = false;
                        isRightOpen = true;
                    }
                    else if (maxRight.CompareTo(current.Right) < 0)
                    {
                        maxRight = current.Right;
                        isRightOpen = current.IsRightOpen();
                    }
                }

            } while (enumerator.MoveNext());

            return factory(
                minLeft,
                maxRight,
                Interval.DetermineOpenKind(isLeftOpen, isRightOpen),
                Interval.DetermineBoundKind(!isLeftBounded, !isRightBounded));
        }
    }

    /// <summary>
    /// Creates a new <see cref="IntervalDictionary{TKey,TValue}"/> containing the intervals and values from the provided
    /// <see cref="IEnumerable{T}"/> of tuples.
    /// </summary>
    /// <param name="enumerable"> An enumerable of tuples of intervals and values. </param>
    /// <typeparam name="TKey"> Type of the bounds of the intervals. </typeparam>
    /// <typeparam name="TValue"> Type of the values associated with each interval. </typeparam>
    /// <returns> An <see cref="IntervalDictionary{TKey,TValue}"/> </returns>
    public static IntervalDictionary<TKey, TValue> ToIntervalDictionary<TKey, TValue>(
        [InstantHandle] this IEnumerable<(IInterval<TKey> interval, TValue value)> enumerable)
        where TKey : IComparable<TKey>
    {
        return new IntervalDictionary<TKey, TValue>(enumerable);
    }

    /// <summary>
    /// Creates a new <see cref="IntervalDictionary{TKey,TInterval,TValue}"/> containing the intervals and values from the provided
    /// <see cref="IEnumerable{T}"/> of tuples.
    /// </summary>
    /// <param name="enumerable"> An enumerable of tuples of intervals and values. </param>
    /// <typeparam name="TKey"> Type of the bounds of the intervals. </typeparam>
    /// <typeparam name="TValue"> Type of the values associated with each interval. </typeparam>
    /// <typeparam name="TInterval"> Type of the intervals. </typeparam>
    /// <returns> An <see cref="IntervalDictionary{TKey,TInterval,TValue}"/> </returns>
    public static IntervalDictionary<TKey, TInterval, TValue> ToIntervalDictionary<TKey, TInterval, TValue>(
        [InstantHandle] this IEnumerable<(TInterval, TValue)> enumerable)
        where TKey : IComparable<TKey>
        where TInterval : IInterval<TKey>
    {
        return new IntervalDictionary<TKey, TInterval, TValue>(enumerable);
    } 

    /// <summary>
    /// Enumerates <paramref name="values"/>, and yields a <see cref="KeyValuePair{TKey,TValue}"/> where each key is an
    /// interval that has left (lower) bound derived from each element, and right (upper) bound derived from the subsequent
    /// element in the enumeration using <paramref name="leftFunc"/>. The values of the pair are the elements of the
    /// input. The right bound of the last pair is set to <paramref name="finalRight"/>;        
    /// </summary>
    /// <param name="values"> Enumeration of values. </param>
    /// <param name="leftFunc"> Function used to obtain a bound value from each value. </param>
    /// <param name="finalRight"> Right bound of the interval associated with the last value in the enumeration. </param>
    /// <typeparam name="TValue"> Type of the values. </typeparam>
    /// <typeparam name="TKey"> Type of the bounds of the intervals. </typeparam>
    /// <remarks> Note that two elements of the input <see cref="IEnumerable{T}"/> are taken before the first element is
    /// yielded. After that one element is taken for each element yielded. </remarks>
    /// <returns> An <see cref="IEnumerable{T}"/> of pairs with intervals and values. </returns>
    [LinqTunnel] 
    public static IEnumerable<KeyValuePair<Interval<TKey>, TValue>> ToLowerboundIntervalPairs<TValue, TKey>(
            this IEnumerable<TValue> values,
            Func<TValue, TKey> leftFunc,
            TKey finalRight
        )
        where TKey: struct, IComparable<TKey>
    {
        using (var enumerator = values.OrderBy(leftFunc).GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                yield break;
            }

            var currentValue = enumerator.Current;
            var currentLowerBound = leftFunc(currentValue);
            while (enumerator.MoveNext())
            {
                var nextValue = enumerator.Current;
                var currentUpperbound = leftFunc(nextValue);
                yield return new KeyValuePair<Interval<TKey>, TValue>(
                        new Interval<TKey>(currentLowerBound, currentUpperbound),
                        currentValue
                    );

                currentValue = nextValue;
                currentLowerBound = currentUpperbound;
            }

            yield return new KeyValuePair<Interval<TKey>, TValue>(
                    new Interval<TKey>(currentLowerBound, finalRight),
                    currentValue
                );
        }
    }
    
    /// <summary>
    /// Enumerates <paramref name="values"/>, and yields a tuple of an interval and a value where each key is an
    /// interval that has left (lower) bound derived from each element, and right (upper) bound derived from the subsequent
    /// element in the enumeration using <paramref name="leftFunc"/>. The values of the tuples are the elements of the
    /// input. The right bound of the last pair is set to <paramref name="finalRight"/>;        
    /// </summary>
    /// <param name="values"> Enumeration of values. </param>
    /// <param name="leftFunc"> Function used to obtain a bound value from each value. </param>
    /// <param name="finalRight"> Right bound of the interval associated with the last value in the enumeration. </param>
    /// <typeparam name="TValue"> Type of the values. </typeparam>
    /// <typeparam name="TKey"> Type of the bounds of the intervals. </typeparam>
    /// <remarks> Note that two elements of the input <see cref="IEnumerable{T}"/> are taken before the first element is
    /// yielded. After that one element is taken for each element yielded. </remarks>
    /// <returns> An <see cref="IEnumerable{T}"/> of tuples with intervals and values. </returns>    
    [LinqTunnel] 
    public static IEnumerable<(Interval<TKey> interval, TValue value)> ToLowerboundIntervalTuples<TValue, TKey>(
            this IEnumerable<TValue> values,
            Func<TValue, TKey> leftFunc,
            TKey finalRight
        )
        where TKey: struct, IComparable<TKey>
    {
        return ToLowerboundIntervalTuples(values, Interval.MakeHalfOpen, leftFunc, finalRight);
    }

    /// <summary>
    /// Enumerates <paramref name="values"/>, and yields a tuple of an interval and a value where each key is an
    /// interval that has left (lower) bound derived from each element, and right (upper) bound derived from the subsequent
    /// element in the enumeration using <paramref name="leftFunc"/>. The values of the tuples are the elements of the
    /// input. The right bound of the last pair is set to <paramref name="finalRight"/>;        
    /// </summary>
    /// <param name="values"> Enumeration of values. </param>
    /// <param name="intervalFactory"> Function to create the intervals. </param>
    /// <param name="leftFunc"> Function used to obtain a bound value from each value. </param>
    /// <param name="finalRight"> Right bound of the interval associated with the last value in the enumeration. </param>
    /// <typeparam name="TValue"> Type of the values. </typeparam>
    /// <typeparam name="TKey"> Type of the bounds of the intervals. </typeparam>
    /// <typeparam name="TInterval"> Type of the created intervals. </typeparam>
    /// <remarks> Note that two elements of the input <see cref="IEnumerable{T}"/> are taken before the first element is
    /// yielded. After that one element is taken for each element yielded. </remarks>
    /// <returns> An <see cref="IEnumerable{T}"/> of tuples with intervals and values. </returns>
    [LinqTunnel] 
    public static IEnumerable<(TInterval interval, TValue value)> ToLowerboundIntervalTuples<TValue, TKey, TInterval>(
            this IEnumerable<TValue> values,
            Func<TKey, TKey, TInterval> intervalFactory,
            Func<TValue, TKey> leftFunc,
            TKey finalRight
        )
        where TKey: struct, IComparable<TKey>
        where TInterval: IReadOnlyInterval<TKey>
    {
        using (var enumerator = values.OrderBy(leftFunc).GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                yield break;
            }

            var currentValue = enumerator.Current;
            var currentLowerBound = leftFunc(currentValue);
            while (enumerator.MoveNext())
            {
                var nextValue = enumerator.Current;
                var currentUpperbound = leftFunc(nextValue);
                yield return (
                    intervalFactory(currentLowerBound, currentUpperbound),
                    currentValue
                );

                currentValue = nextValue;
                currentLowerBound = currentUpperbound;
            }

            yield return (
                intervalFactory(currentLowerBound, finalRight),
                currentValue
            );
        }
    }
}
