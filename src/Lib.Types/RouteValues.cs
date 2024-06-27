using System.Collections;
using System.Diagnostics.CodeAnalysis;
using Semantica.Collections;
using Semantica.Patterns;

namespace Semantica.Types;

public readonly struct RouteValues : IEnumerable<KeyValuePair<string, object?>>, ICanBeEmpty
{
    private const int c_initialCapacity = 4;
    
    private RouteValues(KeyValueList<string, object?> values)
    {
        _values = values;
    }
    
    private readonly KeyValueList<string, object?>? _values;
    
    public IReadOnlyList<KeyValuePair<string, object?>> Values
    {
        get => _values ?? (IReadOnlyList<KeyValuePair<string, object?>>) ArraySegment<KeyValuePair<string, object?>>.Empty;
    }
    
    public RouteValues Add(string param, object value)
    {
        if (IsEmpty())
        {
            return new RouteValues(new KeyValueList<string, object?>(c_initialCapacity) {
                {param, value}
            });
        }
        
        var index = _values.IndexOf(pair => pair.Key == param);
        if (index >= 0)
        {
            _values[index] = new (param, value);
        }
        else 
        {
            _values.Add(new (param, value));
        }
        return this;
    }
    
    public RouteValues Set(string param, object value)
    {
        if (IsEmpty())
        {
            return new RouteValues(new KeyValueList<string, object?>(c_initialCapacity) {
                {param, value}
            });
        }

        var index = _values.IndexOf(pair => pair.Key == param);
        if (index >= 0)
        {
            var newValues = new KeyValueList<string, object?>(_values) {
                [index] = new (param, value)
            };
            return new RouteValues(newValues);
        }
        else
        {
            var newValues = new KeyValueList<string, object?>(_values.Count + 1);
            newValues.AddRange(_values);
            newValues.Add(new (param, value));
            return new RouteValues(newValues);
        }
    }

    [MemberNotNullWhen(returnValue: false, nameof(_values))]
    public bool IsEmpty()
    {
        return _values == null;
    }

    public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
    {
        return IsEmpty() 
            ? Enumerable.Empty<KeyValuePair<string, object?>>().GetEnumerator() 
            : _values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public static RouteValues Create(string param, object? value)
    {
        return new RouteValues(new KeyValueList<string, object?>{{param, value}});
    }

    public static RouteValues None => default;
}
