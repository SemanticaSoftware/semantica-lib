using System.Diagnostics.Contracts;
using System.Reflection;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for property metadata.
/// </summary>
[Pure]
public static class PropertyInfoExtensions
{
    /// <summary>
    /// Determines whether the property contains a custom attribute of the
    /// specified type.
    /// </summary>
    /// <typeparam name="TAttr">The type of attribute to search for.</typeparam>
    /// <param name="propertyInfo">
    /// The property metadata whose attributes to search.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the property contains a <typeparamref
    /// name="TAttr"/> attribute; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool HasAttribute<TAttr>(this PropertyInfo propertyInfo)
        where TAttr : Attribute
    {
        return propertyInfo.GetCustomAttribute<TAttr>() != null;
    }
}
