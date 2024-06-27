using System.Text.Json;
using System.Text.Json.Serialization;
using Semantica.Lib.Tests.Core.Test._Mocks;

namespace Semantica.Lib.Tests.Core.Test._SomeData;

public static class SomeJson
{
    public const string Empty = "{}";
    
    public const string EmptyValue = "\"\"";

    public const string Null = "null";

    public static string WhitespaceValue = "\"  \"";

    public static TestModel<T> CreateDefaultModel<T>() => new TestModel<T>(default);

    public static string EmptyValueJson() => Json(EmptyValue);
    
    public static string Json(string value) => $"{{\"{nameof(TestModel<int>.Value)}\":{value}}}";

    public static string Json<T>(TestType<T> value) => Json(JsonValue(value.Value?.ToString() ?? Null));

    public static string JsonValue(string value) => $"\"{value}\"";

    public static string NullValueJson() => Json(Null);


    public record TestModel<T>(TestType<T> Value);

    #region ACT
    
    public static TestModel<T>? ActDeserialize<T>(string json, JsonSerializerOptions options)
    {
        return JsonSerializer.Deserialize<TestModel<T>>(json, options);
    }

    public static TestModel<T>? ActDeserialize<T>(string json, params JsonConverter[] converters)
    {
        return ActDeserialize<T>(json, MakeOptions(converters));
    }

    public static string ActSerialize<T>(TestModel<T> value, JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(value, options);
    }

    public static string ActSerialize<T>(TestModel<T> value, params JsonConverter[] converters)
    {
        return ActSerialize(value, MakeOptions(converters));
    }

    public static JsonSerializerOptions MakeOptions(params JsonConverter[] converters)
    {
        var options = new JsonSerializerOptions();
        converters.ForEach(options.Converters.Add);
        return options;
    }
    
    #endregion
}
