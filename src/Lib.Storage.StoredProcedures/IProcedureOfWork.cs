using Semantica.Domain;

namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public interface IProcedureOfWork<out TProcedureCall> : IUnitOfWork
    where TProcedureCall: IWorkProcedureCall
{
    TProcedureCall Call { get; }
}