using Semantica.Patterns;

namespace Semantica.Intervals;

/// <summary>
/// An implementation of <see cref="IInterval{T}"/> that is defined by a center point (<see cref="TargetValue"/>) and a
/// distance of the bounds to that center point (<see cref="Margin"/>). This means these intervals are always bounded on both
/// sides.  
/// </summary>
/// <remarks>
/// Is considered empty when <see cref="Margin"/> is <see langword="default"/>, which is slightly different from other typesof
/// intervals. Consequently, these intervals are never considered degenerate.
/// </remarks>
/// <typeparam name="T"> Any type implementing <see cref="IArithmatic{T}"/> and <see cref="IComparable{T}"/>. </typeparam>
public readonly struct TargetInterval<T> : IInterval<T>, IEquatable<TargetInterval<T>>, IFormattable
    where T : struct, IArithmatic<T>
{
    /// <summary>
    /// Constructs the interval centered around <paramref name="targetValue"/>, with either bounds <paramref name="margin"/>
    /// away from either side of that value.
    /// </summary>
    /// <param name="targetValue"> The center of the interval. </param>
    /// <param name="margin"> The margin of the interval (distance of either bound to the interval). </param>
    /// <param name="openKind"> <see cref="IntervalOpenKind"/> value indicating whether the bounds are open or closed. </param>
    public TargetInterval(T targetValue, T margin, IntervalOpenKind openKind = IntervalOpenKind.Closed)
    {
        TargetValue = targetValue;
        Margin = margin;
        OpenKind = openKind;
    }
    
    public IntervalBoundKind BoundKind => IntervalBoundKind.Bound;
    
    public T Left => TargetValue.Subtract(Margin);

    /// <summary>
    /// The margin (radius) of the interval. This value is subtracted from <see cref="TargetValue"/> to obtain
    /// <see cref="Left"/>; added to get <see cref="Right"/>.
    /// </summary>
    public T Margin { get; }

    public IntervalOpenKind OpenKind { get; }

    public T Right => TargetValue.Add(Margin);

    /// <summary>
    /// The value representing the center of the interval, from which the bounds are calculated. 
    /// </summary>
    public T TargetValue { get; }

    public bool Equals(IReadOnlyInterval<T>? other)
    {
        return other != null && Interval.Equals(this, other);
    }

    public override bool Equals(object? obj)
    {
        return obj is IReadOnlyInterval<T> other && Interval.Equals(this, other);
    }

    public bool Equals(TargetInterval<T> other)
    {
        return Margin.CompareTo(other.Margin) == 0
               && TargetValue.CompareTo(other.TargetValue) == 0;
    }

    public override int GetHashCode() => HashCode.Combine(Margin, TargetValue, OpenKind);

    public bool IsEmpty() => EqualityComparer<T>.Default.Equals(Margin, default(T));

    public bool IsDegenerate() => false;

    public override string ToString() => Interval.ToString(this);

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return Interval.ToStringTryFormat(this, format, formatProvider);
    }

    public static bool operator ==(TargetInterval<T> left, TargetInterval<T> right) => left.Equals(right);
    public static bool operator !=(TargetInterval<T> left, TargetInterval<T> right) => !left.Equals(right);
}
