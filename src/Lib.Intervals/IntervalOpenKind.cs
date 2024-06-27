namespace Semantica.Intervals;

/// <summary>
/// A flags enum that can indicating whether either the left or right bounds of an interval are closed or open. A closed bound
/// means that the bound's value itself is included in the interval, open means that the bound is not included in the interval.
/// <see langword="default"/> indicates both bounds are closed.
/// </summary>
[Flags]
public enum IntervalOpenKind : byte
{
    Closed = 0,
    LeftOpen = 1,
    RightOpen = 1 << 1,
    Open = LeftOpen | RightOpen,
}