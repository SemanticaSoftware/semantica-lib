using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Checks;

namespace Semantica.TestTools.Core.Assertions;

public static class CheckAssertExtensions
{
    public static void IsOfKind(this Assert assert, Chk<CheckKind> check, CheckKind expectedKind, string? message = null)
    {
        Assert.AreEqual(expectedKind, check.Payload, message ?? $"Expected check of kind [{expectedKind}]. Found check of Kind [{check.Payload}]");
    }

    public static void IsNotValid(this Assert assert, Chk<CheckKind> check, string? message = null)
    {
        Assert.IsFalse(check.Passed, message ?? $"Expected not-valid Check. Found valid check of Kind [{check.Payload}]");
    }

    public static void IsValid(this Assert assert, Chk<CheckKind> check, string? message = null)
    {
        Assert.IsTrue(check.Passed, message ?? $"Expected valid Check. Found not-valid check of Kind [{check.Payload}]");
    }
}
