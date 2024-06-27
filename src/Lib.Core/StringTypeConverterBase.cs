using System.ComponentModel;
using System.Globalization;

namespace Semantica.Core;

/// <summary>
/// Base class that inherits from <see cref="TypeConverter"/>, meant for conversions of <typeparamref name="T"/> from and to
/// <see langword="string"/>. Only <see cref="FromString"/> and <see cref="ToString"/> abstract methods need to be implemented.
/// </summary>
/// <typeparam name="T"> Type to convert to and from <see cref="String"/>. </typeparam>
/// <remarks>
/// For conversions from string, override <see cref="DefaultOnNull"/> if a value different to default(T) should be returned on a
/// <see langword="null"/> value.  
/// </remarks>>
public abstract class StringTypeConverterBase<T> : TypeConverter
{
    /// <summary>
    /// Returns default(T). Override if a different value to should be returned when a default value is needed. Override
    /// If both other default properties are overriden, this property is no longer used. 
    /// </summary>
    protected virtual T? Default => default(T?);

    /// <summary>
    /// This property is called by <see cref="ConvertTo"/> to get the value that's used when the input is an empty string (or
    /// whitespace if <see cref="DoTrim"/> is true).
    /// </summary>
    protected virtual T? DefaultOnEmpty => Default;
    
    /// <summary>
    /// This property is called by <see cref="ConvertFrom"/> to get the value that's used when the input is
    /// <see langword="null"/>, or cannot be cast to a string.
    /// </summary>
    protected virtual T? DefaultOnNull => default(T?);

    /// <summary>
    /// Returns <see langword="false"/> unless overriden. When <see langword="true"/>, the read string is trimmed before
    /// evaluating whether it's empty, and passing it to <see cref="FromString"/>.
    /// </summary>
    protected virtual bool DoTrim => false;

    public override bool CanConvertFrom(ITypeDescriptorContext? context, Type sourceType) => sourceType == typeof(string);

    public override bool CanConvertTo(ITypeDescriptorContext? context, Type? destinationType) 
        => destinationType == typeof(string);

    public override object? ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
    {
        if (value is string strValue)
        {
            if (DoTrim)
            {
                strValue = strValue.Trim();
            }
            try
            {
                return strValue.Length == 0 ? DefaultOnEmpty : FromString(strValue);
            }
            catch (Exception e)
            {
                return GetDefaultOnParseException(e);
            }
        }
        return DefaultOnNull;
    }

    public override object? ConvertTo(
        ITypeDescriptorContext? context,
        CultureInfo? culture,
        object? value,
        Type destinationType) => value is T typedValue ? ToString(typedValue) : null;

    /// <summary> Implementation of the conversion to <typeparamref name="T"/>. </summary>
    /// <param name="str"> String value to convert. </param>
    /// <returns> An instance of <typeparamref name="T"/>. </returns>
    protected abstract T FromString(string str);

    /// <summary>
    /// Rethrows the passed exception <paramref name="e"/>. Called by <see cref="ConvertFrom"/> when an exception occured during
    /// <see cref="FromString"/> (i.e. parsing). Override this method to make <see cref="ConvertFrom"/> return a default value
    /// rather than throwing when this happens.
    /// </summary>
    /// <param name="e"> The previously caught parse exception. </param>
    /// <exception cref="Exception"> (Re-)throws always. </exception>
    protected virtual T? GetDefaultOnParseException(Exception e) => throw e;

    /// <summary> Implementation of the conversion of <typeparamref name="T"/> to string. </summary>
    /// <param name="value"> Value of <typeparamref name="T"/> to convert. </param>
    /// <returns> An string representation of the input. </returns>
    protected abstract string? ToString(T? value);
}
