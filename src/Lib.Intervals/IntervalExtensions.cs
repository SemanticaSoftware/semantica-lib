namespace Semantica.Intervals;

/// <summary>
/// Provides extension methods for <see cref="IReadOnlyInterval{T}"/>.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static class IntervalExtensions
{
    /// <summary>
    /// Creates an <see cref="Interval{T}"/> with the bounds of <paramref name="interval"/> converted using provided converter. 
    /// </summary>
    /// <param name="interval"> <see cref="IReadOnlyInterval{T}"/> to convert. </param>
    /// <param name="convertFunc"> Function to convert the bounds with. </param>
    /// <typeparam name="TIn"> Type of bounds of the input interval. </typeparam>
    /// <typeparam name="TOut"> Type of bounds of the returned interval.</typeparam>
    /// <returns> New instance of <see cref="Interval{T}"/> derived from <paramref name="interval"/>. </returns>
    public static Interval<TOut> Convert<TIn, TOut>(this IReadOnlyInterval<TIn> interval, Func<TIn, TOut> convertFunc)
        where TIn : IComparable<TIn>
        where TOut : IComparable<TOut>
    {
        return new Interval<TOut>(
            convertFunc(interval.Left),
            convertFunc(interval.Right),
            interval.OpenKind,
            interval.BoundKind);
    }

    /// <summary>
    /// Creates an <see cref="Interval{T}"/> with the left (lower) bound taken from the minimal value in either of the inputs
    /// intervals, and the right (upper) bound taken from the maximal value in either of the inputs. 
    /// </summary>
    /// <param name="interval"> First <see cref="IReadOnlyInterval{T}"/> to use. </param>
    /// <param name="otherInterval"> Second <see cref="IReadOnlyInterval{T}"/> to use. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// New instance of <see cref="Interval{T}"/> spanning all the values within either input interval, and all values in
    /// between.
    /// </returns>
    public static Interval<T> Extend<T>(this IReadOnlyInterval<T> interval, IReadOnlyInterval<T> otherInterval)
        where T : IComparable<T>
    {
        var isLeftOpen = interval.IsLeftOpen();
        var isRightOpen = interval.IsRightOpen();
        var left = interval.Left;
        var right = interval.Right;
        if (interval.IsLeftBounded()
            && (
                !otherInterval.IsLeftBounded()
                || interval.Left.CompareTo(otherInterval.Left) > 0
            ))
        {
            left = otherInterval.Left;
            isLeftOpen = otherInterval.IsLeftOpen();
        }
        if (interval.IsRightBounded()
            && (
                !otherInterval.IsRightBounded()
                || interval.Right.CompareTo(otherInterval.Right) < 0
            ))
        {
            right = otherInterval.Right;
            isRightOpen = otherInterval.IsRightOpen();
        }
        return new Interval<T>(
            left,
            right,
            Interval.DetermineOpenKind(isLeftOpen, isRightOpen),
            interval.BoundKind | otherInterval.BoundKind);
    }

    /// <summary>
    /// Determines if any values in <paramref name="interval"/> are left of <paramref name="otherInterval"/>.
    /// </summary>
    /// <param name="interval"> First <see cref="IReadOnlyInterval{T}"/> to compare to. </param>
    /// <param name="otherInterval"> Second <see cref="IReadOnlyInterval{T}"/> to compare fo first. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="interval"/> has any values left of <paramref name="otherInterval"/>. Always
    /// <see langword="false"/> if either of the intervals are empty.
    /// </returns>
    public static bool IsAnyLeftOf<T>(this IReadOnlyInterval<T> interval, IReadOnlyInterval<T> otherInterval)
        where T : IComparable<T>
    {
        return !(interval.IsEmpty() || otherInterval.IsEmpty())
               && otherInterval.IsLeftBounded()
               && (
                   !interval.IsLeftBounded()
                   || interval.Left.CompareTo(otherInterval.Left) switch {
                       0 => !interval.IsLeftOpen() && otherInterval.IsLeftOpen(),
                       var comp => comp < 0
                   }
               );
    }

    /// <summary> Determines if any values in <paramref name="interval"/> are left of <paramref name="value"/>. </summary>
    /// <param name="interval"> <see cref="IReadOnlyInterval{T}"/> to compare to. </param>
    /// <param name="value"> A single value of type <typeparamref name="T"/>. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="interval"/> has any values left of <paramref name="value"/>. Always
    /// <see langword="false"/> if the interval is empty.
    /// </returns>
    public static bool IsAnyLeftOf<T>(this IReadOnlyInterval<T> interval, T value)
        where T : IComparable<T>
    {
        return !interval.IsEmpty()
               && (
                   !interval.IsLeftBounded()
                   || interval.Left.CompareTo(value) < 0
               );
    }

    /// <summary>
    /// Determines if any values in <paramref name="interval"/> are right of <paramref name="otherInterval"/>.
    /// </summary>
    /// <param name="interval"> First <see cref="IReadOnlyInterval{T}"/> to compare to. </param>
    /// <param name="otherInterval"> Second <see cref="IReadOnlyInterval{T}"/> to compare fo first. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="interval"/> has any values right of <paramref name="otherInterval"/>. Always
    /// <see langword="false"/> if either of the intervals are empty.
    /// </returns>
    public static bool IsAnyRightOf<T>(this IReadOnlyInterval<T> interval, IReadOnlyInterval<T> otherInterval)
        where T : IComparable<T>
    {
        return !(interval.IsEmpty() || otherInterval.IsEmpty())
               && otherInterval.IsRightBounded()
               && (
                   !interval.IsRightBounded()
                   || interval.Right.CompareTo(otherInterval.Right) switch {
                       0 => !interval.IsRightOpen() && otherInterval.IsRightOpen(),
                       var comp => comp > 0
                   }
               );
    }

    /// <summary> Determines if any values in <paramref name="interval"/> are right of <paramref name="value"/>. </summary>
    /// <param name="interval"> <see cref="IReadOnlyInterval{T}"/> to compare to. </param>
    /// <param name="value"> A single value of type <typeparamref name="T"/>. </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="interval"/> has any values right of <paramref name="value"/>. Always
    /// <see langword="false"/> if the interval is empty.
    /// </returns>
    public static bool IsAnyRightOf<T>(this IReadOnlyInterval<T> interval, T value)
        where T : IComparable<T>
    {
        return !interval.IsEmpty()
               && (
                   !interval.IsRightBounded()
                   || interval.Right.CompareTo(value) > 0
               );
    }

    /// <summary> Determines if <paramref name="value"/> is left of <paramref name="interval"/>. </summary>
    /// <param name="value"> A single value of type <typeparamref name="T"/> to compare to. </param>
    /// <param name="interval"> The <see cref="IReadOnlyInterval{T}"/> to compare to the value. </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="value"/> is left of <paramref name="interval"/>. Always
    /// <see langword="false"/> if either of the intervals are empty.
    /// </returns>
    public static bool IsLeftOf<T>(this T value, IReadOnlyInterval<T> interval)
        where T : IComparable<T>
    {
        return !interval.IsEmpty()
               && interval.IsLeftBounded()
               && value.CompareTo(interval.Left) switch {
                   0 => interval.IsLeftOpen(),
                   var comp => comp < 0
               };
    }

    /// <summary>
    /// Determines if all values in <paramref name="interval"/> are left of <paramref name="otherInterval"/>.
    /// </summary>
    /// <param name="interval"> First <see cref="IReadOnlyInterval{T}"/> to compare. </param>
    /// <param name="otherInterval"> Second <see cref="IReadOnlyInterval{T}"/> to compare fo first. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="interval"/> is completely left of <paramref name="otherInterval"/>. Always
    /// <see langword="false"/> if either of the intervals are empty.
    /// </returns>
    public static bool IsLeftOf<T>(this IReadOnlyInterval<T> interval, IReadOnlyInterval<T> otherInterval)
        where T : IComparable<T>
    {
        return !(interval.IsEmpty() || otherInterval.IsEmpty())
               && otherInterval.IsLeftBounded()
               && interval.Right.CompareTo(otherInterval.Left) switch {
                   0 => interval.IsRightOpen() || otherInterval.IsLeftOpen(),
                   var comp => comp < 0
               };
    }

    /// <summary> Determines if <paramref name="value"/> is right of <paramref name="interval"/>. </summary>
    /// <param name="value"> A single value of type <typeparamref name="T"/> to compare to. </param>
    /// <param name="interval"> The <see cref="IReadOnlyInterval{T}"/> to compare to the value. </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="value"/> is right of <paramref name="interval"/>. Always
    /// <see langword="false"/> if either of the intervals are empty.
    /// </returns>
    public static bool IsRightOf<T>(this T value, IReadOnlyInterval<T> interval)
        where T : IComparable<T>
    {
        return !interval.IsEmpty()
               && interval.IsRightBounded()
               && value.CompareTo(interval.Right) switch {
                   0 => interval.IsRightOpen(),
                   var comp => comp > 0
               };
    }

    /// <summary>
    /// Determines if all values in <paramref name="interval"/> are right of <paramref name="otherInterval"/>.
    /// </summary>
    /// <param name="interval"> First <see cref="IReadOnlyInterval{T}"/> to compare. </param>
    /// <param name="otherInterval"> Second <see cref="IReadOnlyInterval{T}"/> to compare fo first. </param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="interval"/> is completely right of <paramref name="otherInterval"/>. Always
    /// <see langword="false"/> if either of the intervals are empty.
    /// </returns>
    public static bool IsRightOf<T>(this IReadOnlyInterval<T> interval, IReadOnlyInterval<T> otherInterval)
        where T : IComparable<T>
    {
        return !(interval.IsEmpty() || otherInterval.IsEmpty())
               && otherInterval.IsRightBounded()
               && interval.Left.CompareTo(otherInterval.Right) switch {
                   0 => interval.IsLeftOpen() || otherInterval.IsRightOpen(),
                   var comp => comp > 0
               };
    }

    /// <summary> Determines if <paramref name="value"/> is within <paramref name="interval"/>. </summary>
    /// <param name="value"> A single value of type <typeparamref name="T"/> to compare to. </param>
    /// <param name="interval"> The <see cref="IReadOnlyInterval{T}"/> to compare to the value. </param>
    /// <returns>
    /// <see langword="true"/> if the <paramref name="value"/> is within <paramref name="interval"/>. Always
    /// <see langword="false"/> if the interval is empty.
    /// </returns>
    public static bool IsWithin<T>(this T value, IReadOnlyInterval<T> interval)
        where T : IComparable<T>
    {

        return !(
            interval.IsLeftBounded()
            && value.CompareTo(interval.Left) switch {
                0 => interval.IsLeftOpen(),
                var comp2 => comp2 < 0
            }
            || interval.IsRightBounded()
            && value.CompareTo(interval.Right) switch {
                0 => interval.IsRightOpen(),
                var comp3 => comp3 > 0
            }
        );
    }

    /// <summary> Determines if all values in <paramref name="interval"/> are in <paramref name="otherInterval"/>. </summary>
    /// <param name="interval"> First <see cref="IReadOnlyInterval{T}"/> to compare. </param>
    /// <param name="otherInterval"> Second <see cref="IReadOnlyInterval{T}"/> to compare fo first. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// <see langword="true"/> if the complete <paramref name="interval"/> is within <paramref name="otherInterval"/>.
    /// Always <see langword="false"/> if one of the intervals is empty.
    /// </returns>
    public static bool IsWithin<T>(this IReadOnlyInterval<T> interval, IReadOnlyInterval<T> otherInterval)
        where T : IComparable<T>
    {
        return !(interval.IsEmpty() || otherInterval.IsEmpty())
               && (
                   otherInterval.TryDegenerateValue(out var otherIntervalValue)
                       ? (interval.TryDegenerateValue(out var intervalValue)
                          && intervalValue.CompareTo(otherIntervalValue) == 0
                       )
                       : (!otherInterval.IsRightBounded()
                          || (interval.IsLeftBounded()
                              && interval.Left.CompareTo(otherInterval.Left) switch {
                                  0 => interval.IsLeftOpen() || !otherInterval.IsLeftOpen(),
                                  var comp => comp > 0
                              })
                         )
                         && (!otherInterval.IsLeftBounded()
                             || (interval.IsRightBounded()
                                 && interval.Right.CompareTo(otherInterval.Right) switch {
                                     0 => interval.IsRightOpen() || !otherInterval.IsRightOpen(),
                                     var comp => comp < 0
                                 }
                             )
                         )
               );
    }

    /// <summary> Determines if any values in <paramref name="interval"/> are in <paramref name="otherInterval"/>. </summary>
    /// <param name="interval"> First <see cref="IReadOnlyInterval{T}"/> to compare. </param>
    /// <param name="otherInterval"> Second <see cref="IReadOnlyInterval{T}"/> to compare fo first. </param>
    /// <typeparam name="T"> Type of bounds of the intervals. </typeparam>
    /// <returns>
    /// <see langword="true"/> if the intervals overlap. Always <see langword="false"/> if one of the intervals is empty.
    /// </returns>
    public static bool Overlaps<T>(this IReadOnlyInterval<T> interval, IReadOnlyInterval<T> otherInterval)
        where T : IComparable<T>
    {
        if (interval.IsEmpty() || otherInterval.IsEmpty())
        {
            return false;
        }

        var isLeftBounded = interval.IsLeftBounded();
        var isRightBounded = interval.IsRightBounded();
        var isOtherLeftBounded = otherInterval.IsLeftBounded();
        var isOtherRightBounded = otherInterval.IsRightBounded();
        if (!((isLeftBounded || isRightBounded) && (isOtherLeftBounded || isOtherRightBounded)))
        {
            return true;
        }

        return (isLeftBounded == isOtherLeftBounded) && (isRightBounded == isOtherRightBounded)
            ? !(isLeftBounded == isRightBounded
                && (
                    interval.Left.CompareTo(otherInterval.Right) switch {
                        0 => interval.IsLeftOpen() || otherInterval.IsRightOpen(),
                        var comp => comp > 0
                    }
                    || interval.Right.CompareTo(otherInterval.Left) switch {
                        0 => interval.IsRightOpen() || otherInterval.IsLeftOpen(),
                        var comp1 => comp1 < 0
                    })
                )
            : isLeftBounded && isOtherRightBounded
                ? !(interval.Left.CompareTo(otherInterval.Right) switch {
                    0 => interval.IsLeftOpen() || otherInterval.IsRightOpen(),
                    var comp => comp > 0
                })
                : !(interval.Right.CompareTo(otherInterval.Left) switch {
                    0 => interval.IsRightOpen() || otherInterval.IsLeftOpen(),
                    var comp2 => comp2 < 0
                });

        // Onderstaande code is vanuit de waarheidstabel opgesteld, bovenstaande code is logisch gerefactored vanuit de onderstaande code
        // //gevallen x:∅ en y:∅
        // if (interval.IsEmpty() || otherInterval.IsEmpty())
        // {
        //     return false;
        // }
        // //geval x:[u,u] en y:[u,u]
        // if (interval.SpansDomain() || otherInterval.SpansDomain())
        // {
        //     return true;
        // }
        // //gevallen x:[b,b],y:[b,b] en x:[u,b],y:[u,b] en x:[b,u],y:[b,u]
        // if ((interval.IsLeftBounded() == otherInterval.IsLeftBounded()) && (interval.IsRightBounded() == otherInterval.IsRightBounded()))
        // {
        //     return ! (interval.IsLeftBounded() == interval.IsRightBounded()
        //               && (
        //                   interval.IsRightOf<TInterval, TValue>(otherInterval)
        //                   || interval.IsLeftOf<TInterval, TValue>(otherInterval))
        //         );
        // }
        // //gevallen x:[b,u],y:[b,b] en x:[b,u],y:[u,b] en x:[b,b],y:[u,b]
        // if (interval.IsLeftBounded() && otherInterval.IsRightBounded())
        // {
        //     return ! interval.IsRightOf<TInterval, TValue>(otherInterval);
        // }
        // //gevallen x:[u,b],y:[b,b] en x:[u,b],y:[b,u] en x:[b,b],y:[b,u]
        // return ! interval.IsLeftOf<TInterval, TValue>(otherInterval);
    }

    /// <summary> Checks interval for degeneracy. Returns the interval's value as out parameter. </summary>
    /// <param name="interval"> <see cref="IReadOnlyInterval{T}"/> to check. </param>
    /// <param name="degenerateValue"> Out parameter containing the value of the interval. </param>
    /// <typeparam name="T"> Type of bounds of the interval. </typeparam>
    /// <returns> <see langword="true"/> if the intervals is degenerate; <see langword="false"/> otherwise. </returns>
    public static bool TryDegenerateValue<T>(this IReadOnlyInterval<T> interval, out T degenerateValue)
        where T : IComparable<T>
    {
        degenerateValue = interval.IsLeftOpen() ? interval.Right : interval.Left;
        return interval.IsDegenerate();
    }
}
