using System.ComponentModel;
using System.Reflection;

namespace Semantica.Types.Converters;

#if NET7_0_OR_GREATER
/// <summary>
/// Provides functionality to dynamically add <see cref="TypeConverterAttribute"/> to types, so this can be used when the
/// converter and the value type are in different assemblies. Converter classes have to implement
/// <see cref="IRuntimeTypeConverter{T,TConverter}"/> to be recognised.<br/>
/// <see cref="AddTypeConverterAttributesInAssembly"/> is the main entry method. 
/// </summary>
#else
/// <summary>
/// Provides functionality to dynamically add <see cref="TypeConverterAttribute"/> to types, so this can be used when the
/// converter and the value type are in different assemblies. Converter classes have to implement
/// <see cref="IRuntimeTypeConverter{T}"/> to be recognised.<br/>
/// <see cref="AddTypeConverterAttributesInAssembly"/> is the main entry method. 
/// </summary>
#endif
public static class TypeConverterRegistrations
{
#if NET7_0_OR_GREATER
    /// <summary>
    /// Main entry method. Finds all classes that implement <see cref="IRuntimeTypeConverter{T,TConverter}"/> in the supplied
    /// assemblies. Adds <see cref="TypeConverterAttribute"/> for the found types.
    /// </summary>
    /// <param name="assemblies"> Assemblies to look for typeconverters in. </param>
    /// <exception cref="TypeConverterRegistrationsException">
    /// Throws if two converters are found for the same type. Throws if the converter type attribute of the
    /// <see cref="IRuntimeTypeConverter{T,TConverter}"/> interface is not the converter type itself.
    /// </exception>
#else
    /// <summary>
    /// Main entry method. Finds all classes that implement <see cref="IRuntimeTypeConverter{T}"/> in the supplied
    /// assemblies. Adds <see cref="TypeConverterAttribute"/> for the found types.
    /// </summary>
    /// <param name="assemblies"> Assemblies to look for typeconverters in. </param>
    /// <exception cref="TypeConverterRegistrationsException">
    /// Throws if two converters are found for the same type.
    /// </exception>
#endif
    public static void AddTypeConverterAttributesInAssembly(params Assembly[] assemblies)
    {
        AddTypeConverterAttributes(assemblies.SelectMany(assembly => assembly.GetTypes()));
    }

#if NET7_0_OR_GREATER
    /// <summary>
    /// Filters the supplied types to ones that implement <see cref="IRuntimeTypeConverter{T,TConverter}"/>. Adds
    /// <see cref="TypeConverterAttribute"/> for the found types.
    /// </summary>
    /// <param name="types"> An enumeration of types that include the typeconverter types. </param>
    /// <exception cref="TypeConverterRegistrationsException">
    /// Throws if two converters are found for the same type. Throws if the converter type attribute of the
    /// <see cref="IRuntimeTypeConverter{T,TConverter}"/> interface is not the converter type itself.
    /// </exception>
#else
    /// <summary>
    /// Filters the supplied types to ones that implement <see cref="IRuntimeTypeConverter{T}"/>. Adds
    /// <see cref="TypeConverterAttribute"/> for the found types.
    /// </summary>
    /// <param name="types"> An enumeration of types that include the typeconverter types. </param>
    /// <exception cref="TypeConverterRegistrationsException">
    /// Throws if two converters are found for the same type.
    /// </exception>
#endif
    public static void AddTypeConverterAttributes(IEnumerable<Type> types)
    {
        Dictionary<Type, Type> valueTypeConverterPairs = new();
        var typeConverterType = typeof(TypeConverter);
#if NET7_0_OR_GREATER
        var converterInterfaceGeneric = typeof(IRuntimeTypeConverter<,>);
#else
        var converterInterfaceGeneric = typeof(IRuntimeTypeConverter<>);
#endif
        foreach (var converterType in types.Where(type => type is { IsClass: true, IsAbstract: false }
                                                          && typeConverterType.IsAssignableFrom(type)))
        {
            foreach (var converterInterface in converterType.FindInterfaces(
                         (type, _) => type.GetGenericTypeDefinition() == converterInterfaceGeneric,
                         converterInterfaceGeneric))
            {
                var genericArguments = converterInterface.GetGenericArguments();
#if NET7_0_OR_GREATER
                if (genericArguments[1] != converterType)
                    throw TypeConverterRegistrationsException.ForWrongConverterType(converterType);
#endif
                if (!valueTypeConverterPairs.TryAdd(genericArguments[0], converterType))
                    throw TypeConverterRegistrationsException.ForDuplicateValueType(genericArguments[0], converterType);
            }
            foreach (var valueTypeConverterPair in valueTypeConverterPairs)
            {
                AddTypeConverterAttribute(valueTypeConverterPair.Key, valueTypeConverterPair.Value);
            }
        }
    }

    /// <summary> Adds a <see cref="TypeConverterAttribute"/> to <paramref name="valueType"/>. </summary>
    /// <param name="valueType"> Value type to add the attribute to. </param>
    /// <param name="converterType"> Converter type to use as the attribute argument. </param>
    public static void AddTypeConverterAttribute(Type valueType, Type converterType)
    {
        TypeDescriptor.AddAttributes(valueType, new TypeConverterAttribute(converterType));
    }

    public sealed class TypeConverterRegistrationsException : Exception 
    {
        public TypeConverterRegistrationsException(string? message) : base(message)
        {
        }

        public static TypeConverterRegistrationsException ForWrongConverterType(Type converterType)
            => new TypeConverterRegistrationsException($"Type argument on IRuntimeTypeConverter does not match the class {converterType.FullName}");

        public static TypeConverterRegistrationsException ForDuplicateValueType(Type valueType, Type converterType)
            => new TypeConverterRegistrationsException($"Second typeconverters encountered ({converterType.FullName}) for the type {valueType.FullName}");
    }
}
