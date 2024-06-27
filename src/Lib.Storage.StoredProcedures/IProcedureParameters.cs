using StoredProcedureEFCore;

namespace Semantica.Storage.StoredProcedures;

/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public interface IProcedureParameters
{
    IStoredProcBuilder AddParams(IStoredProcBuilder builder);
}