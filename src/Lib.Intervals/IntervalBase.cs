namespace Semantica.Intervals;

/// <summary>
/// Base implementation of <see cref="IInterval{T}"/> 
/// </summary>
/// <inheritdoc cref="IInterval{T}"/>
public abstract class IntervalBase<T> : IInterval<T>, IFormattable
    where T : IComparable<T>
{
    /// <param name="left"> Left (lower) boundary of the interval. </param>
    /// <param name="right"> Right (upper) boundary of the interval. </param>
    /// <param name="boundKind"> The <see cref="IntervalBoundKind"/> used for guarding (not stored!). </param>
    /// <exception cref="ArgumentException">
    /// throws if <paramref name="left"/> is greater than <paramref name="right"/>.
    /// </exception>
    protected IntervalBase(T left, T right, IntervalBoundKind boundKind) : this((left, right))
    {
        Interval.Guard(Left, Right, boundKind);
    }

    /// <summary>
    /// Does not do left-right comparison because it assumes that was done when <paramref name="interval"/> was constructed. 
    /// </summary>
    /// <param name="interval"> Tuple with left and right values of type <typeparamref name="T"/>. </param>
    protected IntervalBase(IReadOnlyInterval<T> interval) : this((interval.Left, interval.Right))
    {
    }

    /// <summary>
    /// Does not do left-right comparison. Only use if order is already checked, or call <see cref="Interval.Guard{T}"/>.  
    /// </summary>
    /// <param name="interval"> Tuple with left and right values of type <typeparamref name="T"/>. </param>
    protected IntervalBase((T left, T right) interval)
    {
        Left = interval.left;
        Right = interval.right;
    }

    public virtual IntervalBoundKind BoundKind => Interval.DetermineBoundKind(IsLeftUnbound, IsRightUnbound);

    /// <summary> <see langword="true"/> if the left bound is open; <see langword="false"/> if it's closed. </summary>
    public abstract bool IsLeftOpen { get; }
    
    /// <summary> <see langword="true"/> if the left side is unbound; <see langword="false"/> if it's bound. </summary>
    public abstract bool IsLeftUnbound { get; }
    
    /// <summary> <see langword="true"/> if the right bound is open; <see langword="false"/> if it's closed. </summary>
    public abstract bool IsRightOpen { get; }
    
    /// <summary> <see langword="true"/> if the right side is unbound; <see langword="false"/> if it's bound. </summary>
    public abstract bool IsRightUnbound { get; }

    public T Left { get; }

    public virtual IntervalOpenKind OpenKind => Interval.DetermineOpenKind(IsLeftOpen, IsRightOpen, BoundKind);

    public T Right { get; }

    public virtual bool Equals(IReadOnlyInterval<T>? other)
    {
        return other is not null && Interval.Equals(this, other);
    }

    public override bool Equals(object? obj)
    {
        return obj is not null
               && (ReferenceEquals(this, obj)
                   || obj is IInterval<T> interval && Interval.Equals(this, interval));
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Left, Right);
    }

    public virtual bool IsDegenerate() => Interval.DetermineDegenerateEmpty(Left, Right, OpenKind, BoundKind).isDegenerate;

    public virtual bool IsEmpty() => Interval.DetermineDegenerateEmpty(Left, Right, OpenKind, BoundKind).isEmpty;

    public override string ToString() => Interval.ToString(this);

    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        return Interval.ToStringTryFormat(this, format, formatProvider);
    }

    /// <value>
    /// Name of type <typeparamref name="T"/>, used for <see cref="System.Diagnostics.DebuggerDisplayAttribute"/>
    /// </value>
    private static string TypeName => typeof(T).Name;
}