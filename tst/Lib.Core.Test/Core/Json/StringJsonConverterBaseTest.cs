using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Core.Json;
using Semantica.Lib.Tests.Core.Test._Mocks;

namespace Semantica.Lib.Tests.Core.Test.Core.Json;

[TestClass]
public class StringJsonConverterBaseTest
{
    private TestJsonConverter _sut = null!;
    private OverrideTestJsonConverter _overrideSut = null!;
    //data
    private const int _intValue = 42;
    private static readonly TestType<int> _typeValue = new TestType<int>(_intValue);
    private static readonly string _jsonValue = SomeJson.Json(_typeValue);
    private static readonly SomeJson.TestModel<int> _model = new SomeJson.TestModel<int>(_typeValue);

    [TestInitialize]
    public void Init()
    {
        _sut = new TestJsonConverter();
        _overrideSut = new OverrideTestJsonConverter();
    }

    #region Deserialization

    [TestMethod]
    public void Read_EmptyJson_Default()
    {
        //ACT
        var actual = SomeJson.ActDeserialize<int>(SomeJson.Empty, _sut);
        //ASSERT
        Assert.That.IsDefault<TestType<int>>(actual?.Value);
    }

    [TestMethod]
    public void Read_JsonNull_Default()
    {
        //ACT
        var actual = SomeJson.ActDeserialize<int>(SomeJson.NullValueJson(), _sut);
        //ASSERT
        Assert.That.IsDefault<TestType<int>>(actual?.Value);
    }

    [TestMethod]
    public void Read_StringValue_CorrectValue()
    {
        //ACT
        var actual = SomeJson.ActDeserialize<int>(_jsonValue, _sut);
        //ASSERT
        Assert.AreEqual(_typeValue, actual?.Value);
    }

    [TestMethod]
    public void Read_OverrideEmptyJson_Default()
    {
        //ACT
        var actual = SomeJson.ActDeserialize<int>(SomeJson.Empty, _overrideSut);
        //ASSERT
        Assert.That.IsDefault<TestType<int>>(actual?.Value);
    }

    [TestMethod]
    public void Read_OverrideJsonEmptyString_EmptyDefault()
    {
        //ACT
        var actual = SomeJson.ActDeserialize<int>(SomeJson.EmptyValueJson(), _overrideSut);
        //ASSERT
        Assert.AreEqual(OverrideTestJsonConverter.EmptyDefault, actual?.Value);
    }

    [TestMethod]
    public void Read_OverrideJsonNull_NullDefault()
    {
        //ACT
        var actual = SomeJson.ActDeserialize<int>(SomeJson.NullValueJson(), _overrideSut);
        //ASSERT
        Assert.AreEqual(OverrideTestJsonConverter.NullDefault, actual?.Value);
    }

    [TestMethod]
    public void Read_OverrideJsonNumberValue_TokenDefault()
    {
        var json = SomeJson.Json("1");
        //ACT
        var actual = SomeJson.ActDeserialize<int>(json, _overrideSut);
        //ASSERT
        Assert.AreEqual(OverrideTestJsonConverter.TokenDefault, actual?.Value);
    }

    [TestMethod]
    public void Read_WhitespaceValue_ParseDefault()
    {
        var json = SomeJson.Json(SomeJson.WhitespaceValue);
        //ACT
        var actual = SomeJson.ActDeserialize<int>(json, _overrideSut);
        //ASSERT
        Assert.AreEqual(OverrideTestJsonConverter.ParseDefault, actual?.Value);
    }

    [TestMethod]
    public void Read_WhitespaceValueWithTrim_EmptyDefault()
    {
        var json = SomeJson.Json(SomeJson.WhitespaceValue);
        //ACT
        var actual = SomeJson.ActDeserialize<int>(json, new OverrideTestJsonConverter(true));
        //ASSERT
        Assert.AreEqual(OverrideTestJsonConverter.EmptyDefault, actual?.Value);
    }

    #endregion

    #region Serialization

    [TestMethod]
    public void Write_Default_Null()
    {
        //ACT
        var actual = SomeJson.ActSerialize(SomeJson.CreateDefaultModel<int>(), _sut);
        //ASSERT
        Assert.AreEqual(SomeJson.Json(SomeJson.Null), actual);
    }

    [TestMethod]
    public void Write_Model_CorrectJson()
    {
        //ACT
        var actual = SomeJson.ActSerialize(_model, _sut);
        //ASSERT
        Assert.AreEqual(_jsonValue, actual);
    }

    #endregion

    private class TestJsonConverter : StringJsonConverterBase<TestType<int>>
    {
        protected override TestType<int> FromString(string str) => new TestType<int>(int.Parse(str));

        protected override string? ToString(TestType<int> value) => value.Value == 0 ? null : value.Value.ToString();
    }

    private class OverrideTestJsonConverter : TestJsonConverter
    {
        public override bool HandleNull => true;

        public static readonly TestType<int> EmptyDefault = new TestType<int>(-1);
        public static readonly TestType<int> NullDefault = new TestType<int>(-2);
        public static readonly TestType<int> ParseDefault = new TestType<int>(-3);
        public static readonly TestType<int> TokenDefault = new TestType<int>(-4);

        protected override TestType<int> DefaultOnEmpty => EmptyDefault;
        protected override TestType<int> DefaultOnNull => NullDefault;
        protected override TestType<int> GetDefaultOnParseException(Exception e) => ParseDefault;
        protected override TestType<int> GetDefaultOnUnexpectedTokenType(Exception e) => TokenDefault;

        public OverrideTestJsonConverter(bool doTrim = false)
        {
            DoTrim = doTrim;
        }
        
        protected override bool DoTrim { get; }
    }
}
