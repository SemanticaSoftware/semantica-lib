using Semantica.Intervals;

namespace Semantica.Lib.Tests.Core.Test._Mocks;

/// <summary>
///     Implementatie van <see cref="IInterval{T}"/> ten behoeve van UnitTests
/// </summary>
/// <inheritdoc cref="IInterval{T}"/>
internal readonly struct TestInterval : IInterval<decimal>
{

    public TestInterval(
        decimal left,
        decimal right,
        IntervalOpenKind openKind = IntervalOpenKind.RightOpen,
        IntervalBoundKind boundKind = IntervalBoundKind.Bound) : this()
    {
        Filled = true;
        Left = left;
        Right = right;
        BoundKind = boundKind;
        OpenKind = openKind;
    }

    public bool Filled { get; }
    
    public decimal Left { get; }
    
    public decimal Right { get; }
    
    public IntervalBoundKind BoundKind { get; }
    
    public IntervalOpenKind OpenKind { get; }

    public bool IsDegenerate() => false;

    public bool IsEmpty() => ! Filled;

    public static TestInterval GetSome() => new TestInterval(1m, 9m);
        
    public static TestInterval GetEmpty() => new TestInterval();

    public bool Equals(IReadOnlyInterval<decimal>? other)
    {
        if (other == null) return false;

        return Interval.Equals(this, other);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;

        return obj is TestInterval range && Equals(range);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Filled, Left, Right, BoundKind, OpenKind);
    }


    public override string ToString()
    {
        return Interval.ToString(this);
    }

    public static bool operator ==(TestInterval left, TestInterval right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(TestInterval left, TestInterval right)
    {
        return !left.Equals(right);
    }
}