using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class EnumExtensionsTest
{
    [TestMethod]
    public void EnumerateFlagValues_TestFlags_ReturnsCorrectCount()
    {
        var multiValueFlag = TestFlag.Twee | TestFlag.Vierenzestig | TestFlag.Tweehonderdzesenvijftig;
        //ACT
        var result = multiValueFlag.EnumerateFlagValues().Count();
        //ASSERT
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void EnumerateFlagValues_TestFlags_ReturnsCorrectFlags()
    {
        var multiValueFlag = TestFlag.Twee | TestFlag.Vierenzestig | TestFlag.Tweehonderdzesenvijftig;
        //ACT
        var result = multiValueFlag.EnumerateFlagValues().ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { TestFlag.Twee, TestFlag.Vierenzestig, TestFlag.Tweehonderdzesenvijftig }, result);
    }

    [TestMethod]
    public void EnumerateFlagValues_TestFlagsWithZero_ReturnsCorrectCount()
    {
        var multiValueFlag = TestFlagWithZero.Twee | TestFlagWithZero.Vierenzestig | TestFlagWithZero.Tweehonderdzesenvijftig;
        //ACT
        var result = multiValueFlag.EnumerateFlagValues().Count();
        //ASSERT
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void EnumerateFlagValues_TestFlagsWithZero_ReturnsCorrectFlags()
    {
        var multiValueFlag = TestFlagWithZero.Twee | TestFlagWithZero.Vierenzestig | TestFlagWithZero.Tweehonderdzesenvijftig;
        //ACT
        var result = multiValueFlag.EnumerateFlagValues().ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { TestFlagWithZero.Nul, TestFlagWithZero.Twee, TestFlagWithZero.Vierenzestig, TestFlagWithZero.Tweehonderdzesenvijftig }, result);
    }

    [TestMethod]
    public void EnumerateFlagValues_TestFlagsWithZero_ReturnsOnlyZero()
    {
        var multiValueFlag = TestFlagWithZero.Nul;
        //ACT
        var result = multiValueFlag.EnumerateFlagValues().ToList();
        //ASSERT
        CollectionAssert.AreEqual(new[] { TestFlagWithZero.Nul }, result);
    }


    [Flags]
    public enum TestFlag
    {
        Een = 1 << 1,
        Twee = 1 << 2,
        Vier = 1 << 3,
        Acht = 1 << 4,
        Zestien = 1 << 5,
        Tweeendertig = 1 << 6,
        Vierenzestig = 1 << 7,
        Honderdachtentwintig = 1 << 8,
        Tweehonderdzesenvijftig = 1 << 9,
    }

    [Flags]
    public enum TestFlagWithZero
    {
        Nul = 0,
        Een = 1 << 1,
        Twee = 1 << 2,
        Vier = 1 << 3,
        Acht = 1 << 4,
        Zestien = 1 << 5,
        Tweeendertig = 1 << 6,
        Vierenzestig = 1 << 7,
        Honderdachtentwintig = 1 << 8,
        Tweehonderdzesenvijftig = 1 << 9,
    }
}