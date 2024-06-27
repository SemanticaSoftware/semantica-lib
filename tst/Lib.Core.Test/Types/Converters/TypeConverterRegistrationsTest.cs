using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Core;
using Semantica.Lib.Tests.Core.Test._Mocks;
using Semantica.Types;
using Semantica.Types.Converters;

namespace Semantica.Lib.Tests.Core.Test.Types.Converters;

[TestClass]
public class TypeConverterRegistrationsTest
{
    [TestMethod]
    public void AddTypeConverterAttributesInAssembly_PartitionDateTypeConverter_IsCorrectConverter()
    {
        var converterType = typeof(PartitionDateTypeConverter);
        //ACT
        TypeConverterRegistrations.AddTypeConverterAttributesInAssembly(converterType.Assembly);
        //ASSERT
        var converter = TypeDescriptor.GetConverter(typeof(PartitionDate));
        Assert.IsInstanceOfType(converter, converterType);
    }
    
    [TestMethod]
    public void AddTypeConverterAttributes_TestTypeConverter_IsCorrectConverter()
    {
        //ACT
        var converterType = typeof(TestTypeConverter);
        TypeConverterRegistrations.AddTypeConverterAttributes(new Type[] { converterType });
        //ASSERT
        var converter = TypeDescriptor.GetConverter(typeof(TestType<int>));
        Assert.IsInstanceOfType(converter, converterType);
    }
    
    [TestMethod]
    public void AddTypeConverterAttributes_InvalidTestTypeConverter_Throws()
    {
        //ACT
        var act = () => TypeConverterRegistrations.AddTypeConverterAttributes(
            new Type[] { typeof(InvalidTestTypeConverter) });
        //ASSERT
        Assert.ThrowsException<TypeConverterRegistrations.TypeConverterRegistrationsException>(act);
    }
    
    [TestMethod]
    public void AddTypeConverterAttributes_DuplicateTestTypeConverter_Throws()
    {
        //ACT
        var act = () => TypeConverterRegistrations.AddTypeConverterAttributes(
            new Type[] { typeof(TestTypeConverter), typeof(TestTypeConverter) });
        //ASSERT
        Assert.ThrowsException<TypeConverterRegistrations.TypeConverterRegistrationsException>(act);
    }
    
    private class TestTypeConverter : StringTypeConverterBase<TestType<int>>, IRuntimeTypeConverter<TestType<int>, TestTypeConverter>
    {
        protected override TestType<int> FromString(string str) => throw new NotImplementedException();

        protected override string? ToString(TestType<int> value) => throw new NotImplementedException();
    }
    
    private class InvalidTestTypeConverter : StringTypeConverterBase<TestType<int>>, IRuntimeTypeConverter<TestType<int>, TestTypeConverter>
    {
        protected override TestType<int> FromString(string str) => throw new NotImplementedException();

        protected override string? ToString(TestType<int> value) => throw new NotImplementedException();
    }
}
