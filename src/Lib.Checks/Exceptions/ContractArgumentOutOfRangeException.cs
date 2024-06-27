using JetBrains.Annotations;

namespace Semantica.Checks.Exceptions;

/// <summary>
/// A subtype of <see cref="ArgumentOutOfRangeException"/>, meant to be thrown when a contract guard on the arguments of a
/// method fails.
/// </summary>
public class ContractArgumentOutOfRangeException : ArgumentOutOfRangeException
{
    /// <inheritdoc/>
    internal ContractArgumentOutOfRangeException([InvokerParameterName] string? argumentName, string message)
        : base(message, argumentName)
    {
    }
}