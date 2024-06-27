using Semantica.Checks;
using Semantica.Storage.EntityFramework;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public class UnitOfWorkProcedureManager : UnitOfWorkManager, IUnitOfWorkProcedureManager
{
    public UnitOfWorkProcedureManager(IDbContextProvider dbContextProvider) : base(dbContextProvider)
    {
    }

    public IProcedureOfWork<TCall> StartWorkProcedure<TCall>(TCall call)
        where TCall : IWorkProcedureCall
    {
        Guard.Contract(call is IWorkProcedureCallInternal<TCall>, nameof(TCall));
        Guard.State(WorkCompleted, "A new UnitOfWork cannot be started before the previous was completed.", nameof(WorkCompleted));

        WorkCompleted = false;
        return ((IWorkProcedureCallInternal<TCall>)call).CreateProcedureOfWork(DbContextProvider.ActiveContext, NotifyWorkComplete);
    }

}
