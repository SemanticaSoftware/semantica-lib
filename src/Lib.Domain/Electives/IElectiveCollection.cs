namespace Semantica.Domain.Electives;

/// <summary>
/// Indicates an elective (i.e. optionally filled) collection or collection property. An elective property is by default always
/// not <see cref="IElective{T}.IsLoaded()"/>, and will throw if it's retrieved before it's loaded. 
/// </summary>
/// <typeparam name="TCollection"> Type of collection. </typeparam>
/// <typeparam name="T"> Type of the elements of the collection. </typeparam>
public interface IElectiveCollection<out TCollection, out T> : IElective<TCollection>, IEnumerable<T>
{
    /// <summary>
    /// Indicates whether the collection contains all existing values/elements, or if elements have been additionally filtered
    /// when retrieving them. 
    /// </summary>
    /// <returns> <see langword="true"/> when during loading the collection is indicated to be complete. </returns>
    bool IsFiltered();
}
