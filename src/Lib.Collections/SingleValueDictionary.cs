using System.Collections;

namespace Semantica.Collections;

public class SingleValueDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
    where TKey: struct
{
    private readonly TKey _defaultKey;
    private readonly TValue _value;
    
    public SingleValueDictionary(TValue value)
    {
        _value = value;
        _defaultKey = default(TKey)!;
    }
    
    public SingleValueDictionary(TValue value, TKey defaultKey)
    {
        _value = value;
        _defaultKey = defaultKey;
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => Enumerable.Repeat(new KeyValuePair<TKey, TValue>(_defaultKey, _value), 1).GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    public int Count => 1;
    public bool ContainsKey(TKey key) => true;
    public bool TryGetValue(TKey key, out TValue value) { value = _value; return true; }
    public TValue this[TKey key] => _value;
    public IEnumerable<TKey> Keys => Enumerable.Repeat(_defaultKey, 1);
    public IEnumerable<TValue> Values => Enumerable.Repeat(_value, 1);
}
