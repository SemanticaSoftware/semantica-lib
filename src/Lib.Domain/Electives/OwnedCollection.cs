using System.Collections;
using Semantica.Checks;
using Semantica.Extensions;

namespace Semantica.Domain.Electives;

/// <summary>
/// <para>
/// An <see cref="IElective{T}"/> collection type that can be used to wrap the type of a collection that is optionally loaded.
/// It indicates that it's aggregated onto a domain class from within that entity's aggregate.
/// </para> 
/// <para>
/// Can be implicitly cast to <typeparamref name="TCollection"/> to get it's <see cref="Payload"/>.
/// </para>
/// <para>
/// Using this instead of <see cref="Owned{TOwned}"/> can make using the property a bit more streamlined, because of enhanced
/// <see cref="IsEmpty"/> functionality and <see cref="IEnumerable{T}"/> implementation, although definition and initialisation
/// become a bit less concise.
/// </para>
/// </summary>
/// <typeparam name="TCollection"> Type of collection. </typeparam>
/// <typeparam name="TOwned"> Type of elements of the collection. </typeparam>
/// <inheritdoc cref="IElective{T}"/>
[System.Diagnostics.DebuggerNonUserCode]
public readonly struct OwnedCollection<TCollection, TOwned> : IElectiveCollection<TCollection, TOwned>
    where TCollection: IReadOnlyCollection<TOwned>
    where TOwned: class, IOwned
{
    private readonly TCollection _payload;
    private readonly LoadKind _loadKind;

    internal OwnedCollection(TCollection payload, bool isFiltered = false)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | (isFiltered ? 0 : LoadKind.Unfiltered);
    }

    internal OwnedCollection(TCollection payload, LoadKind loadKind)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | loadKind;
    }

    internal OwnedCollection(LoadKind loadKind)
    {
        _payload = default!;
        _loadKind = loadKind;
    }

    public TCollection Payload
    {
        get
        {
            Guard.For<ElectiveNotLoadedException<TCollection>>(IsLoaded());
            return _payload;
        }
    }

    public LoadKind LoadKind => _loadKind;

    public IEnumerator<TOwned> GetEnumerator() => (Payload.IsNullOrDefault() ? Enumerable.Empty<TOwned>() : Payload).GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)(Payload.IsNullOrDefault() ? Enumerable.Empty<TOwned>() : Payload)).GetEnumerator();

    public override int GetHashCode() => HashCode.Combine(LoadKind, _payload);

    public bool IsEmpty() => Payload.IsNullOrDefault() || _payload.Count == 0;

    public bool IsFiltered() => !_loadKind.HasFlag(LoadKind.Unfiltered);

    public bool IsLoaded() => _loadKind.HasFlag(LoadKind.Loaded);

    public override string? ToString() =>
        !IsLoaded() ? $"unloaded owned {typeof(TCollection).Name}"
        : IsEmpty() ? $"empty owned {typeof(TCollection).Name}"
        : _payload?.ToString();

    public static implicit operator TCollection(OwnedCollection<TCollection, TOwned> value) => value.Payload;
}

/// <summary>
/// Provides static methods to initialize <see cref="OwnedCollection{TCollection, TOwned}"/> properties.
/// </summary>
public static class OwnedCollection
{
    /// <summary>
    /// Initializes the <see cref="OwnedCollection{TCollection, TOwned}"/> without a payload.
    /// </summary>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns> An empty <see cref="OwnedCollection{TCollection, TOwned}"/>. </returns>
    public static OwnedCollection<TCollection, TOwned> Empty<TCollection, TOwned>()
        where TCollection : IReadOnlyCollection<TOwned>
        where TOwned : class, IOwned
        => new OwnedCollection<TCollection, TOwned>(LoadKind.Loaded | LoadKind.Unfiltered);

