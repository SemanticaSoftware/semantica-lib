namespace Semantica.Patterns.Domain;

public interface ISimpleKey<out TSelf, T> : IIdKey<T>, ICanBeEmpty
    where TSelf : struct
    where T : struct, IEquatable<T>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <example>
    /// In most cases, the following implementation should suffice:
    /// <code>=> IsEmpty() ? default(T?) : Id</code>
    /// </example>
    T? AsNullableId();

#if NET7_0_OR_GREATER 
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"> Nullable id parameter (typically the mapped database type for any optional foreign key. </param>
    /// <returns></returns>
    /// <example>
    /// In most cases, the following implementation should suffice:
    /// <code>=> id.HasValue ? new(id.Value) : default</code>
    /// </example>
    static abstract TSelf FromNullableId(T? id) ;
#endif
}
