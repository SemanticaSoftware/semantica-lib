using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Checks;
using Semantica.Patterns;

namespace Semantica.TestTools.Core.Assertions;

public static class ChkAssertExtensions
{
    /// <summary>Asserts if the <paramref name="chk"/> is a determined <see cref="Chk.Fail"/>.</summary>
    public static void HasFailed(this Assert assert, IChk chk, string? message = null)
    {
        IsDetermined(assert, chk, message);
        IsFail(assert, chk, message);
    }

    /// <summary>Asserts if the <paramref name="chk"/> is a determined <see cref="Chk.Pass"/>.</summary>
    public static void HasPassed(this Assert assert, IChk chk, string? message = null)
    {
        IsDetermined(assert, chk, message);
        IsPass(assert, chk, message);
    }

    /// <summary>Asserts if the <paramref name="chk"/> contains a non-default payload.</summary>
    public static void HasPayload<T>(this Assert assert, Chk<T> chk, string? message = null)
    {
        Assert.AreEqual(default(T), chk.Payload, message ?? $"{nameof(Chk.Reason)} expected on {nameof(Chk)}.");
    }

    /// <summary>Asserts if the <paramref name="chk"/> contains a reason.</summary>
    public static void HasReason(this Assert assert, IChk chk, string? message = null)
    {
        Assert.IsNotNull(chk.Reason, message ?? $"{nameof(Chk.Reason)} expected on {nameof(Chk)}.");
    }

    /// <summary>Asserts if the <paramref name="chk"/> is determined.</summary>
    public static void IsDetermined(this Assert assert, IChk chk, string? message = null)
    {
        var determinable = chk as IDeterminable;
        Assert.IsTrue(determinable == null || determinable.IsDetermined,
            message ?? $"Encountered undetermined value of {nameof(Chk)}{WithReason(chk)}.");
    }

    /// <summary>Asserts if the <paramref name="chk"/> is a <see cref="Chk.Fail"/>.</summary>
    /// <remarks>
    /// Caution! Does not check if the chk is determined. Always use Assert.<see cref="HasFailed"/> unless you specifically
    /// do not want the <see cref="IDeterminable.IsDetermined"/> assert. 
    /// </remarks>
    public static void IsFail(this Assert assert, IChk chk, string? message = null)
    {
        Assert.IsFalse(chk.Passed,
            message ?? $"Expected {nameof(Chk)}.{nameof(Chk.Fail)}. Encountered {nameof(Chk)}.{nameof(Chk.Pass)}{WithReason(chk)}.");
    }

    /// <summary>Asserts if the <paramref name="chk"/> is an undetermined <see cref="Chk.Fail"/> with a payload.</summary>
    public static void IsFailPayload<T>(this Assert assert, Chk<T> chk, string? message = null)
    {
        assert.IsFail(chk, message);
        assert.IsUndetermined(chk, message);
        assert.HasPayload(chk, message);
    }

    /// <summary>Asserts if the <paramref name="chk"/> is an undetermined <see cref="Chk.Fail"/> with a reason.</summary>
    public static void IsFailReason(this Assert assert, IChk chk, string? message = null)
    {
        assert.IsFail(chk, message);
        assert.IsUndetermined(chk, message);
        assert.HasReason(chk, message);
    }
    
    /// <summary>Asserts if the <paramref name="chk"/> is a <see cref="Chk.Pass"/>.</summary>
    /// <remarks>
    /// Caution! Does not check if the chk is determined. Always use Assert.<see cref="HasFailed"/> unless you specifically
    /// do not want the <see cref="IDeterminable.IsDetermined"/> assert. 
    /// </remarks>
    public static void IsPass(this Assert assert, IChk chk, string? message = null)
    {
        Assert.IsTrue(chk.Passed,
            message ?? $"Expected {nameof(Chk)}.{nameof(Chk.Pass)}. Encountered {nameof(Chk)}.{nameof(Chk.Fail)}{WithReason(chk)}.");
    }

    /// <summary>Asserts if the <paramref name="chk"/> is an undetermined <see cref="Chk.Pass"/> with a payload.</summary>
    public static void IsPassPayload<T>(this Assert assert, Chk<T> chk, string? message = null)
    {
        assert.IsPass(chk, message);
        assert.IsUndetermined(chk, message);
        assert.HasPayload(chk, message);
    }

    /// <summary>Asserts if the <paramref name="chk"/> is an undetermined <see cref="Chk.Pass"/> with a reason.</summary>
    public static void IsPassReason(this Assert assert, IChk chk, string? message = null)
    {
        assert.IsPass(chk, message);
        assert.IsUndetermined(chk, message);
        assert.HasReason(chk, message);
    }

    /// <summary>Asserts if the <paramref name="chk"/> is undetermined.</summary>
    public static void IsUndetermined(this Assert assert, IChk chk, string? message = null)
    {
        var determinable = chk as IDeterminable;
        Assert.IsFalse(determinable is { IsDetermined: true },
            message ?? $"Encountered undetermined value of {nameof(Chk)}{WithReason(chk)}.");
    }

    private static string? WithReason(IChk chk) => chk.Reason == null ? null : $" with {nameof(Chk.Reason)}: \"{chk.Reason}\"";
}
