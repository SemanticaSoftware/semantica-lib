namespace Semantica.Patterns;

/// <summary>
/// Provides additional functionality for types that implement <see cref="ICanBeEmpty"/>.
/// </summary>
[System.Diagnostics.Contracts.Pure]
public static class CanBeEmptyExtensions
{
    /// <summary>
    /// Returns the value as a <see cref="System.Nullable"/>, or the default <see cref="System.Nullable"/> of <typeparamref name="T"/> value if it is empty.
    /// </summary>
    /// <typeparam name="T">The type of value implementing <see cref="ICanBeEmpty"/>.</typeparam>
    /// <param name="value">The instance to evaluate.</param>
    /// <returns><paramref name="value"/> as a <see cref="System.Nullable"/>, or the default if <paramref name="value"/> is empty.</returns>
    public static T? CanBeEmptyToNullable<T>(this T value)
        where T : struct, ICanBeEmpty
    {
        return value.IsEmpty() ? default(T?) : value;
    }
    /// <summary>Applies a transform function to a <see cref="ICanBeEmpty"/> value, if the value is not empty.</summary>
    /// <param name="value">The value to evaluate.</param>
    /// <param name="transformFunc">The transformation function.</param>
    /// <typeparam name="T">Any type that implements <see cref="ICanBeEmpty"/>.</typeparam>
    /// <typeparam name="TOut">The output type of the transformation.</typeparam>
    /// <returns>
    /// A <see cref="Nullable{TOut}"/> with no value if the input is empty, otherwise the output of the transformation function.
    /// </returns>
    public static TOut? IfNotEmpty<T, TOut>(this T value, Func<T, TOut> transformFunc)
        where T : ICanBeEmpty
        where TOut : struct
    {
        return value.IsEmpty() ? default(TOut?) : transformFunc(value); 
    }
    
    /// <summary>Applies a transform function to a <see cref="ICanBeEmpty"/> value, if the value is not empty.</summary>
    /// <param name="value">The value to evaluate.</param>
    /// <param name="transformFunc">The transformation function.</param>
    /// <typeparam name="T">Any type that implements <see cref="ICanBeEmpty"/>.</typeparam>
    /// <typeparam name="TOut">The output type of the transformation.</typeparam>
    /// <returns>
    /// A <see cref="Nullable{TOut}"/> with no value if the input is empty, otherwise the output of the transformation function.
    /// </returns>
    public static TOut? IfNotEmpty<T, TOut>(this T value, Func<T, TOut?> transformFunc)
        where T : ICanBeEmpty
        where TOut : struct
    {
        return value.IsEmpty() ? default(TOut?) : transformFunc(value); 
    }  


    /// <summary>
    /// If <paramref name="canBeEmpty"/> is empty, returns <see langword="null"/>, otherwise returns <paramref name="val"/>.
    /// This overload is used when <typeparamref name="T"/> is a <see langword="class"/> type.
    /// </summary>
    /// <typeparam name="T">Return type and type of <paramref name="val"/>.</typeparam>
    /// <param name="canBeEmpty">The instance to evaluate <see cref="ICanBeEmpty.IsEmpty"/> on.</param>
    /// <param name="val">The value to return if <paramref name="canBeEmpty"/> is not empty.</param>
    /// <returns><see langword="null"/> if <paramref name="canBeEmpty"/> is empty; otherwise <paramref langword="null"/>.</returns>
    public static T? NullOnEmpty<T>(this ICanBeEmpty canBeEmpty, T val)
        where T : class?
    {
        return canBeEmpty.IsEmpty() ? null : val;
    }

    /// <summary>
    /// If <paramref name="canBeEmpty"/> is empty, returns <see langword="default"/>, otherwise returns <paramref name="val"/>.
    /// This overload is used when <typeparamref name="T"/> is a <see langword="struct"/> type.
    /// </summary>
    /// <typeparam name="T">Return type and type of <paramref name="val"/>.</typeparam>
    /// <param name="canBeEmpty">The instance to evaluate <see cref="ICanBeEmpty.IsEmpty"/> on.</param>
    /// <param name="val">The value to return if <paramref name="canBeEmpty"/> is not empty.</param>
    /// <returns><see langword="default"/> if <paramref name="canBeEmpty"/> is empty; otherwise <paramref langword="null"/>.</returns>
    public static T? NullOnEmpty<T>(this ICanBeEmpty canBeEmpty, T? val)
        where T : struct
    {
        return canBeEmpty.IsEmpty() ? default(T?) : val;
    }
}

/// <summary>
/// Provides additional functionality for <see cref="ICanBeEmpty"/> in electives, that cannot be part of
/// <see cref="CanBeEmptyExtensions"/> because of signature overlap.
/// </summary>
/// <remarks>
/// The compiler doesn't acknoweledge the difference between a non-nullable struct and class in Func output types, unless they
/// are on a separate class, so this weird thing has to exist. 
/// </remarks>
[System.Diagnostics.Contracts.Pure]
public static class CanBeEmptyExtensionsX
{
    /// <summary>Applies a transform function to a <see cref="ICanBeEmpty"/> value, if the value is not empty.</summary>
    /// <param name="value">The value to evaluate.</param>
    /// <param name="transformFunc">The transformation function.</param>
    /// <typeparam name="T">Any type that implements <see cref="ICanBeEmpty"/>.</typeparam>
    /// <typeparam name="TOut">The output type of the transformation.</typeparam>
    /// <returns>
    /// A <see cref="Nullable{TOut}"/> with no value if the input is empty, otherwise the output of the transformation function.
    /// </returns>
    public static TOut? IfNotEmpty<T, TOut>(this T value, Func<T, TOut> transformFunc)
        where T : ICanBeEmpty
        where TOut : class?
    {
        return value.IsEmpty() ? null : transformFunc(value); 
    }  
}
