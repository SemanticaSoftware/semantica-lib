namespace Semantica.Trees.Converters;

public class TreeConverter<TIn, TOut> : ITreeConverter<TIn, TOut>
{
    private readonly IPayloadConverter<ITreeNode<TIn>, TOut> _payloadConverter;

    public TreeConverter(IPayloadConverter<ITreeNode<TIn>, TOut> payloadConverter)
    {
        _payloadConverter = payloadConverter;
    }

    public IGrowingTree<TOut> Convert(IReadOnlyTree<TIn> source)
    {
        return TreeConverter.ConvertTree(source, _payloadConverter.ConvertPayload);
    }
}
