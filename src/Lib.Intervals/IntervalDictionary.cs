namespace Semantica.Intervals;

/// <inheritdoc cref="IntervalDictionary{T,T,T}"/>
public class IntervalDictionary<TKey, TValue>
    : IntervalDictionary<TKey, IInterval<TKey>, TValue>, IIntervalDictionary<TKey, TValue>
    where TKey : IComparable<TKey>
{
    /// <inheritdoc />
    public IntervalDictionary() 
    {
    }

    /// <inheritdoc />
    public IntervalDictionary(IEnumerable<KeyValuePair<IInterval<TKey>, TValue>> pairs) : base(pairs)
    {
    }

    /// <inheritdoc />
    public IntervalDictionary(IEnumerable<(IInterval<TKey> interval, TValue value)> tuples) : base(tuples)
    {
    }
}

/// <inheritdoc />
public class IntervalDictionary<TKey, TInterval, TValue> : IIntervalDictionary<TKey, TInterval, TValue>
    where TKey : IComparable<TKey> 
    where TInterval : IReadOnlyInterval<TKey>, IEquatable<IReadOnlyInterval<TKey>>
{
    //Dictionary that holds the actual T's
    private readonly Dictionary<TInterval, TValue> _dictionary;
    //Ordered linked list that hold just the intervals used to find the relevant interval efficiently
    private readonly LinkedList<TInterval> _intervals;

    /// <summary>
    /// Constructs an empty instance.
    /// </summary>
    public IntervalDictionary()
    {
        _dictionary = new Dictionary<TInterval, TValue>();
        _intervals = new LinkedList<TInterval>();
    }

    /// <summary>
    /// Constucts an instance, adding all pairs of intervals and values.
    /// </summary>
    /// <param name="pairs">
    /// An <see cref="IEnumerable{T}"/> of <see cref="KeyValuePair{T,T}"/>, where they keys are intervals.
    /// </param>
    /// <exception cref="ArgumentException"> Throws if any of the intervals have a non-empty intersection. </exception>
    public IntervalDictionary(IEnumerable<KeyValuePair<TInterval, TValue>> pairs)
        :this()
    {
        foreach ((var interval, var value) in pairs)
        {
            if (! Add(interval, value))
            {
                throw new ArgumentException($"{nameof(pairs)} contains overlap at [{interval}>");
            }
        }
    }

    /// <summary>
    /// Constucts an instance, adding all tuples of intervals and values.
    /// </summary>
    /// <param name="tuples"> An <see cref="IEnumerable{T}"/> of tuples of intervals and corresponding values. </param>
    /// <exception cref="ArgumentException"> Throws if any of the intervals have a non-empty intersection. </exception>
    public IntervalDictionary(IEnumerable<(TInterval interval, TValue value)> tuples)
        :this()
    {
        foreach ((var interval, var value) in tuples)
        {
            if (! Add(interval, value))
            {
                throw new ArgumentException($"{nameof(tuples)} contains overlap at [{interval}>");
            }
        }
    }

    public IReadOnlyCollection<TInterval> Intervals => _dictionary.Keys;
        
    public IReadOnlyCollection<TValue> Values => _dictionary.Values;

    public TValue this[TInterval interval]
    {
        get
        {
            return _dictionary[interval];
        }
        set
        {
            if (_dictionary.ContainsKey(interval))
            {
                _dictionary[interval] = value;
            }
            else if (! Add(interval, value))
            {
                throw new ArgumentException($"duplicate or overlapping interval: {interval}");
            }
        }
    }

    public TValue this[TKey key]
    {
        get => TryGet(key, out var value) ? value! : throw new KeyNotFoundException();
    }

    public bool Contains(TKey key) => TryGetInterval(key, out _);

    public bool Contains(TInterval interval) => _intervals.Contains(interval);

    public IEnumerable<TInterval> IntervalsAscending()
    {
        return _intervals;
    }

    public IEnumerable<TInterval> IntervalsDescending()
    {
        var loopNode = _intervals.Last;
        while (loopNode != null)
        {
            yield return loopNode.Value;
            loopNode = loopNode.Previous;
        }
    }

    public bool TryGet(TKey key, out TValue? value)
    {
        var foundInterval = _intervals
                            .TakeWhile(interval => interval.Left.CompareTo(key) <= 0)
                            .FirstOrDefault(interval => key.IsWithin(interval));
        if (foundInterval == null || foundInterval.IsEmpty())
        {
            value = default(TValue?);
            return false;
        }
        value = _dictionary[foundInterval];
        return true;
    }

    public bool TryGetInterval(TKey key, out TInterval? interval)
    {
        var foundInterval = _intervals.TakeWhile(interval => interval.Left.CompareTo(key) <= 0)
                                      .FirstOrDefault(interval => key.IsWithin(interval));
        if (foundInterval == null || foundInterval.IsEmpty())
        {
            interval = default(TInterval?);
            return false;
        }
        interval = foundInterval;
        return true;
    }
    
    public bool Add(TInterval keyInterval, TValue value)
    {
        if (keyInterval.IsEmpty())
        {
            return false;
            //return _dictionary.TryAdd(TInterval.Empty(), value); //not possible before c# 8.0
        } 
        
        if (_intervals.TakeWhile(interval => interval.Left.CompareTo(keyInterval.Right) <= 0)
                      .Any(interval => interval.Overlaps<TKey>(keyInterval)))
        {
            return false;
        }
        var lastNodeBefore = GetLastNodeBefore(keyInterval.Left);
        if (lastNodeBefore != null)
        {
            _intervals.AddAfter(lastNodeBefore, keyInterval);
        }
        else
        {
            _intervals.AddFirst(keyInterval);
        }
        _dictionary.Add(keyInterval, value);
        return true;
    }

    private LinkedListNode<TInterval>? GetLastNodeBefore(TKey key)
    {
        for (var loopNode = _intervals.Last; loopNode != null; loopNode = loopNode.Previous)
        {
            if (loopNode.Value.Right.CompareTo(key) <= 0)
            {
                return loopNode;
            }
        }
        return null;
    }
}
