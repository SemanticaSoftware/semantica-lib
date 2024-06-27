using System.Text.Json;
using System.Text.Json.Serialization;

namespace Semantica.Trees.JsonConverters;

/// <summary>
/// Can convert any <see cref="IReadOnlyMorphologicTree{TNode, TPayload}"/> with payloads to a json-represemtation.  
/// </summary>
/// <remarks>
/// Conversion from json has not yet been implemented.
/// </remarks>
/// <typeparam name="TPayload">Type of the payload of each node.</typeparam>
/// <typeparam name="TNode">Type of the nodes.</typeparam>
public class MorphologicTreeJsonConverter<TNode, TPayload> : JsonConverter<IReadOnlyMorphologicTree<TNode, TPayload>>
    where TNode: IMorphologicTreeNode<TNode>, ITreeNodeProperties<TPayload>
{
    private readonly TypedTreeNodeConverter<TNode, TPayload> _nodeConverter;

    public MorphologicTreeJsonConverter()
    {
        _nodeConverter = new TypedTreeNodeConverter<TNode, TPayload>();
    }

    public override IReadOnlyMorphologicTree<TNode, TPayload> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        throw new NotSupportedException();
    }

    public override void Write(Utf8JsonWriter writer, IReadOnlyMorphologicTree<TNode, TPayload> value, JsonSerializerOptions options)
    {
        if (value == null)
        {
            writer.WriteNullValue();
            return;
        }

        writer.WriteStartObject();
        writer.WritePropertyName(nameof(IMorphologicTree<TNode>.RootNode));
        _nodeConverter.Write(writer, value.RootNode, options);
        writer.WriteEndObject();
    }

    private class TypedTreeNodeConverter<TTNode, TTPayload> : JsonConverter<TTNode>
        where TTNode: IMorphologicTreeNode<TTNode>, ITreeNodeProperties<TTPayload>
    {
        public override void Write(Utf8JsonWriter writer, TTNode value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName(nameof(ITreeNodeProperties<TTPayload>.Payload));
            if (value.Payload == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                JsonSerializer.Serialize(writer, value.Payload, typeof(TTPayload), options);
            }

            writer.WritePropertyName(nameof(IMorphologicTreeNode<TTNode>.ChildNodes));
            writer.WriteStartArray();
            foreach (var childNode in value.ChildNodes)
            {
                Write(writer, childNode, options);
            }

            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        public override TTNode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
