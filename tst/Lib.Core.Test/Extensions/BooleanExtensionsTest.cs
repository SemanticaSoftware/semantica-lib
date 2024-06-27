using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Semantica.Lib.Tests.Core.Test.Extensions;

class BooleanExtensionsTest
{
    [TestMethod]
    public void IsExplicitFalse_NullableBoolFalse_ReturnsTrue()
    {
        bool? nullableBool = false;
        //ACT
        var result = nullableBool.IsExplicitFalse();
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsExplicitFalse_NullableBoolTrue_ReturnsFalse()
    {
        bool? nullableBool = true;
        //ACT
        var result = nullableBool.IsExplicitFalse();
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsExplicitFalse_NullableBoolNull_ReturnsFalse()
    {
        bool? nullableBool = null;
        //ACT
        var result = nullableBool.IsExplicitFalse();
        //ASSERT
        Assert.IsFalse(result);
    }
}