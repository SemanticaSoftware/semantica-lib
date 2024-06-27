using JetBrains.Annotations;

namespace Semantica.Checks.Exceptions;

/// <summary>
/// A subtype of <see cref="ArgumentException"/>, meant to be thrown when a guard on the arguments of a method fails.
/// </summary>
public class GuardArgumentException : ArgumentException
{
    /// <inheritdoc/>
    internal GuardArgumentException(string message) : base(message)
    {
    }
    
    /// <inheritdoc/>
    internal GuardArgumentException([InvokerParameterName] string? argumentName, string message) : base(message, argumentName)
    {
    }
}
