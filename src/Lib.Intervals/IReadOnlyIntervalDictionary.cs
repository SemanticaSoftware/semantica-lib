using JetBrains.Annotations;

namespace Semantica.Intervals;

/// <summary>
/// A generic read-only collection of <see cref="IInterval{T}"/> of keys and associated values. Intervals are not
/// allowed to overlap.
/// </summary>
/// <typeparam name="TKey"> Type of keys and the bounds of the intervals. </typeparam>
/// <typeparam name="TValue"> Type of values stored in the dictionary. </typeparam>
public interface IReadOnlyIntervalDictionary<TKey, out TValue> : IReadOnlyIntervalDictionary<TKey, IInterval<TKey>, TValue>
    where TKey : IComparable<TKey>
{}

/// <summary>
/// A generic read-only collection of intervals of keys and associated values. Intervals are not allowed to overlap.
/// </summary>
/// <typeparam name="TKey"> Type of keys and the bounds of the intervals. </typeparam>
/// <typeparam name="TInterval"> Type of the intervals. </typeparam>
/// <typeparam name="TValue"> Type of values stored in the dictionary. </typeparam>
public interface IReadOnlyIntervalDictionary<in TKey, out TInterval, out TValue>
    where TKey : IComparable<TKey>
    where TInterval : IReadOnlyInterval<TKey>, IEquatable<IReadOnlyInterval<TKey>>
{
    /// <summary>
    /// Determines whether the dictionary contains an interval that has the specified key within it.
    /// </summary>
    /// <param name="key"> Key to search for. </param>
    /// <returns> <see langword="true"/> if in interval in dictionary contains <paramref name="key"/>. </returns>
    [CollectionAccess(CollectionAccessType.Read)]
    bool Contains(TKey key);
    
    /// <summary>
    /// Collection of intervals in the dictionary in no specified order (typically in order they were added).
    /// </summary>
    [CollectionAccess(CollectionAccessType.Read)]
    IReadOnlyCollection<TInterval> Intervals { get; }

    /// <summary>
    /// Collection of values in the dictionary in no specified order (typically in order they were added).
    /// </summary>
    [CollectionAccess(CollectionAccessType.Read)]
    IReadOnlyCollection<TValue> Values { get; }
        
    /// <summary>
    /// Enumerates all intervals in the dictionary in ascending logical order of values.
    /// </summary>
    [CollectionAccess(CollectionAccessType.Read)]
    IEnumerable<TInterval> IntervalsAscending();

    /// <summary>
    /// Enumerates all intervals in the dictionary in descending logical order of values.
    /// </summary>
    [CollectionAccess(CollectionAccessType.Read)]
    IEnumerable<TInterval> IntervalsDescending();

    /// <summary>
    /// Searches for an interval containing <paramref name="key" /> and returns the associated <typeparamref name="TValue"/> value.
    /// </summary>
    /// <param name="key"> The key to locate the interval for. </param>
    /// <exception cref="KeyNotFoundException"> Throws if <paramref name="key"/> is not part of any interval. </exception>
    /// <returns> Value associated with the <paramref name="key" />. </returns>
    [CollectionAccess(CollectionAccessType.Read)]
    TValue this[TKey key] { get; }
}