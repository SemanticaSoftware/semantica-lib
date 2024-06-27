using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Types;
// ReSharper disable InvokeAsExtensionMethod

namespace Semantica.Lib.Tests.Core.Test.Types;

[TestClass]
public class PartitionDateExtensionsTest
{
    private PartitionDate _partitionDate, _emptyPartitionDate;
    private DateTime _equivalentDateTime;
    private DateOnly _equivalentDate;
    
    [TestInitialize]
    public void Init()
    {
        _emptyPartitionDate = default;
        _partitionDate = SomePartitionDate.Create();
        _equivalentDateTime = new DateTime(SomePartitionDate.Year, SomePartitionDate.Month, SomePartitionDate.Day);
        _equivalentDate = DateOnly.FromDateTime(_equivalentDateTime);
    }

    #region AsDate(Only|Time)

    [TestMethod]
    public void AsDateOnly_SomeValue_ReturnsEquivalent()
    {
        //ACT
        var actual = PartitionDateExtensions.AsDateOnly(_partitionDate);
        //ASSERT
        Assert.AreEqual(_equivalentDate, actual);
    }

    [TestMethod]
    public void AsDateOnly_EmptyValue_Throws()
    {
        //ACT
        var actual = () => { PartitionDateExtensions.AsDateOnly(_emptyPartitionDate); };
        //ASSERT
        Assert.ThrowsException<ArgumentOutOfRangeException>(actual);
    }

    [TestMethod]
    public void AsDateTime_SomeValue_ReturnsEquivalent()
    {
        //ACT
        var actual = PartitionDateExtensions.AsDateTime(_partitionDate);
        //ASSERT
        Assert.AreEqual(_equivalentDateTime, actual);
    }

    [TestMethod]
    public void AsDateTime_EmptyValue_Throws()
    {
        //ACT
        var actual = () => { PartitionDateExtensions.AsDateTime(_emptyPartitionDate); };
        //ASSERT
        Assert.ThrowsException<ArgumentOutOfRangeException>(actual);
    }

    #endregion
    #region AsNullableDate(Only|Time)

    [TestMethod]
    public void AsNullableDateOnly_EmptyValue_ReturnsNullable()
    {
        //ACT
        var actual = PartitionDateExtensions.AsNullableDateOnly(_emptyPartitionDate);
        //ASSERT
        Assert.IsFalse(actual.HasValue);
    }

    [TestMethod]
    public void AsNullableDateTime_EmptyValue_ReturnsNullable()
    {
        //ACT
        var actual = PartitionDateExtensions.AsNullableDateTime(_emptyPartitionDate);
        //ASSERT
        Assert.IsFalse(actual.HasValue);
    }

    #endregion
    #region AsPartitionDate

    [TestMethod]
    public void AsPartitionDate_FromDateOnly_ReturnsEquivalent()
    {
        //ACT
        var actual = PartitionDateExtensions.AsPartitionDate(_equivalentDate);
        //ASSERT
        Assert.AreEqual(_partitionDate, actual);
    }

    [TestMethod]
    public void AsPartitionDate_FromDateTime_ReturnsEquivalent()
    {
        //ACT
        var actual = PartitionDateExtensions.AsPartitionDate(_equivalentDateTime);
        //ASSERT
        Assert.AreEqual(_partitionDate, actual);
    }

    #endregion
    #region HasValid(Day|Month|Year)

    [TestMethod]
    public void HasValidDay_DayTooHigh_False()
    {
        //ACT
        var actual = PartitionDateExtensions.HasValidDay(SomePartitionDate.Create(day: 32));
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void HasValidDay_ValidDay_True()
    {
        //ACT
        var actual = PartitionDateExtensions.HasValidDay(SomePartitionDate.Create(day: 16));
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void HasValidDay_Zero_False()
    {
        //ACT
        var actual = PartitionDateExtensions.HasValidDay(SomePartitionDate.Create(day: 0));
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void HasValidMonth_MonthTooHigh_False()
    {
        //ACT
        var actual = PartitionDateExtensions.HasValidMonth(SomePartitionDate.Create(month: 13));
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void HasValidMonth_ValidMonth_True()
    {
        //ACT
        var actual = PartitionDateExtensions.HasValidMonth(SomePartitionDate.Create(month: 6));
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void HasValidMonth_Zero_False()
    {
        //ACT
        var actual = PartitionDateExtensions.HasValidMonth(SomePartitionDate.Create(month: 0));
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void HasValidYear_ValidYear_True()
    {
        //ACT
        var actual = PartitionDateExtensions.HasValidYear(SomePartitionDate.Create(year: 6));
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void HasValidYear_Zero_False()
    {
        //ACT
        var actual = PartitionDateExtensions.HasValidYear(SomePartitionDate.Create(year: 0));
        //ASSERT
        Assert.IsFalse(actual);
    }
    
    #endregion
    #region IsValidDate

    [TestMethod]
    public void IsValidDate_EmptyDate_False()
    {
        //ACT
        var actual = PartitionDateExtensions.IsValidDate(_emptyPartitionDate);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsValidDate_InvalidCombination_False()
    {
        //ACT
        var actual = PartitionDateExtensions.IsValidDate(SomePartitionDate.Create(month: 2, day: 30));
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsValidDate_InvalidPart_False()
    {
        //ACT
        var actual = PartitionDateExtensions.IsValidDate(SomePartitionDate.Create(day: 33));
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void IsValidDate_LeapDay_True()
    {
        //ACT
        var actual = PartitionDateExtensions.IsValidDate(SomePartitionDate.Create(day: 29, month: 2, year: 2020));
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void IsValidDate_SomeValidDate_True()
    {
        //ACT
        var actual = PartitionDateExtensions.IsValidDate(_partitionDate);
        //ASSERT
        Assert.IsTrue(actual);
    }

    #endregion
    #region TryAsDate(Only|Time)

    [TestMethod]
    public void TryAsDateOnly_EmptyValue_False()
    {
        //ACT
        var actual = PartitionDateExtensions.TryAsDateOnly(_emptyPartitionDate, out _);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void TryAsDateOnly_SomeValue_CorrectOutput()
    {
        //ACT
        PartitionDateExtensions.TryAsDateOnly(_partitionDate, out var actual);
        //ASSERT
        Assert.AreEqual(_equivalentDate, actual);
    }

    [TestMethod]
    public void TryAsDateOnly_SomeValue_True()
    {
        //ACT
        var actual = PartitionDateExtensions.TryAsDateOnly(_partitionDate, out _);
        //ASSERT
        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void TryAsDateTime_EmptyValue_False()
    {
        //ACT
        var actual = PartitionDateExtensions.TryAsDateTime(_emptyPartitionDate, out _);
        //ASSERT
        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void TryAsDateTime_SomeValue_CorrectOutput()
    {
        //ACT
        PartitionDateExtensions.TryAsDateTime(_partitionDate, out var actual);
        //ASSERT
        Assert.AreEqual(_equivalentDateTime , actual);
    }

    [TestMethod]
    public void TryAsDateTime_SomeValue_True()
    {
        //ACT
        var actual = PartitionDateExtensions.TryAsDateTime(_partitionDate, out _);
        //ASSERT
        Assert.IsTrue(actual);
    }

    #endregion
}
