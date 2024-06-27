using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Types;

namespace Semantica.Lib.Tests.Core.Test.Types;

[TestClass]
public class DateSpanExtensionsTest
{
    private readonly DateSpan _difference = SomeDateSpan.Create();
    private readonly DateOnly _earlierDateOnly = SomeDateOnly.CreateSpanSubtracted();
    private readonly DateTime _earlierDateTime = SomeDateTime.CreateSpanSubtracted();
    private readonly DateOnly _laterDateOnly = SomeDateOnly.Create();
    private readonly DateTime _laterDateTime = SomeDateTime.Create();
    private readonly DateSpan _negativeDifference = SomeDateSpan.CreateNegative();

    [TestMethod]
    public void Difference_LeftEarlierDate_CorrectValue()
    {
        //ACT
        var actual = _earlierDateOnly.Difference(_laterDateOnly);
        //ASSERT
        Assert.AreEqual(_negativeDifference, actual);
    }
    
    [TestMethod]
    public void Difference_LeftEarlierDateTime_CorrectValue()
    {
        //ACT
        var actual = _earlierDateTime.Difference(_laterDateTime);
        //ASSERT
        Assert.AreEqual(_negativeDifference, actual);
    }

    [TestMethod]
    public void Difference_LeftEarlierDate_IsNegative()
    {
        //ACT
        var actual = _earlierDateOnly.Difference(_laterDateOnly);
        //ASSERT
        Assert.That.IsTrue(actual.IsNegative);
    }

    [TestMethod]
    public void Difference_LeftEarlierDateTime_IsNegative()
    {
        //ACT
        var actual = _earlierDateTime.Difference(_laterDateTime);
        //ASSERT
        Assert.That.IsTrue(actual.IsNegative);
    }

    [TestMethod]
    public void Difference_LeftLaterDate_CorrectValue()
    {
        //ACT
        var actual = _laterDateOnly.Difference(_earlierDateOnly);
        //ASSERT
        Assert.AreEqual(_difference, actual);
    }

    [TestMethod]
    public void Difference_LeftLaterDateTime_CorrectValue()
    {
        //ACT
        var actual = _laterDateTime.Difference(_earlierDateTime);
        //ASSERT
        Assert.AreEqual(_difference, actual);
    }

    [TestMethod]
    public void Difference_LeftLaterDate_IsPositive()
    {
        //ACT
        var actual = _laterDateOnly.Difference(_earlierDateOnly);
        //ASSERT
        Assert.That.IsFalse(actual.IsNegative);
    }

    [TestMethod]
    public void Difference_LeftLaterDateTime_IsPositive()
    {
        //ACT
        var actual = _laterDateTime.Difference(_earlierDateTime);
        //ASSERT
        Assert.That.IsFalse(actual.IsNegative);
    }
}
