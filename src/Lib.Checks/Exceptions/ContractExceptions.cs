using JetBrains.Annotations;

namespace Semantica.Checks.Exceptions;

/// <summary>
/// Provides a number of static methods that create exception instances to be thrown when contract guards fail.
/// </summary>
public static class ContractException
{

    /// <summary>
    /// Makes a new <see cref="ContractArgumentException"/>.
    /// </summary>
    public static ContractArgumentException Make(string? expression)
    {
        return new ContractArgumentException($@"[Contract] failure evaluating {expression}.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentException"/>.
    /// </summary>
    public static ContractArgumentException Make(string description, [InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentException(argumentName, $@"[Contract] unexpected condition: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentNullException"/>.
    /// </summary>
    public static ContractArgumentNullException MakeEmpty([InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentNullException(
            argumentName,
            @"[Contract] unexpected null or empty argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentNullException"/>.
    /// </summary>
    public static ContractArgumentNullException MakeEmpty(string description, [InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentNullException(
            argumentName,
            $@"[Contract] unexpected null or empty argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentException"/>, <see cref="ContractArgumentNullException"/> or
    /// <see cref="ContractArgumentOutOfRangeException"/>, depending on the <paramref name="check"/>'s <see cref="CheckKind"/>.
    /// </summary>
    public static ArgumentException MakeFor(Chk<CheckKind> check)
    {
        return check.Payload switch {
                CheckKind.Defined => MakeUndefined(check.Reason),
                CheckKind.NotNull => MakeNull(check.Reason),
                CheckKind.NotEmpty => MakeEmpty(check.Reason),
                CheckKind.NonZero => MakeNonZero(check.Reason),
                CheckKind.NonNegative => MakeNonNegative(check.Reason),
                CheckKind.StrictPositive => MakeStrictPositive(check.Reason),
                _ => Make(check.Reason)
            };
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentException"/>, <see cref="ContractArgumentNullException"/> or
    /// <see cref="ContractArgumentOutOfRangeException"/>, depending on the <paramref name="check"/>'s <see cref="CheckKind"/>.
    /// </summary>
    public static ArgumentException MakeFor(
        Chk<CheckKind> check,
        string description)
    {
        return check.Payload switch {
            CheckKind.Defined => MakeUndefined(description, check.Reason),
            CheckKind.NotNull => MakeNull(description, check.Reason),
            CheckKind.NotEmpty => MakeEmpty(description, check.Reason),
            CheckKind.NonZero => MakeNonZero(description, check.Reason),
            CheckKind.NonNegative => MakeNonNegative(description, check.Reason),
            CheckKind.StrictPositive => MakeStrictPositive(description, check.Reason),
            _ => Make(description, check.Reason)
        };
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentOutOfRangeException"/>.
    /// </summary>
    public static ContractArgumentOutOfRangeException MakeNonNegative([InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentOutOfRangeException(
            argumentName,
            @"[Contract] unexpected negative argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentOutOfRangeException"/>.
    /// </summary>
    public static ContractArgumentOutOfRangeException MakeNonNegative(
        string description,
        [InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentOutOfRangeException(
            argumentName,
            $@"[Contract] unexpected negative argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentOutOfRangeException"/>.
    /// </summary>
    public static ContractArgumentOutOfRangeException MakeNonZero([InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentOutOfRangeException(
            argumentName,
            @"[Contract] unexpected zero-value argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentOutOfRangeException"/>.
    /// </summary>
    public static ContractArgumentOutOfRangeException MakeNonZero(
        string description,
        [InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentOutOfRangeException(
            argumentName,
            $@"[Contract] unexpected zero-value argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentNullException"/>.
    /// </summary>
    public static ContractArgumentNullException MakeNull([InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentNullException(argumentName, @"[Contract] unexpected null argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentNullException"/>.
    /// </summary>
    public static ContractArgumentNullException MakeNull(string description, [InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentNullException(argumentName, $@"[Contract] unexpected null argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentOutOfRangeException"/>.
    /// </summary>
    public static ContractArgumentOutOfRangeException MakeStrictPositive([InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentOutOfRangeException(
            argumentName,
            @"[Contract] unexpected negative or zero-value argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentOutOfRangeException"/>.
    /// </summary>
    public static ContractArgumentOutOfRangeException MakeStrictPositive(
        string description,
        [InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentOutOfRangeException(
            argumentName,
            $@"[Contract] unexpected negative or zero-value argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentException"/>.
    /// </summary>
    public static ContractArgumentException MakeUndefined([InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentException(argumentName, @"[Contract] undefined value encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="ContractArgumentException"/>.
    /// </summary>
    public static ContractArgumentException MakeUndefined(string description, [InvokerParameterName] string? argumentName)
    {
        return new ContractArgumentException(argumentName, $@"[Contract] undefined value: {description}.");
    }
}