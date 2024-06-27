using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Core.Test._SomeData.Trees;
using Semantica.Trees;
using Semantica.Trees.Converters;
using Semantica.Trees.Extensions;

namespace Semantica.Lib.Tests.Core.Test.Collections.Trees;

[TestClass]
public class TreeConverterTest
{
    //SUT
    private IGrowingTree<int> _tree = null!;
    private IPayloadConverter<ITreeNode<int>, string> _payloadConverterToString = null!;
    private IPayloadConverter<ITreeNode<int>, int> _payloadConverterMultiplyValue = null!;

    [TestInitialize]
    public void Init()
    {
        //Initialize SUT
        _tree = SomeTree.CreateWithChildNodes();
        _payloadConverterToString = new SomeTreePayloadConverterToString();
        _payloadConverterMultiplyValue = new SomeTreePayloadConverterMultiplyValue();
    }

    [TestMethod]
    public void ConvertPayload_IntegerToString_ReturnsCorrectPayload()
    {
        var result = _payloadConverterToString.ConvertPayload(_tree.RootNode);
        Assert.AreEqual(_tree.RootNode.Payload.ToString(), result);
    }

    [TestMethod]
    public void ConvertPayload_IntToInt_ReturnsCorrectPayload()
    {
        var result = _payloadConverterMultiplyValue.ConvertPayload(_tree.ElementAt(4));
        Assert.AreEqual(_tree.ElementAt(4).Payload * 2, result);
    }


    [TestMethod]
    public void Convert_SomeTreeToString_ReturnsSameCountAfterConversion()
    {
        var converter = new TreeConverter<int, string>(_payloadConverterToString);
        var result = converter.Convert(_tree).Count;
        Assert.AreEqual(_tree.Count, result);
    }

    [TestMethod]
    public void Convert_SomeTreeToString_ReturnsCorrectPayloads()
    {
        var converter = new TreeConverter<int, string>(_payloadConverterToString);
        var result = converter.Convert(_tree).EnumerateDepthFirst().Select(n => n.Payload).ToList();
        CollectionAssert.AreEqual(new[] { "0", "1", "2", "3", "4", "6", "9", "5", "7", "8" }, result);
    }

    [TestMethod]
    public void Convert_SomeTreeToDoubleValues_ReturnsCorrectPayloads()
    {
        var converter = new TreeConverter<int, int>(_payloadConverterMultiplyValue);
        var result = converter.Convert(_tree).EnumerateDepthFirst().Select(n => n.Payload).ToList();
        CollectionAssert.AreEqual(new[] { 0, 2, 4, 6, 8, 12, 18, 10, 14, 16 }, result);
    }
}