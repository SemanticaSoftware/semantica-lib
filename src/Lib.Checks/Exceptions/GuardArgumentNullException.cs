using JetBrains.Annotations;

namespace Semantica.Checks.Exceptions;

/// <summary>
/// A subtype of <see cref="ArgumentNullException"/>, meant to be thrown when a guard on the arguments of a method fails.
/// </summary>
public class GuardArgumentNullException : ArgumentNullException
{
    /// <inheritdoc/>
    internal GuardArgumentNullException([InvokerParameterName] string? argumentName, string message)
        : base(argumentName, message)
    {
    }
}
