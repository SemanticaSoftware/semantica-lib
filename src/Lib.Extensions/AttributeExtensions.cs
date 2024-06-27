using System.Diagnostics.Contracts;
using System.Globalization;
using System.Reflection;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional methods for retrieving custom attributes.
/// </summary>
[Pure]
public static class AttributeExtensions
{
    /// <summary>
    /// Returns the first custom attribute applied to the enum value.
    /// </summary>
    /// <typeparam name="TAttribute">
    /// The type of the custom attribute to return.
    /// </typeparam>
    /// <typeparam name="TEnum">
    /// The type of the enum value whose custom attributes to find.
    /// </typeparam>
    /// <param name="enum">The enum value whose custom attributes to find.</param>
    /// <returns>
    /// The first custom attribute of the specified type that is applied to
    /// <paramref name="enum"/>, or <see langword="null"/> if none match.
    /// </returns>
    public static TAttribute? GetAttribute<TAttribute, TEnum>(this TEnum @enum)
        where TAttribute : Attribute
        where TEnum : IConvertible
    {
        return GetAttribute<TAttribute, TEnum>(@enum, GetEnumFieldInfos<TEnum>());
    }

    /// <summary>
    /// Returns the first custom attribute applied to the enum value.
    /// </summary>
    /// <typeparam name="TAttribute">
    /// The type of the custom attribute to retrieve.
    /// </typeparam>
    /// <typeparam name="TEnum">The type of enum.</typeparam>
    /// <param name="enum">The enum value whose custom attributes to find.</param>
    /// <param name="enumFieldInfos">
    /// A collection of fields representing the values in the enum.
    /// </param>
    /// <returns>
    /// The first custom attribute of the specified type that is applied to
    /// <paramref name="enum"/>, or <see langword="null"/> if none match.
    /// </returns>
    public static TAttribute? GetAttribute<TAttribute, TEnum>(this TEnum @enum, IEnumerable<FieldInfo> enumFieldInfos)
        where TAttribute : Attribute
        where TEnum : IConvertible
    {
        var stringValue = @enum.ToString(CultureInfo.InvariantCulture);
        var fieldInfo = enumFieldInfos.FirstOrDefault(fi => fi.Name == stringValue);
        return fieldInfo?.GetCustomAttributes(typeof(TAttribute), false).OfType<TAttribute>().FirstOrDefault();
    }

    /// <summary>
    /// Determines whether the enum value has any custom attributes applied to it.
    /// </summary>
    /// <typeparam name="TAttribute">
    /// The type of the custom attribute to check.
    /// </typeparam>
    /// <typeparam name="TEnum">The type of enum.</typeparam>
    /// <param name="enum">The enum value whose custom attributes to check.</param>
    /// <returns>
    /// <see langword="true"/> if <paramref name="enum"/> has a <typeparamref
    /// name="TAttribute"/> applied to it; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool HasAttribute<TAttribute, TEnum>(this TEnum @enum)
        where TAttribute : Attribute
        where TEnum : IConvertible
    {
        var stringValue = @enum.ToString(CultureInfo.InvariantCulture);
        var fieldInfo = typeof(TEnum).GetRuntimeFields().FirstOrDefault(fi => fi.Name == stringValue);
        return fieldInfo?.GetCustomAttributes(typeof(TAttribute), false).OfType<TAttribute>().Any() ?? false;
    }

    private static IEnumerable<FieldInfo> GetEnumFieldInfos<TEnum>()
            where TEnum : IConvertible
    {
        return typeof(TEnum).GetRuntimeFields();
    }
}
