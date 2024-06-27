using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Semantica.Checks;

namespace Semantica.Storage.StoredProcedures;

/// <summary>
///     Types that inherit from this base class should contain the logic that transforms domain types into the database types of <see name="TParams"/>
/// </summary>
/// <typeparam name="TCall">The proper type of the work procedure call</typeparam>
/// <typeparam name="TParams">The type of the work procedure parameter object</typeparam>
/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public abstract class WorkProcedureCallBase<TCall, TParams> : IWorkProcedureCallInternal<TCall>
    where TCall : WorkProcedureCallBase<TCall, TParams>
    where TParams : class, IProcedureParameters, new()
{
    private IReadOnlyList<WorkResult>? _results;

    private enum CallState
    {
        Initializing = 0,
        Ready,
        Executed,
        Success,
        Failed
    }

    private CallState _callState = CallState.Initializing;

    public bool IsReady => _callState >= CallState.Ready; 
    public bool IsExecuted => _callState >= CallState.Executed;
    public bool IsSuccess => _callState == CallState.Success;

    protected abstract WorkProcedureDefinition<TParams> GetDefinition();

    /// <summary>
    /// In the implementation of this method the parameters 
    /// </summary>
    /// <returns></returns>
    protected abstract TParams GetParams();

    /// <summary>
    /// Call this method from the custom SetParameter method of the base class, or from the constructor if there are no parameters.
    /// </summary>
    protected void CheckSetParams()
    {
        Guard.State(_callState == CallState.Initializing, "Procedure parameters can only be set once.", nameof(_callState));

        _callState = CallState.Ready;
    }

    /// <summary>
    /// Override to add custom processing of results. 
    /// </summary>
    protected virtual void ProcessResults(IReadOnlyList<WorkResult> results)
    {
        _callState = results.All(result => result.Success) ? CallState.Success : CallState.Failed;
    }

    internal async Task ExecuteOnContextAsync(DbContext context, CancellationToken cancellationToken = default)
    {
        CheckExecutionPreconditions();
        _results = await context.ExecuteProcedureAsync<TParams, WorkResult>(GetDefinition(), GetParams(), cancellationToken);
        ProcessResults(_results);
    }

    internal void ExecuteOnContext(DbContext context)
    {
        CheckExecutionPreconditions();
        _results = context.ExecuteProcedure<TParams, WorkResult>(GetDefinition(), GetParams());
        ProcessResults(_results);
    }

    public IReadOnlyList<string> GetErrorMessages()
    {
        Guard.State(Check.NotNull(_results));
        return _results!.Where(result => !result.Success).Select(result => result.Message).WhereNotNull().ToReadOnlyList();
    }

    private void CheckExecutionPreconditions()
    {
        Guard.State(IsReady, "Cannot make parameter object before parameters are set.", nameof(_callState));
        Guard.State(!IsExecuted, "Cannot execute procedure call more than once.", nameof(_callState));

        _callState = CallState.Executed;
    }

    public IProcedureOfWork<TCall> CreateProcedureOfWork(DbContext context, Action<bool> onCompleted)
    {
        return new ProcedureOfWork<TCall, TParams>(context, (TCall)this, onCompleted);
    }
}
