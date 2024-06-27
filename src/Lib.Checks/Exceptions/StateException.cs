namespace Semantica.Checks.Exceptions;

/// <summary>
/// <para>
/// A subtype of <see cref="InvalidOperationException"/>, meant to be thrown when a guard on the state when calling an instance
/// method fails.
/// </para>
/// <para>
/// Also provides a number of static methods that create exception instances.
/// </para>
/// </summary>
public class StateException : InvalidOperationException
{
    public StateException() {
    }

    /// <inheritdoc/>
    public StateException(string message) : base(message)
    {
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException Make(string? expression)
    {
        return new StateException($@"[State]: failure evaluating {expression}.");
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException Make(string? description, string? fieldName)
    {
        return new StateException($@"[State]: failure{Field(fieldName)}.{Description(description)}");
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException MakeEmpty(string? fieldName, string? description = null)
    {
        return new StateException($@"[State] null or empty{Field(fieldName)}.{Description(description)}");
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException MakeFor(Chk<CheckKind> check)
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
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException MakeFor(Chk<CheckKind> check, string description)
    {
        return check.Payload switch {
            CheckKind.Defined => MakeUndefined(check.Reason, description),
            CheckKind.NotNull => MakeNull(check.Reason, description),
            CheckKind.NotEmpty => MakeEmpty(check.Reason, description),
            CheckKind.NonZero => MakeNonZero(check.Reason, description),
            CheckKind.NonNegative => MakeNonNegative(check.Reason, description),
            CheckKind.StrictPositive => MakeStrictPositive(check.Reason, description),
            CheckKind.Bool => Make(description, check.Reason),
            _ => Make(description)
        };
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException MakeNonNegative(string? fieldName, string? description = null)
    {
        return new StateException($@"[State] negative{Field(fieldName)}.{Description(description)}");
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException MakeNonZero(string? fieldName, string? description = null)
    {
        return new StateException($@"[State] zero-value{Field(fieldName)}.{Description(description)}");
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException MakeNull(string? fieldName, string? description = null)
    {
        return new StateException($@"[State] null{Field(fieldName)}.{Description(description)}");
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException MakeStrictPositive(string? fieldName, string? description = null)
    {
        return new StateException($@"[State] negative or zero-value{Field(fieldName)}.{Description(description)}");
    }

    /// <summary>
    /// Makes a new <see cref="StateException"/>.
    /// </summary>
    public static StateException MakeUndefined(string? fieldName, string? description = null)
    {
        return new StateException($@"[State] undefined{Field(fieldName)}.{Description(description)}");
    }

    private static string Description(string? description) => description == null ? string.Empty : $" {description}.";
    private static string Field(string? fieldName) => fieldName == null ? string.Empty : $" field: {fieldName}";
}