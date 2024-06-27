using System.Text.Json;
using System.Text.Json.Serialization;

namespace Semantica.Trees.JsonConverters;

/// <summary>
/// Implementation of <see cref="JsonConverterFactory"/>, that will instantiate the correct <see cref="JsonConverter{T}"/> for one of the supported tree types.  
/// </summary>
/// <remarks>
/// Supports <see cref="IReadOnlyMorphologicTree{TNode,TPayload}"/>, <see cref="IReadOnlyTree{T}"/> and <see cref="IReadOnlyPartialTree{T}"/>
/// </remarks>
public class TreeJsonConverterFactory : JsonConverterFactory
{
    private static readonly Type c_morphologicTreeIType = typeof(IReadOnlyMorphologicTree<,>);
    private static readonly Type c_treeIType = typeof(IReadOnlyTree<>);
    private static readonly Type c_partialTreeIType = typeof(IReadOnlyPartialTree<>);
    private static readonly Type c_morphologicTreeConverterType = typeof(MorphologicTreeJsonConverter<,>);
    private static readonly Type c_partialTreeConverterType = typeof(PartialTreeJsonConverter<>);
    private static readonly Type c_treeConverterType = typeof(TreeJsonConverter<>);

    public override bool CanConvert(Type typeToConvert)
    {
        if (! typeToConvert.IsGenericType)
        {
            return false;
        }

        var interfaces = typeToConvert.GetInterfaces();
        var canConvert = FindMorphologicTreeInterface(typeToConvert, interfaces).Any();
        return canConvert;
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterType = DeriveConverterType(typeToConvert);
        var converter = (JsonConverter)Activator.CreateInstance(converterType);
        return converter;
    }

    private static Type DeriveConverterType(Type typeToConvert)
    {
        var interfaces = typeToConvert.GetInterfaces();
        if (FindTreeInterface(typeToConvert, interfaces).TryFirst(out var treeIType))
        {
            var genericArguments = treeIType.GetGenericArguments();
            var payloadType = genericArguments[0];
            return c_treeConverterType.MakeGenericType(payloadType);
        }
        if (FindPartialTreeInterface(typeToConvert, interfaces).TryFirst(out var partialTreeIType))
        {
            var genericArguments = partialTreeIType.GetGenericArguments();
            var payloadType = genericArguments[0];
            return c_partialTreeConverterType.MakeGenericType(payloadType);
        }
        else
        {
            var morphologicTreeIType = FindMorphologicTreeInterface(typeToConvert, interfaces).First();
            var genericArguments = morphologicTreeIType.GetGenericArguments();
            var nodeType = genericArguments[0];
            var payloadType = genericArguments[1];
            return c_morphologicTreeConverterType.MakeGenericType(nodeType, payloadType);
        }
    }

    private static IEnumerable<Type> FindMorphologicTreeInterface(Type typeToConvert, IEnumerable<Type> interfaces)
    {
        return interfaces.PrecedeBy(typeToConvert).Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == c_morphologicTreeIType);
    }

    private static IEnumerable<Type> FindTreeInterface(Type typeToConvert, IEnumerable<Type> interfaces)
    {
        return interfaces.PrecedeBy(typeToConvert).Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == c_treeIType);
    }

    private static IEnumerable<Type> FindPartialTreeInterface(Type typeToConvert, IEnumerable<Type> interfaces)
    {
        return interfaces.PrecedeBy(typeToConvert).Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == c_partialTreeIType);
    }
}
