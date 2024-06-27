namespace Semantica.Checks;

/// <summary>
/// Represents the result of a (<see langword="bool"/>) check, with an optional <see cref="Reason"/>.
/// </summary>
public interface IChk
{
    /// <summary>
    /// Indicates if the <see cref="Chk"/> has passed or failed, or if the <see cref="Reason"/> is associated with passing or
    /// failing. Always use <see cref="HasPassed"/> for control flow.
    /// </summary>
    bool Passed { get; }

    /// <summary>
    /// Not <see cref="Passed"/>. Always use <see cref="HasFailed"/> for control flow.
    /// </summary>
    bool Failed { get; }
    
    /// <summary>
    /// The <see langword="string"/> reason associated with this check's <see cref="Passed"/> or <see cref="Failed"/> value.
    /// </summary>
    string? Reason { get; }
    
    /// <summary>
    /// Has the check <see cref="Failed"/> or is it not <see cref="Chk.IsDetermined"/>. Use to check the outcome in control
    /// flow for safety.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if either <see cref="Passed"/> or <see cref="Chk.IsDetermined"/> are <see langword="false"/>.
    /// </returns>
    bool HasFailed();
    
    /// <summary>
    /// Has the check <see cref="Passed"/> and <see cref="Chk.IsDetermined"/>. Use to check the outcome in control flow for
    /// safety. 
    /// </summary>
    /// <returns>
    /// <see langword="true"/> only if <see cref="Passed"/> and <see cref="Chk.IsDetermined"/> are both <see langword="true"/>.
    /// </returns>
    bool HasPassed();
}
