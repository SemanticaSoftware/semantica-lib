using Semantica.Patterns;

namespace Semantica.Domain.Electives;

/// <summary>
/// <para>
/// Indicates an elective (i.e. optionally assigned) value or property. An elective property is by default never
/// <see cref="IsLoaded"/>, and will throw if it's retrieved before it's loaded.
/// </para>
/// <para>
/// Loading in this sense means assigning a value to the property of the entity or value object model that the value belongs to. 
/// </para>
/// </summary>
/// <remarks>
/// <para>
/// When <see cref="Payload"/> is retrieved (or <see cref="ICanBeEmpty.IsEmpty"/> is called) before the elective is loaded, a
/// <see cref="ElectiveNotLoadedException{T}"/> will be thrown.
/// </para>
/// <para>
/// It can be used to be able to differentiate at runtime between a property/value not yet being initialized, and it
/// purposefully set to the default/null value. This will automatically guard for assembly mistakes. It can also be used to
/// signal to enable or skip further processing.
/// </para>
/// </remarks>
/// <typeparam name="T"> The type of the load. </typeparam>
public interface IElective<out T> : ICanBeEmpty
{
    /// <summary> Retrieves the payload. </summary>
    /// <exception cref="ElectiveNotLoadedException{T}"> Throws if not yet loaded. </exception>
    T? Payload { get; }
    
    /// <summary>
    /// Indicates if the value has been loaded. i.e. Has the property been assigned on the owning model instance. Regardless of
    /// whether the payload value was default or not.
    /// </summary>
    bool IsLoaded();
    
    /// <summary>
    /// Contains the <see cref="LoadKind"/> of the assemblage. This property is public so that the unused six bits could be
    /// used to contain extra loading information.
    /// </summary>
    LoadKind LoadKind { get; }
}
