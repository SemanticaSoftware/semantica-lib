using System.Diagnostics.Contracts;

namespace Semantica.Intervals;

/// <summary>
/// Provides static methods used with <see cref="Interval{T}"/> and <see cref="IReadOnlyInterval{T}"/>.
/// </summary>
[Pure]
public static class Interval
{
    /// <summary>
    /// Determines the appropriate <see cref="IntervalBoundKind"/> value from two boolean values indicating if a side is
    /// unbound.  
    /// </summary>
    /// <param name="isLeftUnbound"> <see langword="true"/> if the left side is unbound. </param>
    /// <param name="isRightUnbound"> <see langword="true"/> if the right side is unbound. </param>
    /// <returns> <see cref="IntervalBoundKind"/> indicating an intervals bound/unbound value. </returns>
    public static IntervalBoundKind DetermineBoundKind(
        bool isLeftUnbound,
        bool isRightUnbound)
    {
        return (isLeftUnbound ? IntervalBoundKind.LeftUnbound : default)
               | (isRightUnbound ? IntervalBoundKind.RightUnbound : default);
    }

    /// <summary>
    /// Determines if parameter values would constitute an empty or degenerate interval.
    /// </summary>
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="openKind"> <see cref="IntervalOpenKind"/> indicating if any bounds are open. </param>
    /// <param name="boundKind"> <see cref="IntervalBoundKind"/> indicating whether sides are bound or unbound. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <returns>
    /// A tuple <see langword="(bool isDegenerate, bool isEmpty)"/> with two values where <see langword="true"/> indicates
    /// if the interval would be degenerate or empty respectively. Both values can never be <see langword="true"/>. 
    /// </returns>
    public static (bool isDegenerate, bool isEmpty) DetermineDegenerateEmpty<T>(
        T left,
        T right,
        IntervalOpenKind openKind,
        IntervalBoundKind boundKind)
        where T : IComparable<T>
    {
        if (boundKind != IntervalBoundKind.Bound) return (false, false);

        var areEqual = left.CompareTo(right) == 0;
        return openKind == IntervalOpenKind.Closed ? (areEqual, false) : (false, areEqual);
    }

    /// <summary>
    /// Determines the appropriate <see cref="IntervalOpenKind"/> value from two boolean values indicating if a bound is open.
    /// If a <paramref name="boundKind"/> is provided, guarantees a side that is unbound is always open.
    /// </summary>
    /// <param name="isLeftOpen"> <see langword="true"/> if the left bound is open. </param>
    /// <param name="isRightOpen"> <see langword="true"/> if the right bound is open. </param>
    /// <param name="boundKind"> Optional <see cref="IntervalBoundKind"/>. </param>
    /// <returns> <see cref="IntervalOpenKind"/> indicating an intervals open/closed bounds. </returns>
    public static IntervalOpenKind DetermineOpenKind(
        bool isLeftOpen,
        bool isRightOpen,
        IntervalBoundKind boundKind = default)
    {
        return (isLeftOpen ? IntervalOpenKind.LeftOpen : default)
               | (isRightOpen ? IntervalOpenKind.RightOpen : default)
               | (IntervalOpenKind)boundKind;
    }

    /// <summary> Makes an empty <see cref="Interval{T}"/>. Equivalent to using <see langword="default"/>. </summary>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <returns> An empty <see cref="Interval{T}"/>. </returns>
    public static Interval<T> Empty<T>()
        where T : IComparable<T> => new();

    /// <summary>
    /// Determines whether two intervals are equal.
    /// </summary>
    /// <param name="x"> The first <see cref="IReadOnlyInterval{T}"/> to compare. </param>
    /// <param name="y"> The second <see cref="IReadOnlyInterval{T}"/> to compare. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <returns> <see langword="true"/> if the specified intervals are equal; <see langword="false"/> otherwise. </returns>
    public static bool Equals<T>(IReadOnlyInterval<T> x, IReadOnlyInterval<T> y)
        where T : IComparable<T>
    {
        return x.BoundKind == y.BoundKind 
               && x.OpenKind == y.OpenKind
               && (x.IsLeftUnbound()
                   || EqualityComparer<T>.Default.Equals(x.Left, y.Left))
               && (x.IsRightUnbound()
                   || EqualityComparer<T>.Default.Equals(x.Right, y.Right));
    }

    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="boundKind"> <see cref="IntervalBoundKind"/> indicating whether sides are bound or unbound. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <exception cref="ArgumentException">
    /// Throws if <see cref="IntervalBase{T}.Left"/> is greater than <see cref="IntervalBase{T}.Right"/>.
    /// </exception>
    public static void Guard<T>(T left, T right, IntervalBoundKind boundKind)
        where T : IComparable<T>
    {
        if (boundKind == IntervalBoundKind.Bound && right.CompareTo(left) < 0)
        {
            throw new ArgumentException($"{nameof(IInterval<T>.Left)} has to be equal or greater than {nameof(IInterval<T>.Right)}.");
        }
    }

