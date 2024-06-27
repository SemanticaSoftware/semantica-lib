using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Storage.CharEnums;

namespace Semantica.Lib.Tests.Design.Test.Storage.CharEnums;

[TestClass]
public class CharEnumConverterTest
{
    private static readonly string c_nullString = $"{'\0'}";
    private const TestCharEnum c_defaultEnumValue = (TestCharEnum)0;

    [TestMethod]
    public void ToEnum_StringChar_CorrectCharValue()
    {
        //ACT
        var result = CharEnumConverter.ToChar("A");
        //ASSERT
        Assert.AreEqual('A', result);
    }

    [TestMethod]
    public void ToEnum_EmptyString_ZeroCharValue()
    {
        //ACT
        var result = CharEnumConverter.ToChar("");
        //ASSERT
        Assert.AreEqual('\0', result);
    }

    [TestMethod]
    public void ToEnum_NullString_ZeroCharValue()
    {
        //ACT
        var result = CharEnumConverter.ToChar(c_nullString);
        //ASSERT
        Assert.AreEqual('\0', result);
    }

    [TestMethod]
    public void ToEnum_Null_ZeroCharValue()
    {
        //ACT
        var result = CharEnumConverter.ToChar(null);
        //ASSERT
        Assert.AreEqual('\0', result);
    }

    [TestMethod]
    public void ToEnum_Generic_StringChar_CorrectEnumValue()
    {
        //ACT
        var result = CharEnumConverter.ToEnum<TestCharEnum>("A");
        //ASSERT
        Assert.AreEqual(TestCharEnum.A, result);
    }

    [TestMethod]
    public void ToEnum_Generic_OtherStringChar_CorrectEnumValue()
    {
        //ACT
        var result = CharEnumConverter.ToEnum<TestCharEnum>("B");
        //ASSERT
        Assert.AreEqual(TestCharEnum.B, result);
    }

    [TestMethod]
    public void ToEnum_Generic_EmptyString_ZeroCharValue()
    {
        //ACT
        var result = CharEnumConverter.ToEnum<TestCharEnum>("");
        //ASSERT
        Assert.IsFalse(Enum.IsDefined(typeof(TestCharEnum), result));
        Assert.AreEqual(c_defaultEnumValue, result);
    }

    [TestMethod]
    public void ToEnum_Generic_NullString_ZeroCharValue()
    {
        //ACT
        var result = CharEnumConverter.ToEnum<TestCharEnum>(c_nullString);
        //ASSERT
        Assert.IsFalse(Enum.IsDefined(typeof(TestCharEnum), result));
        Assert.AreEqual(c_defaultEnumValue, result);
    }

    [TestMethod]
    public void ToEnum_Generic_Null_ZeroCharValue()
    {
        //ACT
        var result = CharEnumConverter.ToEnum<TestCharEnum>(null);
        //ASSERT
        Assert.IsFalse(Enum.IsDefined(typeof(TestCharEnum), result));
        Assert.AreEqual(c_defaultEnumValue, result);
    }

    [TestMethod]
    public void ToEnum_Generic_NullString_DefaultValue()
    {
        //ACT
        var result = CharEnumConverter.ToEnum<TestCharEnumWithDefault>(c_nullString);
        //ASSERT
        Assert.AreEqual(TestCharEnumWithDefault.Default, result);
    }

    [TestMethod]
    public void ToString_Char_CorrectStringValue()
    {
        //ACT
        var result = CharEnumConverter.ToString('A');
        //ASSERT
        Assert.AreEqual("A", result);
    }

    [TestMethod]
    public void ToStringSafe_Generic_EnumVal_CorrectStringValue()
    {
        //ACT
        var result = CharEnumConverter.ToStringSafe(TestCharEnum.A);
        //ASSERT
        Assert.AreEqual("A", result);
    }

    [TestMethod]
    public void ToStringSafe_Generic_OtherEnumVal_CorrectStringValue()
    {
        //ACT
        var result = CharEnumConverter.ToStringSafe(TestCharEnum.B);
        ;
        //ASSERT
        Assert.AreEqual("B", result);
    }

    [TestMethod]
    public void ToStringSafe_Generic_DefaultEnumVal_Null()
    {
        //ACT
        var result = CharEnumConverter.ToStringSafe(c_defaultEnumValue);
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToStringSafe_Generic_UndefinedEnumVal_Null()
    {
        //ACT
        var result = CharEnumConverter.ToStringSafe((TestCharEnum)1);
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToStringSafe_Generic_EnumValDefault_Null()
    {
        //ACT
        var result = CharEnumConverter.ToStringSafe(TestCharEnumWithDefault.Default);
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToStringSafe_Generic_DefaultEnumValDefault_Null()
    {
        //ACT
        var result = CharEnumConverter.ToStringSafe(default(TestCharEnumWithDefault));
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToStringOrderedSafe_Null_Null()
    {
        //ACT
        var result = CharEnumConverter.ToStringOrderedSafe((HashSet<TestCharEnum>)null);
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToStringOrderedSafe_EmptySet_Null()
    {
        //ACT
        var result = CharEnumConverter.ToStringOrderedSafe(new HashSet<TestCharEnum>());
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToStringOrderedSafe_EnumVal_CorrectStringValue()
    {
        //ACT
        var result = CharEnumConverter.ToStringOrderedSafe(new HashSet<TestCharEnum> { TestCharEnum.A });

        //ASSERT
        Assert.AreEqual("A", result);
    }

    [TestMethod]
    public void ToStringOrderedSafe_EnumVals_CorrectStringValue()
    {
        //ACT
        var result = CharEnumConverter.ToStringOrderedSafe(
                new HashSet<TestCharEnum> { TestCharEnum.B, TestCharEnum.A }
            );

        //ASSERT
        Assert.AreEqual("AB", result);
    }

    [TestMethod]
    public void ToEnumSet_Null_Null()
    {
        //ACT
        var result = CharEnumConverter.ToEnumSet<TestCharEnum>(null);
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public void ToEnumSet_Empty_EmptySet()
    {
        //ACT
        var result = CharEnumConverter.ToEnumSet<TestCharEnum>(String.Empty);
        //ASSERT
        Assert.IsFalse(result.Any());
    }

    [TestMethod]
    public void ToEnumSet_StringChar_CorrectEnumSetValue()
    {
        //ACT
        HashSet<TestCharEnum> result = CharEnumConverter.ToEnumSet<TestCharEnum>("B");
        //ASSERT
        Assert.IsTrue(result.Contains(TestCharEnum.B));
    }

    [TestMethod]
    public void ToEnumSet_StringChars_CorrectEnumSetValues()
    {
        //ACT
        HashSet<TestCharEnum> result = CharEnumConverter.ToEnumSet<TestCharEnum>("AB");
        //ASSERT
        Assert.IsTrue(result.Contains(TestCharEnum.B));
        Assert.IsTrue(result.Contains(TestCharEnum.A));
    }

    private enum TestCharEnum : ushort
    {
        A = 'A',
        B = 'B'
    }

    private enum TestCharEnumWithDefault : ushort
    {
        Default = 0,
        A = 'A',
        B = 'B'
    }
}
