using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace Semantica.Storage.CharEnums;

public static class CharEnumConverter
{
    [Pure]
    public static bool IsEmptyOrDefault(string? str)
    {
        return string.IsNullOrEmpty(str) || str[0] == char.MinValue;
    }

    [Pure]
    public static bool IsNotNulChar(char chrValue)
    {
        return chrValue != char.MinValue;
    }

    [Pure]
    public static char ToChar(string? str)
    {
        return str?.FirstOrDefault() ?? default;
    }

    [Pure]
    public static char ToChar<T>(T enumValue)
        where T : struct, Enum
    {
        return Convert.ToChar(enumValue);
    }

    [Pure]
    public static char[]? ToCharsSafe<T>(IEnumerable<T> charEnums)
        where T : struct, Enum
    {
        char[]? chrs = charEnums?.Where(Enum.IsDefined)
                                       .Select(ToChar)
                                       .Where(IsNotNulChar)
                                       .ToArrayOrNull();
        return chrs;
    }

    [Pure]
    public static string? ToString(char chr)
    {
        return chr == char.MinValue ? null : new string(new[] { chr });
    }

    [Pure]
    public static string? ToString<T>(T enumValue)
        where T : struct, Enum
    {
        return ToString(ToChar(enumValue));
    }

    [Pure]
    public static string? ToString<T>(T? charEnum)
        where T : struct, Enum
    {
        return charEnum.HasValue ? ToString(charEnum.Value) : null;
    }

    [Pure]
    public static string? ToString<T>(IEnumerable<T> charEnums)
        where T : struct, Enum
    {
        char[]? str = charEnums?.Select(ToChar)
                                        .Where(IsNotNulChar)
                                        .ToArrayOrNull();
        return str == null ? null : new string(str);
    }

    [Pure]
    public static string? ToStringSafe<T>(T charEnum)
        where T : struct, Enum
    {
        return Enum.IsDefined(charEnum) ? ToString(charEnum) : null;
    }

    [Pure]
    public static string? ToStringSafe<T>(T? charEnum)
        where T : struct, Enum
    {
        return charEnum.HasValue && Enum.IsDefined(charEnum.Value) ? ToString(charEnum.Value) : null;
    }

    [Pure]
    public static string? ToStringSafe<T>(IEnumerable<T> enumValues)
        where T : struct, Enum
    {
        char[]? chrs = ToCharsSafe(enumValues);
        return chrs == null ? null : new string(chrs);
    }

    [Pure]
    public static string? ToStringOrderedSafe<T>(IEnumerable<T> enumValues)
        where T : struct, Enum
    {
        char[]? chrs = ToCharsSafe(enumValues);
        if (chrs == null) { return null; }
        Array.Sort(chrs);
        return new string(chrs);
    }

    [Pure]
    public static T ToEnum<T>(char chr)
        where T : struct, Enum
    {
        try
        {
            return (T)(ValueType)Convert.ToUInt16(chr);
        }
        catch (InvalidCastException castException)
        {
            throw new CharEnumCastException(chr, typeof(T), castException);
        }
    }

    [Pure]
    public static T ToEnum<T>(string? str)
        where T : struct, Enum
    {
        return ToEnum<T>(ToChar(str));
    }

    [Pure]
    [return: NotNullIfNotNull("str")]
    public static List<T>? ToEnumList<T>(string? str)
        where T : struct, Enum
    {
        return str?.Select(ToEnum<T>).ToList();
    }

    [Pure]
    [return: NotNullIfNotNull("str")]
    public static HashSet<T>? ToEnumSet<T>(string? str)
        where T : struct, Enum
    {
        return str?.Select(ToEnum<T>).ToHashSet();
    }
}

public class CharEnumCastException : InvalidCastException
{
    public Type CharEnumType { get; }

    public char CharEnum { get; }

    public CharEnumCastException(in char charEnum, Type charEnumType, InvalidCastException castException)
        : base(MakeMessage(charEnum, charEnumType), castException)
    {
        CharEnum = charEnum;
        CharEnumType = charEnumType;
    }

    private static string MakeMessage(in char charEnum, Type charEnumType)
    {
        return $"Cannot cast char value '{charEnum}' to char enum type {charEnumType}.";
    }
}
