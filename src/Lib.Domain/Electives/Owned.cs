using Semantica.Checks;
using Semantica.Extensions;
using Semantica.Patterns;

namespace Semantica.Domain.Electives;

/// <summary>
/// <para>
/// An <see cref="IElective{T}"/> type that can be used to wrap a reference to another domain entity that is optionally loaded.
/// It represents a  It indicates that it's aggregated onto a domain class from within that entity's aggregate.
/// </para> 
/// <para>
/// Can be implicitly cast to <typeparamref name="TOwned"/> to get it's <see cref="Payload"/>.
/// </para> 
/// </summary>
/// <typeparam name="TOwned"></typeparam>
/// <inheritdoc/>
[System.Diagnostics.DebuggerNonUserCode]
public readonly struct Owned<TOwned> : IElective<TOwned>
    where TOwned: class?, IOwned
{
    private readonly TOwned? _payload;
    private readonly LoadKind _loadKind;

    internal Owned(TOwned? payload, LoadKind loadKind = 0)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | loadKind;
    }

    internal Owned(LoadKind loadKind)
    {
        _payload = default!;
        _loadKind = loadKind;
    }

    public TOwned? Payload
    {
        get
        {
            Guard.For<ElectiveNotLoadedException<TOwned>>(IsLoaded());
            return _payload;
        }
    }

    public LoadKind LoadKind => _loadKind;

    public bool IsEmpty() => Payload.IsNullOrDefault();

    public bool IsLoaded() => _loadKind.HasFlag(LoadKind.Loaded);

    public override int GetHashCode() => HashCode.Combine(LoadKind, _payload);

    public override string? ToString() =>
        !IsLoaded() ? $"unloaded owned {typeof(TOwned).Name}"
        : IsEmpty() ? $"empty owned {typeof(TOwned).Name}"
        : _payload?.ToString();

    public static implicit operator TOwned?(Owned<TOwned> value) => value.Payload;
}

/// <summary>
/// Provides static methods to initialize <see cref="Owned{T}"/> properties.
/// </summary>
public static class Owned
{
    /// <summary>
    /// Initializes the <see cref="Owned{T}"/> without a payload.
    /// </summary>
    /// <typeparam name="TOwned"> Type of the payload. </typeparam>
    /// <returns> An empty <see cref="Owned{T}"/>. </returns>
    public static Owned<TOwned> Empty<TOwned>()
        where TOwned : class?, IOwned 
        => new Owned<TOwned>(LoadKind.Loaded);
        
    /// <summary>
    /// <see cref="Empty{TOwned}"/> if <paramref name="condition"/> is <see langword="false"/>; An <see cref="Owned{T}"/>
    /// with <paramref name="owned"/> otherwise. <see cref="IOwned{T}.Owner"/> property on <paramref name="owned"/>
    /// will be set.
    /// </summary>
    /// <param name="condition"> The condition to check. </param>
    /// <param name="owned"> The payload to use if the condition passed. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <typeparam name="TOwned"> Type of the payload. </typeparam>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <returns>
    /// An <see cref="Owned{T}"/> with payload if <paramref name="condition"/> is <see langword="true"/>;
    /// <see cref="Empty{TOwned}"/> otherwise.
    /// </returns>
    public static Owned<TOwned> If<TOwner, TOwned>(bool condition, TOwned? owned, TOwner owner) 
        where TOwned : class?, IOwned<TOwner> 
        => condition ? Of(owned, owner) : Empty<TOwned>();

    /// <summary>
    /// <see cref="Empty{TOwned}"/> if <paramref name="ownedFunc"/> is <see langword="null"/>; Otherwise
    /// <paramref name="ownedFunc"/> will be evaluated and the result is used to make an <see cref="Owned{T}"/> instance.
    /// <see cref="IOwned{T}.Owner"/> property on the owned instance will be set.
    /// </summary>
    /// <param name="ownedFunc"> The function that is evaluated to get the payload. </param>
    /// <param name="owner"> Owner of owned result instance. </param>
    /// <typeparam name="TOwned"> Type of the payload. </typeparam>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <returns>
    /// An <see cref="Owned{T}"/> with payload if <paramref name="ownedFunc"/> is not <see langword="null"/>;
    /// <see cref="Empty{TOwned}"/> otherwise.
    /// </returns>
    public static Owned<TOwned> If<TOwner, TOwned>(Func<TOwned?>? ownedFunc, TOwner owner) 
        where TOwned : class?, IOwned<TOwner> 
        => ownedFunc == null ? Empty<TOwned>() : Of(ownedFunc.Invoke(), owner);

    /// <summary>
    /// <see cref="Empty{TOwned}"/> if <paramref name="owned"/>.<see cref="ICanBeEmpty.IsEmpty()"/> is
    /// <see langword="true"/>; An <see cref="Owned{T}"/> with <paramref name="owned"/> otherwise. <see cref="IOwned{T}.Owner"/>
    /// property on <paramref name="owned"/> will be set.
    /// </summary>
    /// <param name="owned"> The payload to use if not empty. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <typeparam name="TOwned"> Type of the payload. </typeparam>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <returns>
    /// An <see cref="Owned{T}"/> with payload if <paramref name="owned"/>.<see cref="ICanBeEmpty.IsEmpty()"/> is
    /// <see langword="false"/>; <see cref="Empty{TOwned}"/> otherwise.
    /// </returns>
    public static Owned<TOwned> If<TOwner, TOwned>(TOwned? owned, TOwner owner)
        where TOwned : class?, IOwned<TOwner>, ICanBeEmpty 
        => owned?.IsEmpty() ?? false ? Empty<TOwned>() : Of(owned, owner);

    /// <summary>
    /// An <see cref="Owned{T}"/> instance with <paramref name="owned"/>. <see cref="IOwned{T}.Owner"/> property on
    /// <paramref name="owned"/> will be set.
    /// </summary>
    /// <param name="owned"> The payload to use. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <typeparam name="TOwned"> Type of the payload. </typeparam>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <returns> An <see cref="Owned{T}"/> with <paramref name="owned"/> loaded. </returns>
    public static Owned<TOwned> Of<TOwner, TOwned>(TOwned? owned, TOwner owner) 
        where TOwned : class, IOwned<TOwner>
    {
        return Of(owned, owner, default);
    }

    /// <summary>
    /// An <see cref="Owned{T}"/> instance with <paramref name="owned"/> and a custom <see cref="LoadKind"/>.
    /// <see cref="LoadKind.Loaded"/> flag is always added. <see cref="IOwned{T}.Owner"/> property on <paramref name="owned"/>
    /// will be set.
    /// </summary>
    /// <param name="owned"> The payload to use. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <param name="loadKind"> The flags value to use. </param>
    /// <typeparam name="TOwned"> Type of the payload. </typeparam>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <returns> An <see cref="Owned{T}"/> with <paramref name="owned"/> loaded. </returns>
    /// <returns></returns>
    public static Owned<TOwned> Of<TOwner, TOwned>(TOwned? owned, TOwner owner, LoadKind loadKind) 
        where TOwned : class?, IOwned<TOwner>
    {
        if (owned != null)
        {
            owned.Owner = new Owner<TOwner>(owner);
        }
        return new Owned<TOwned>(owned, loadKind);
    }
}
