using Microsoft.EntityFrameworkCore;

namespace Semantica.Storage.StoredProcedures;

internal interface IWorkProcedureCallInternal<out TCall> : IWorkProcedureCall
    where TCall : IWorkProcedureCall
{
    IProcedureOfWork<TCall> CreateProcedureOfWork(DbContext context, Action<bool> onCompleted);
}