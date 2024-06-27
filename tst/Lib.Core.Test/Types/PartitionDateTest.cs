using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Core.Test._SomeData.Types;
using Semantica.Types;

namespace Semantica.Lib.Tests.Core.Test.Types;

[TestClass]
public class PartitionDateTest
{
    private PartitionDate _partitionDate, _emptyPartitionDate;
    
    [TestInitialize]
    public void Init()
    {
        _emptyPartitionDate = default;
        _partitionDate = SomePartitionDate.Create();
    }

    #region Equals

    [TestMethod]
    public void Equals_DifferentDay_False()
    {
        var second = new PartitionDate(_partitionDate.Year, _partitionDate.Month, _partitionDate.Day - 1);
        //ACT
        var actual = _partitionDate.Equals(second);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Equals_DifferentMonth_False()
    {
        var second = new PartitionDate(_partitionDate.Year, _partitionDate.Month - 1, _partitionDate.Day);
        //ACT
        var actual = _partitionDate.Equals(second);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Equals_DifferentYear_False()
    {
        var second = new PartitionDate(_partitionDate.Year - 1, _partitionDate.Month, _partitionDate.Day);
        //ACT
        var actual = _partitionDate.Equals(second);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Equals_SomeValue_True()
    {
        var second = new PartitionDate(_partitionDate.Year, _partitionDate.Month, _partitionDate.Day);
        //ACT
        var actual = _partitionDate.Equals(second);
        //ASSERT
        Assert.IsTrue(actual);
    }


    #endregion
    #region Get(Day|Month|Year)

    [TestMethod]
    public void GetDay_SomeValue_CorrectValue()
    {
        //ACT
        var actual = _partitionDate.GetDay();
        //ASSERT
        Assert.AreEqual(SomePartitionDate.Day, actual);
    }

    [TestMethod]
    public void GetMonth_SomeValue_CorrectValue()
    {
        //ACT
        var actual = _partitionDate.GetMonth();
        //ASSERT
        Assert.AreEqual(SomePartitionDate.Month, actual);
    }

    [TestMethod]
    public void GetYear_SomeValue_CorrectValue()
    {
        //ACT
        var actual = _partitionDate.GetYear();
        //ASSERT
        Assert.AreEqual(SomePartitionDate.Year, actual);
    }

    #endregion
    #region Has(Day|Month|Year)

    [TestMethod]
    public void HasDay_EmptyValue_False()
    {
        //ACT
        var actual = _emptyPartitionDate.HasDay();
        //ASSERT
        Assert.IsFalse(actual);
    }


    [TestMethod]
    public void HasDay_SomeValue_True()
    {
        //ACT
        var actual = _partitionDate.HasDay();
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void HasMonth_EmptyValue_False()
    {
        //ACT
        var actual = _emptyPartitionDate.HasMonth();
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void HasMonth_SomeValue_True()
    {
        //ACT
        var actual = _partitionDate.HasMonth();
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void HasYear_EmptyValue_False()
    {
        //ACT
        var actual = _emptyPartitionDate.HasYear();
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void HasYear_SomeValue_True()
    {
        //ACT
        var actual = _partitionDate.HasYear();
        //ASSERT
        Assert.IsTrue(actual);
    }

    #endregion

    [TestMethod]
    public void IsEmpty_EmptyValue_True()
    {
        //ACT
        var actual = _emptyPartitionDate.IsEmpty();
        //ASSERT
        Assert.IsTrue(actual);
    }
    
    #region MakeSafe

    [TestMethod]
    public void MakeSafe_SomeValue_CorrectValue()
    {
        //ACT
        var actual = PartitionDate.MakeSafe(_partitionDate.Year, _partitionDate.Month, _partitionDate.Day);
        //ASSERT
        Assert.AreEqual(_partitionDate, actual);
    }

    [TestMethod]
    public void MakeSafe_OutOfRangeYear_ReturnsEmpty()
    {
        //ACT
        var actual = PartitionDate.MakeSafe(10000, _partitionDate.Month, _partitionDate.Day);
        //ASSERT
        Assert.That.IsEmpty(actual);
    }

    [TestMethod]
    public void MakeSafe_OutOfRangeMonth_ReturnsEmpty()
    {
        //ACT
        var actual = PartitionDate.MakeSafe(_partitionDate.Year, 100, _partitionDate.Day);
        //ASSERT
        Assert.That.IsEmpty(actual);
    }

    [TestMethod]
    public void MakeSafe_OutOfRangeDay_ReturnsEmpty()
    {
        //ACT
        var actual = PartitionDate.MakeSafe(_partitionDate.Year, _partitionDate.Month, 100);
        //ASSERT
        Assert.That.IsEmpty(actual);
    }

    #endregion
}
