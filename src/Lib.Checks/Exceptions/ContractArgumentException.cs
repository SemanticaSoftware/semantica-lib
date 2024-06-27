using JetBrains.Annotations;

namespace Semantica.Checks.Exceptions;

/// <summary>
/// A subtype of <see cref="ArgumentException"/>, meant to be thrown when a contract guard on the arguments of a method fails.
/// </summary>
public class ContractArgumentException : ArgumentException
{
    /// <inheritdoc/>
    internal ContractArgumentException(string message) : base(message)
    {
    }
    
    /// <inheritdoc/>
    internal ContractArgumentException([InvokerParameterName] string? argumentName, string message)
        : base(message, argumentName)
    {
    }
}