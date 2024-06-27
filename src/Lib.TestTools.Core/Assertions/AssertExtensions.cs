using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Extensions;
using Semantica.Intervals;
using Semantica.Patterns;

namespace Semantica.TestTools.Core.Assertions;

public static class AssertExtensions
{
    [AssertionMethod]
    public static void AreCorrectBounds<T>(this Assert _, T lowerBound, T upperbound, IReadOnlyInterval<T> result, string? message = null)
        where T : IComparable<T>
    {
        var correctLowerBound = lowerBound.CompareTo(result.Left) == 0;
        var correctUpperBound = upperbound.CompareTo(result.Right) == 0;
        Assert.IsTrue(correctUpperBound && correctLowerBound, message ?? 
                                                              "Lower bound is {0}. Upper bound is {1}.",
            (correctLowerBound ? "correct" : $"incorrect - expected [{lowerBound}], encountered [{result.Left}]"),
            (correctUpperBound ? "correct" : $"incorrect - expected [{upperbound}], encountered [{result.Right}]"));
    }

    [AssertionMethod]
    public static void AreEqual<T>(this Assert _, T expected, T actual, IEqualityComparer<T> comparer, string? message = null)
    {
        Assert.IsTrue(comparer.Equals(expected, actual), message ?? $"Encountered value of [{actual}] was expected to be equal to value of [{expected}]");
    }

    [AssertionMethod]
    public static void AreEqual(this Assert _, string expected, ReadOnlySpan<char> actual, string? message = null)
    {
        Assert.AreEqual(expected, actual.ToString(), message);
    }

    [AssertionMethod]
    public static void AreNotEqual<T>(this Assert _, T expected, T actual, IEqualityComparer<T> comparer, string? message = null)
    {
        Assert.IsFalse(comparer.Equals(expected, actual), message ?? $"Encountered value of [{actual}] was expected to be not equal to value of [{expected}]");
    }

    [AssertionMethod]
    public static void AreNotEqual(this Assert _, string expected, ReadOnlySpan<char> actual, string? message = null)
    {
        Assert.AreNotEqual(expected, actual.ToString(), message);
    }

    [AssertionMethod]
    public static void AreWithinEpsilon(this Assert _, decimal expected, decimal actual, decimal epsilon, string? message = null)
    {
        Assert.IsTrue(Math.Abs(expected - actual) < epsilon, message ?? $"Encountered value [{actual}] is not within epislon of expected value {expected}");
    }

    [AssertionMethod]
    public static void AreWithinEpsilon(this Assert _, decimal expected, decimal? actual, decimal epsilon, string? message = null)
    {
        Assert.IsTrue(actual.HasValue, message ?? "Encountered actual value is null");
        AreWithinEpsilon(_, expected, actual.Value, epsilon, message);
    }

    [AssertionMethod]
    public static void AreWithinEpsilon(this Assert _, double expected, double actual, double epsilon, string? message = null)
    {
        Assert.IsTrue(Math.Abs(expected - actual) < epsilon, message ?? $"Encountered value [{actual}] is not within epislon of expected value {expected}");
    }

    [AssertionMethod]
    public static void AreWithinEpsilon(this Assert _, double expected, double? actual, double epsilon, string? message = null)
    {
        Assert.IsTrue(actual.HasValue, message ?? "Encountered actual value is null");
        AreWithinEpsilon(_, expected, actual.Value, epsilon, message);
    }

    [AssertionMethod]
    public static void IsDefault<T>(this Assert _, T actual, string? message = null)
        where T: struct
    {
        Assert.IsTrue(actual.IsDefault(), message ?? $"Default value expected; Non-default value ({actual}) encountered.");
    }

    [AssertionMethod]
    public static void IsDefault<T>(this Assert _, object? actual, string? message = null)
        where T: struct
    {
        Assert.IsNotNull(actual, message ?? "Default value expected; Null encountered.");
        Assert.IsTrue(((T)actual).IsDefault(), message ?? $"Default value expected; Non-default value ({actual}) encountered.");
    }

