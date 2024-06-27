namespace Semantica.Intervals;

/// <summary>
/// A flags enum that can indicating if an interval is fully bound (default), or left- and/or right-unbound. 
/// </summary>
[Flags]
public enum IntervalBoundKind : byte
{
    Bound = 0,
    LeftUnbound = 1,
    RightUnbound = 1 << 1,
    Unbound = LeftUnbound | RightUnbound
}
