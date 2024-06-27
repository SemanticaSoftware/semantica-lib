using System.Reflection;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for method metadata.
/// </summary>
public static class MethodInfoExtensions
{
    /// <summary>
    /// Creates a delegate of the specified type to represent the method.
    /// </summary>
    /// <typeparam name="T">The type of delegate to create.</typeparam>
    /// <param name="method">The method to represent.</param>
    /// <returns>
    /// A <typeparamref name="T"/> delegate that represents <paramref name="method"/>.
    /// </returns>
    public static T? CreateDelegate<T>(this MethodInfo method)
        where T : class
    {
        return Delegate.CreateDelegate(typeof(T), method) as T;
    }
}
