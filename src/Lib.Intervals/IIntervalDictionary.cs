using JetBrains.Annotations;

namespace Semantica.Intervals;

/// <summary>
/// A generic collection of <see cref="IReadOnlyInterval{T}"/> of keys and associated values. Intervals are not allowed to
/// overlap.
/// </summary>
/// <inheritdoc cref="IReadOnlyIntervalDictionary{T,T}"/>
public interface IIntervalDictionary<TKey, TValue> 
    : IIntervalDictionary<TKey, IInterval<TKey>, TValue>, IReadOnlyIntervalDictionary<TKey, TValue>
    where TKey : IComparable<TKey>
{}

/// <summary>
/// A generic collection of intervals of keys and associated values. Intervals are not allowed to overlap.
/// </summary>
/// <inheritdoc />
public interface IIntervalDictionary<in TKey, TInterval, TValue> : IReadOnlyIntervalDictionary<TKey, TInterval, TValue>
    where TKey : IComparable<TKey> 
    where TInterval : IReadOnlyInterval<TKey>, IEquatable<IReadOnlyInterval<TKey>>
{
    /// <summary>
    /// Determines whether the dictionary contains en element with the exact provided interval.
    /// </summary>
    /// <param name="interval"> Interval to search for. </param>
    /// <returns> <see langword="true"/> if the dictionary contains the exact <paramref name="interval"/>. </returns>
    [CollectionAccess(CollectionAccessType.Read)]
    bool Contains(TInterval interval);

    
    /// <summary>
    /// Searches for an interval containing <paramref name="key" /> and returns the associated <typeparamref name="TValue"/>
    /// value as out parameter <paramref name="value"/>.
    /// </summary>
    /// <param name="key"> The key to locate the value for. </param>
    /// <param name="value">
    /// Value associated with the <paramref name="key" />; or <see langword="default"/> if not found.
    /// </param>
    /// <returns> <see langword="true"/> if the dictionary contains an interval has <paramref name="key"/> within it. </returns>
    [CollectionAccess(CollectionAccessType.Read)]
    bool TryGet(TKey key, out TValue? value);

    /// <summary>
    /// Searches for an interval containing <paramref name="key" /> and returns it as out parameter <paramref name="interval"/>.
    /// </summary>
    /// <param name="key"> The key to locate the value for. </param>
    /// <param name="interval"> Out parameter containing the found interval, or <see langword="default"/> if not found. </param>
    /// <returns> <see langword="true"/> if the dictionary contains an interval has <paramref name="key"/> within it. </returns>
    [CollectionAccess(CollectionAccessType.Read)]
    bool TryGetInterval(TKey key, out TInterval? interval);

    /// <summary>
    /// <para>
    /// <see langword="get"/>: Searches the dictionary for the exact provided <paramref name="interval"/> and returns the
    /// associated value.
    /// </para>
    /// <para>
    /// <see langword="set"/>: If the exact provided <paramref name="interval"/> is present in the dictionary the currently
    /// associated value is replaced by <see langword="value"/>. Tries to adds the interval and value otherwise. Throws if
    /// interval partly overlaps with an existing interval. 
    /// </para>
    /// </summary>
    /// <param name="interval"> Interval to search for. </param>
    /// <exception cref="KeyNotFoundException">
    /// Throws on <see langword="get"/> if <paramref name="interval"/> is not present in the dictionary.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Throws on <see langword="set"/> if <paramref name="interval"/> partly overlaps with any existing interval.
    /// </exception>
    /// <returns> Value associated with the <paramref name="interval"/>. </returns>
    [CollectionAccess(CollectionAccessType.Read | CollectionAccessType.UpdatedContent)]
    TValue this[TInterval interval] { get; set; }

    /// <summary>
    /// Adds an element to the dictionary consisting of the specified key interval and associated value, but only if the
    /// interval does not overlap with a key interval already in the dictionary. 
    /// </summary>
    /// <param name="keyInterval"> The interval of keys associated with the value to add. </param>
    /// <param name="value"> The value to add. </param>
    /// <returns>
    /// <see langword="true"/> if the element is added; <see langword="false"/> if <paramref name="keyInterval"/> overlaps with
    /// any of the key intervals already in the dictionary. 
    /// </returns>
    [CollectionAccess(CollectionAccessType.UpdatedContent)]
    bool Add(TInterval keyInterval, TValue value);
}
