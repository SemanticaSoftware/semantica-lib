using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for enumerations.
/// </summary>
[Pure]
public static class EnumExtensions
{
    /// <summary>
    /// Enumerates all defined value members of TEnum that are present in <paramref name="flags"/>. Note
    /// that if the enum has an explicit entry for <c>0</c>, that value is _always_ returned, since flags.HasFlag(0) is always
    /// true.
    /// </summary>
    /// <param name="flags"> The value whose flags to enumerate. </param>
    /// <typeparam name="TEnum"> Type of enum with <see cref="FlagsAttribute"/>. </typeparam>
    /// <returns> An <see cref="IEnumerable{T}"/> that contains the flags which are set on <paramref name="flags"/>. </returns>
    public static IEnumerable<TEnum> EnumerateFlagValues<TEnum>(this TEnum flags)
        where TEnum : struct, Enum
    {
        return Enum.GetValues<TEnum>()
                   .Cast<Enum>()
                   .Where(flags.HasFlag)
                   .Cast<TEnum>();
    }

    /// <summary>Determines whether the list is <see langword="null"/>, empty or contains only the default value.</summary>
    /// <typeparam name="T">The type of enum in <paramref name="values"/>.</typeparam>
    /// <param name="values">The list of values to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="values"/> is <see langword="null"/>, empty or contains only the default value
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <example>
    /// The ASP.MVC modelbinder wil set the value of a property <c>MyEnum[] EnumProp {get;set;}</c> to an array with one
    /// element of value <c>default(MyEnum)</c> when the request has <c>EnumProp=</c> in the querystring. 
    /// </example>
    public static bool IsNullOrDefault<T>([NotNullWhen(false)] this IReadOnlyList<T>? values)
        where T : struct, Enum
    {
        return values == null || values.Count == 0 || (values.Count == 1 && values[0].IsDefault());
    }
    
    /// <summary>Determines whether the list is <see langword="null"/>, empty or contains only the default value.</summary>
    /// <typeparam name="T">The type of enum in <paramref name="values"/>.</typeparam>
    /// <param name="values">The list of values to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="values"/> is <see langword="null"/>, empty or contains only the default value
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <example>
    /// The ASP.MVC modelbinder wil set the value of a property <c>MyEnum[] EnumProp {get;set;}</c> to an array with one
    /// element of value <c>default(MyEnum)</c> when the request has <c>EnumProp=</c> in the querystring. 
    /// </example>
    public static bool IsNullOrDefault<T>([NotNullWhen(false)] this IReadOnlyList<T?>? values)
        where T : struct, Enum
    {
        return values == null || values.Count == 0 || (values.Count == 1 && values[0].GetValueOrDefault().IsDefault());
    }    
}
