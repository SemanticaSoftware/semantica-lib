using JetBrains.Annotations;

namespace Semantica.Checks.Exceptions;

/// <summary>
/// A subtype of <see cref="ArgumentOutOfRangeException"/>, meant to be thrown when a guard on the arguments of a method fails.
/// </summary>
public class GuardArgumentOutOfRangeException : ArgumentOutOfRangeException
{
    /// <inheritdoc/>
    internal GuardArgumentOutOfRangeException([InvokerParameterName] string? argumentName, string message)
        : base(message, argumentName)
    {
    }
}
