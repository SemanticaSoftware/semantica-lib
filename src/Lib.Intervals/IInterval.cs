namespace Semantica.Intervals;

/// <inheritdoc cref="IReadOnlyInterval{T}"/>
public interface IInterval<T> : IReadOnlyInterval<T>, IEquatable<IReadOnlyInterval<T>>
    where T : IComparable<T>
{}
