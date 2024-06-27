using System.Text.Json;
using System.Text.Json.Serialization;

namespace Semantica.Trees.JsonConverters;

/// <summary>
/// Can convert any <see cref="IReadOnlyPartialTree{TPayload}"/> to a json-represemtation.  
/// </summary>
/// <remarks>
/// Conversion from json has not yet been implemented.
/// </remarks>
/// <typeparam name="TPayload">Type of the payload of each node.</typeparam>
public class PartialTreeJsonConverter<TPayload> : JsonConverter<IReadOnlyPartialTree<TPayload>>
{
    private readonly MorphologicTreeJsonConverter<IPartialTreeNode<TPayload>, TPayload> _converter = new MorphologicTreeJsonConverter<IPartialTreeNode<TPayload>, TPayload>();
        
    public override IReadOnlyPartialTree<TPayload> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, IReadOnlyPartialTree<TPayload> value, JsonSerializerOptions options)
    {
        _converter.Write(writer, value, options);
    }
}
