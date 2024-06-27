namespace Semantica.Trees.Converters;

public class PartialTreeConverter<TIn, TOut> : IPartialTreeConverter<TIn, TOut>
{
    private readonly IPayloadConverter<IPartialTreeNode<TIn>, TOut> _payloadConverter;

    public PartialTreeConverter(IPayloadConverter<IPartialTreeNode<TIn>, TOut> payloadConverter)
    {
        _payloadConverter = payloadConverter;
    }

    public IReadOnlyPartialTree<TOut> Convert(IReadOnlyPartialTree<TIn> source)
    {
        return TreeConverter.ConvertTree(source, _payloadConverter.ConvertPayload);
    }
}
