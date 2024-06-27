using System.Text.Json;

namespace Semantica.Patterns.JsonConverters;

public class CanSerializeJsonConverter<TSerializable> : CanSerializeOneWayJsonConverter<TSerializable>
    where TSerializable : ICanSerialize<TSerializable>, IEquatable<TSerializable>
#if !NET7_0_OR_GREATER    
    , new()
#endif
{
    public override TSerializable? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var stringValue = reader.GetString();
#if NET7_0_OR_GREATER    
        return TSerializable.Deserialize(stringValue);
#else    
        var deserializer = new TSerializable();
        return deserializer.Deserialize(stringValue);
#endif
    }
}
