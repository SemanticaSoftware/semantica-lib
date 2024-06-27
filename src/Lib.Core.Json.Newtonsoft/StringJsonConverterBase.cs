using Newtonsoft.Json;

namespace Semantica.Core.Json.Newtonsoft;

/// <summary>
/// <para>
/// Base class that inherits from <see cref="JsonConverter{T}"/>, meant for conversions of <typeparamref name="T"/> from and to
/// <see langword="string"/>. Only <see cref="FromString"/> and <see cref="ToString"/> abstract methods need to be implemented.
/// </para>
/// <para>
/// For conversions from string, override <see cref="GetDefault"/> if a value different to default(T) should be returned on a
/// <see langword="null"/> value, or override <see cref="UseDefaultOnNull"/> to return <see langword="false"/> if
/// <see langword="null"/> values should be handled by <see cref="FromString"/>. When not overriden, <see cref="FromString"/>
/// will never be called with <see langword="null"/>.  
/// </para>
/// </summary>
/// <typeparam name="T"> Type to convert to and from <see cref="String"/>. </typeparam>
public abstract class StringJsonConverterBase<T> : JsonConverter<T>
{
    public override T? ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var strValue = reader.ReadAsString();
        return strValue == null && UseDefaultOnNull ? GetDefault() : FromString(strValue);
    }

    public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
    {
        var strValue = value == null ? null : ToString(value);
        if (strValue == null)
        {
            writer.WriteNull();
        }
        else
        {
            writer.WriteValue(strValue);
        }
    }
    
    /// <summary>
    /// Implementation of the conversion to <typeparamref name="T"/>.
    /// </summary>
    /// <param name="str">
    /// String value to convert. Never <see langword="null"/> unless <see cref="UseDefaultOnNull"/> is overriden and returns
    /// <see langword="false"/>.
    /// </param>
    /// <returns> An instance of <typeparamref name="T"/>. </returns>
    protected abstract T FromString(string? str);

    /// <summary>
    /// Returns default(T). Override if a different value to should be returned on a <see langword="null"/> value.
    /// </summary>
    protected virtual T? GetDefault() => default(T?);
    
    /// <summary> Implementation of the conversion of <typeparamref name="T"/> to string. </summary>
    /// <param name="value"> Value of <typeparamref name="T"/> to convert. </param>
    /// <returns> An string representation of the input. </returns>
    protected abstract string? ToString(T? value);

    /// <summary>
    /// When <see langword="true"/>, the output of <see cref="GetDefault"/> is returned on a string input of
    /// <see langword="null"/>. Override and return <see langword="false"/> if <see langword="null"/> values should be handled
    /// by <see cref="FromString"/>.
    /// </summary>
    protected virtual bool UseDefaultOnNull => false;
}
