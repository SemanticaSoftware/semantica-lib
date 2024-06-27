namespace Semantica.Core;

/// <summary> Provides predefined selector functions. </summary>
public static class StaticSelectors
{
    /// <summary> Returns the element itself. </summary>
    /// <typeparam name="T"> The type of element to select. </typeparam>
    /// <param name="t"> The source element. </param>
    /// <returns> <paramref name="t"/>. </returns>
    public static T Self<T>(T t) => t;
    
    /// <summary> Returns the value of the element itself. Throws if element has no value. </summary>
    /// <typeparam name="T"> The type of element to select. </typeparam>
    /// <param name="t"> The source element. </param>
    /// <returns> <paramref name="t"/>. </returns>
    public static T SelfNotNull<T>(T? t) where T: struct => t!.Value;
    
    /// <summary> Returns the element itself. </summary>
    /// <typeparam name="T"> The type of element to select. </typeparam>
    /// <param name="t"> The source element. </param>
    /// <returns> <paramref name="t"/>. </returns>
    public static T SelfNotNull<T>(T? t) where T: class => t!;
}
