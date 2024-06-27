namespace Semantica.Core.DependencyInjection;

/// <summary>
/// Represents errors that occur during DI registrations using <see cref="ModuleBase{TContainer}"/>.   
/// </summary>
public class ModuleException : Exception
{
    public ModuleException(string message) : base(message)
    {
    }

    public ModuleException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
