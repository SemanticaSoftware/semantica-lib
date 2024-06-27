using System.Diagnostics.Contracts;
using Semantica.Patterns;

namespace Semantica.Intervals;

/// <summary>
/// Represents an interval of values. The interval is considered empty if it has either no, or a single value (a degenerate
/// interval). 
/// </summary>
/// <remarks>
/// Implementations have to guarantee that <see cref="Left"/> is not greater than <see cref="Right"/>.
/// Obviously, when T is not immutable this cannot be guaranteed after creation. 
/// </remarks>
/// <typeparam name="T"> Any <see cref="IComparable{T}"/> type. </typeparam>
public interface IReadOnlyInterval<out T> : ICanBeEmpty
    where T : IComparable<T>
{
    /// <value> Lower boundary of the interval. </value>
    T Left { get; }

    /// <value> Upper boundary of the interval. </value>
    T Right { get; }

    /// <summary> Indicates if the interval is fully bound, or left- and/or right-unbound. </summary>
    /// <remarks> When a side is unbound, that boundary's property are never used for comparisons. </remarks>
    IntervalBoundKind BoundKind { get; }

    /// <summary> Indicates if the interval is closed on both sides, or left- and/or right-open. </summary>
    IntervalOpenKind OpenKind { get; }

    /// <summary> <see langword="true"/> if the interval has only a single element. </summary>
    [Pure] bool IsDegenerate();
}