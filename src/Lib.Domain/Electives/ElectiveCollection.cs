using System.Collections;
using System.Diagnostics.CodeAnalysis;
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
/// Using this instead of <see cref="Elective"/> can make using the property a bit more streamlined, because of enhanced
/// <see cref="IsEmpty"/> functionality and <see cref="IEnumerable{T}"/> implementation, although definition and initialisation
/// become a bit less concise.
/// </para>
/// </summary>
/// <typeparam name="TElement"> Type of elements of the collection. </typeparam>
/// <typeparam name="TCollection"> Type of collection. </typeparam>
/// <inheritdoc cref="IElective{T}"/>
[System.Diagnostics.DebuggerNonUserCode]
public readonly struct ElectiveCollection<TCollection, TElement> : IElectiveCollection<TCollection, TElement>
    where TCollection: IReadOnlyCollection<TElement>
{
    private readonly TCollection _payload;
    private readonly LoadKind _loadKind;

    public ElectiveCollection(TCollection payload, bool isFiltered = false)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | (isFiltered ? 0 : LoadKind.Unfiltered);
    }

    internal ElectiveCollection(TCollection payload, LoadKind loadKind)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | loadKind;
    }

    internal ElectiveCollection(LoadKind loadKind)
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

    public IEnumerator<TElement> GetEnumerator() => (Payload.IsNullOrDefault() ? Enumerable.Empty<TElement>() : Payload).GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)(Payload.IsNullOrDefault() ? Enumerable.Empty<TElement>() : Payload)).GetEnumerator();

    public override int GetHashCode() => HashCode.Combine(LoadKind, _payload);

    [MemberNotNullWhen(returnValue: false, nameof(Payload))]
    public bool IsEmpty() => Payload.IsNullOrDefault() || _payload.Count == 0;

    public bool IsFiltered() => !_loadKind.HasFlag(LoadKind.Unfiltered);

    public bool IsLoaded() => _loadKind.HasFlag(LoadKind.Loaded);

    public override string? ToString() =>
        !IsLoaded() ? $"unloaded {typeof(TCollection).Name}"
        : IsEmpty() ? $"empty {typeof(TCollection).Name}"
        : _payload?.ToString();

    public static implicit operator TCollection(ElectiveCollection<TCollection, TElement> value) => value.Payload;
}

/// <summary>
/// Provides static methods to initialize <see cref="ElectiveCollection{TCollection,TElement}"/> properties.
/// </summary>
public static class ElectiveCollection
{
    /// <summary>
    /// Initializes the <see cref="ElectiveCollection{TCollection,TElement}"/> without a payload.
    /// </summary>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TElement"> Type of the elements of the collection. </typeparam>
    /// <returns> An empty <see cref="ElectiveCollection{TCollection,TElement}"/>. </returns>
    public static ElectiveCollection<TCollection, TElement> Empty<TCollection, TElement>()
        where TCollection : IReadOnlyCollection<TElement>
        => new ElectiveCollection<TCollection, TElement>(LoadKind.Loaded | LoadKind.Unfiltered);

    /// <summary>
    /// <see cref="Empty{TCollection, TElement}"/> if <paramref name="condition"/> is <see langword="false"/>; An
    /// <see cref="ElectiveCollection{TCollection,TElement}"/> with <paramref name="payload"/> otherwise.
    /// </summary>
    /// <param name="condition"> The condition to check. </param>
    /// <param name="payload"> The payload to use if the condition passed. </param>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TElement"> Type of the elements of the collection. </typeparam>
    /// <returns>
    /// An <see cref="ElectiveCollection{TCollection,TElement}"/> with payload if <paramref name="condition"/> is
    /// <see langword="true"/>; <see cref="Empty{TCollection, TElement}"/> otherwise.
    /// </returns>
    public static ElectiveCollection<TCollection, TElement> If<TCollection, TElement>(bool condition, TCollection payload)
        where TCollection : IReadOnlyCollection<TElement>
        => condition ? Of<TCollection, TElement>(payload) : Empty<TCollection, TElement>();

    /// <summary>
    /// <see cref="Empty{TCollection, TElement}"/> if <paramref name="payloadFunc"/> is <see langword="null"/>; Otherwise
    /// <paramref name="payloadFunc"/> will be evaluated and the result is used to make an
    /// <see cref="ElectiveCollection{TCollection,TElement}"/> instance.
    /// </summary>
    /// <param name="payloadFunc"> The function that is evaluated to get the payload. </param>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TElement"> Type of the elements of the collection. </typeparam>
    /// <returns>
    /// An <see cref="ElectiveCollection{TCollection,TElement}"/> with payload if <paramref name="payloadFunc"/> is not
    /// <see langword="null"/>; <see cref="Empty{TCollection, TElement}"/> otherwise.
    /// </returns>
    public static ElectiveCollection<TCollection, TElement> If<TCollection, TElement>(Func<TCollection>? payloadFunc)
        where TCollection : IReadOnlyCollection<TElement>
        => payloadFunc == null ? Empty<TCollection, TElement>() : Of<TCollection, TElement>(payloadFunc.Invoke());

    /// <summary>
    /// An <see cref="ElectiveCollection{TCollection,TElement}"/> instance with <paramref name="payload"/>.
    /// </summary>
    /// <param name="payload"> The payload to use. </param>
    /// <param name="isFiltered">
    /// Pass <see langword="true"/> if the collection is filtered; <see langword="false"/> if the collection contains all
    /// existing elements of <typeparamref name="TElement"/> that are associated with the current context.
    /// </param>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TElement"> Type of the elements of the collection. </typeparam>
    /// <returns> An <see cref="ElectiveCollection{TCollection,TElement}"/> with <paramref name="payload"/> loaded. </returns>
    public static ElectiveCollection<TCollection, TElement> Of<TCollection, TElement>(
        TCollection payload,
        bool isFiltered = false)
        where TCollection : IReadOnlyCollection<TElement>
        => new(payload, isFiltered);

    /// <summary>
    /// An <see cref="ElectiveCollection{TCollection,TElement}"/> instance with <paramref name="payload"/> and a custom
    /// <see cref="LoadKind"/>. <see cref="LoadKind.Loaded"/> flag is always added.
    /// </summary>
    /// <param name="payload"> The payload to use. </param>
    /// <param name="loadKind"> The flags value to use. </param>
    /// <typeparam name="TCollection"> Type of the collection payload. </typeparam>
    /// <typeparam name="TElement"> Type of the elements of the collection. </typeparam>
    /// <returns> An <see cref="ElectiveCollection{TCollection,TElement}"/> with <paramref name="payload"/> loaded. </returns>
    public static ElectiveCollection<TCollection, TElement> Of<TCollection, TElement>(TCollection payload, LoadKind loadKind)
        where TCollection : IReadOnlyCollection<TElement>
        => new(payload, loadKind);
}
