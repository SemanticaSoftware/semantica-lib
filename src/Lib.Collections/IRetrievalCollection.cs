using JetBrains.Annotations;
using Semantica.Patterns;

namespace Semantica.Collections;

/// <summary>
///     Low overhead data structure to pour a collection of items in, in order to find and retrieve each item at most once.
/// </summary>
public interface IRetrievalCollection<out T>
    : IEnumerable<T>, ICanBeEmpty
{
    /// <summary>
    ///     Finds the first element that matches the predicate, returns it, and removes it from the collection
    /// </summary>
    /// <param name="predicate">Predicate to check the elements with.</param>
    /// <returns>The found item or default</returns>
    [CollectionAccess(CollectionAccessType.ModifyExistingContent)]
    T RetrieveFirstOrDefault(Func<T, bool> predicate);

    /// <summary>
    ///     Finds elements that match the predicate, and removes them from the collection as it returns them.
    ///     Elements are not removed until they are enumerated over.
    /// </summary>
    /// <param name="predicate">Predicate to check the elements with.</param>
    /// <returns>An enumerable of matching elements, or an emty enumeration if no matching elements are found.</returns>
    [CollectionAccess(CollectionAccessType.ModifyExistingContent)]
    IEnumerable<T> Retrieve(Func<T, bool> predicate);

    int Count { get; }
}
