using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Core.Test._Mocks;

namespace Semantica.Lib.Tests.Core.Test.Extensions;

[TestClass]
public class ExtensionsTest
{
    private TestClass Class { get; } = new TestClass(666); 
    private TestStruct Struct { get; } = new TestStruct(666);
    private TestClass? ClassNullable => Class;
    private TestStruct? StructNullable => Struct;
    private TestClass? ClassNull => default;
    private TestStruct? StructNull => default;
    
    [TestMethod]
    public void IfNotNull_NullClassToClass_Null()
    {
        //ACT
        var actual = ClassNull.IfNotNull(ClassToClass);
        //ASSERT
        Assert.IsNull(actual);
    }
    
    [TestMethod]
    public void IfNotNull_NullClassToStruct_Null()
    {
        //ACT
        var actual = ClassNull.IfNotNull(ClassToStruct);
        //ASSERT
        Assert.IsNull(actual);
    }
    
    [TestMethod]
    public void IfNotNull_NullStructToClass_Null()
    {
        //ACT
        var actual = StructNull.IfNotNull(StructToClass);
        //ASSERT
        Assert.IsNull(actual);
    }
    
    [TestMethod]
    public void IfNotNull_NullStructToStruct_Null()
    {
        //ACT
        var actual = StructNull.IfNotNull(StructToStruct);
        //ASSERT
        Assert.IsNull(actual);
    }
    
    [TestMethod]
    public void IfNotNull_NotNullClassToClass_NotNull()
    {
        //ACT
        var actual = ClassNullable.IfNotNull(ClassToClass);
        //ASSERT
        Assert.IsNotNull(actual);
    }
    
    [TestMethod]
    public void IfNotNull_NotNullClassToStruct_NotNull()
    {
        //ACT
        var actual = ClassNullable.IfNotNull(ClassToStruct);
        //ASSERT
        Assert.IsNotNull(actual);
    }
    
    [TestMethod]
    public void IfNotNull_NotNullStructToClass_NotNull()
    {
        //ACT
        var actual = StructNullable.IfNotNull(StructToClass);
        //ASSERT
        Assert.IsNotNull(actual);
    }
    
    [TestMethod]
    public void IfNotNull_NotNullStructToStruct_NotNull()
    {
        //ACT
        var actual = StructNullable.IfNotNull(StructToStruct);
        //ASSERT
        Assert.IsNotNull(actual);
    }

    
    private TestClass ClassToClass(TestClass instance) => new TestClass(instance.Value);
    private TestStruct ClassToStruct(TestClass instance) => new TestStruct(instance.Value);
    private TestStruct StructToStruct(TestStruct instance) => new TestStruct(instance.Value);
    private TestClass StructToClass(TestStruct instance) => new TestClass(instance.Value);
}
