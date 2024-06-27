using System.Reflection;
using Semantica.Storage.Attributes;

namespace Semantica.Domain.Data.Repositories;

/// <summary>
/// Default implementation for <see cref="IPropertyIdentifier"/>, detecting the <see cref="ImmutableAttribute"/> on properties
/// to determine mutability.
/// </summary>
public class PropertyIdentifier : IPropertyIdentifier
{

    public bool IsImmutableProperty(PropertyInfo propertyInfo)
    {
        return propertyInfo.GetCustomAttributes<ImmutableAttribute>().Any();
    }
}