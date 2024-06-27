using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Semantica.Checks;

namespace Semantica.Mvc.Types;

/// <summary>
///     Dit is niet een echte dictionary, gewoon een wrapper om een simpele array, en implementeert alleen de IEnumerable methods.
///     De class is bedoeld voor plekken in het framework die IDictionary als input verwachten, en vervolgens alleen de keyvaluepairs enumereren.
/// </summary>
public class CheapDictionary : IDictionary<string, object>, IReadOnlyList<KeyValuePair<string, object>>
{
    private readonly IReadOnlyList<KeyValuePair<string, object>> _values;

    public CheapDictionary([NotNull] IReadOnlyList<KeyValuePair<string, object>> values)
    {
        Check.NotNull(values).Contract();
        _values = values;
    }

    public int Count => _values.Count;

    public bool IsReadOnly => false;

    public KeyValuePair<string, object> this[int index] => _values[index];

    public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
    {
        return _values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(KeyValuePair<string, object> item)
    {
        throw InvalidUseException();
    }

    public void Clear()
    {
        throw InvalidUseException();
    }

    public bool Contains(KeyValuePair<string, object> item)
    {
        throw InvalidUseException();
    }

    public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
    {
        throw InvalidUseException();
    }

    public bool Remove(KeyValuePair<string, object> item)
    {
        throw InvalidUseException();
    }

    public bool ContainsKey(string key)
    {
        throw InvalidUseException();
    }

    public void Add(string key, object value)
    {
        throw InvalidUseException();
    }

    public bool Remove(string key)
    {
        throw InvalidUseException();
    }

    public bool TryGetValue(string key, out object value)
    {
        throw InvalidUseException();
    }

    public object this[string key]
    {
        get => throw InvalidUseException();
        set => throw InvalidUseException();
    }

    public ICollection<string> Keys => throw InvalidUseException();

    public ICollection<object> Values => throw InvalidUseException();

    private Exception InvalidUseException()
    {
        return new NotSupportedException("CheapDictionary is used as something else than IEnumerable<KeyValuePair>. Use ArrayDictionary or Dictionary instead");
    }
}