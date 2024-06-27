using System.Runtime.CompilerServices;

namespace Semantica.Storage.EntityFramework;

public class UnitOfWorkException : Exception
{
    public UnitOfWorkException(Exception? innerException, [CallerMemberName] string? methodName = null) 
        : base($"Exception thrown in UnitOfWork by {methodName ?? "unknown"}", innerException)
    {
    }
}
