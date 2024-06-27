using Semantica.Patterns;

namespace Semantica.Lib.Tests.Core.Test._Mocks;

public class TestCanBeEmpty : ICanBeEmpty
{
    public int Value { get; set; }

    public TestCanBeEmpty(int value = 0)
    {
        Value = value;
    }

    public bool IsEmpty()
    {
        return Value == 0;
    }
}