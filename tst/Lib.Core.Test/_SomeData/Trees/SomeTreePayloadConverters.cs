using Semantica.Trees;
using Semantica.Trees.Converters;

namespace Semantica.Lib.Tests.Core.Test._SomeData.Trees;

public class SomeTreePayloadConverterToString : IPayloadConverter<ITreeNode<int>, string>
{
    public string ConvertPayload(ITreeNode<int> node)
    {
        return node.Payload.ToString();
    }
}

public class SomeTreePayloadConverterMultiplyValue : IPayloadConverter<ITreeNode<int>, int>
{
    public int ConvertPayload(ITreeNode<int> node)
    {
        return node.Payload * 2;
    }
}