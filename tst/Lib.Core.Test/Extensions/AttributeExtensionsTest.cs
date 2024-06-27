using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class AttributeExtensionsTest
{
    private const int c_int = 1073741823;
        
    [TestMethod]
    public void GetAttribute_TestEnum_ReturnsMyTestAttribute()
    {
        //ACT
        var result = TestEnum.ValueWithAttribute.GetAttribute<MyTestAttribute, TestEnum>();
        //ASSERT
        Assert.AreEqual(c_int, result.Value);
    }

    [TestMethod]
    public void GetAttribute_EnumValueWithNoAttribute_ReturnsNull()
    {
        //ACT
        var result = TestEnum.ValueWithoutAttribute.GetAttribute<MyTestAttribute, TestEnum>();
        //ASSERT
        Assert.IsNull(result);
    }


    [TestMethod]
    public void HasAttribute_EnumValueWithAttribute_ReturnsTrue()
    {
        //ACT
        var result = TestEnum.ValueWithAttribute.HasAttribute<MyTestAttribute, TestEnum>();
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void HasAttribute_EnumValueWithNoAttribute_ReturnsFalse()
    {
        //ACT
        var result = TestEnum.ValueWithoutAttribute.HasAttribute<MyTestAttribute, TestEnum>();
        //ASSERT
        Assert.IsFalse(result);
    }

    private enum TestEnum
    {
        [MyTest(c_int)]
        ValueWithAttribute,
        ValueWithoutAttribute
    }

    private class MyTestAttribute : Attribute
    {
        public MyTestAttribute(int value)
        {
            Value = value;
        }

        public int Value { get; }
    }
}