    /// <summary>
    /// Constructs an Interval. Degenerate and Empty flags will be determined using the bounds and kinds.
    /// </summary>
    /// <remarks> If a side is unbound, that side's open flag will be ignored and it will always be open. </remarks>
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="openKind"> <see cref="IntervalOpenKind"/> indicating if any bounds are open. </param>
    /// <param name="boundKind"> <see cref="IntervalBoundKind"/> indicating whether sides are bound or unbound. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <exception cref="ArgumentException">
    /// Throws if <paramref name="left"/> is greater than <paramref name="right"/>.
    /// </exception>
    public static Interval<T> Make<T>(
        T left,
        T right,
        IntervalOpenKind openKind,
        IntervalBoundKind boundKind)
    where T : IComparable<T>
    {
        return new Interval<T>(left, right, openKind, boundKind);
    }

    /// <summary>
    /// Constructs an interval. Degenerate and Empty flags will be determined using the bounds and kinds. Determines
    /// <see cref="Interval{T}.BoundKind"/> by evaluating <paramref name="unboundPredicate"/> for both bounds.
    /// </summary>
    /// <remarks> If a side is unbound, that side's open flag will be ignored and it will always be open. </remarks>
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="openKind"> <see cref="IntervalOpenKind"/> indicating if any bounds are open. </param>
    /// <param name="unboundPredicate"> Function that is called for each bound to determine if it's unbound. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <exception cref="ArgumentException">
    /// Throws if <paramref name="left"/> is greater than <paramref name="right"/>.
    /// </exception>
    public static Interval<T> Make<T>(
        T left,
        T right,
        IntervalOpenKind openKind,
        Func<T, bool> unboundPredicate)
        where T : IComparable<T>
    {
        return new Interval<T>(
            left,
            right,
            openKind,
            DetermineBoundKind(unboundPredicate(left), unboundPredicate(right)));
    }

    /// <summary>
    /// Constructs a degenerate interval.
    /// </summary>
    /// <param name="degenerateValue"> Value used for both boundaries of the interval. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    public static Interval<T> MakeDegenerate<T>(T degenerateValue)
        where T : IComparable<T>
    {
        return new(
            degenerateValue,
            degenerateValue,
            IntervalOpenKind.Closed,
            IntervalBoundKind.Bound,
            isDegenerate: true, 
            isEmpty: false);
    }

    /// <summary>
    /// Constructs a bound, half open interval (<see cref="IntervalOpenKind.RightOpen"/>).
    /// </summary>
    /// <remarks> If a side is unbound, that side's open flag will be ignored and it will always be open. </remarks>
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <exception cref="ArgumentException">
    /// Throws if <paramref name="left"/> is greater than <paramref name="right"/>.
    /// </exception>
    public static Interval<T> MakeHalfOpen<T>(
        T left,
        T right)
        where T : IComparable<T>
    {
        return new Interval<T>(left, right);
    }

    /// <summary>
    /// Constructs a half open interval (<see cref="IntervalOpenKind.RightOpen"/>). Determines
    /// <see cref="Interval{T}.BoundKind"/> by evaluating <paramref name="unboundPredicate"/> for both bounds.
    /// </summary>
    /// <remarks> If a side is unbound, that side's open flag will be ignored and it will always be open. </remarks>
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="unboundPredicate"> Function that is called for each bound to determine if it's unbound. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <exception cref="ArgumentException">
    /// Throws if <paramref name="left"/> is greater than <paramref name="right"/>.
    /// </exception>
    public static Interval<T> MakeHalfOpen<T>(
        T left,
        T right,
        Func<T, bool> unboundPredicate)
        where T : IComparable<T>
    {
        return new Interval<T>(
            left,
            right,
            IntervalOpenKind.RightOpen,
            DetermineBoundKind(unboundPredicate(left), unboundPredicate(right)));
    }
    
    /// <summary>
    /// Constructs an interval that is left unbound.
    /// </summary>
    /// <remarks> If a side is unbound, that side's open flag will be ignored and it will always be open. </remarks>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="openKind"> <see cref="IntervalOpenKind"/> that can indivate if the right bound is closed. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    public static Interval<T> MakeLeftUnbound<T>(T right, IntervalOpenKind openKind = IntervalOpenKind.RightOpen)
        where T : IComparable<T>
    {
        return new(
            right,
            right,
            openKind,
            IntervalBoundKind.LeftUnbound,
            isDegenerate: false,
            isEmpty: false);
    }

