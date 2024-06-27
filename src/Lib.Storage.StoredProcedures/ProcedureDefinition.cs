using Semantica.Checks;
using Semantica.Storage.DataStores;

namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public class ProcedureDefinition<TParams, TOut> : IProcedure<TParams, TOut>
    where TParams: class
    where TOut: class
{
    public ProcedureDefinition(ProcedureId id)
    {
        Check.NotEmpty(id).Contract();
        Id = id;
    }

    public ProcedureId Id { get; }

    public string Name => Id.ToString();
}