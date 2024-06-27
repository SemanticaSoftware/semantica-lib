using System.Diagnostics.CodeAnalysis;

namespace Semantica.Extensions;

/// <summary>
/// Provides additional functionality for classes/structs.
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Returns the value typed as <see cref="Nullable{T}"/> if not default. If the value is default, the nullable returned has
    /// no value ("<see langword="null"/>"). 
    /// </summary>
    /// <param name="value"> The value to convert.</param>
    /// <typeparam name="T"> A value type. </typeparam>
    /// <returns>
    /// <paramref name="value"/>, or <see langword="null"/> if <paramref name="value"/> equals
    /// <see langword="default"/>(<typeparamref name="T"/>).
    /// </returns>
    public static T? AsNullable<T>(this T value)
        where T : struct
    {
        return value.IsDefault() ? default(T?) : value;
    }
    
    public static TOut? IfNotDefault<T, TOut>(this T value, Func<T, TOut> transformFunc)
        where T : struct
        where TOut : struct
    {
        return value.IsDefault() ? default(TOut?) : transformFunc(value); 
    }
    
    public static TOut? IfNotNull<T, TOut>(this T? value, Func<T, TOut> transformFunc)
        where T : class
        where TOut : class?
    {
        return value == null ? null : transformFunc(value);
    }

    public static TOut? IfNotNull<T, TOut>(this T? value, Func<T, TOut> transformFunc)
        where T : struct
        where TOut : struct
    {
        return value.HasValue ? transformFunc(value.Value) : default(TOut?);
    }

    public static TOut? IfNotNull<T, TOut>(this T? value, Func<T, TOut?> transformFunc)
        where T : struct
        where TOut : struct
    {
        return value.HasValue ? transformFunc(value.Value) : default(TOut?);
    }

    /// <summary>
    /// Uses de default <see cref="EqualityComparer{T}"/> to check if the struct is equal to it's default. This method should
    /// avoid boxing, so is more efficient than using <see cref="Object"/>.<see cref="object.Equals(object?)"/>.
    /// </summary>
    /// <param name="value"> <see langword="struct"/> value to check. </param>
    /// <typeparam name="T"> A value type. </typeparam>
    /// <returns>
    /// <see langword="true"/> if the <paramref name="value"/> equals <see langword="default"/>(<typeparamref name="T"/>);
    /// <see langword="false"/> otherwise.
    /// </returns>
    public static bool IsDefault<T>(this T value)
        where T : struct
    {
        return EqualityComparer<T>.Default.Equals(value, default(T));
    }

    /// <summary>
    /// Uses de default <see cref="EqualityComparer{T}"/> to check if the struct is not equal to it's default. This method
    /// should avoid boxing, so is more efficient than using <see cref="Object"/>.<see cref="object.Equals(object?)"/>.
    /// </summary>
    /// <param name="value"> <see langword="struct"/> value to check. </param>
    /// <typeparam name="T"> A value type. </typeparam>
    /// <returns>
    /// <see langword="true"/> if <paramref name="value"/> does not equal to
    /// <see langword="default"/>(<typeparamref name="T"/>); <see langword="false"/> otherwise.
    /// </returns>
    public static bool IsNotDefault<T>(this T value)
        where T : struct
    {
        return !value.IsDefault();
    }
    
    /// <summary>
    /// Uses de default <see cref="EqualityComparer{T}"/> to check if the value is equal to it's default or null.
    /// </summary>
    /// <param name="value"> The value to check. </param>
    /// <typeparam name="T"> Type of the value to check for null or default. </typeparam>
    /// <returns>
    /// <see langword="true"/> if the <paramref name="value"/> equals <see langword="default"/>(<typeparamref name="T"/>) if
    /// <typeparamref name="T"/> is a value type, or <see langword="null"/> if it's a reference type; <see langword="false"/>
    /// otherwise.
    /// </returns>
    public static bool IsNullOrDefault<T>([NotNullWhen(false)] this T value)
    {
        return EqualityComparer<T>.Default.Equals(value, default(T));
    }

    /// <summary>
    /// Outputs the (non nullable) value of a nullable type instance, and returns whether that value existed or not.
    /// </summary>
    /// <param name="nullableValue"> A nullable value to check. </param>
    /// <param name="value"> Out parameter that will contain the input as non-nullable. </param>
    /// <typeparam name="T"> Value type. </typeparam>
    /// <returns>
    /// <see langword="true"/> if the <paramref name="nullableValue"/> has a value ; <see langword="false"/> otherwise.
    /// </returns>
    public static bool TryValue<T>([NotNullWhen(true)] this T? nullableValue, out T value)
        where T : struct
    {
        value = nullableValue.GetValueOrDefault();
        return nullableValue.HasValue;
    }
}

/// <summary>
/// Provides additional functionality for classes/structs, that cannot be part of <see cref="Extensions"/> because of signature
/// overlap.
/// </summary>
/// <remarks>
/// The compiler doesn't acknoweledge the difference between a non-nullable struct and class in Func output types, unless they
/// are on a separate class, so this weird thing has to exist. 
/// </remarks>
public static class ExtensionsX
{
    
    public static TOut? IfNotNull<T, TOut>(this T? value, Func<T, TOut> transformFunc)
        where T : class
        where TOut : struct
    {
        return value == null ? default(TOut?) : transformFunc(value);
    }
    
    public static TOut? IfNotNull<T, TOut>(this T? value, Func<T, TOut?> transformFunc)
        where T : class
        where TOut : struct
    {
        return value == null ? default(TOut?) : transformFunc(value);
    }

    public static TOut? IfNotNull<T, TOut>(this T? value, Func<T, TOut> transformFunc)
        where T : struct
        where TOut : class?
    {
        return value.HasValue ? transformFunc(value.Value) : null; 
    }    
}
