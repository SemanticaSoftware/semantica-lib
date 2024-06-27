using JetBrains.Annotations;

namespace Semantica.Collections;

public class KeyValueList<TKey, TValue> : List<KeyValuePair<TKey, TValue>>
{
    public KeyValueList() { }
    
    public KeyValueList(int capacity) : base(capacity) { }
    
    public KeyValueList([NotNull] IEnumerable<KeyValuePair<TKey, TValue>> collection) : base(collection) { }
    
    public void Add(TKey key, TValue value)
    {
        Add(new KeyValuePair<TKey, TValue>(key, value));
    }
}
