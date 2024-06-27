using System;
using Semantica.Patterns;

namespace Semantica.TestTools.Core.ValueTypes;

public readonly struct ComparableCanBeEmpty : IComparable<ComparableCanBeEmpty>, ICanBeEmpty
{
    public ComparableCanBeEmpty(int? value)
    {
        Value = value;
    }

    private int? Value { get; }
        
    public bool IsEmpty()
    {
        return ! Value.HasValue;
    }

    public int CompareTo(ComparableCanBeEmpty other)
    {
        return Nullable.Compare(Value, other.Value);
    }
}