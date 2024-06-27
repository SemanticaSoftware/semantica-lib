using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semantica.Checks;
using Semantica.Storage.EntityFramework;

namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public class ProcedureOfWork<TProcedureCall, TParams> : IProcedureOfWork<TProcedureCall>
    where TProcedureCall : WorkProcedureCallBase<TProcedureCall, TParams> 
    where TParams : class, IProcedureParameters, new()
{
    private readonly DbContext _dataContext;
    private readonly Action<bool> _onCompleted;
    private PowState _state;

    public ProcedureOfWork(DbContext dataContext, TProcedureCall procedureCall, Action<bool> onCompleted)
    {
        Guard.Contract(Check.NotNull(dataContext));
        Guard.Contract(Check.NotNull(procedureCall));
        Guard.Contract(Check.NotNull(onCompleted));
        _onCompleted = onCompleted;
        _dataContext = dataContext;
        Call = procedureCall;
    }

    public TProcedureCall Call { get; }

    public async Task CompleteAsync(CancellationToken cancellationToken = default)
    {
        Guard.State(_state == PowState.Initialized, "A Work Procedure can only be completed once.", nameof(_state));
        _state = PowState.Completing;
        try
        {
            await Call.ExecuteOnContextAsync(_dataContext, cancellationToken);
        }
        catch (Exception e)
        {
            _onCompleted.Invoke(false);
            throw new UnitOfWorkException(e);
        }
        _onCompleted.Invoke(true);
        Guard.State(_state <= PowState.Completing, "Work procedure call state has been altered while awaiting execution.", nameof(_state));
        _state = PowState.Completed;
    }

    public void Dispose()
    {
        if (_state != PowState.Disposed)
        {
            _state = PowState.Disposed;
            _onCompleted.Invoke(false);
            GC.SuppressFinalize(this);
        }
    }

    private enum PowState
    {
        Initialized = 0,
        Completing,
        Completed,
        Disposed,
    }
}