    [AssertionMethod]
    public static void IsEmpty(this Assert _, ICanBeEmpty actual, string? message = null)
    {
        Assert.IsTrue(actual.IsEmpty(), message ?? $"Empty value expected; Non-empty value ({actual}) encountered.");
    }

    [AssertionMethod]
    public static void IsEmpty(this Assert _, string? actual, string? message = null)
    {
        Assert.IsTrue(string.IsNullOrEmpty(actual), message ?? $"Empty value expected; Non-empty value ({actual}) encountered.");
    }

    [AssertionMethod]
    public static void IsEmpty<T>(this Assert _, ReadOnlySpan<T> actual, string? message = null)
    {
        Assert.IsTrue(actual.IsEmpty, message ?? $"Empty value expected; Non-empty value ({actual.ToString()}) encountered.");
    }

    [AssertionMethod]
    public static void IsFalse(
        this Assert _,
        [DoesNotReturnIf(true)] bool condition,
        [CallerArgumentExpression("condition")] string? expression = null)
    {
        Assert.IsFalse(condition, $"Expression: [{expression}] is true; False expected.");
    }

    [AssertionMethod]
    public static void IsFalse(
        this Assert _,
        [DoesNotReturnIf(true)] bool? condition,
        [CallerArgumentExpression("condition")] string? expression = null)
    {
        Assert.IsFalse(condition, $"Expression: [{expression}] is {(condition.HasValue ? "true" : "null")}; False expected.");
    }

    [AssertionMethod]
    public static void IsNotDefault<T>(this Assert _, object? actual, string? message = null)
        where T: struct
    {
        Assert.IsNotNull(actual, message ?? "Non-default value expected; Null encountered.");
        Assert.IsFalse(((T)actual).IsDefault(), message ?? "Non-default value expected; Default value encountered.");
    }

    [AssertionMethod]
    public static void IsNotDefault<T>(this Assert _, T actual, string? message = null)
        where T: struct
    {
        Assert.IsFalse(actual.IsDefault(), message ?? $"Non-default value expected; Default value ({actual}) encountered.");
    }

    [AssertionMethod]
    public static void IsNotEmpty(this Assert _, ICanBeEmpty actual, string? message = null)
    {
        Assert.IsFalse(actual.IsEmpty(), message ?? $"Non-empty value expected; Empty value ({actual}) encountered");
    }

    [AssertionMethod]
    public static void IsNotEmpty(this Assert _, string? actual, string? message = null)
    {
        Assert.IsNotNull(actual, message ?? "Non-empty value expected; Null encountered.");
        Assert.IsFalse(string.IsNullOrEmpty(actual), message ?? $"Non-empty value expected; Empty value ({actual}) encountered");
    }

    [AssertionMethod]
    public static void IsNotEmpty<T>(this Assert _, ReadOnlySpan<T> actual, string? message = null)
    {
        Assert.IsFalse(actual.IsEmpty, message ?? $"Non-empty value expected; Empty value ({actual.ToString()}) encountered");
    }

    [AssertionMethod]
    public static void IsTrue(
        this Assert _,
        [DoesNotReturnIf(false)] bool condition,
        [CallerArgumentExpression("condition")] string? expression = null)
    {
        Assert.IsTrue(condition, $"Expression: [{expression}] is false; True expected.");
    }

    [AssertionMethod]
    public static void IsTrue(
        this Assert _,
        [DoesNotReturnIf(false)] bool? condition,
        [CallerArgumentExpression("condition")] string? expression = null)
    {
        Assert.IsTrue(condition, $"Expression: [{expression}] is {(condition.HasValue ? "false" : "null")}; True expected.");
    }

    [AssertionMethod]
    public static void StartsWith(this Assert _, string expected, string actual, string? message = null)
    {
        Assert.IsTrue(actual.StartsWith(expected), message ?? $"Expected start \"{expected}\" was not encountered at the start of actual \"{actual}\"");
    }
}
