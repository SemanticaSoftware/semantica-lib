namespace Semantica.Core.Providers;

/// <summary>
/// Provides methods to get the current date and time. Contrary to the normal <see cref="IDateTimeProvider"/>, the first time
/// the current date or time is retrieved in the current scope, this value is always returned until <see cref="Reset"/> is
/// called.
/// </summary>
/// <remarks>
/// When the implementation is registered with a scoped lifetime, this can be used to ensure that all multiple calls utilize the
/// same time, even when there is some process delaying parts of the execution by a significant amount of time. 
/// </remarks>
public interface ISnapshotDateTimeProvider : IDateTimeProvider
{
    /// <summary>
    /// Resets the stored date/time value for this scope. The next call to get the date/time will set the value to the exact
    /// current date/time value at the moment of calling.
    /// </summary>
    void Reset();   
}
