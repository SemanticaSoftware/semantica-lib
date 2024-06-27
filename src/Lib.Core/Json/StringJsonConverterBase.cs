using System.Text.Json;
using System.Text.Json.Serialization;

namespace Semantica.Core.Json;

/// <summary>
/// <para>
/// Base class that inherits from <see cref="JsonConverter{T}"/>, meant for conversions of <typeparamref name="T"/> from and to
/// <see langword="string"/>. Only <see cref="FromString"/> and <see cref="ToString"/> abstract methods need to be implemented.
/// </para>
/// <para>
/// For conversions from string, exceptions are thrown by default when an unexpected token is encountered. Override
/// <see cref="GetDefaultOnUnexpectedTokenType"/> to change this behaviour. When <see cref="FromString"/> throws a
/// (parse-)exception, this exception is caught and rethrown in <see cref="GetDefaultOnParseException"/>. Override this method
/// to change that behaviour. Override <see cref="DefaultOnNull"/> or <see cref="DefaultOnEmpty"/> when a special default value
/// (and not default(T)) is needed on null or empty input respectively. Overriding <see cref="Default"/> if these situations
/// require the same value.  
/// </para>
/// </summary>
/// <typeparam name="T"> Type to convert to and from <see cref="String"/>. </typeparam>
/// <remarks>
/// Like the base <see cref="JsonConverter{T}"/>, if the property type is a class, or <see cref="Nullable{T}"/> and the input is
/// null, the value of null is assigned directly unless <see cref="JsonConverter{T}.HandleNull"/> is overriden.  
/// </remarks>
public abstract class StringJsonConverterBase<T> : JsonConverter<T>
{
    /// <summary>
    /// Returns default(T). Override if a different value to should be returned when a default value is needed. Override
    /// If both other default properties are overriden, this property is no longer used. 
    /// </summary>
    protected virtual T? Default => default(T?);

    /// <summary>
    /// This property is called by <see cref="Read"/> to get the value that's used when the input is an empty string (or
    /// whitespace if <see cref="DoTrim"/> is true).
    /// </summary>
    protected virtual T? DefaultOnEmpty => Default;

    /// <summary>
    /// This property is called by <see cref="Read"/> to get the value that's used when the input is <see langword="null"/>.
    /// </summary>
    protected virtual T? DefaultOnNull => Default;

    /// <summary>
    /// Returns <see langword="false"/> unless overriden. When <see langword="true"/>, the read string is trimmed before
    /// evaluating whether it's empty, and passing it to <see cref="FromString"/>.
    /// </summary>
    protected virtual bool DoTrim => false;

    /// <summary> Implementation of the conversion to <typeparamref name="T"/>. </summary>
    /// <param name="str"> String value to convert. </param>
    /// <returns> An instance of <typeparamref name="T"/>. </returns>
    protected abstract T FromString(string str);

    /// <summary>
    /// Rethrows the passed exception <paramref name="e"/>. Called by <see cref="Read"/> when an unexpected token type is
    /// encountered. Override this method to make <see cref="Read"/> return a default value rather than throwing when this
    /// happens.
    /// </summary>
    /// <param name="e"> The previously caught token exception. </param>
    /// <exception cref="Exception"> (Re-)throws always. </exception>
    protected virtual T? GetDefaultOnUnexpectedTokenType(Exception e) => throw e;

    /// <summary>
    /// Rethrows the passed exception <paramref name="e"/>. Called by <see cref="Read"/> when an exception occured during
    /// <see cref="FromString"/> (i.e. parsing). Override this method to make <see cref="Read"/> return a default value rather
    /// than throwing when this happens.
    /// </summary>
    /// <param name="e"> The previously caught parse exception. </param>
    /// <exception cref="Exception"> (Re-)throws always. </exception>
    protected virtual T? GetDefaultOnParseException(Exception e) => throw e;

    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? strValue;
        try
        {
            strValue = reader.GetString();
        }
        catch (Exception e)
        {
            return GetDefaultOnUnexpectedTokenType(e);
        }
        if (strValue == null)
        {
            return DefaultOnNull;
        }
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

    /// <summary> Implementation of the conversion of <typeparamref name="T"/> to string. </summary>
    /// <param name="value"> Value of <typeparamref name="T"/> to convert. </param>
    /// <returns> An string representation of the input. </returns>
    protected abstract string? ToString(T? value);

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        try
        {
            var strValue = value == null ? null : ToString(value);
            if (strValue != null)
            {
                writer.WriteStringValue(strValue);
                return;
            }
        }
        catch
        {
            //ignore
        }
        writer.WriteNullValue();
    }
}
