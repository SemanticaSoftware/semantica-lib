namespace Semantica.Intervals;

/// <summary>
/// Provides extension methods for <see cref="IReadOnlyIntervalDictionary{T,T,T}"/>.
/// </summary>
public static class IntervalDictionaryExtensions
{
    /// <summary>
    /// Retrieves the interval from <paramref name="dictionary"/> with <see cref="IReadOnlyInterval{T}.Left"/> equal to the provided
    /// key.
    /// </summary>
    /// <remarks>
    /// Note that the interval is returned regardless of the key being within the interval (<see cref="IntervalOpenKind"/>).
    /// </remarks>
    /// <param name="dictionary"> Dictionary to search for intervals. </param>
    /// <param name="left"> Key to search for. </param>
    /// <typeparam name="TValue"> Type of values stored in the dictionary. </typeparam>
    /// <typeparam name="TKey"> Type of the bounds of the intervals. </typeparam>
    /// <typeparam name="TInterval"> Type of the intervals. </typeparam>
    /// <returns> Interval with <see cref="IReadOnlyInterval{T}.Left"/> equal to <paramref name="left"/>. </returns>
    public static TInterval? GetIntervalWithLeft<TKey, TInterval, TValue>(
        this IReadOnlyIntervalDictionary<TKey, TInterval, TValue> dictionary, TKey left)
        where TKey : struct, IComparable<TKey> 
        where TInterval : IInterval<TKey>
    {
        return dictionary.TryGetIntervalWithLeft(left, out var interval) ? interval : default;
    }

    /// <summary>
    /// Searches <paramref name="dictionary"/> for the interval with <see cref="IReadOnlyInterval{T}.Left"/> equal to the provided key.
    /// </summary>
    /// <remarks>
    /// Note that an interval will match regardless of the key being within the interval (<see cref="IntervalOpenKind"/>).
    /// </remarks>
    /// <param name="dictionary"> Dictionary to search for intervals. </param>
    /// <param name="left"> Key to search for. </param>
    /// <param name="interval">
    /// Out parameter that contains the interval with <see cref="IReadOnlyInterval{T}.Left"/> equal to <paramref name="left"/> if
    /// found; default otherwise.
    /// </param>
    /// <typeparam name="TValue"> Type of values stored in the dictionary. </typeparam>
    /// <typeparam name="TKey"> Type of the bounds of the intervals. </typeparam>
    /// <typeparam name="TInterval"> Type of the intervals. </typeparam>
    /// <returns> <see langword="true"/> if such an interval is contained in the dictionary. </returns>
    public static bool TryGetIntervalWithLeft<TKey, TInterval, TValue>(
        this IReadOnlyIntervalDictionary<TKey, TInterval, TValue> dictionary, TKey left, out TInterval? interval)
        where TKey : struct, IComparable<TKey> 
        where TInterval : IInterval<TKey>
    {
        if (dictionary.IntervalsAscending()
                      .Select(intvl => (intvl, comp: intvl.Left.CompareTo(left)))
                      .SkipWhile(tupl => tupl.comp < 0)
                      .TryFirst(out var tuple) && tuple.comp == 0)
        {
            interval = tuple.intvl;
            return true;
        }

        interval = default;
        return false;
    }
}
