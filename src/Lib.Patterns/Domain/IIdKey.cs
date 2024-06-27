namespace Semantica.Patterns.Domain;

public interface IIdKey<out T>
    where T : struct, IEquatable<T>
{
    T Id { get; }
}