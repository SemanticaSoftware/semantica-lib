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
/// <typeparam name="TElement"> Type of elements of the <see cref="IReadOnlyList{T}"/>. </typeparam>
/// <inheritdoc cref="IElective{T}"/>
[System.Diagnostics.DebuggerNonUserCode]
public readonly struct ElectiveList<TElement> : IElectiveCollection<IReadOnlyList<TElement>, TElement>, IReadOnlyList<TElement>
{
    private readonly IReadOnlyList<TElement> _payload;
    private readonly LoadKind _loadKind;

    public ElectiveList(IReadOnlyList<TElement> payload, bool isFiltered = false)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | (isFiltered ? 0 : LoadKind.Unfiltered);
    }

    internal ElectiveList(IReadOnlyList<TElement> payload, LoadKind loadKind)
    {
        _payload = payload;
        _loadKind = LoadKind.Loaded | loadKind;
    }

    internal ElectiveList(LoadKind loadKind)
    {
        _payload = ArraySegment<TElement>.Empty;
        _loadKind = loadKind;
    }

    public int Count => Payload.Count;

    public IReadOnlyList<TElement> Payload
    {
        get
        {
            Guard.For<ElectiveNotLoadedException<IReadOnlyList<TElement>>>(IsLoaded());
            return _payload;
        }
    }

    public LoadKind LoadKind => _loadKind;

    public TElement this[int index] => Payload[index];

    public IEnumerator<TElement> GetEnumerator() => Payload.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Payload).GetEnumerator();

    public override int GetHashCode() => HashCode.Combine(LoadKind, _payload);

    public bool IsEmpty() => _payload.Count == 0;

    public bool IsFiltered() => !_loadKind.HasFlag(LoadKind.Unfiltered);

    public bool IsLoaded() => _loadKind.HasFlag(LoadKind.Loaded);

    public override string? ToString() =>
        !IsLoaded() ? $"unloaded list of {typeof(TElement).Name}"
        : IsEmpty() ? $"empty list of {typeof(TElement).Name}"
        : _payload?.ToString();
}

/// <summary>
/// Provides static methods to initialize <see cref="ElectiveList{TElement}"/> properties.
/// </summary>
public static class ElectiveList
{
    /// <summary>
    /// Initializes the <see cref="ElectiveList{TElement}"/> without a payload.
    /// </summary>
    /// <typeparam name="TElement"> Type of the elements of the payload. </typeparam>
    /// <returns> An empty <see cref="ElectiveList{TElement}"/>. </returns>
    public static ElectiveList<TElement> Empty<TElement>()
        => new ElectiveList<TElement>(LoadKind.Loaded | LoadKind.Unfiltered);
    
    /// <summary>
    /// <see cref="Empty{TPayload}"/> if <paramref name="condition"/> is <see langword="false"/>; An
    /// <see cref="ElectiveList{TElement}"/> with <paramref name="payload"/> otherwise.
    /// </summary>
    /// <param name="condition"> The condition to check. </param>
    /// <param name="payload"> The payload to use if the condition passed. </param>
    /// <typeparam name="TElement"> Type of the elements of the payload. </typeparam>
    /// <returns>
    /// An <see cref="ElectiveList{TElement}"/> with payload if <paramref name="condition"/> is <see langword="true"/>;
    /// <see cref="Empty{TPayload}"/> otherwise.
    /// </returns>
    public static ElectiveList<TElement> If<TElement>(bool condition, IReadOnlyList<TElement> payload) 
        => condition ? Of<TElement>(payload) : Empty<TElement>();

    /// <summary>
    /// <see cref="Empty{TPayload}"/> if <paramref name="payloadFunc"/> is <see langword="null"/>; Otherwise
    /// <paramref name="payloadFunc"/> will be evaluated and the result is used to make an <see cref="ElectiveList{TElement}"/>
    /// instance.
    /// </summary>
    /// <param name="payloadFunc"> The function that is evaluated to get the payload. </param>
    /// <typeparam name="TElement"> Type of the elements of the payload. </typeparam>
    /// <returns>
    /// An <see cref="ElectiveList{TElement}"/> with payload if <paramref name="payloadFunc"/> is not <see langword="null"/>;
    /// <see cref="Empty{TPayload}"/> otherwise.
    /// </returns>
    public static ElectiveList<TElement> If<TElement>(Func<IReadOnlyList<TElement>>? payloadFunc) 
        => payloadFunc == null ? Empty<TElement>() : Of<TElement>(payloadFunc.Invoke());

    /// <summary>
    /// An <see cref="ElectiveList{TElement}"/> instance with <paramref name="payload"/>.
    /// </summary>
    /// <param name="payload"> The payload to use. </param>
    /// <param name="isFiltered">
    /// Pass <see langword="true"/> if the collection is filtered; <see langword="false"/> if the collection contains all
    /// existing elements of <typeparamref name="TElement"/> that are associated with the current context.
    /// </param>
    /// <typeparam name="TElement"> Type of the elements of the payload. </typeparam>
    /// <returns> An <see cref="ElectiveList{TElement}"/> with <paramref name="payload"/> loaded. </returns>
    public static ElectiveList<TElement> Of<TElement>(IReadOnlyList<TElement> payload, bool isFiltered = false)
        => new(payload, isFiltered);

    /// <summary>
    /// An <see cref="ElectiveList{TElement}"/> instance with <paramref name="payload"/> and a custom <see cref="LoadKind"/>.
    /// <see cref="LoadKind.Loaded"/> flag is always added.
    /// </summary>
    /// <param name="payload"> The payload to use. </param>
    /// <param name="loadKind"> The flags value to use. </param>
    /// <typeparam name="TElement"> Type of the elements of the payload. </typeparam>
    /// <returns> An <see cref="ElectiveList{TElement}"/> with <paramref name="payload"/> loaded. </returns>
    public static ElectiveList<TElement> Of<TElement>(IReadOnlyList<TElement> payload, LoadKind loadKind)
        => new(payload, loadKind);
}
