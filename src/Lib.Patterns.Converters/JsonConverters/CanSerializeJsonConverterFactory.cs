using System.Text.Json;
using System.Text.Json.Serialization;

namespace Semantica.Patterns.JsonConverters;

public class CanSerializeJsonConverterFactory : JsonConverterFactory
{
    private static readonly Type c_nonGenericInterfaceType = typeof(ICanSerialize);
    private static readonly Type c_genericInterfaceType = typeof(ICanSerialize<>);
    private static readonly Type c_twoWayConverterType = typeof(CanSerializeJsonConverter<>);
    private static readonly Type c_oneWayConverterType = typeof(CanSerializeOneWayJsonConverter<>);

    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.IsAssignableTo(c_nonGenericInterfaceType);
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterType = CanConvertTwoWay(typeToConvert) ? c_twoWayConverterType.MakeGenericType(typeToConvert) : c_oneWayConverterType.MakeGenericType(typeToConvert);
        var converter = (JsonConverter?)Activator.CreateInstance(converterType);
        return converter;
    }

    private static bool CanConvertTwoWay(Type typeToConvert)
    {
        var interfaces = typeToConvert.GetInterfaces();
        return interfaces.Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == c_genericInterfaceType);
    }
}
