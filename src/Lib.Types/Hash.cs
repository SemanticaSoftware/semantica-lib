using System.Diagnostics.CodeAnalysis;
using Semantica.Checks;
using Semantica.Patterns;

namespace Semantica.Types;

public readonly struct Hash : ICanBeEmpty, IEquatable<Hash>
{
    private const int c_length = 16;
    private readonly byte[] _value;

    public Hash(byte[] value)
    {
        Guard.For(Check.That(value.Length == c_length));
        _value = value;
    }

    public IReadOnlyList<byte>? Value => _value;

    public byte[] GetValue()
    {
        Guard.State(Check.NotEmpty(this));
        var returnVal = new byte[c_length];
        _value.CopyTo(returnVal, 0);
        return returnVal;
    }

    [MemberNotNullWhen(returnValue: false, nameof(Value))]
    public bool IsEmpty()
    {
        return Value == null;
    }

    public override string ToString() => new string(GetFirstNCharacters(c_length * 2));

    public char[] GetFirstNCharacters(int numOfChars)
    {
        const byte charAoffset = 'A' - 10;
        Guard.State(Check.NotEmpty(this));
        Guard.For(Check.NotNegative(numOfChars));
        Guard.For(Check.That(numOfChars <= 32));
        var result = new char[numOfChars];
        for (int i = 0, pos = 0; pos < numOfChars; ++i, ++pos)
        {
            var bt = _value[i];
            SetChar((byte)(bt >> 4), pos); //use 4 most significant bits for first char
            if (++pos < numOfChars)
            {
                SetChar((byte)(bt & 0xF), pos); //use 4 least significant bits for second char
            }
        }

        return result;

        void SetChar(byte nibble, int pos)
        {
            result[pos] = (char) (nibble < 10 ? nibble + '0' : nibble + charAoffset);
        }
    }

    public bool Equals(Hash other)
    {
        if (other.IsEmpty())
        {
            return IsEmpty();
        }

        if (IsEmpty())
        {
            return false;
        }
        for (var i = 0; i < c_length; i++)
        {
            if (_value[i] != other.Value[i])
            {
                return false;
            }
        }
        return true;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }

        return obj is Hash hash && Equals(hash);
    }

    public override int GetHashCode()
    {
        return (Value != null ? Value.GetHashCode() : 0);
    }
}
