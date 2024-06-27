namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public class WorkProcedureDefinition<TParams> : ProcedureDefinition<TParams, WorkResult>
    where TParams : class, IProcedureParameters, new()
{
    public WorkProcedureDefinition(ProcedureId id) : base(id)
    {
    }
}