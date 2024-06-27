using System.Text.Json;
using System.Text.Json.Serialization;
using Semantica.Patterns.Exceptions;

namespace Semantica.Patterns.JsonConverters;

public class CanSerializeOneWayJsonConverter<TSerializable> : JsonConverter<TSerializable>
    where TSerializable : ICanSerialize
{
    public override TSerializable? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var attemptedValue = string.Empty;
        try
        {
            attemptedValue = reader.GetString() ?? attemptedValue;
        }
        catch (InvalidOperationException) { }
        throw new JsonDeserializationException(typeToConvert, attemptedValue);
    }

    public override void Write(Utf8JsonWriter writer, TSerializable value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Serialize());
    }
}
