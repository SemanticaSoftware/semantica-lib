namespace Semantica.Patterns;

/// <summary>
/// A struct or class can implement <see cref="ICanSerialize{T}"/> when it can be serialized to a string without losing any relevant information.  
/// In principal for any instance of a type implementing <see cref="ICanSerialize{T}"/> this should evaluate to <see langword="true"/>:
/// instance.<see cref="ICanSerialize{T}.Deserialize"/>(instance.<see cref="ICanSerialize.Serialize"/>()).<see cref="object.Equals(object?)"/>(instance)
/// </summary>
/// <typeparam name="T">The type deserialization returns, generally the instance type that this interface is applied to.</typeparam>
public interface ICanSerialize<out T> : ICanSerialize
    where T : IEquatable<T>, ICanSerialize<T>
#if !NET7_0_OR_GREATER
    , new()
#endif
{
    /// <summary>
    /// </summary>
    /// <param name="str">serialized <see langword="string"/> representation of an instance of <typeparamref name="T"/>.</param>
    /// <returns>A new instance of <typeparamref name="T"/>, equivalent to <paramref name="str"/>, or <see langword="default"/>(T) if deserialization failed.</returns>
#if NET7_0_OR_GREATER
    static abstract T? Deserialize(string? str);
#else
    T? Deserialize(string? str);
#endif
}
