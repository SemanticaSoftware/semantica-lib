using System.Text;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for <see cref="StringBuilder"/> objects.
/// </summary>
public static class StringBuilderExtensions
{
    /// <summary>
    /// Converts the value of this instance to a <see langword="string"/>,
    /// ignoring the last trailing line ending, if any.
    /// </summary>
    /// <param name="stringBuilder">
    /// The <see cref="StringBuilder"/> whose value to convert.
    /// </param>
    /// <returns>
    /// A string whose value is the same as the string builder, excluding the
    /// last trailing line ending, if it has any.
    /// </returns>
    public static string ToStringNoNewLine(this StringBuilder stringBuilder)
    {
        if (stringBuilder[^1] == '\n')
        {
            stringBuilder.Length--;
        }

        if (stringBuilder[^1] == '\r')
        {
            stringBuilder.Length--;
        }

        return stringBuilder.ToString();
    }
}
