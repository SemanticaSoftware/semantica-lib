using System.Diagnostics;

namespace Semantica.Intervals;

/// <summary>
/// Represents an interval of values.
/// </summary>
/// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
[DebuggerDisplay("Interval :{ToString()}")]
public readonly struct Interval<T> : IInterval<T>, IEquatable<Interval<T>>, IFormattable
    where T : IComparable<T>
{
    private const byte s_boundMask = ((byte)IntervalBoundKind.Unbound) << 2;
    private const byte s_isDegenerateMask = 1 << 4;
    private const byte s_isNotEmptyMask = 1 << 5;
    private const byte s_openMask = (byte)IntervalOpenKind.Open;

    /// <value>
    /// Two least significant bits for <see cref="IntervalOpenKind"/>.
    /// Subsequent two bits for <see cref="IntervalBoundKind"/>.
    /// Fifth bit for <see cref="IsDegenerate"/>.
    /// Sixth bit for not <see cref="IsEmpty"/>. Logic is inverted so that default value is empty.
    /// </value>
    private readonly byte _flags;

    /// <summary>
    /// Constructs an Interval. Degenerate and Empty flags will be determined using the bounds and kinds.
    /// </summary>
    /// <remarks> If a side is unbound, that side's open flag will be ignored and it will always be open. </remarks>
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="openKind"> <see cref="IntervalOpenKind"/> indicating if any bounds are open. Default is half-open. </param>
    /// <param name="boundKind"> <see cref="IntervalBoundKind"/> indicating if sides are bound or unbound. </param>
    /// <exception cref="ArgumentException">
    /// throws if <paramref name="left"/> is greater than <paramref name="right"/>.
    /// </exception>
    public Interval(
        T left,
        T right,
        IntervalOpenKind openKind = IntervalOpenKind.RightOpen,
        IntervalBoundKind boundKind = IntervalBoundKind.Bound)
        : this(left, right, openKind, boundKind, Interval.DetermineDegenerateEmpty(left, right, openKind, boundKind))
    {
        Interval.Guard(left, right, boundKind);
    }

    /// <summary>
    /// Constructs an <see cref="Interval{T}"/> that is a functional copy of another interval.
    /// </summary>
    /// <param name="interval"> Any interval implementing <see cref="IReadOnlyInterval{T}"/>. </param>
    public Interval(IReadOnlyInterval<T> interval)
        : this(
            interval.Left,
            interval.Right,
            interval.OpenKind,
            interval.BoundKind,
            (interval.IsDegenerate(), interval.IsEmpty()))
    {
    }

    /// <summary>
    /// constructor used in the static <see cref="Interval"/> methods; 
    /// </summary>
    internal Interval(
        T left,
        T right,
        IntervalOpenKind openKind,
        IntervalBoundKind boundKind,
        bool isDegenerate, 
        bool isEmpty)
        : this(left, right, openKind, boundKind, (isDegenerate, isEmpty))
    {
        Interval.Guard(left, right, boundKind);
    }

    private Interval(
        T left,
        T right,
        IntervalOpenKind openKind,
        IntervalBoundKind boundKind,
        (bool isDegenerate, bool isEmpty) flags)
    {
        _flags = ToFlags(openKind, boundKind, flags.isDegenerate, flags.isEmpty);
        Left = left;
        Right = right;
    }

    public IntervalBoundKind BoundKind => (IntervalBoundKind)((_flags & s_boundMask) >> 2);

    public T Left { get; }

    public IntervalOpenKind OpenKind => (IntervalOpenKind)(_flags & s_openMask);

    public T Right { get; }

    public static Interval<T> Empty => new();

    public bool Equals(Interval<T> other)
    {
        return _flags == other._flags
               && EqualityComparer<T>.Default.Equals(Left, other.Left)
               && EqualityComparer<T>.Default.Equals(Right, other.Right);
    }

    public bool Equals(IReadOnlyInterval<T>? other) => other != null && Interval.Equals(this, other);

    public override bool Equals(object? obj) => obj is Interval<T> other && Equals(other);

    public override int GetHashCode() => HashCode.Combine(_flags, Left, Right);

    public bool IsDegenerate() => (_flags & s_isDegenerateMask) != 0;

    public bool IsEmpty() => (_flags & s_isNotEmptyMask) == 0;

    private static byte ToFlags(IntervalOpenKind openKind, IntervalBoundKind boundKind, bool isDegenerate, bool isEmpty)
    {
        var flags = (s_openMask & ((uint)openKind | (uint)boundKind)) //If a side is unbound, that side cannot be closed. 
                    | (s_boundMask & (((uint)boundKind) << 2))
                    | (uint)(isDegenerate ? s_isDegenerateMask : 0)
                    | (uint)(isEmpty ? 0 : s_isNotEmptyMask);
        return (byte)flags;
    }

    public override string ToString() => Interval.ToString(this);

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return Interval.ToStringTryFormat(this, format, formatProvider);
    }

    public static bool operator ==(Interval<T> left, Interval<T> right) => left.Equals(right);

    public static bool operator !=(Interval<T> left, Interval<T> right) => !left.Equals(right);
}
