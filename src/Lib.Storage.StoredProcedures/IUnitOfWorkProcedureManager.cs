using Semantica.Domain;

namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public interface IUnitOfWorkProcedureManager : IUnitOfWorkManager
{
    IProcedureOfWork<TCall> StartWorkProcedure<TCall>(TCall call)
        where TCall: IWorkProcedureCall;
}
