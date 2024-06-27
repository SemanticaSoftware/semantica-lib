using System.Diagnostics;
using Semantica.Patterns;

namespace Semantica.Intervals;

/// <summary>
/// A class implementing <see cref="IInterval{T}"/>, where the bounds implement <see cref="ICanBeEmpty"/>, where if
/// calling <see cref="ICanBeEmpty.IsEmpty"/> for a bound returns <see langword="true"/>, that bound is considered unbounded.   
/// </summary>
/// <typeparamref name="T">
/// Any type implementing <see cref="ICanBeEmpty"/> and <see cref="IComparable{T}"/>. 
/// </typeparamref>
/// <inheritdoc />
[DebuggerDisplay("EmpyUnbindsInterval of {TypeName}:{ToString()}")]
public class EmptyUnbindsInterval<T> : IntervalBase<T>
    where T : IComparable<T>, ICanBeEmpty
{
    public EmptyUnbindsInterval(T left, T right, IntervalOpenKind openKind = IntervalOpenKind.RightOpen) : base((left, right))
    {
        Interval.Guard(left, right, Interval.DetermineBoundKind(left.IsEmpty(), right.IsEmpty()));
        IsLeftOpen = openKind.IsLeftOpen();
        IsRightOpen = openKind.IsRightOpen();
    }

    public EmptyUnbindsInterval(IReadOnlyInterval<T> interval) : base(interval)
    {
        IsLeftOpen = interval.IsLeftOpen();
        IsRightOpen = interval.IsRightOpen();
    }

    public override bool IsLeftOpen { get; }
    
    public override bool IsLeftUnbound => Left.IsEmpty();
    
    public override bool IsRightOpen { get; }
    
    public override bool IsRightUnbound => Right.IsEmpty();

    public override bool IsDegenerate() => Interval.DetermineDegenerateEmpty(Left, Right, OpenKind, BoundKind).isDegenerate;

    public override bool IsEmpty() => Interval.DetermineDegenerateEmpty(Left, Right, OpenKind, BoundKind).isDegenerate;

    public static EmptyUnbindsInterval<T> Make(T left, T right) => new EmptyUnbindsInterval<T>(left, right);

    public static EmptyUnbindsInterval<T> Make(T left, T right, IntervalOpenKind openKind) =>
        new EmptyUnbindsInterval<T>(left, right, openKind);

    public static EmptyUnbindsInterval<T> Make(T left, T right, IntervalOpenKind openKind, IntervalBoundKind boundKind) =>
        new EmptyUnbindsInterval<T>(left, right, openKind);

}