using System.Diagnostics.CodeAnalysis;
using Semantica.Checks;
using Semantica.Extensions;
using Semantica.Patterns;

namespace Semantica.Domain.Electives;

/// <summary>
/// <para>
/// An <see cref="IElective{T}"/> type that can be used to wrap the type of a property or value that is optionally loaded. On
/// entity types, this indicates that it's assembled onto a domain class from outside that entity's aggregate.
/// </para> 
/// <para>
/// Can be implicitly cast to <typeparamref name="T"/> to get it's <see cref="Payload"/>.
/// </para> 
/// </summary>
/// <inheritdoc/>
[System.Diagnostics.DebuggerNonUserCode]
public readonly struct Elective<T> : IElective<T>
{
    private readonly T _payload;
    private readonly LoadKind _loadKind;

    public Elective(T payload)
        : this(payload, 0)
    {
    }
    
    internal Elective(T payload, LoadKind loadKind)
    {
        _payload = payload;
        _loadKind = loadKind | LoadKind.Loaded;
    }
    
    internal Elective(LoadKind loadKind)
    {
        _payload = default!;
        _loadKind = loadKind;
    }

    public T Payload
   {
        get
        {
            Guard.For<ElectiveNotLoadedException<T>>(IsLoaded());
            return _payload;
        }
    }

    public LoadKind LoadKind => _loadKind;
    
    [MemberNotNullWhen(returnValue: false, nameof(Payload))]
    public bool IsEmpty() => Payload.IsNullOrDefault();
    
    public bool IsLoaded() => _loadKind.HasFlag(LoadKind.Loaded);

    public override int GetHashCode() => HashCode.Combine(LoadKind, _payload);

    public override string? ToString() =>
        !IsLoaded() ? $"unloaded {typeof(T).Name}"
        : IsEmpty() ? $"empty {typeof(T).Name}"
        : _payload?.ToString();
    
    public static implicit operator T(Elective<T> value) => value.Payload;
}

/// <summary>
/// Provides static methods to initialize <see cref="Elective{T}"/> properties.
/// </summary>
[System.Diagnostics.DebuggerNonUserCode]
public static class Elective
{
    /// <summary>
    /// Initializes the <see cref="Elective{T}"/> without a payload.
    /// </summary>
    /// <typeparam name="TPayload"> Type of the payload. </typeparam>
    /// <returns> An empty <see cref="Elective{T}"/>. </returns>
    public static Elective<TPayload> Empty<TPayload>() => new Elective<TPayload>(LoadKind.Loaded);
    
    /// <summary>
    /// <see cref="Empty{TPayload}"/> if <paramref name="condition"/> is <see langword="false"/>; An <see cref="Elective{T}"/>
    /// with <paramref name="payload"/> otherwise.
    /// </summary>
    /// <param name="condition"> The condition to check. </param>
    /// <param name="payload"> The payload to use if the condition passed. </param>
    /// <typeparam name="TPayload"> Type of the payload. </typeparam>
    /// <returns>
    /// An <see cref="Elective{T}"/> with payload if <paramref name="condition"/> is <see langword="true"/>;
    /// <see cref="Empty{TPayload}"/> otherwise.
    /// </returns>
    public static Elective<TPayload> If<TPayload>(bool condition, TPayload payload) 
        => condition ? Of(payload) : Empty<TPayload>();

    /// <summary>
    /// <see cref="Empty{TPayload}"/> if <paramref name="payloadFunc"/> is <see langword="null"/>; Otherwise
    /// <paramref name="payloadFunc"/> will be evaluated and the result is used to make an <see cref="Elective{T}"/> instance.
    /// </summary>
    /// <param name="payloadFunc"> The function that is evaluated to get the payload. </param>
    /// <typeparam name="TPayload"> Type of the payload. </typeparam>
    /// <returns>
    /// An <see cref="Elective{T}"/> with payload if <paramref name="payloadFunc"/> is not <see langword="null"/>;
    /// <see cref="Empty{TPayload}"/> otherwise.
    /// </returns>
    public static Elective<TPayload> If<TPayload>(Func<TPayload>? payloadFunc) 
        => payloadFunc == null ? Empty<TPayload>() : Of(payloadFunc.Invoke());

    /// <summary>
    /// <see cref="Empty{TPayload}"/> if <paramref name="payload"/>.<see cref="ICanBeEmpty.IsEmpty()"/> is
    /// <see langword="true"/>; An <see cref="Elective{T}"/> with <paramref name="payload"/> otherwise.
    /// </summary>
    /// <param name="payload"> The payload to use if not empty. </param>
    /// <typeparam name="TPayload"> Type of the payload. </typeparam>
    /// <returns>
    /// An <see cref="Elective{T}"/> with payload if <paramref name="payload"/>.<see cref="ICanBeEmpty.IsEmpty()"/> is
    /// <see langword="false"/>; <see cref="Empty{TPayload}"/> otherwise.
    /// </returns>
    public static Elective<TPayload> If<TPayload>(TPayload payload)
        where TPayload : ICanBeEmpty 
        => payload.IsEmpty() ? Empty<TPayload>() : Of(payload);

    /// <summary>
    /// An <see cref="Elective{T}"/> instance with <paramref name="payload"/>.
    /// </summary>
    /// <param name="payload"> The payload to use. </param>
    /// <typeparam name="TPayload"> Type of the payload. </typeparam>
    /// <returns> An <see cref="Elective{T}"/> with <paramref name="payload"/> loaded. </returns>
    public static Elective<TPayload> Of<TPayload>(TPayload payload) => new(payload);

    /// <summary>
    /// An <see cref="Elective{T}"/> instance with <paramref name="payload"/> and a custom <see cref="LoadKind"/>.
    /// <see cref="LoadKind.Loaded"/> flag is always added.
    /// </summary>
    /// <param name="payload"> The payload to use. </param>
    /// <param name="loadKind"> The flags value to use. </param>
    /// <typeparam name="TPayload"> Type of the payload. </typeparam>
    /// <returns> An <see cref="Elective{T}"/> with <paramref name="payload"/> loaded. </returns>
    public static Elective<TPayload> Of<TPayload>(TPayload payload, LoadKind loadKind) => new(payload, loadKind);
}
