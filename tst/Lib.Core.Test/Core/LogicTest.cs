using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Core;

namespace Semantica.Lib.Tests.Core.Test.Core;

[TestClass]
public class LogicTest
{
    #region ExactlyOne

    [TestMethod]
    public void ExactlyOne_PtrueQtrue_ReturnsFalse()
    {
        //ACT
        var result = Logic.ExactlyOne(true, true);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ExactlyOne_PtrueQfalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.ExactlyOne(true, false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ExactlyOne_PfalseQtrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.ExactlyOne(false, true);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ExactlyOne_PfalseQfalse_ReturnsFalse()
    {
        //ACT
        var result = Logic.ExactlyOne(false, false);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ExactlyOne_MultipleParamsOneTrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.ExactlyOne(false, true, false, false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ExactlyOne_MultipleParamsTwoTrue_ReturnsFalse()
    {
        //ACT
        var result = Logic.ExactlyOne(false, true, true, false);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ExactlyOne_OneParamFalse_ReturnsFalse()
    {
        //ACT
        var result = Logic.ExactlyOne(false);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void ExactlyOne_OneParamTrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.ExactlyOne(true);
        //ASSERT
        Assert.IsTrue(result);
    }

    #endregion ExactlyOne

    #region None

    [TestMethod]
    public void None_PtrueQtrue_ReturnsFalse()
    {
        //ACT
        var result = Logic.None(true, true);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void None_PtrueQfalse_ReturnsFalse()
    {
        //ACT
        var result = Logic.None(true, false);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void None_PfalseQtrue_ReturnsFalse()
    {
        //ACT
        var result = Logic.None(false, true);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void None_PfalseQfalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.None(false, false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void None_MultipleParamsAllFalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.None(false, false, false, false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void None_MultipleParamsTwoTrue_ReturnsFalse()
    {
        //ACT
        var result = Logic.None(false, true, true, false);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void None_OneParamFalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.None(false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void None_OneParamTrue_ReturnsFalse()
    {
        //ACT
        var result = Logic.None(true);
        //ASSERT
        Assert.IsFalse(result);
    }

    #endregion None

    #region OneOrNone

    [TestMethod]
    public void OneOrNone_PtrueQtrue_ReturnsFalse()
    {
        //ACT
        var result = Logic.NoneOrOne(true, true);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void OneOrNone_PtrueQfalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.NoneOrOne(true, false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void OneOrNone_PfalseQtrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.NoneOrOne(false, true);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void OneOrNone_PfalseQfalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.NoneOrOne(false, false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void OneOrNone_MultipleParamsAllFalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.NoneOrOne(false, false, false, false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void OneOrNone_MultipleParamsTwoTrue_ReturnsFalse()
    {
        //ACT
        var result = Logic.NoneOrOne(false, true, true, false);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void OneOrNone_OneParamFalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.NoneOrOne(false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void OneOrNone_OneParamTrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.NoneOrOne(true);
        //ASSERT
        Assert.IsTrue(result);
    }

    #endregion OneOrNone

    #region Follows

    [TestMethod]
    public void Follows_PtrueQtrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.Follows(true, true);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Follows_PtrueQfalse_ReturnsFalse()
    {
        //ACT
        var result = Logic.Follows(true, false);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Follows_PfalseQtrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.Follows(false, true);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Follows_PfalseQfalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.Follows(false, true);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Follows_PtrueMultipleQallTrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.Follows(true, true, true);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Follows_PtrueMultipleQallFalse_ReturnsFalse()
    {
        //ACT
        var result = Logic.Follows(true, false, false);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Follows_PfalseMultipleQallFalse_ReturnsTrue()
    {
        //ACT
        var result = Logic.Follows(false, false, false);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Follows_PfalseMultipleQallTrue_ReturnsTrue()
    {
        //ACT
        var result = Logic.Follows(false, true, true);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Follows_PtrueMultipleQmixed_ReturnsFalse()
    {
        //ACT
        var result = Logic.Follows(true, false, true);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Follows_PfalseMultipleQmixed_ReturnsTrue()
    {
        //ACT
        var result = Logic.Follows(false, false, true);
        //ASSERT
        Assert.IsTrue(result);
    }

    #endregion Follows
}