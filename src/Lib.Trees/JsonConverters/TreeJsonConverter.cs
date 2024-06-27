using System.Text.Json;
using System.Text.Json.Serialization;

namespace Semantica.Trees.JsonConverters;

/// <summary>
/// Can convert any <see cref="IReadOnlyTree{TPayload}"/> to a json-represemtation.  
/// </summary>
/// <remarks>
/// Conversion from json has not yet been implemented.
/// </remarks>
/// <typeparam name="TPayload">Type of the payload of each node.</typeparam>
public class TreeJsonConverter<TPayload> : JsonConverter<IReadOnlyTree<TPayload>>
{
    private readonly MorphologicTreeJsonConverter<ITreeNode<TPayload>, TPayload> _converter = new MorphologicTreeJsonConverter<ITreeNode<TPayload>, TPayload>();
        
    public override IReadOnlyTree<TPayload> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, IReadOnlyTree<TPayload> value, JsonSerializerOptions options)
    {
        _converter.Write(writer, value, options);
    }
}
