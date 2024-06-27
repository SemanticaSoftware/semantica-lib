using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Types;
using Semantica.Types.Converters;

namespace Semantica.Lib.Tests.Core.Test.Types.Converters;

[TestClass]
public class PartitionDateJsonConverterTest
{
    private PartitionDateJsonConverter _sut = null!;
    //data
    private JsonSerializerOptions _options = null!;
    private static readonly PartitionDate _someValue = SomePartitionDate.Create();
    private static readonly string _jsonValue = SomeJson.Json(SomeJson.JsonValue(SomePartitionDate.ValueSerialized));
    private static readonly Model _model = new Model(_someValue);

    [TestInitialize]
    public void Init()
    {
        _sut = new PartitionDateJsonConverter();
        _options = SomeJson.MakeOptions(_sut);
    }

    #region Deserialization

    [TestMethod]
    public void Read_EmptyJson_Default()
    {
        //ACT
        var actual = JsonSerializer.Deserialize<Model>(SomeJson.Empty, _options);
        //ASSERT
        Assert.That.IsDefault<PartitionDate>(actual?.Value);
    }

    [TestMethod]
    public void Read_JsonNull_Default()
    {
        //ACT
        var actual = JsonSerializer.Deserialize<Model>(SomeJson.NullValueJson(), _options);
        //ASSERT
        Assert.That.IsDefault<PartitionDate>(actual?.Value);
    }

    [TestMethod]
    public void Read_StringValue_CorrectValue()
    {
        //ACT
        var actual = JsonSerializer.Deserialize<Model>(_jsonValue, _options);
        //ASSERT
        Assert.AreEqual(_someValue, actual?.Value);
    }

    #endregion
    #region Serialization

    [TestMethod]
    public void Write_Default_Null()
    {
        //ACT
        var actual = JsonSerializer.Serialize(new Model(default), _options);
        //ASSERT
        Assert.AreEqual(SomeJson.Json(SomeJson.Null), actual);
    }

    [TestMethod]
    public void Write_Model_CorrectJson()
    {
        //ACT
        var actual = JsonSerializer.Serialize(_model, _options);
        //ASSERT
        Assert.AreEqual(_jsonValue, actual);
    }

    #endregion
    
    public record Model(PartitionDate Value);    
}
