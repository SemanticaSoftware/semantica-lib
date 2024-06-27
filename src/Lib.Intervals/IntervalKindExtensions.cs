namespace Semantica.Intervals;

/// <summary>
/// Provides extension methods for <see cref="IntervalBoundKind"/>, <see cref="IntervalOpenKind"/>, as well as extension
/// methods for <see cref="IReadOnlyInterval{T}"/> using those properties.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static class IntervalKindExtensions
{
    /// <summary>
    /// <see langword="true"/> if left closed, and right open. 
    /// </summary>
    public static bool IsHalfOpen(this IntervalOpenKind kind) => kind == IntervalOpenKind.RightOpen;

    /// <summary>
    /// <see langword="true"/> if the left boundary is closed, and the right boundary is open. 
    /// </summary>
    public static bool IsHalfOpen<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.OpenKind.IsHalfOpen();

    /// <summary>
    /// <see langword="true"/> if left bounded (not infinite).
    /// </summary>
    public static bool IsLeftBounded(this IntervalBoundKind kind) => !kind.HasFlag(IntervalBoundKind.LeftUnbound);

    /// <summary>
    /// <see langword="true"/> if the left (lower) boundary is considered to be bound (not infinite).
    /// </summary>
    public static bool IsLeftBounded<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.BoundKind.IsLeftBounded();

    /// <summary>
    /// <see langword="true"/> if left closed (bound included within the interval). 
    /// </summary>
    public static bool IsLeftClosed(this IntervalOpenKind kind) => !kind.HasFlag(IntervalOpenKind.LeftOpen);

    /// <summary>
    /// <see langword="true"/> if the left (lower) boundary is considered to be closed (included within the interval).
    /// </summary>
    public static bool IsLeftClosed<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.OpenKind.IsLeftClosed();

    /// <summary>
    /// <see langword="true"/> if left open (bound not included within the interval). 
    /// </summary>
    public static bool IsLeftOpen(this IntervalOpenKind kind) => kind.HasFlag(IntervalOpenKind.LeftOpen);

    /// <summary>
    /// <see langword="true"/> if the left (lower) boundary is considered to be open (not included within the interval). 
    /// </summary>
    public static bool IsLeftOpen<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.OpenKind.IsLeftOpen();

    /// <summary>
    /// <see langword="true"/> if left unbounded (infinite).
    /// </summary>
    public static bool IsLeftUnbound(this IntervalBoundKind kind) => kind.HasFlag(IntervalBoundKind.LeftUnbound);

    /// <summary>
    /// <see langword="true"/> if the left (lower) boundary is considered to be unbound (infinite).
    /// </summary>
    public static bool IsLeftUnbound<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.BoundKind.IsLeftUnbound();

    /// <summary>
    /// <see langword="true"/> if right bounded (not infinite).
    /// </summary>
    public static bool IsRightBounded(this IntervalBoundKind kind) => !kind.HasFlag(IntervalBoundKind.RightUnbound);

    /// <summary>
    /// <see langword="true"/> if the right (upper) boundary is considered to be bound (not infinite).
    /// </summary>
    public static bool IsRightBounded<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.BoundKind.IsRightBounded();

    /// <summary>
    /// <see langword="true"/> if right closed (bound included within the interval). 
    /// </summary>
    public static bool IsRightClosed(this IntervalOpenKind kind) => !kind.HasFlag(IntervalOpenKind.RightOpen);

    /// <summary>
    /// <see langword="true"/> if the right (upper) boundary is considered to be closed (included within the interval).
    /// </summary>
    public static bool IsRightClosed<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.OpenKind.IsRightClosed();

    /// <summary>
    /// <see langword="true"/> if right open (bound not included within the interval). 
    /// </summary>
    public static bool IsRightOpen(this IntervalOpenKind kind) => kind.HasFlag(IntervalOpenKind.RightOpen);

    /// <summary>
    /// <see langword="true"/> if the right (upper) boundary is considered to be open (not included within the interval). 
    /// </summary>
    public static bool IsRightOpen<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.OpenKind.IsRightOpen();

    /// <summary>
    /// <see langword="true"/> if right unbounded (infinite).
    /// </summary>
    public static bool IsRightUnbound(this IntervalBoundKind kind) => kind.HasFlag(IntervalBoundKind.RightUnbound);

    /// <summary>
    /// <see langword="true"/> if the right (upper) boundary is considered to be unbound (infinite).
    /// </summary>
    public static bool IsRightUnbound<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T> => interval.BoundKind.IsRightUnbound();

    /// <summary>
    /// <see langword="true"/> if unbounded (infinite) on both sides.
    /// </summary>
    public static bool IsUnbound(this IntervalBoundKind kind)
    {
        return kind == IntervalBoundKind.Unbound;
    }    
    
    /// <summary>
    /// <see langword="true"/> if the interval is unbounded (infinite) on both sides.
    /// </summary>
    public static bool IsUnbound<T>(this IReadOnlyInterval<T> interval)
        where T : IComparable<T>
    {
        return interval.BoundKind.IsUnbound();
    }    
}
