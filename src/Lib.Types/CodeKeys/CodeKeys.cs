using CommunityToolkit.HighPerformance;
using Semantica.Checks;

namespace Semantica.Types.CodeKeys;

public static class CodeKeys
{
    public const int ChunkLength = 5;
    public const ushort ChunkMax = 31;
    public const char NulChar = '0';

    public static readonly IReadOnlyList<char> AllowedChars = new[] {
        NulChar,
        '1',
        '2',
        '3',
        '4',
        '5',
        '6',
        '7',
        '8',
        '9',
        'A',
        'B',
        'C',
        'D',
        'E',
        'F',
        'G',
        'H',
        'J',
        'K',
        'L',
        'M',
        'N',
        'P',
        'Q',
        'R',
        'S',
        'T',
        'U',
        'W',
        'X',
        'Y'
    };

    public static readonly IReadOnlyList<char> SkippedChars = new[] { 'I', 'O', 'V', 'Z' };

    public static ushort CharToChunk(char value)
    {
        return (value) switch {
            NulChar => 0, '1' => 1, '2' => 2, '3' => 3, '4' => 4, '5' => 5, '6' => 6, '7' => 7, '8' => 8, '9' => 9,
            'A' => 10, 'B' => 11, 'C' => 12, 'D' => 13, 'E' => 14, 'F' => 15, 'G' => 16, 'H' => 17, 'J' => 18, 'K' => 19,
            'L' => 20, 'M' => 21, 'N' => 22, 'P' => 23, 'Q' => 24, 'R' => 25, 'S' => 26, 'T' => 27, 'U' => 28, 'W' => 29,
            'X' => 30, 'Y' => 31,
            _ => throw new ArgumentOutOfRangeException(nameof(value))
        };
    }

    public static char ChunkToChar(ushort value)
    {
        return (value & ChunkMax) switch {
            0 => NulChar, 1 => '1', 2 => '2', 3 => '3', 4 => '4', 5 => '5', 6 => '6', 7 => '7', 8 => '8', 9 => '9',
            10 => 'A', 11 => 'B', 12 => 'C', 13 => 'D', 14 => 'E', 15 => 'F', 16 => 'G', 17 => 'H', 18 => 'J', 19 => 'K',
            20 => 'L', 21 => 'M', 22 => 'N', 23 => 'P', 24 => 'Q', 25 => 'R', 26 => 'S', 27 => 'T', 28 => 'U', 29 => 'W',
            30 => 'X', 31 => 'Y',
            _ => throw new ArgumentOutOfRangeException(nameof(value))
        };
    }

    public static int CodeToInt(string code)
    {
        Guard.For(Check.MaxLength(code, 6));
        int output = 0;
        foreach (var chr in code)
        {
            output <<= ChunkLength;
            output |= CharToChunk(chr);
        }
        return output;
    }

    public static string Int16ToCode(short value, int length = 3)
    {
        Guard.For(Check.MaxValue(length, 3));
        char[] chrs = new char[length];
        for (int i = length - 1; i >= 0; i--)
        {
            chrs[i] = ChunkToChar(Convert.ToUInt16(value));
            value >>= ChunkLength;
        }
        return new string(chrs);
    }

    public static string Int32ToCode(int value, int length = 6)
    {
        Guard.For(Check.NotNegative(value));
        Guard.For(Check.MaxValue(length, 6));
        char[] chrs = new char[length];
        for (int i = length - 1; i >= 0; i--)
        {
            chrs[i] = ChunkToChar(Convert.ToUInt16(value));
            value >>= ChunkLength;
        }
        if (value > 0) throw new ArgumentOutOfRangeException(nameof(value));
        return new string(chrs);
    }

    public static bool IsValid(string? str)
    {
        return str?.Length <= 6 && str.All(IsValidChar);
    }

    public static bool IsValid(ReadOnlySpan<char> str)
    {
        foreach (var item in str.Enumerate())
        {
            if (!IsValidChar(item.Value)) return false;
        }
        return true;
    }

    public static bool IsValidChar(char chr)
    {
        return chr switch {
            'I' => false,
            'O' => false,
            'V' => false,
            _ => chr is >= NulChar and <= '9' or >= 'A' and < 'Z'
        };
    }

    public static bool IsValidHumanInputChar(char chr)
    {
        return chr is >= NulChar and <= '9' or >= 'a' and <= 'z' or >= 'A' and <= 'Z';
    }

    public static bool IsValidHumanInput(string? str)
    {
        return str?.All(IsValidHumanInputChar) ?? false;
    }

    public static bool IsValidHumanInput(ReadOnlySpan<char> str)
    {
        foreach (var item in str.Enumerate())
        {
            if (!IsValidHumanInputChar(item.Value)) return false;
        }
        return true;
    }

    public static string Pad(string code, int length) => code.PadLeft(length, NulChar);

    public static string SanitizeHumanInput(string str)
    {
        return new string(str.SelectArray(str.Length, SanitizeHumanInputChar));
    }

    public static string SanitizeHumanInput(ReadOnlySpan<char> str)
    {
        char[] output = new char[str.Length];
        foreach (var item in str.Enumerate())
        {
            output[item.Index] = SanitizeHumanInputChar(item.Value);
        }
        return new string(output);
    }

    public static char SanitizeHumanInputChar(char chr)
    {
        return chr switch {
            'i' => '1',
            'I' => '1',
            'o' => NulChar,
            'O' => NulChar,
            'v' => 'U',
            'V' => 'U',
            'z' => '2',
            'Z' => '2',
            _ => char.ToUpperInvariant(chr)
        };
    }

    public static string TrimPadding(string code) => code.TrimStart(NulChar);
}
