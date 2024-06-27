using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using CommunityToolkit.HighPerformance;
using JetBrains.Annotations;
using Semantica.Extensions.Flags;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for strings.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static class StringExtensions
{
    /// <summary>
    /// Returns the string with the first character converted to its uppercase equivalent using the invariant culture.
    /// </summary>
    /// <param name="str">The string to capitalize.</param>
    /// <returns>
    /// A new string, based on this string, with its first character converted to uppercase.
    /// </returns>
    public static string Capitalize(this string str)
    {
        return str.Length == 1
            ? char.ToUpperInvariant(str[0]).ToString()
            : $"{char.ToUpperInvariant(str[0])}{str[1..]}";
    }
    
    /// <summary>
    /// Returns the string with the first character converted to its uppercase equivalent using the invariant culture.
    /// </summary>
    /// <param name="str">The string to capitalize.</param>
    /// <returns>
    /// A new string, based on this string, with its first character converted to uppercase.
    /// </returns>
    public static string Capitalize(this ReadOnlySpan<char> str)
    {
        return str.Length == 1
            ? char.ToUpperInvariant(str[0]).ToString()
            : $"{char.ToUpperInvariant(str[0])}{str[1..]}";
    }

    /// <summary>Trims the input string, only if the argument is <see langword="true"/>.</summary>
    /// <param name="str">The input <see cref="String"/> to conditionally trim.</param>
    /// <param name="trim">A <see cref="Boolean"/> that determines if trim is applied.</param>
    /// <returns>The trimmed input, or the plain input if <paramref name="trim"/> is <see langword="false"/>.</returns>
    public static ReadOnlySpan<char> ConditionalTrim(this string str, bool trim)
    {
        return trim ? str.Trim() : str;
    }

    /// <summary>Trims the input string, only if the argument is <see langword="true"/>.</summary>
    /// <param name="str">The input <see cref="String"/> to conditionally trim.</param>
    /// <param name="trim">A <see cref="Boolean"/> that determines if trim is applied.</param>
    /// <returns>The trimmed input, or the plain input if <paramref name="trim"/> is <see langword="false"/>.</returns>
    public static ReadOnlySpan<char> ConditionalTrim(this ReadOnlySpan<char> str, bool trim)
    {
        return trim ? str.Trim() : str;
    }

    /// <summary>
    /// Determines whether this string contains the specified string, optionally specifying additional comparison options.
    /// </summary>
    /// <param name="stringToSearch">The string to search in.</param>
    /// <param name="stringToFind">The string to find.</param>
    /// <param name="compareOptions">A value specifying how the search should be searched for.</param>
    /// <returns>
    /// <see langword="true"/> if this string contains <paramref name="stringToFind"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool Contains(this string stringToSearch, ReadOnlySpan<char> stringToFind,
        CompareOptions compareOptions = CompareOptions.None)
    {
        return CultureInfo.InvariantCulture.CompareInfo.IndexOf(stringToSearch, stringToFind, compareOptions) >= 0;
    }

    /// <summary>
    /// Determines whether this string contains the specified string, optionally specifying additional comparison options.
    /// </summary>
    /// <param name="stringToSearch">The string to search in.</param>
    /// <param name="stringToFind">The string to find.</param>
    /// <param name="compareOptions">A value specifying how the search should be searched for.</param>
    /// <returns>
    /// <see langword="true"/> if this string contains <paramref name="stringToFind"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool Contains(this ReadOnlySpan<char> stringToSearch, ReadOnlySpan<char> stringToFind,
        CompareOptions compareOptions = CompareOptions.None)
    {
        return CultureInfo.InvariantCulture.CompareInfo.IndexOf(stringToSearch, stringToFind, compareOptions) >= 0;
    }
    
    /// <summary>
    /// Returns the string with the first character converted to its lowercase equivalent using the invariant culture.
    /// </summary>
    /// <param name="str">The string to decapitalize.</param>
    /// <returns> A new string, based on this string, with its first character converted to lowercase. </returns>
    public static string Decapitalize(this string str)
    {
        return str.Length == 1
            ? char.ToLowerInvariant(str[0]).ToString()
            : $"{char.ToLowerInvariant(str[0])}{str[1..]}";
    }
    
    /// <summary>
    /// Returns the string with the first character converted to its lowercase equivalent using the invariant culture.
    /// </summary>
    /// <param name="str">The string to decapitalize.</param>
    /// <returns> A new string, based on this string, with its first character converted to lowercase. </returns>
    public static string Decapitalize(this ReadOnlySpan<char> str)
    {
        return str.Length == 1
            ? char.ToLowerInvariant(str[0]).ToString()
            : $"{char.ToLowerInvariant(str[0])}{str[1..]}";
    }

    /// <summary>
    /// Returns this string instance, or the empty string if it is <see langword="null"/>, optionally removing leading and
    /// trailing white space.
    /// </summary>
    /// <param name="str">The string to return.</param>
    /// <param name="trim"><see langword="true"/> to remove leading and trailing white space from the string.</param>
    /// <returns>The string, optionally trimmed, or the empty string if it is <see langword="null"/>.</returns>
    public static string EmptyOnNull(this string? str, bool trim = false)
    {
        if (str == null)
        {
            return string.Empty;
        }
        return trim ? str.Trim() : str;
    }

    /// <summary>Converts the enumeration of chars to a string.</summary>
    /// <param name="enumerable">An enumaration of <see cref="char"/>.</param>
    /// <returns>A string containing all chars in <paramref name="enumerable"/>.</returns>
    public static string EnumerateToString([InstantHandle] this IEnumerable<char> enumerable)
    {
        return new string(enumerable.ToArray());
    }
    
    /// <summary>
    /// Returns this string instance, or <see langword="null"/> if it is empty,
    /// optionally removing leading and trailing white space.
    /// </summary>
    /// <remarks>
    /// If <paramref name="trim"/> is <see langword="true"/> and the string only
    /// consists of white-space characters, this method also returns <see langword="null"/>.
    /// </remarks>
    /// <param name="str">The string to return.</param>
    /// <param name="trim">
    /// <see langword="true"/> to remove leading and trailing white space from
    /// the string.
    /// </param>
    /// <returns>
    /// The string, optionally trimmed, or <see langword="null"/> if the result
    /// would be empty or <see langword="null"/>.
    /// </returns>
    public static string? NullOnEmpty(this string? str, bool trim = true)
    {
        if (str == null)
        {
            return null;
        }
        var trimmedStr = trim ? str.Trim() : str;
        return trimmedStr == string.Empty ? null : trimmedStr;
    }
    
    /// <summary>
    /// In a specified input string, replaces all strings that match a regular expression pattern with a specified replacement
    /// string. Uses <see cref="Regex"/>.<see cref="Regex.Replace(string,string)"/>.
    /// </summary>
    /// <param name="input">The string to search for a match.</param>
    /// <param name="regex">The regex instance to use.</param>
    /// <param name="replacement">The replacement string.</param>
    /// <returns>
    /// A new string that is identical to the input string, except that the replacement string takes the place of each matched
    /// string. If the regular expression pattern is not matched in the current instance, the method returns the current
    /// instance unchanged.
    /// </returns>
    public static string RegexReplace(this string input, Regex regex, string replacement)
        => regex.Replace(input, replacement);

    /// <summary>
    /// Removes all characters other than letters or digits from the string.
    /// </summary>
    /// <param name="str">The string to clean.</param>
    /// <returns>
    /// A new string containing only the letters and digits from the string.
    /// </returns>
    [return: NotNullIfNotNull("str")]
    public static string? RemoveSpecialCharacters(this string? str)
    {
        if (str == null) return null;
        var builder = new StringBuilder();
        foreach (var chr in str.Where(char.IsLetterOrDigit))
        {
            builder.Append(chr);
        }
        return builder.ToString();
    }

    /// <summary>
    /// Returns a string that does not end with the specified string.
    /// </summary>
    /// <param name="str">The string to return.</param>
    /// <param name="suffix">The string to remove from the end of <paramref name="str"/>.</param>
    /// <param name="stringComparison">Determines how the string is searched.</param>
    /// <returns>
    /// A new string with <paramref name="suffix"/> removed from its end, or the
    /// same string instance if it does not end with <paramref name="suffix"/>.
    /// </returns>
    [return: NotNullIfNotNull("str")]
    public static string? StripIfEndsWith(this string? str, string suffix,
        StringComparison stringComparison = StringComparison.CurrentCulture)
    {
        return str?.EndsWith(suffix, stringComparison) ?? false ? str[..^suffix.Length] : str;
    }

    /// <summary>
    /// Returns a string whose length does not exceed the specified maximum.
    /// </summary>
    /// <param name="str">The string whose length to limit.</param>
    /// <param name="maxLength">The maximum length of the string to return.</param>
    /// <returns>A string whose length does not exceed <paramref name="maxLength"/>.</returns>
    [return: NotNullIfNotNull("str")]
    public static string? TakeMax(this string? str, int maxLength)
    {
        return str != null && str.Length > maxLength ? str[..maxLength] : str;
    }

    /// <summary>Converts the characters representing a number to the equivalent integer.</summary>
    /// <param name="digits">A collection of characters representing the digits to convert.</param>
    /// <returns>A 32-bit integer that contains the number represented by <paramref name="digits"/>.</returns>
    public static int ToInt(this IEnumerable<char> digits)
    {
        var result = 0;
        foreach (var digit in digits)
        {
            result = 10 * result + digit - '0';
        }
        return result;
    }

    /// <summary>
    /// Transforms an input <see cref="String"/> with a Pascal-case identifier into a Kebab-case identifier. The default
    /// <see cref="CasingStyle"/> is used, which will preserve underscores.
    /// </summary>
    /// <param name="str">The identifier to transform.</param>
    /// <returns>A <see cref="String"/> with the input converted into Kebab Case.</returns>
    public static string ToKebabCase(this string str)
    {
        return new string(TransformPascalCase(str, '-', CasingStyle.PreserveUnderscores).ToArray());
    }

    /// <summary>
    /// Transforms an input <see cref="String"/> with a Pascal-case identifier into a Kebab-case identifier. The default
    /// <see cref="CasingStyle"/> is used, which will double up existing underscores.
    /// </summary>
    /// <param name="str">The identifier to transform.</param>
    /// <param name="style">Controls the style of the transformation.</param>
    /// <returns>A <see cref="String"/> with the input converted into Kebab Case.</returns>
    public static string ToKebabCase(this string str, CasingStyle style)
    {
        return new string(TransformPascalCase(str, '-', style).ToArray());
    }

    /// <summary>Transforms an input <see cref="String"/> with a Pascal-case identifier into a Snake-case identifier.</summary>
    /// <param name="str">The identifier to transform.</param>
    /// <returns>A <see cref="String"/> with the input converted into Kebab Case.</returns>
    public static string ToSnakeCase(this string str)
    {
        return new string(TransformPascalCase(str, '_',
            CasingStyle.PreserveUnderscores | CasingStyle.UnderscoresAsBoundaries).ToArray());
    }

    /// <summary>Transforms an input <see cref="String"/> with a Pascal-case identifier into a Snake-case identifier.</summary>
    /// <param name="str">The identifier to transform.</param>
    /// <param name="style">Controls the style of the transformation.</param>
    /// <returns>A <see cref="String"/> with the input converted into Kebab Case.</returns>
    public static string ToSnakeCase(this string str, CasingStyle style)
    {
        return new string(TransformPascalCase(str, '_', style).ToArray());
    }

    /// <summary>Transforms an input <see cref="String"/> with a Pascal-case identifier into a Snake-case identifier.</summary>
    /// <param name="chars">The identifier to transform.</param>
    /// <param name="separator">The seperator character to insert on a word boundary.</param>
    /// <param name="style">Controls the style of the transformation.</param>
    /// <returns>A <see cref="String"/> with the input converted into Kebab Case.</returns>
    public static IEnumerable<char> TransformPascalCase(this IEnumerable<char> chars, char separator, CasingStyle style)
    {
        foreach (var elm in SelectWithContext(chars,
                     static (previous, current, next) => (previous, current, next)))
        {
            bool currentIsUnderscore = elm.current == '_';
            if (char.IsLetterOrDigit(elm.previous) 
                && char.IsLetterOrDigit(elm.next)
                && (currentIsUnderscore && style.HasFlag(CasingStyle.UnderscoresAsBoundaries))
                || (char.IsUpper(elm.current)
                    && (char.IsLower(elm.previous)
                        || char.IsDigit(elm.previous)
                        || (char.IsUpper(elm.previous) && char.IsLower(elm.next))
                    )))
            {
                yield return separator;
            }
            if (!currentIsUnderscore || style.HasFlag(CasingStyle.PreserveUnderscores))
            {
                yield return style.HasFlag(CasingStyle.PreserveCasing) ? elm.current
                    : style.HasFlag(CasingStyle.ToUpperCase) ? char.ToUpperInvariant(elm.current)
                    : char.ToLowerInvariant(elm.current);
            }
        }
    }

    /// <summary>Limits the string to the specified maximum length.</summary>
    /// <param name="str">The string whose length to limit.</param>
    /// <param name="maxLength">The maximum number of characters to take from the string.</param>
    /// <returns>
    /// This string if it is under the maximum length; otherwise, the string is cut off at <paramref name="maxLength"/>.
    /// </returns>
    [return: NotNullIfNotNull("str")]
    public static string? TrimTo(this string? str, int maxLength)
    {
        return str != null && str.Length > maxLength ? str[..maxLength] : str;
    }

    /// <summary>
    /// Limits the string to the specified maximum length, optionally specifying a string to append to indicate the string was
    /// truncated.
    /// </summary>
    /// <param name="str">The string whose length to limit.</param>
    /// <param name="maxLength">The maximum number of characters to take from the string.</param>
    /// <param name="elipsis">The string to append if a string has been truncated.</param>
    /// <returns>
    /// This string if it is under the maximum length; otherwise, the string is cut off at <paramref name="maxLength"/> followed
    /// by <paramref name="elipsis"/>.
    /// </returns>
    [return: NotNullIfNotNull("str")]
    public static string? Truncate(this string? str, int maxLength, string elipsis = "(...)")
    {
        return str != null && str.Length > maxLength ? str[..maxLength] + elipsis : str;
    }

    /// <summary>
    /// Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
    /// whether it was found.
    /// </summary>
    /// <param name="str">The string to search in.</param>
    /// <param name="chr">The character to find.</param>
    /// <param name="index">
    /// When this method returns, contains the zero-based index of <paramref name="chr"/> in the string, or -1 if it is not
    /// found.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the string contained <paramref name="chr"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryIndexOf(this string str, char chr, out int index)
    {
        index = str.IndexOf(chr);
        return index >= 0;
    }

    /// <summary>
    /// Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
    /// whether it was found.
    /// </summary>
    /// <param name="str">The string to search in.</param>
    /// <param name="chr">The character to find.</param>
    /// <param name="index">
    /// When this method returns, contains the zero-based index of <paramref name="chr"/> in the string, or -1 if it is not
    /// found.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the string contained <paramref name="chr"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryIndexOf(this ReadOnlySpan<char> str, char chr, out int index)
    {
        index = str.IndexOf(chr);
        return index >= 0;
    }

    /// <summary>
    /// Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
    /// whether it was found.
    /// </summary>
    /// <param name="str">The string to search in.</param>
    /// <param name="chr">The character to find.</param>
    /// <param name="startIndex">The search starting position.</param>
    /// <param name="index">
    /// When this method returns, contains the zero-based index of <paramref name="chr"/> in the string, or -1 if it is not
    /// found.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the string contained <paramref name="chr"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryIndexOf(this string str, char chr, int startIndex, out int index)
    {
        index = str.IndexOf(chr, startIndex);
        return index >= 0;
    }

    /// <summary>
    /// Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
    /// whether it was found.
    /// </summary>
    /// <param name="str">The string to search in.</param>
    /// <param name="value">The character to find.</param>
    /// <param name="index">
    /// When this method returns, contains the zero-based index of <paramref name="value"/> in the string, or -1 if it is not
    /// found.
    /// </param>
    /// <param name="comparisonType">One of the enumeration values that specifies the rules of the search.</param>
    /// <returns>
    /// <see langword="true"/> if the string contained <paramref name="value"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryIndexOf(this string str, string value, out int index,
        StringComparison comparisonType = StringComparison.Ordinal)
    {
        index = str.IndexOf(value, comparisonType);
        return index >= 0;
    }

    /// <summary>
    /// Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
    /// whether it was found.
    /// </summary>
    /// <param name="str">The string to search in.</param>
    /// <param name="value">The character to find.</param>
    /// <param name="index">
    /// When this method returns, contains the zero-based index of <paramref name="value"/> in the string, or -1 if it is not
    /// found.
    /// </param>
    /// <param name="comparisonType">One of the enumeration values that specifies the rules of the search.</param>
    /// <returns>
    /// <see langword="true"/> if the string contained <paramref name="value"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryIndexOf(this ReadOnlySpan<char> str, ReadOnlySpan<char> value, out int index,
        StringComparison comparisonType = StringComparison.Ordinal)
    {
        index = str.IndexOf(value, comparisonType);
        return index >= 0;
    }

    /// <summary>
    /// Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
    /// whether it was found.
    /// </summary>
    /// <param name="str">The string to search in.</param>
    /// <param name="value">The character to find.</param>
    /// <param name="startIndex">The search starting position.</param>
    /// <param name="index">
    /// When this method returns, contains the zero-based index of <paramref name="value"/> in the string, or -1 if it is not
    /// found.
    /// </param>
    /// <param name="comparisonType"> One of the enumeration values that specifies the rules of the search. </param>
    /// <returns>
    /// <see langword="true"/> if the string contained <paramref name="value"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryIndexOf(this string str, string value, int startIndex, out int index,
        StringComparison comparisonType = StringComparison.Ordinal)
    {
        index = str.IndexOf(value, startIndex, comparisonType);
        return index >= 0;
    }

    /// <summary>
    /// Determines the zero-based index of the first occurrence of a character in the string and returns a value indicating
    /// whether it was found.
    /// </summary>
    /// <param name="str">The string to search in.</param>
    /// <param name="value">The character to find.</param>
    /// <param name="startIndex">The search starting position.</param>
    /// <param name="index">
    /// When this method returns, contains the zero-based index of <paramref name="value"/> in the string, or -1 if it is not
    /// found.
    /// </param>
    /// <param name="comparisonType">One of the enumeration values that specifies the rules of the search.</param>
    /// <returns>
    /// <see langword="true"/> if the string contained <paramref name="value"/>; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool TryIndexOf(this ReadOnlySpan<char> str, ReadOnlySpan<char> value, int startIndex, out int index,
        StringComparison comparisonType = StringComparison.Ordinal)
    {
        index = str[startIndex..].IndexOf(value, comparisonType) + startIndex;
        return index >= 0;
    }

    /// <summary>
    /// Splits a string into substrings based on the specified separator character and returns a value indicating whether the
    /// result contains the expected number of substrings.
    /// </summary>
    /// <param name="str">The string to split.</param>
    /// <param name="separator">The character to split the string on.</param>
    /// <param name="expectedParts">The expected number of substrings after the string is split.</param>
    /// <param name="parts">When this method returns, contains the substrings.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="parts"/> contains the expected number of substrings; otherwise,
    /// <see langword="false"/>.
    /// </returns>
    public static bool TrySplit(this string str, char separator, int expectedParts,
        [NotNullWhen(returnValue: true)] out string[]? parts)
    {
        if (string.IsNullOrEmpty(str))
        {
            parts = null;
            return false;
        }
        parts = str.Split(separator);
        return parts.Length == expectedParts;
    }

    /// <summary>Returns this string, followed by a space if it ends with a non-space character.</summary>
    /// <param name="str">The string to return.</param>
    /// <returns>The string, followed by a space if the string is not empty and does not already end in white space.</returns>
    [return: NotNullIfNotNull("str")]
    public static string? WithLeadingSpace(this string? str)
    {
        if (string.IsNullOrEmpty(str) || char.IsWhiteSpace(str[0]))
        {
            return str;
        }
        return " " + str;
    }

    /// <summary>Returns this string, followed by a space if it ends with a non-space character.</summary>
    /// <param name="str">The string to return.</param>
    /// <returns>The string, followed by a space if the string is not empty and does not already end in white space.</returns>
    [return: NotNullIfNotNull("str")]
    public static string? WithSpace(this string? str)
    {
        if (string.IsNullOrEmpty(str) || char.IsWhiteSpace(str[^1]))
        {
            return str;
        }
        return str + " ";
    }
    
    private static IEnumerable<TOut> SelectWithContext<TSource, TOut>(IEnumerable<TSource> source,
            Func<TSource?, TSource, TSource?, TOut> combineWithContext)
    {
        using (var enumerator = source.GetEnumerator())
        {
            if (!enumerator.MoveNext())
            {
                yield break;
            }

            var previous = default(TSource);
            var current = enumerator.Current;
            while (enumerator.MoveNext())
            {
                var next = enumerator.Current;
                yield return combineWithContext(previous, current, next);

                previous = current;
                current = next;
            }

            yield return combineWithContext(previous, current, default);
        }
    }    
}