    /// <summary>
    /// <see cref="Empty{TCollection, TOwned}"/> if <paramref name="condition"/> is <see langword="false"/>; An
    /// <see cref="OwnedCollection{TCollection, TOwned}"/> with <paramref name="owned"/> otherwise.
    /// </summary>
    /// <param name="condition"> The condition to check. </param>
    /// <param name="owned"> The payload to use if the condition passed. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns>
    /// An <see cref="OwnedCollection{TCollection, TOwned}"/> with payload if <paramref name="condition"/> is
    /// <see langword="true"/>; <see cref="Empty{TCollection, TOwned}"/> otherwise.
    /// </returns>
    public static OwnedCollection<TCollection, TOwned> If<TOwner, TCollection, TOwned>(
        bool condition,
        TCollection owned,
        TOwner owner)
        where TCollection : IReadOnlyCollection<TOwned>
        where TOwned : class, IOwned<TOwner>
        => condition ? Of<TOwner, TCollection, TOwned>(owned, owner) : Empty<TCollection, TOwned>();

    /// <summary>
    /// <see cref="Empty{TCollection, TOwned}"/> if <paramref name="ownedFunc"/> is <see langword="null"/>; Otherwise
    /// <paramref name="ownedFunc"/> will be evaluated and the result is used to make an
    /// <see cref="OwnedCollection{TCollection, TOwned}"/> instance.
    /// </summary>
    /// <param name="ownedFunc"> The function that is evaluated to get the payload. </param>
    /// <param name="owner"> Owner of result of <paramref name="ownedFunc"/>. </param>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns>
    /// An <see cref="OwnedCollection{TCollection, TOwned}"/> with payload if <paramref name="ownedFunc"/> is not
    /// <see langword="null"/>; <see cref="Empty{TCollection, TOwned}"/> otherwise.
    /// </returns>
    public static OwnedCollection<TCollection, TOwned> If<TOwner, TCollection, TOwned>(
        Func<TCollection>? ownedFunc,
        TOwner owner)
        where TCollection : IReadOnlyCollection<TOwned>
        where TOwned : class, IOwned<TOwner>
        => ownedFunc == null ? Empty<TCollection, TOwned>() : Of<TOwner, TCollection, TOwned>(ownedFunc.Invoke(), owner);

    /// <summary>
    /// An <see cref="OwnedCollection{TCollection, TOwned}"/> instance with <paramref name="owned"/>.
    /// </summary>
    /// <param name="owned"> The payload to use. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <param name="isFiltered">
    /// Pass <see langword="true"/> if the collection is filtered; <see langword="false"/> if the collection contains all
    /// existing elements of <typeparamref name="TOwned"/> that are associated with the current context.
    /// </param>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns> An <see cref="OwnedCollection{TCollection, TOwned}"/> with <paramref name="owned"/> loaded. </returns>
    public static OwnedCollection<TCollection, TOwned> Of<TOwner, TCollection, TOwned>(
        TCollection owned,
        TOwner owner,
        bool isFiltered = false)
        where TCollection : IReadOnlyCollection<TOwned>
        where TOwned : class, IOwned<TOwner>
    {
        owned.ForEach(ownd => ownd.Owner = new Owner<TOwner>(owner));
        return new OwnedCollection<TCollection, TOwned>(owned, isFiltered);
    }

    /// <summary>
    /// An <see cref="OwnedCollection{TCollection, TOwned}"/> instance with <paramref name="owned"/> and a custom
    /// <see cref="LoadKind"/>. <see cref="LoadKind.Loaded"/> flag is always added.
    /// </summary>
    /// <param name="owned"> The payload to use. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <param name="loadKind"> The flags value to use. </param>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns> An <see cref="OwnedCollection{TCollection, TOwned}"/> with <paramref name="owned"/> loaded. </returns>
    public static OwnedCollection<TCollection, TOwned> Of<TOwner, TCollection, TOwned>(
        TCollection owned,
        TOwner owner,
        LoadKind loadKind)
        where TCollection : IReadOnlyCollection<TOwned>
        where TOwned : class, IOwned<TOwner>
    {
        owned.ForEach(ownd => ownd.Owner = new Owner<TOwner>(owner));
        return new OwnedCollection<TCollection, TOwned>(owned, loadKind);
    }
}
