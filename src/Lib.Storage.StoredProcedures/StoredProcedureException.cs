using JetBrains.Annotations;

namespace Semantica.Storage.StoredProcedures;

public class StoredProcedureException : InvalidOperationException
{
    public StoredProcedureException([CanBeNull] string message) : base(message)
    {
    }

    public StoredProcedureException([CanBeNull] string message, [CanBeNull] Exception innerException) : base(message, innerException)
    {
    }
}
