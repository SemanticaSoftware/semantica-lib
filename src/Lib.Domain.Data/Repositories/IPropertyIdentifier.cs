using System.Reflection;

namespace Semantica.Domain.Data.Repositories;

/// <summary>
/// Can identify an immutable storage property using its <see cref="PropertyInfo"/>. Used in the default implementation of
/// <see cref="IPropertyAnalyser"/>. Register/inject custom implementations of this interface to use a different method of
/// identifying immutable properties than the (default) <see cref="Storage.Attributes.ImmutableAttribute"/>. 
/// </summary>
public interface IPropertyIdentifier
{
    bool IsImmutableProperty(PropertyInfo propertyInfo);
}