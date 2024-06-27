using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class IntExtensionsTest
{
    [TestMethod]
    public void Modulo_SomeNumber_CalculatesTheModulo()
    {            
        //ACT
        var result = 12.Modulo(10);
        //ASSERT
        Assert.AreEqual(2, result);
    }
        
    [TestMethod]
    public void Modulo_SomeNegativeNumber_CalculatesTheModulo()
    {
        //ACT
        var result = (-12).Modulo(10);
        //ASSERT
        Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void IsPowerOfTwo_Two_ReturnsTrue()
    {            
        //ACT
        var result = 2.IsPowerOfTwo();
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPowerOfTwo_One_ReturnsTrue()
    {
        //ACT
        var result = 1.IsPowerOfTwo();
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsPowerOfTwo_Zero_ReturnsFalse()
    {
        //ACT
        var result = 0.IsPowerOfTwo();
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsPowerOfTwo_Tree_ReturnsFalse()
    {
        //ACT
        var result = 3.IsPowerOfTwo();
        //ASSERT
        Assert.IsFalse(result);
    }

    [DataTestMethod]
    [DataRow(4)]
    [DataRow(8)]
    [DataRow(16)]
    [DataRow(128)]
    [DataRow(256)]
    [DataRow(65536)]
    [DataRow(1073741824)]
    public void IsPowerOfTwo_SomeMorePowersOfTwo_ReturnsTrue(int num)
    {
        //ACT
        var result = num.IsPowerOfTwo();
        //ASSERT
        Assert.IsTrue(result);
    }

    [DataTestMethod]
    [DataRow(5)]
    [DataRow(6)]
    [DataRow(7)]
    [DataRow(99)]
    [DataRow(255)]
    [DataRow(257)]
    [DataRow(65537)]
    public void IsPowerOfTwo_SomeMoreNonPowersOfTwo_ReturnsFalse(int num)
    {
        //ACT
        var result = num.IsPowerOfTwo();
        //ASSERT
        Assert.IsFalse(result);
    }
}