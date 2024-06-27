using JetBrains.Annotations;

namespace Semantica.Checks.Exceptions;

/// <summary>
/// Provides a number of static methods that create exception instances to be thrown when argument guards fail.
/// </summary>
public static class GuardException
{

    /// <summary>
    /// Makes a new <see cref="GuardArgumentException"/>.
    /// </summary>
    public static GuardArgumentException Make(string? expression)
    {
        return new GuardArgumentException($@"[Guard] failure evaluating {expression}.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentException"/>.
    /// </summary>
    public static GuardArgumentException Make(string description, [InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentException(argumentName, $@"[Guard] unexpected condition: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentNullException"/>.
    /// </summary>
    public static GuardArgumentNullException MakeEmpty([InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentNullException(argumentName, @"[Guard] unexpected null or empty argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentNullException"/>.
    /// </summary>
    public static GuardArgumentNullException MakeEmpty(string description, [InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentNullException(
            argumentName,
            $@"[Guard] unexpected null or empty argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentException"/>, <see cref="GuardArgumentNullException"/> or
    /// <see cref="GuardArgumentOutOfRangeException"/>, depending on the <paramref name="check"/>'s <see cref="CheckKind"/>.
    /// </summary>
    public static ArgumentException MakeFor(Chk<CheckKind> check)
    {
        return check.Payload switch {
                CheckKind.Defined => MakeUndefined(check.Reason),
                CheckKind.MaxValue => MakeMaxValue(check.Reason),
                CheckKind.NotNull => MakeNull(check.Reason),
                CheckKind.NotEmpty => MakeEmpty(check.Reason),
                CheckKind.NonZero => MakeNonZero(check.Reason),
                CheckKind.NonNegative => MakeNonNegative(check.Reason),
                CheckKind.StrictPositive => MakeStrictPositive(check.Reason),
                _ => Make(check.Reason)
            };
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentException"/>, <see cref="GuardArgumentNullException"/> or
    /// <see cref="GuardArgumentOutOfRangeException"/>, depending on the <paramref name="check"/>'s <see cref="CheckKind"/>.
    /// </summary>
    public static ArgumentException MakeFor(
        Chk<CheckKind> check,
        string description)
    {
        return check.Payload switch {
            CheckKind.Defined => MakeUndefined(description, check.Reason),
            CheckKind.MaxValue => MakeMaxValue(description,check.Reason),
            CheckKind.NotNull => MakeNull(description, check.Reason),
            CheckKind.NotEmpty => MakeEmpty(description, check.Reason),
            CheckKind.NonZero => MakeNonZero(description, check.Reason),
            CheckKind.NonNegative => MakeNonNegative(description, check.Reason),
            CheckKind.StrictPositive => MakeStrictPositive(description, check.Reason),
            _ => Make(description, check.Reason)
        };
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentOutOfRangeException"/>.
    /// </summary>
    public static GuardArgumentOutOfRangeException MakeMaxValue([InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentOutOfRangeException(argumentName, @"[Guard] argument is larger than max value.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentOutOfRangeException"/>.
    /// </summary>
    public static GuardArgumentOutOfRangeException MakeMaxValue(
        string description,[InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentOutOfRangeException(
            argumentName, $@"[Guard] argument is larger than max value: {description}");
    }
    
    /// <summary>
    /// Makes a new <see cref="GuardArgumentOutOfRangeException"/>.
    /// </summary>
    public static GuardArgumentOutOfRangeException MakeNonNegative([InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentOutOfRangeException(argumentName, @"[Guard] unexpected negative argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentOutOfRangeException"/>.
    /// </summary>
    public static GuardArgumentOutOfRangeException MakeNonNegative(
        string description,
        [InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentOutOfRangeException(
            argumentName, $@"[Guard] unexpected negative argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentOutOfRangeException"/>.
    /// </summary>
    public static GuardArgumentOutOfRangeException MakeNonZero([InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentOutOfRangeException(
            argumentName, @"[Guard] unexpected zero-value argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentOutOfRangeException"/>.
    /// </summary>
    public static GuardArgumentOutOfRangeException MakeNonZero(string description, [InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentOutOfRangeException(
            argumentName, $@"[Guard] unexpected zero-value argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentNullException"/>.
    /// </summary>
    public static GuardArgumentNullException MakeNull([InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentNullException(argumentName, @"[Guard] unexpected null argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentNullException"/>.
    /// </summary>
    public static GuardArgumentNullException MakeNull(string description, [InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentNullException(argumentName, $@"[Guard] unexpected null argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentOutOfRangeException"/>.
    /// </summary>
    public static GuardArgumentOutOfRangeException MakeStrictPositive([InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentOutOfRangeException(
            argumentName, @"[Guard] unexpected negative or zero-value argument encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentOutOfRangeException"/>.
    /// </summary>
    public static GuardArgumentOutOfRangeException MakeStrictPositive(
        string description,
        [InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentOutOfRangeException(
            argumentName, $@"[Guard] unexpected negative or zero-value argument: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentException"/>.
    /// </summary>
    public static GuardArgumentException MakeUndefined([InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentException(argumentName, @"[Guard] undefined value encountered.");
    }

    /// <summary>
    /// Makes a new <see cref="GuardArgumentException"/>.
    /// </summary>
    public static GuardArgumentException MakeUndefined(string description, [InvokerParameterName] string? argumentName)
    {
        return new GuardArgumentException(argumentName, $@"[Guard] undefined value: {description}.");
    }

    /// <summary>
    /// Makes a new <see cref="IndexOutOfRangeException"/>
    /// </summary>
    public static Exception MakeIndex(int start, int end)
    {
        return new IndexOutOfRangeException($"index is less than {start}, or larger than or equal to {end}.");
    }
}