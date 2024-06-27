using System.Collections;
using Semantica.Checks;

namespace Semantica.Domain.Electives;

/// <summary>
/// <para>
/// An <see cref="IElective{T}"/> collection type that can be used to wrap a <see cref="IReadOnlyList{T}"/> that is optionally
/// loaded. It indicates that it's aggregated onto a domain class from within that entity's aggregate.
/// </para> 
/// <para>
/// Implements <see cref="IReadOnlyList{T}"/>, delegating all members to the payload.  
/// </para> 
/// </summary>
/// <typeparam name="TOwned"> Type of elements of the <see cref="IReadOnlyList{T}"/>. </typeparam>
/// <inheritdoc cref="IElective{T}"/>
[System.Diagnostics.DebuggerNonUserCode]
public readonly struct OwnedList<TOwned> : IElectiveCollection<IReadOnlyList<TOwned>, TOwned>, IReadOnlyList<TOwned>
    where TOwned: class, IOwned
{
    private readonly IReadOnlyList<TOwned> _payload;
    private readonly LoadKind _loadKind;

    internal OwnedList(IReadOnlyList<TOwned> payload, bool isFiltered = false)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | (isFiltered ? 0 : LoadKind.Unfiltered);
    }

    internal OwnedList(IReadOnlyList<TOwned> payload, LoadKind loadKind)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | loadKind;
    }

    internal OwnedList(LoadKind loadKind)
    {
        _payload = ArraySegment<TOwned>.Empty;
        _loadKind = loadKind;
    }

    public int Count => Payload.Count;

    public IReadOnlyList<TOwned> Payload
    {
        get
        {
            Guard.For<ElectiveNotLoadedException<IReadOnlyList<TOwned>>>(IsLoaded());
            return _payload;
        }
    }

    public LoadKind LoadKind => _loadKind;

    public TOwned this[int index] => Payload[index];

    public IEnumerator<TOwned> GetEnumerator() => Payload.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Payload).GetEnumerator();

    public override int GetHashCode() => HashCode.Combine(LoadKind, _payload);

    public bool IsEmpty() => _payload.Count == 0;

    public bool IsFiltered() => !_loadKind.HasFlag(LoadKind.Unfiltered);

    public bool IsLoaded() => _loadKind.HasFlag(LoadKind.Loaded);

    public override string? ToString() =>
        !IsLoaded() ? $"unloaded owned list of {typeof(TOwned).Name}"
        : IsEmpty() ? $"empty owned list of {typeof(TOwned).Name}"
        : _payload?.ToString();
}

/// <summary>
/// Provides static methods to initialize <see cref="OwnedCollection{TCollection, TOwned}"/> properties.
/// </summary>
public static class OwnedList
{
    /// <summary>
    /// Initializes the <see cref="OwnedCollection{TCollection, TOwned}"/> without a payload.
    /// </summary>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns> An empty <see cref="OwnedCollection{TCollection, TOwned}"/>. </returns>
    public static OwnedList<TOwned> Empty<TOwned>()
        where TOwned: class, IOwned
        => new OwnedList<TOwned>(LoadKind.Loaded | LoadKind.Unfiltered);
         
    /// <summary>
    /// <see cref="Empty{TOwned}"/> if <paramref name="condition"/> is <see langword="false"/>; An
    /// <see cref="OwnedCollection{TCollection, TOwned}"/> with <paramref name="owned"/> otherwise.
    /// </summary>
    /// <param name="condition"> The condition to check. </param>
    /// <param name="owned"> The payload to use if the condition passed. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns>
    /// An <see cref="OwnedCollection{TCollection, TOwned}"/> with payload if <paramref name="condition"/> is
    /// <see langword="true"/>; <see cref="Empty{TOwned}"/> otherwise.
    /// </returns>
    public static OwnedList<TOwned> If<TOwner, TOwned>(bool condition, IReadOnlyList<TOwned> owned, TOwner owner) 
        where TOwned: class, IOwned<TOwner>
        => condition ? Of<TOwner, TOwned>(owned, owner) : Empty<TOwned>();

    /// <summary>
    /// <see cref="Empty{TOwned}"/> if <paramref name="ownedFunc"/> is <see langword="null"/>; Otherwise
    /// <paramref name="ownedFunc"/> will be evaluated and the result is used to make an
    /// <see cref="OwnedCollection{TCollection, TOwned}"/> instance.
    /// </summary>
    /// <param name="ownedFunc"> The function that is evaluated to get the payload. </param>
    /// <param name="owner"> Owner of result of <paramref name="ownedFunc"/>. </param>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns>
    /// An <see cref="OwnedCollection{TCollection, TOwned}"/> with payload if <paramref name="ownedFunc"/> is not
    /// <see langword="null"/>; <see cref="Empty{TOwned}"/> otherwise.
    /// </returns>
    public static OwnedList<TOwned> If<TOwner, TOwned>(Func<IReadOnlyList<TOwned>>? ownedFunc, TOwner owner) 
        where TOwned: class, IOwned<TOwner>
        => ownedFunc == null ? Empty<TOwned>() : Of<TOwner, TOwned>(ownedFunc.Invoke(), owner);

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
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns> An <see cref="OwnedCollection{TCollection, TOwned}"/> with <paramref name="owned"/> loaded. </returns>
    public static OwnedList<TOwned> Of<TOwner, TOwned>(IReadOnlyList<TOwned> owned, TOwner owner, bool isFiltered = false)
        where TOwned: class, IOwned<TOwner>
    {
        owned.ForEach(ownd => ownd.Owner = new Owner<TOwner>(owner));
        return new OwnedList<TOwned>(owned, isFiltered);
    }

    /// <summary>
    /// An <see cref="OwnedCollection{TCollection, TOwned}"/> instance with <paramref name="owned"/> and a custom
    /// <see cref="LoadKind"/>. <see cref="LoadKind.Loaded"/> flag is always added.
    /// </summary>
    /// <param name="owned"> The payload to use. </param>
    /// <param name="owner"> Owner of <paramref name="owned"/>. </param>
    /// <param name="loadKind"> The flags value to use. </param>
    /// <typeparam name="TOwner"> Type of the owner. </typeparam>
    /// <typeparam name="TOwned"> Type of the elements of the collection. </typeparam>
    /// <returns> An <see cref="OwnedCollection{TCollection, TOwned}"/> with <paramref name="owned"/> loaded. </returns>
    public static OwnedList<TOwned> Of<TOwner, TOwned>(IReadOnlyList<TOwned> owned, TOwner owner, LoadKind loadKind)
        where TOwned: class, IOwned<TOwner>
    {
        owned.ForEach(ownd => ownd.Owner = new Owner<TOwner>(owner));
        return new OwnedList<TOwned>(owned, loadKind);
    }
}