    /// <summary>
    /// Constructs an interval that is right unbound.
    /// </summary>
    /// <remarks> If a side is unbound, that side's open flag will be ignored and it will always be open. </remarks>
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="openKind"> <see cref="IntervalOpenKind"/> that can indivate if the right bound is closed. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    public static Interval<T> MakeRightUnbound<T>(T left, IntervalOpenKind openKind = IntervalOpenKind.RightOpen)
        where T : IComparable<T>
    {
        return new(
            left,
            left,
            openKind,
            IntervalBoundKind.RightUnbound,
            isDegenerate: false, 
            isEmpty: false);
    }

    /// <summary>
    /// Formats the value of the provided interval.
    /// </summary>
    /// <param name="interval"> The <see cref="IReadOnlyInterval{T}"/> to format. </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <returns> A string representation of the interval. </returns>
    public static string ToString<T>(IReadOnlyInterval<T> interval)
        where T : IComparable<T>
    {
        if (interval.IsEmpty())
        {
            return "∅";
        }
        return $"{(interval.IsLeftOpen() ? "<" : "[")}{(interval.IsLeftBounded() ? interval.Left : "←")},{(interval.IsRightBounded() ? interval.Right : "→")}{(interval.IsRightOpen() ? ">" : "]")}";
    }

    /// <summary>
    /// Formats the value of the provided interval using the specified format.
    /// </summary>
    /// <param name="interval"> The <see cref="IReadOnlyInterval{T}"/> to format. </param>
    /// <param name="format">
    /// The format to use. -or- A null reference to use the default format defined for the type of the IFormattable
    /// implementation.
    /// </param>
    /// <param name="formatProvider">
    /// The provider to use to format the value. -or- A null reference to obtain the numeric format information from the current
    /// locale setting of the operating system.
    /// </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/>, <see cref="IFormattable"/> type. </typeparam>
    /// <returns> A string representation of the interval, with formatted boundary values. </returns>
    public static string ToString<T>(
        IReadOnlyInterval<T> interval,
        string? format,
        IFormatProvider? formatProvider = null)
        where T : IComparable<T>, IFormattable
    {
        return ToString(
            interval.Left,
            interval.Right,
            interval.IsEmpty(),
            interval.OpenKind,
            interval.BoundKind,
            format,
            formatProvider);
    }

    /// <summary>
    /// Formats two value as an interval using the specified format.
    /// </summary>
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="isEmpty"> <see langword="true"/> if the interval is empty. </param>
    /// <param name="openKind"> <see cref="IntervalOpenKind"/> indicating if any bounds are open. </param>
    /// <param name="boundKind"> <see cref="IntervalBoundKind"/> indicating if sides are bound or unbound. </param>
    /// <param name="format">
    /// The format to use. -or- A null reference to use the default format defined for the type of the IFormattable
    /// implementation.
    /// </param>
    /// <param name="formatProvider">
    /// The provider to use to format the value. -or- A null reference to obtain the numeric format information from the current
    /// locale setting of the operating system.
    /// </param>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <returns> A string representation of the interval. </returns>
    public static string ToString<T>(
        T left,
        T right,
        bool isEmpty,
        IntervalOpenKind openKind,
        IntervalBoundKind boundKind,
        string? format = null,
        IFormatProvider? formatProvider = null)
        where T : IFormattable
    {
        if (isEmpty)
        {
            return "∅";
        }
        var sleft = boundKind.IsLeftUnbound() ? "←" : left.ToString(format, formatProvider);
        var sright = boundKind.IsRightUnbound() ? "→" : right.ToString(format, formatProvider);
        return $"{(openKind.IsLeftOpen() ? "<" : "[")}{sleft},{sright}{(openKind.IsRightOpen() ? ">" : "]")}";
    }

    /// <summary>
    /// Formats the value of the provided interval using the specified format, if bounds implement <see cref="IFormattable"/>.
    /// </summary>
    /// <param name="interval"> The <see cref="IReadOnlyInterval{T}"/> to format. </param>
    /// <param name="format">
    /// The format to use. -or- A null reference to use the default format defined for the type of the IFormattable
    /// implementation.
    /// </param>
    /// <param name="formatProvider">
    /// The provider to use to format the value. -or- A null reference to obtain the numeric format information from the current
    /// locale setting of the operating system.
    /// </param>
    /// <remarks>
    /// If <typeparamref name="T"/> does not implement <see cref="IFormattable"/>, default <see cref="object.ToString()"/> is
    /// used.
    /// </remarks>
    /// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
    /// <returns> A string representation of the interval, with formatted boundary values. </returns>    
    public static string ToStringTryFormat<T>(IReadOnlyInterval<T> interval, string? format, IFormatProvider? formatProvider)
        where T : IComparable<T>
    {
        return interval is { Left: IFormattable left, Right: IFormattable right }
            ? Interval.ToString(left, right, interval.IsEmpty(), interval.OpenKind, interval.BoundKind, format, formatProvider)
            : Interval.ToString(interval);
    }
}
