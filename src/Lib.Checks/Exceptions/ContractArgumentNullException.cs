using JetBrains.Annotations;

namespace Semantica.Checks.Exceptions;

/// <summary>
/// A subtype of <see cref="ArgumentNullException"/>, meant to be thrown when a contract guard on the arguments of a method
/// fails.
/// </summary>
public class ContractArgumentNullException : ArgumentNullException
{
    /// <inheritdoc/>
    internal ContractArgumentNullException([InvokerParameterName] string? argumentName, string message)
        : base(argumentName, message)
    {
    }
}