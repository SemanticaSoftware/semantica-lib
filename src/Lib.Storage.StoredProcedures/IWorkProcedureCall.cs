namespace Semantica.Storage.StoredProcedures;

/// <summary>
/// Interfaces that inherit from this Interface should add some kind of SetParameters method that set all required procedure parameters in domain types
/// </summary>
/// <remarks>
/// This assembly is a Work In Progress. Neither interfaces nor implementations should be considered stable in 6.4.0.
/// </remarks>
public interface IWorkProcedureCall
{
    bool IsReady { get; }
    bool IsExecuted { get; }
    bool IsSuccess { get; }
    IReadOnlyList<string> GetErrorMessages();
}