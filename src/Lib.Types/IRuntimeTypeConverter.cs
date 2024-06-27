using System.ComponentModel;

namespace Semantica.Types;

#if NET7_0_OR_GREATER

/// <summary>
/// Interface that provides standardizes a method to dynamically add a <see cref="TypeConverterAttribute"/> for a
/// value type, that can be put on the typeconverter for that type. The default implementation should always suffice.
/// </summary>
/// <typeparam name="T"> (value-)type the the typeconverter can convert. </typeparam>
/// <typeparam name="TConverter"> Type of the typeconverter </typeparam>
/// <remarks>
/// <para>
/// This interface can be used for using type converters for value types that are in a different assembly than the
/// corresponding typeconverter. 
/// </para>
/// <para>
/// The <see cref="AddTypeConverterAttribute"/> method can be called at runtime for each custom type converter, or alternativly
/// use <see cref="Converters.TypeConverterRegistrations"/> to search for all type converters implementing this interface in
/// provided assemblies.
/// </para>
/// </remarks>
public interface IRuntimeTypeConverter<T, TConverter>
    where TConverter: TypeConverter
{
    static virtual void AddTypeConverterAttribute()
        => Converters.TypeConverterRegistrations.AddTypeConverterAttribute(typeof(T), typeof(TConverter));
}
#else

/// <summary>
/// Interface that provides standardizes a method to dynamically add a <see cref="TypeConverterAttribute"/> for a
/// value type, that can be put on the typeconverter for that type. 
/// </summary>
/// <typeparam name="T"> (value-)type the the typeconverter can convert. </typeparam>
/// <remarks>
/// <para>
/// This interface can be used for using type converters for value types that are in a different assembly than the
/// corresponding typeconverter. 
/// </para>
/// <para>
/// Use <see cref="Converters.TypeConverterRegistrations"/> to search for all type converters implementing this interface in
/// provided assemblies.
/// </para>
/// </remarks> 
public interface IRuntimeTypeConverter<T>
{
}

#endif
