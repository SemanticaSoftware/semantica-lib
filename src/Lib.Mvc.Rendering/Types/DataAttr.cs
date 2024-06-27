using System.Collections.Generic;
using System.Linq;
using Semantica.Patterns;

namespace Semantica.Mvc.Rendering.Types;

/// <summary>
///     Represents a data-dash attribute and it's value, or a set of data-dash attributes and it's values
/// </summary>
public struct DataAttr : ICanBeEmpty
{
    private readonly KeyValuePair<string, object>[] _data;

    public DataAttr(string dataName, object dataValue)
    {
        _data = new[]{ new KeyValuePair<string, object>(dataName, dataValue) };
    }

    private DataAttr(KeyValuePair<string, object>[] data)
    {
        _data = data;
    }

    public int Length => _data?.Length ?? 0;
    public IEnumerable<KeyValuePair<string, object>> Values => _data ?? Enumerable.Empty<KeyValuePair<string, object>>();

    public bool Contains(string dataName)
    {
        return _data.Any(pair => pair.Key == dataName);
    }

    public override string ToString()
    {
        return string.Join(" ", Values.Select(ToDataAttribute));
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public static DataAttr Empty => new DataAttr();

    public static DataAttr operator +(DataAttr left, DataAttr right)
    {
        if (right.IsEmpty())
        {
            return left;
        }
        if (left.IsEmpty())
        {
            return right;
        }

        var target = new KeyValuePair<string, object>[left.Length + right.Length];
        left._data.CopyTo(target, 0);
        right._data.CopyTo(target, left.Length);
        return new DataAttr(target);
    }

    public static DataAttr Make(string dataName, object dataValue)
    {
        return dataValue == null ? Empty : new DataAttr(dataName, dataValue);
    }

    public static string DataNameToAttribute(string dataName)
    {
        return $"data-{dataName.ToLower().Replace("_", "-")}";
    }

    public static string ToDataAttribute(KeyValuePair<string, object> pair)
    {
        return $"{DataNameToAttribute(pair.Key)}={pair.Value}";
    }
}
