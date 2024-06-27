using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Checks;
using Semantica.Lib.Tests.Core.Test._Mocks;

namespace Semantica.Lib.Tests.Core.Test.Checks;

[TestClass]
public class CheckTest
{
    [TestMethod]
    public void That_ConditionTrue_IsValid()
    {
        //Act
        var result = Check.That(true).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void That_ConditionFalse_IsNotValid()
    {
        //Act
        var result = Check.That(false).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void Not_ConditionTrue_IsValid()
    {
        //Act
        var result = Check.Not(true).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void Not_ConditionFalse_IsNotValid()
    {
        //Act
        var result = Check.Not(false).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void WhenNotNull_NullStruct_IsValid()
    {
        //Act
        var result = Check.WhenNotNull<TestStruct>(null, Check.That(true)).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void WhenNotNull_NullStruct_CheckKindBoolean()
    {
        //Act
        var result = Check.WhenNotNull<TestStruct>(null, Check.That(true)).Payload;
        //Assert
        Assert.AreEqual(CheckKind.Bool, result);
    }

    [TestMethod]
    public void WhenNotNullCheckEmpty_StructWithEmptyList_IsNotValid()
    {
        //Act
        var result = Check.WhenNotNull<TestStruct>((TestStruct?) default(TestStruct), Check.NotEmpty(string.Empty)).Passed;
        //Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void WhenNotNull_NullObject_IsValid()
    {
        //Act
        var result = Check.WhenNotNull<object>(null, Check.That(true)).Passed;
        //Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void WhenNotNull_NullObject_CheckKindBoolean()
    {
        //Act
        var result = Check.WhenNotNull<object>(null, Check.That(true)).Payload;
        //Assert
        Assert.AreEqual(CheckKind.Bool, result);
    }

    [TestMethod]
    public void WhenNotNullCheckEmpty_NonNullAndValidCheck_IsValid()
    {
        //Act
        var result = Check.WhenNotNull<object>(new { }, Check.That(true)).Passed;
        //Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void WhenNotNullCheckEmpty_NonNullAndInvalidCheck_IsNotValid()
    {
        //Act
        var result = Check.WhenNotNull<object>(new {}, Check.That(false)).Passed;
        //Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void NotNull_Object_IsValid()
    {
        //Act
        var result = Check.NotNull(new object()).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void NotNull_EmptyList_IsValid()
    {
        //Act
        var result = Check.NotNull(new List<int>()).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void NotNull_Null_IsNotValid()
    {
        //Act
        var result = Check.NotNull<object>(null).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotNull_Class_CheckKindNotNull()
    {
        //Act
        var result = Check.NotNull<object>(null).Payload;
        //Assert
        Assert.AreEqual(CheckKind.NotNull, result);
    }

    [TestMethod]
    public void NotNull_NullStruct_IsNotValid()
    {
        //Act
        var result = Check.NotNull<TestStruct>(null).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotNull_Struct_CheckKindNotNull()
    {
        //Act
        var result = Check.NotNull<TestStruct>(null).Payload;
        //Assert
        Assert.AreEqual(CheckKind.NotNull, result);
    }

    [TestMethod]
    public void NotNullOrDefault_ZeroInteger_IsNotValid()
    {
        //Act
        var result = Check.NotNullOrDefault<int>(0).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotNullOrDefault_EmptyString_IsValid()
    {
        //Act
        var result = Check.NotNullOrDefault<string>(string.Empty).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void NotNullOrDefault_CheckKindNotNull()
    {
        //Act
        var result = Check.NotNullOrDefault<int>(0).Payload;
        //Assert
        Assert.AreEqual(CheckKind.NotNull, result);
    }

    [TestMethod]
    public void NotDefault_DefaultStruct_IsNotValid()
    {
        //Act
        var result = Check.NotDefault<TestStruct>(default(TestStruct)).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotDefault_Struct_IsValid()
    {
        var testStruct = new TestStruct(1);
        //Act
        var result = Check.NotDefault<TestStruct>(testStruct).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void NotEmpty_IEmptyReadOnlyList_IsNotValid()
    { 
        IReadOnlyList<int> readOnlyList = new List<int>();
        //Act
        var result = Check.NotEmpty<int>(readOnlyList).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotEmpty_IReadOnlyList_IsValid()
    {
        IReadOnlyList<int> readOnlyList = new List<int> { 0 };
        //Act
        var result = Check.NotEmpty<int>(readOnlyList).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void NotEmpty_Null_IsNotValid()
    {
        //Act
        var result = Check.NotEmpty<int>(null).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotEmpty_ICanBeEmpty_IsNotValid()
    {
        //Act
        var result = Check.NotEmpty(new TestCanBeEmpty()).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotEmpty_ICanBeEmpty_IsValid()
    {
        //Act
        var result = Check.NotEmpty(new TestCanBeEmpty(42)).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void NotEmpty_Guid_IsValid()
    {
        //Act
        var result = Check.NotEmpty(Guid.NewGuid()).Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void NotEmpty_EmptyGuid_IsNotValid()
    {
        //Act
        var result = Check.NotEmpty(Guid.Empty).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotEmpty_EmptyString_IsNotValid()
    {
        //Act
        var result = Check.NotEmpty(string.Empty).Passed;
        //Assert
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void NotEmpty_String_IsValid()
    {
        //Act
        var result = Check.NotEmpty("niet leeg").Passed;
        //Assert
        Assert.AreEqual(true, result);
    }

    #region NonZero

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, true)]
    public void NonZero_Integer(int input, bool expectedValidity)
    {
        //Act
        var result = Check.NonZero(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, true)]
    public void NonZero_Short(int input, bool expectedValidity)
    {
        //Act
        var result = Check.NonZero((short)input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, true)]
    public void NonZero_Long(long input, bool expectedValidity)
    {
        //Act
        var result = Check.NonZero(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, true)]
    public void NonZero_Float(float input, bool expectedValidity)
    {
        //Act
        var result = Check.NonZero(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, true)]
    public void NonZero_Double(double input, bool expectedValidity)
    {
        //Act
        var result = Check.NonZero(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, true)]
    public void NonZero_Decimal(int input, bool expectedValidity)
    {
        //Act
        var result = Check.NonZero((decimal)input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    #endregion NonZero

    #region NotNegative

    [DataTestMethod]
    [DataRow(0, true)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void NotNegative_Integer(int input, bool expectedValidity)
    {
        //Act
        var result = Check.NotNegative(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, true)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void NotNegative_Short(int input, bool expectedValidity)
    {
        //Act
        var result = Check.NotNegative((short)input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, true)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void NotNegative_Long(long input, bool expectedValidity)
    {
        //Act
        var result = Check.NotNegative(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, true)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void NotNegative_Float(float input, bool expectedValidity)
    {
        //Act
        var result = Check.NotNegative(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, true)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void NotNegative_Double(double input, bool expectedValidity)
    {
        //Act
        var result = Check.NotNegative(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, true)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void NotNegative_Decimal(int input, bool expectedValidity)
    {
        //Act
        var result = Check.NotNegative((decimal)input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    #endregion NotNegative

    #region StrictPositive

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void StrictPositive_Integer(int input, bool expectedValidity)
    {
        //Act
        var result = Check.StrictPositive(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void StrictPositive_Short(int input, bool expectedValidity)
    {
        //Act
        var result = Check.StrictPositive((short)input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void StrictPositive_Long(long input, bool expectedValidity)
    {
        //Act
        var result = Check.StrictPositive(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void StrictPositive_Float(float input, bool expectedValidity)
    {
        //Act
        var result = Check.StrictPositive(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void StrictPositive_Double(double input, bool expectedValidity)
    {
        //Act
        var result = Check.StrictPositive(input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    [DataTestMethod]
    [DataRow(0, false)]
    [DataRow(42, true)]
    [DataRow(-42, false)]
    public void StrictPositive_Decimal(int input, bool expectedValidity)
    {
        //Act
        var result = Check.StrictPositive((decimal)input).Passed;
        //Assert
        Assert.AreEqual(expectedValidity, result);
    }

    #endregion StrictPositive
}
