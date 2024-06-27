using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Types;
using Semantica.Types.Converters;

namespace Semantica.Lib.Tests.Core.Test.Types.Converters;

[TestClass]
public class PartitionDateTypeConverterTest
{
    private PartitionDateTypeConverter _sut = new();
    //data
    private static readonly PartitionDate _someValue = SomePartitionDate.Create();
    private static readonly PartitionDate _onlyDayValue = SomePartitionDate.CreateOnlyDayPart();
    private static readonly PartitionDate _onlyMonthValue = SomePartitionDate.CreateOnlyMonthPart();
    private static readonly PartitionDate _onlyYearValue = SomePartitionDate.CreateOnlyYearPart();

    #region Deserialize

    [TestMethod]
    public void Deserialize_InvalidInputs_EmptyValue()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Deserialize($"XXXX|XX");
        //ASSERT
        Assert.That.IsDefault(actual);
    }

    [TestMethod]
    public void Deserialize_InvalidParts_EmptyValue()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Deserialize($"XXXX|XX|XX");
        //ASSERT
        Assert.That.IsDefault(actual);
    }

    [TestMethod]
    public void Deserialize_NegativeYear_ExpectedValue()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Deserialize($"-{SomePartitionDate.Year}|00|00");
        //ASSERT
        Assert.AreEqual(-SomePartitionDate.Year, actual.Year);
    }

    [TestMethod]
    public void Deserialize_PartialSerializedDay_ExpectedValue()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Deserialize($"0000|00|{SomePartitionDate.Day}");
        //ASSERT
        Assert.AreEqual(_onlyDayValue, actual);
    }

    [TestMethod]
    public void Deserialize_PartialSerializedMonth_ExpectedValue()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Deserialize($"0000|{SomePartitionDate.Month}|00");
        //ASSERT
        Assert.AreEqual(_onlyMonthValue, actual);
    }

    [TestMethod]
    public void Deserialize_PartialSerializedYear_ExpectedValue()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Deserialize($"{SomePartitionDate.Year}|00|00");
        //ASSERT
        Assert.AreEqual(_onlyYearValue, actual);
    }

    [TestMethod]
    public void Deserialize_PartialInvalid_ExpectedValue()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Deserialize($"X|{SomePartitionDate.Month}|XX");
        //ASSERT
        Assert.AreEqual(_onlyMonthValue, actual);
    }

    [TestMethod]
    public void Deserialize_SomeSerialized_ExpectedValue()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Deserialize(SomePartitionDate.ValueSerialized);
        //ASSERT
        Assert.AreEqual(_someValue, actual);
    }

    #endregion

    [TestMethod]
    public void FromString_ConverterInterface_ExpectedValue()
    {
        //ACT
        var actual = _sut.ConvertFrom(SomePartitionDate.ValueSerialized) as PartitionDate?;
        //ASSERT
        Assert.AreEqual(_someValue, actual);
    }
    
    #region Serialize

    [TestMethod]
    public void Serialize_EmptyValue_ExpectedString()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Serialize(default);
        //ASSERT
        Assert.AreEqual(string.Empty, actual);
    }

    [TestMethod]
    public void Serialize_PartialValueDay_ExpectedString()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Serialize(_onlyDayValue);
        //ASSERT
        Assert.AreEqual($"0000|00|{SomePartitionDate.Day}", actual);
    }
    
    [TestMethod]
    public void Serialize_PartialValueMonth_ExpectedString()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Serialize(_onlyMonthValue);
        //ASSERT
        Assert.AreEqual($"0000|{SomePartitionDate.Month:D2}|00", actual);
    }

    [TestMethod]
    public void Serialize_PartialValueYear_ExpectedString()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Serialize(_onlyYearValue);
        //ASSERT
        Assert.AreEqual($"{SomePartitionDate.Year}|00|00", actual);
    }

    [TestMethod]
    public void Serialize_SomeValue_ExpectedString()
    {
        //ACT
        var actual = PartitionDateTypeConverter.Serialize(_someValue);
        //ASSERT
        Assert.AreEqual(SomePartitionDate.ValueSerialized, actual);
    }
    
    #endregion

    [TestMethod]
    public void ToString_ConverterInterface_ExpectedValue()
    {
        //ACT
        var actual = _sut.ConvertToString(_someValue);
        //ASSERT
        Assert.AreEqual(SomePartitionDate.ValueSerialized, actual);
    }
    
}
