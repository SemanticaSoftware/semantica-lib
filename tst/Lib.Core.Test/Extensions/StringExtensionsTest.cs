using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class StringExtensionsTest
{
    private const string _someLetters = "abc";
    private const string _someLettersWithWhitespace = " abc ";
    private const string _whitespace = "   ";

    #region Capitalize

    [DataTestMethod]
    [DataRow("abc", "Abc")]
    [DataRow("a", "A")]
    [DataRow("Abc", "Abc")]
    [DataRow(" abc", " abc")]
    [DataRow("%abc", "%abc")]
    [DataRow("a b c", "A b c")]
    [DataRow("123", "123")]
    [DataRow("ë", "Ë")]
    [DataRow("öabc", "Öabc")]
    [DataRow("µ", "Μ")]
    [DataRow("ßabc", "ßabc")]
    public void Capitalize(string stringToCapitalize, string expectedResult)
    {
        //ACT
        var actual = StringExtensions.Capitalize(stringToCapitalize);
        //ASSERT
        Assert.AreEqual(expectedResult, actual);
    }

    #endregion
    #region ConditionalTrim

    [TestMethod]
    public void ConditionalTrim_ConditionFalse_InputNotTrimmed()
    {
        //ACT
        var actual = StringExtensions.ConditionalTrim(_someLettersWithWhitespace, trim: false);
        //ASSERT
        Assert.That.AreEqual(_someLettersWithWhitespace, actual);
    }

    [TestMethod]
    public void ConditionalTrim_ConditionTrue_InputTrimmed()
    {
        //ACT
        var actual = StringExtensions.ConditionalTrim(_someLettersWithWhitespace, trim: true);
        //ASSERT
        Assert.That.AreEqual(_someLetters, actual);
    }

    #endregion
    #region Contains

    [DataTestMethod]
    [DataRow("abc")]
    [DataRow("abcxxx")]
    [DataRow("xxxabc")]
    [DataRow("xabcxx")]
    public void Contains_InputsWithAbc_True(string input)
    {
        //ACT
        var actual = StringExtensions.Contains(input, _someLetters);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [DataTestMethod]
    [DataRow("")]
    [DataRow("ab")]
    [DataRow("Abc")]
    [DataRow("axbc")]
    [DataRow("a bc")]
    public void Contains_InputsWithoutAbc_False(string input)
    {
        //ACT
        var actual = StringExtensions.Contains(input, _someLetters);
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    #endregion
    #region EmptyOnNull

    [DataTestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void EmptyOnNull_Empty_Empty(bool trim)
    {
        //ACT
        var actual = StringExtensions.EmptyOnNull(string.Empty, trim);
        //ASSERT
        Assert.That.IsEmpty(actual);
    }

    [DataTestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void EmptyOnNull_Null_Empty(bool trim)
    {
        //ACT
        var actual = StringExtensions.EmptyOnNull(null, trim);
        //ASSERT
        Assert.That.IsEmpty(actual);
    }

    [DataTestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void EmptyOnNull_SomeLetters_NotEmpty(bool trim)
    {
        //ACT
        var actual = StringExtensions.EmptyOnNull(_someLetters, trim);
        //ASSERT
        Assert.AreEqual(_someLetters, actual);
    }

    [TestMethod]
    public void EmptyOnNull_SomeLettersWithWhitespaceNoTrim_NotTrimmedResult()
    {
        //ACT
        var actual = StringExtensions.EmptyOnNull(_someLettersWithWhitespace, trim: false);
        //ASSERT
        Assert.AreEqual(_someLettersWithWhitespace, actual);
    }

    [TestMethod]
    public void EmptyOnNull_SomeLettersWithWhitespaceTrim_TrimmedResult()
    {
        //ACT
        var actual = StringExtensions.EmptyOnNull(_someLettersWithWhitespace, trim: true);
        //ASSERT
        Assert.AreEqual(_someLetters, actual);
    }

    [TestMethod]
    public void EmptyOnNull_WhitespaceNoTrim_NotEmpty()
    {
        //ACT
        var actual = StringExtensions.EmptyOnNull(_whitespace, trim: false);
        //ASSERT
        Assert.AreEqual(_whitespace, actual);
    }

    [TestMethod]
    public void EmptyOnNull_WhitespaceTrim_Empty()
    {
        //ACT
        var actual = StringExtensions.EmptyOnNull(_whitespace, trim: true);
        //ASSERT
        Assert.That.IsEmpty(actual);
    }

    #endregion
    #region NullOnEmpty

    [DataTestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void NullOnEmpty_Empty_Null(bool trim)
    {
        //ACT
        var actual = StringExtensions.NullOnEmpty(string.Empty, trim);
        //ASSERT
        Assert.IsNull(actual);
    }

    [DataTestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void NullOnEmpty_Null_Null(bool trim)
    {
        //ACT
        var actual = StringExtensions.NullOnEmpty(null, trim);
        //ASSERT
        Assert.IsNull(actual);
    }

    [DataTestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void NullOnEmpty_SomeLetters_NotNull(bool trim)
    {
        //ACT
        var actual = StringExtensions.NullOnEmpty(_someLetters, trim);
        //ASSERT
        Assert.AreEqual(_someLetters, actual);
    }

    [TestMethod]
    public void NullOnEmpty_SomeLettersWithWhitespaceNoTrim_NotTrimmedResult()
    {
        //ACT
        var actual = StringExtensions.NullOnEmpty(_someLettersWithWhitespace, trim: false);
        //ASSERT
        Assert.AreEqual(_someLettersWithWhitespace, actual);
    }

    [TestMethod]
    public void NullOnEmpty_SomeLettersWithWhitespaceTrim_TrimmedResult()
    {
        //ACT
        var actual = StringExtensions.NullOnEmpty(_someLettersWithWhitespace, trim: true);
        //ASSERT
        Assert.AreEqual(_someLetters, actual);
    }

    [TestMethod]
    public void NullOnEmpty_WhitespaceNoTrim_NotNull()
    {
        //ACT
        var actual = StringExtensions.NullOnEmpty(_whitespace, trim: false);
        //ASSERT
        Assert.AreEqual(_whitespace, actual);
    }

    [TestMethod]
    public void NullOnEmpty_WhitespaceTrim_Null()
    {
        //ACT
        var actual = StringExtensions.NullOnEmpty(_whitespace, trim: true);
        //ASSERT
        Assert.IsNull(actual);
    }

    #endregion
    #region ToKebabCase

    [TestMethod]
    public void ToKebabCase_Abbreviation_KebabCase()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("ABCDef");
        //ASSERT
        Assert.AreEqual("abc-def", actual);
    }

    [TestMethod]
    public void ToKebabCase_AbbreviationAndUnderscore_KebabCase()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("ABC_Def");
        //ASSERT
        Assert.AreEqual("abc_def", actual);
    }

    [TestMethod]
    public void ToKebabCase_AbbreviationLast_KebabCase()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("AbcDEF");
        //ASSERT
        Assert.AreEqual("abc-def", actual);
    }

    [TestMethod]
    public void ToKebabCase_AbbreviationLastAndUnderscore_KebabCase()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("Abc_DEF");
        //ASSERT
        Assert.AreEqual("abc_def", actual);
    }

    [TestMethod]
    public void ToKebabCase_AbbreviationMiddle_KebabCase()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("AbCDEf");
        //ASSERT
        Assert.AreEqual("ab-cd-ef", actual);
    }

    [TestMethod]
    public void ToKebabCase_AllLower_SingleChunk()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase(_someLetters);
        //ASSERT
        Assert.AreEqual(_someLetters, actual);
    }

    [TestMethod]
    public void ToKebabCase_AllUpper_SingleChunkLowercase()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase(_someLetters.ToUpper());
        //ASSERT
        Assert.AreEqual(_someLetters, actual);
    }

    [TestMethod]
    public void ToKebabCase_CamelCase_KebabCase()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("abcDef");
        //ASSERT
        Assert.AreEqual("abc-def", actual);
    }

    [TestMethod]
    public void ToKebabCase_PascalCase_KebabCase()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("AbcDef");
        //ASSERT
        Assert.AreEqual("abc-def", actual);
    }
    [TestMethod]
    public void ToKebabCase_Underscore_PreserveUnderscore()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("Abc_Def");
        //ASSERT
        Assert.AreEqual("abc_def", actual);
    }

    [TestMethod]
    public void ToKebabCase_UnderscoreCombo_KebabCaseWithUnderscore()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("Ab_CdEf");
        //ASSERT
        Assert.AreEqual("ab_cd-ef", actual);
    }

    [TestMethod]
    public void ToKebabCase_UnderscoreEnd_PreserveUnderscore()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("AbcDef_");
        //ASSERT
        Assert.AreEqual("abc-def_", actual);
    }

    [TestMethod]
    public void ToKebabCase_UnderscoreStart_PreserveUnderscore()
    {
        //ACT
        var actual = StringExtensions.ToKebabCase("_AbcDef");
        //ASSERT
        Assert.AreEqual("_abc-def", actual);
    }

    #endregion
    #region ToSnakeCase

    [TestMethod]
    public void ToSnakeCase_Abbreviation_SnakeCase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("ABCDef");
        //ASSERT
        Assert.AreEqual("abc_def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_AbbreviationAndUnderscore_SnakeCase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("ABC_Def");
        //ASSERT
        Assert.AreEqual("abc__def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_AbbreviationLast_SnakeCase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("AbcDEF");
        //ASSERT
        Assert.AreEqual("abc_def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_AbbreviationLastAndUnderscore_SnakeCase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("Abc_DEF");
        //ASSERT
        Assert.AreEqual("abc__def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_AbbreviationMiddle_SnakeCase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("AbCDEf");
        //ASSERT
        Assert.AreEqual("ab_cd_ef", actual);
    }

    [TestMethod]
    public void ToSnakeCase_AbbreviationWithNumber_SnakeCase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("ABC7Def");
        //ASSERT
        Assert.AreEqual("abc7_def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_AllLower_SingleChunk()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase(_someLetters);
        //ASSERT
        Assert.AreEqual(_someLetters, actual);
    }

    [TestMethod]
    public void ToSnakeCase_AllUpper_SingleChunkLowercase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase(_someLetters.ToUpper());
        //ASSERT
        Assert.AreEqual(_someLetters, actual);
    }

    [TestMethod]
    public void ToSnakeCase_CamelCase_SnakeCase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("abcDef");
        //ASSERT
        Assert.AreEqual("abc_def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_InnerNumber_SingleChunk()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("abc7def");
        //ASSERT
        Assert.AreEqual("abc7def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_NumberAfterBound_NoBoundaryForNumber()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("abcD7ef");
        //ASSERT
        Assert.AreEqual("abc_d7ef", actual);
    }

    [TestMethod]
    public void ToSnakeCase_NumberPostfix_BoundaryAfterNumber()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("abc7Def");
        //ASSERT
        Assert.AreEqual("abc7_def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_PascalCase_SnakeCase()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("AbcDef");
        //ASSERT
        Assert.AreEqual("abc_def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_Underscore_DoubleUnderscore()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("Abc_Def");
        //ASSERT
        Assert.AreEqual("abc__def", actual);
    }

    [TestMethod]
    public void ToSnakeCase_UnderscoreCombo_DoubleUnderscore()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("Ab_CdEf");
        //ASSERT
        Assert.AreEqual("ab__cd_ef", actual);
    }

    [TestMethod]
    public void ToSnakeCase_UnderscoreEnd_PreserveUnderscore()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("AbcDef_");
        //ASSERT
        Assert.AreEqual("abc_def_", actual);
    }

    [TestMethod]
    public void ToSnakeCase_UnderscoreStart_PreserveUnderscore()
    {
        //ACT
        var actual = StringExtensions.ToSnakeCase("_AbcDef");
        //ASSERT
        Assert.AreEqual("_abc_def", actual);
    }

    #endregion
    #region TryIndexOf

    [DataTestMethod]
    [DataRow("abc", 'a', true, 0)]
    [DataRow("aaaaaa", 'a', true, 0)]
    [DataRow("abc", 'c', true, 2)]
    [DataRow("ABCabc", 'b', true, 4)]
    [DataRow("abcabc", 'z', false, -1)]
    [DataRow("abcabc", 'B', false, -1)]
    public void TryIndexOf(string stringToSearch, char charToFindIndexOf, bool expectedResult, int expectedIndex)
    {
        //ACT
        var actual = StringExtensions.TryIndexOf(stringToSearch, charToFindIndexOf, out var index);
        //ASSERT
        Assert.AreEqual(expectedResult, actual);
        Assert.AreEqual(expectedIndex, index);
    }

    #endregion

    [TestMethod]
    public void TakeMax_ShortString_ReturnsCompleteString()
    {
        var lengthThree  = "abc";
        //ACT
        var actual = StringExtensions.TakeMax(lengthThree, 5);
        //ASSERT
        Assert.AreEqual(lengthThree , actual);
    }

    [TestMethod]
    public void TakeMax_LongString_ReturnsShortnedString()
    {
        var lengthThree  = "abc";
        var lengthSix = lengthThree  + "def";
        //ACT
        var actual = StringExtensions.TakeMax(lengthSix, 3);
        //ASSERT
        Assert.AreEqual(lengthThree , actual);
    }

    [TestMethod]
    public void Truncate_LongString_ReturnsTruncatedString()
    {
        var stringToTruncate = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        //ACT
        var actual = StringExtensions.Truncate(stringToTruncate, 26);

        //ASSERT
        Assert.AreEqual("abcdefghijklmnopqrstuvwxyz(...)", actual);
    }

    [TestMethod]
    public void Truncate_ShortString_ReturnsSameString()
    {
        var stringToTruncate = "abc";
        //ACT
        var actual = StringExtensions.Truncate(stringToTruncate, 26);

        //ASSERT
        Assert.AreEqual(stringToTruncate, actual);
    }

    [TestMethod]
    public void Truncate_LongStringWithProvidedElipsis_ReturnsTruncatedStringWithProvidedElipsis()
    {
        var stringToTruncate = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        var providedElipsis = "...TL;DR";
        //ACT
        var actual = StringExtensions.Truncate(stringToTruncate, 26, providedElipsis);

        //ASSERT
        Assert.AreEqual("abcdefghijklmnopqrstuvwxyz" + providedElipsis, actual);
    }

    [TestMethod]
    public void Truncate_ShortStringWithProvidedElipsis_ReturnsSameString()
    {
        var stringToTruncate = "abc";
        var providedElipsis = "...TL;DR";
        //ACT
        var actual = StringExtensions.Truncate(stringToTruncate, 26, providedElipsis);

        //ASSERT
        Assert.AreEqual(stringToTruncate, actual);
    }

    [TestMethod]
    public void Truncate_Null_ReturnsNull()
    {
        string? stringToTruncate = null;
        //ACT
        var actual = StringExtensions.Truncate(stringToTruncate, 26);

        //ASSERT
        Assert.AreEqual(stringToTruncate, actual);
    }

    [TestMethod]
    public void RemoveSpecialCharacters_SimpleString_ReturnsCompleteString()
    {
        var simpleString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        //ACT
        var actual = StringExtensions.RemoveSpecialCharacters(simpleString);
        //ASSERT
        Assert.AreEqual(simpleString, actual);
    }

    [TestMethod]
    public void RemoveSpecialCharacters_StringWithSpecialChars_ReturnsSimpleString()
    {
        var simpleString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        var specialCharacters = "`-=[];',./\\~!@#$%^&*()_+{}:<>?|\"";
        var stringToTest = specialCharacters + simpleString;
        //ACT
        var actual = StringExtensions.RemoveSpecialCharacters(stringToTest);
        //ASSERT
        Assert.AreEqual(simpleString, actual);
    }

    [DataTestMethod]
    [DataRow("1", 1, DisplayName = "single digit")]
    [DataRow("109", 109, DisplayName = "triple digits")]
    [DataRow("65535", 65535, DisplayName = "uint16.max")]
    [DataRow("2147483647", Int32.MaxValue, DisplayName = "int32.max")]
    public void ToInt_DataRows_ResultsAreAsExpected(IEnumerable<char> digits, int expected)
    {
        //ACT
        var actual = StringExtensions.ToInt(digits);
        //ASSERT
        Assert.AreEqual(expected, actual);
    }

    [DataTestMethod]
    [DataRow("abc", "abc ")]
    [DataRow("a", "a ")]
    [DataRow("a b c", "a b c ")]
    [DataRow("   ", "   ")]
    [DataRow("", "")]
    [DataRow(null, null)]
    public void WithSpace(string stringToWithSpace, string expectedResult)
    {
        //ACT
        var actual = StringExtensions.WithSpace(stringToWithSpace);

        //ASSERT
        Assert.AreEqual(expectedResult, actual);
    }
}
