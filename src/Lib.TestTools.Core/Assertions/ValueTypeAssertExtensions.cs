using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Types;

namespace Semantica.TestTools.Core.Assertions;

public static class ValueTypeAssertExtensions
{
    public static void AreEqualValue(this Assert assert, DateTime expectedValue, PartitionDate actual)
    {
        Assert.That.IsNotEmpty(actual);
        var expectedDateDay = expectedValue.AsPartitionDate();
        Assert.AreEqual(expectedDateDay, actual, $"Dates not equal: {expectedDateDay} expected, {actual} encountered");
    }
}