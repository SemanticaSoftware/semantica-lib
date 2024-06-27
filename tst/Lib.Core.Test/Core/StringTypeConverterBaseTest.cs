using System.ComponentModel;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Core;
using Semantica.Lib.Tests.Core.Test._Mocks;

namespace Semantica.Lib.Tests.Core.Test.Core;

[TestClass]
public class StringTypeConverterBaseTest
{
    private TestTypeConverter _sut = null!;
    private OverrideTestJsonConverter _overrideSut = null!;
    //dependencies
    private CultureInfo? _cultureInfo = null;
    private ITypeDescriptorContext? _descriptor = null;
    //data
    private const int _intValue = 42;
    private static readonly Type _intType = typeof(int);
    private static readonly string _stringValue = $"{_intValue}";
    private static readonly Type _stringType = typeof(string);
    private static readonly TestType<int> _typeValue = new TestType<int>(_intValue);

    [TestInitialize]
    public void Init()
    {
        _sut = new TestTypeConverter();
        _overrideSut = new OverrideTestJsonConverter();
    }

    [TestMethod]
    public void CanConvertFrom_Int_False()
    {
        //ACT
        var actual = _sut.CanConvertFrom(_descriptor, _intType);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void CanConvertFrom_String_True()
    {
        //ACT
        var actual = _sut.CanConvertFrom(_descriptor, _stringType);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void CanConvertTo_Int_False()
    {
        //ACT
        var actual = _sut.CanConvertTo(_descriptor, _intType);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void CanConvertTo_String_True()
    {
        //ACT
        var actual = _sut.CanConvertTo(_descriptor, _stringType);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void ConvertFrom_EmptyValue_Default()
    {
        //ACT
        var actual = _sut.ConvertFrom(_descriptor, _cultureInfo, string.Empty);
        //ASSERT
        Assert.That.IsDefault<TestType<int>>(actual);
    }

    [TestMethod]
    public void ConvertFrom_IntValue_Default()
    {
        //ACT
        var actual = _sut.ConvertFrom(_descriptor, _cultureInfo, _intValue);
        //ASSERT
        Assert.That.IsDefault<TestType<int>>(actual);
    }

    [TestMethod]
    public void ConvertFrom_StringValue_CorrectValue()
    {
        //ACT
        var actual = _sut.ConvertFrom(_descriptor, _cultureInfo, _stringValue);
        //ASSERT
        Assert.AreEqual(_typeValue, actual);
    }

    [TestMethod]
    public void ConvertFrom_OverrideEmptyValue_EmptyDefault()
    {
        //ACT
        var actual = _sut.ConvertFrom(_descriptor, _cultureInfo, string.Empty);
        //ASSERT
        Assert.That.IsDefault<TestType<int>>(actual);
    }

    [TestMethod]
    public void ConvertFrom_OverrideIntValue_NullDefault()
    {
        //ACT
        var actual = _overrideSut.ConvertFrom(_descriptor, _cultureInfo, _intValue);
        //ASSERT
        Assert.AreEqual(OverrideTestJsonConverter.NullDefault, actual);
    }

    [TestMethod]
    public void ConvertFrom_OverrideWhitespaceValue_ParseDefault()
    {
        //ACT
        var actual = _overrideSut.ConvertFrom(_descriptor, _cultureInfo, "  ");
        //ASSERT
        Assert.AreEqual(OverrideTestJsonConverter.ParseDefault, actual);
    }

    [TestMethod]
    public void ConvertFrom_OverrideWhitespaceValueWithTrim_EmptyDefault()
    {
        var sut = new OverrideTestJsonConverter(true);
        //ACT
        var actual = sut.ConvertFrom(_descriptor, _cultureInfo, "  ");
        //ASSERT
        Assert.AreEqual(OverrideTestJsonConverter.EmptyDefault, actual);
    }

    [TestMethod]
    public void ConvertTo_Null_Null()
    {
        //ACT
        var actual = _sut.ConvertTo(_descriptor, _cultureInfo, null, _stringType);
        //ASSERT
        Assert.IsNull(actual);
    }

    [TestMethod]
    public void ConvertTo_TypeValue_CorrectValue()
    {
        //ACT
        var actual = _sut.ConvertTo(_descriptor, _cultureInfo, _typeValue, _stringType);
        //ASSERT
        Assert.AreEqual(_stringValue, actual);
    }

    private class TestTypeConverter : StringTypeConverterBase<TestType<int>>
    {
        protected override TestType<int> FromString(string str) => new TestType<int>(int.Parse(str!));

        protected override string? ToString(TestType<int> value) => value.Value.ToString();
    }

    private class OverrideTestJsonConverter : TestTypeConverter
    {
        public static readonly TestType<int> EmptyDefault = new TestType<int>(-1);
        public static readonly TestType<int> NullDefault = new TestType<int>(-2);
        public static readonly TestType<int> ParseDefault = new TestType<int>(-3);

        protected override TestType<int> DefaultOnEmpty => EmptyDefault;
        protected override TestType<int> DefaultOnNull => NullDefault;
        protected override TestType<int> GetDefaultOnParseException(Exception e) => ParseDefault;

        public OverrideTestJsonConverter(bool doTrim = false)
        {
            DoTrim = doTrim;
        }
        
        protected override bool DoTrim { get; }        
    }
}
