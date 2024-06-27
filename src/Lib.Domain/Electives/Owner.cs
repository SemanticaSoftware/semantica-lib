using Semantica.Checks;
using Semantica.Extensions;

namespace Semantica.Domain.Electives;

/// <summary>
/// <para>
/// An <see cref="IElective{T}"/> type that can be used to wrap the type of a property or value that is optionally loaded. It
/// indicates that it's Owner onto a domain class from outside that entity's aggregate.
/// </para> 
/// <para>
/// Can be implicitly cast to <typeparamref name="T"/> to get it's <see cref="Payload"/>.
/// </para> 
/// </summary>
/// <remarks><see cref="GetHashCode"/> implementation does not use payload, DO NOT USE AS DICTIONARY KEY OR IN HASHSET</remarks>
/// <inheritdoc/>
[System.Diagnostics.DebuggerNonUserCode]
public readonly struct Owner<T> : IElective<T>
{
    private readonly T _payload;
    private readonly bool _isLoaded;

    internal Owner(T payload)
    {
        _payload = payload;
        _isLoaded = true;
    }

    public T Payload
    {
        get
        {
            Guard.For<ElectiveNotLoadedException<T>>(_isLoaded);
            return _payload;
        }
    }

    public LoadKind LoadKind => IsLoaded() ? LoadKind.Unfiltered : 0;

    /// <summary>
    /// Hashcode only calculated on loadkind to avoid recursive calls in records. 
    /// </summary>
    public override int GetHashCode() => LoadKind.GetHashCode();

    public bool IsEmpty() => Payload.IsNullOrDefault();

    public bool IsLoaded() => _isLoaded;

    public override string? ToString() =>
        !IsLoaded() ? $"unloaded owner {typeof(T).Name}"
        : IsEmpty() ? $"empty owner {typeof(T).Name}"
        : _payload?.ToString();

    public static implicit operator T(Owner<T> value) => value.Payload;
}
