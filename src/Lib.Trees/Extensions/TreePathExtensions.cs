namespace Semantica.Trees.Extensions;

/// <summary>
/// Provides additional functionality to <see cref="IReadOnlyTreePath{T}"/>.
/// </summary>
public static class TreePathExtensions
{
    /// <summary>
    /// Enumerates the nodes of the treepath in reverse order, so starting at the ultimate node, and ending at the root node.
    /// </summary>
    /// <param name="treePath">The <see cref="IReadOnlyTreePath{T}"/> to enumerate.</param>
    /// <typeparam name="T">Type of the payloads of the nodes.</typeparam>
    /// <returns>An <see cref="IEnumerable{TNode}"/> of <see cref="ITreePathNode{T}"/>.</returns>
    public static IEnumerable<ITreePathNode<T>> EnumerateNodesFromUltimate<T>(this IReadOnlyTreePath<T> treePath)
    {
        for (var index = treePath.Count - 1; index >= 0; --index)
        {
            yield return treePath.Nodes[index];
        }
    }

    /// <summary>
    /// Finds the first value that is not <see langword="default(TValue)"/> in <paramref name="treePath"/>, using <paramref name="selector"/> to get the values. 
    /// </summary>
    /// <remarks>
    /// Nodes are enumerated in regular order, starting with <see cref="IReadOnlyTreePath{T}.RootNode"/>, ending with <see cref="IReadOnlyTreePath{T}.UltimateNode"/>.
    /// If not found, <see langword="default(TValue)"/> is returned instead.
    /// </remarks>
    /// <param name="treePath">The <see cref="IReadOnlyTreePath{T}"/> to search.</param>
    /// <param name="selector">Function that gets the value from the payload.</param>
    /// <typeparam name="T">Type of the node payloads.</typeparam>
    /// <typeparam name="TValue">Type of value to select.</typeparam>
    /// <returns>First value found not equal to <see langword="default(TValue)"/> in <paramref name="treePath"/>.</returns>
    public static TValue FirstNotDefaultValue<T, TValue>(this IReadOnlyTreePath<T> treePath, Func<T, TValue> selector)
        where TValue: struct
    {
        return treePath.Select(selector)
                       .WhereNotDefault()
                       .FirstOrDefault();
    }
    
    /// <summary>
    /// Finds the first value that is not <see langword="default(TValue)"/> in <paramref name="treePath"/>, using <paramref name="selector"/> to get the values,
    /// starting at the <see cref="IReadOnlyTreePath{T}.UltimateNode"/>. 
    /// </summary>
    /// <remarks>
    /// Nodes are enumerated in reverse order, starting with <see cref="IReadOnlyTreePath{T}.UltimateNode"/>, ending with <see cref="IReadOnlyTreePath{T}.RootNode"/>.
    /// If not found, <see langword="default(TValue)"/> is returned instead.
    /// </remarks>
    /// <param name="treePath">The <see cref="IReadOnlyTreePath{T}"/> to search.</param>
    /// <param name="selector">Function that gets the value from the payload.</param>
    /// <typeparam name="T">Type of the node payloads.</typeparam>
    /// <typeparam name="TValue">Type of value to select.</typeparam>
    /// <returns>First value found not equal to <see langword="default(TValue)"/> in <paramref name="treePath"/>.</returns>
    public static TValue FirstNotDefaultValueFromUltimate<T, TValue>(this IReadOnlyTreePath<T> treePath, Func<T, TValue> selector)
        where TValue: struct
    {
        return treePath.EnumerateNodesFromUltimate()
                       .Payloads()
                       .Select(selector)
                       .WhereNotDefault()
                       .FirstOrDefault();
    }

    /// <summary>
    /// Finds the first node to satisfy the <paramref name="predicate"/>, starting at the <see cref="IReadOnlyTreePath{T}.UltimateNode"/>.
    /// </summary>
    /// <remarks>
    /// Nodes are enumerated in reverse order, starting with <see cref="IReadOnlyTreePath{T}.UltimateNode"/>, ending with <see cref="IReadOnlyTreePath{T}.RootNode"/>.
    /// If not found, <see langword="default(TValue)"/> is returned instead.
    /// </remarks>
    /// <param name="treePath">The <see cref="IReadOnlyTreePath{T}"/> to search.</param>
    /// <param name="predicate">Function used to evaluate each payload</param>
    /// <typeparam name="T">Type of the node payloads.</typeparam>
    /// <returns>First node to satisfy the <paramref name="predicate"/>, or <see langword="default(TValue)"/></returns>
    public static ITreePathNode<T> FirstOrDefaultFromUltimate<T>(this IReadOnlyTreePath<T> treePath, Func<T, bool> predicate)
    {
        return treePath.EnumerateNodesFromUltimate()
                       .FirstOrDefault(node => predicate(node.Payload));
    }

    /// <summary>
    /// Finds the first node to satisfy the <paramref name="predicate"/>, starting at the <see cref="IReadOnlyTreePath{T}.UltimateNode"/>.
    /// </summary>
    /// <remarks>
    /// Nodes are enumerated in reverse order, starting with <see cref="IReadOnlyTreePath{T}.UltimateNode"/>, ending with <see cref="IReadOnlyTreePath{T}.RootNode"/>.
    /// If not found, <see langword="default(TValue)"/> is returned instead.
    /// </remarks>
    /// <param name="treePath">The <see cref="IReadOnlyTreePath{T}"/> to search.</param>
    /// <param name="predicate">Function used to evaluate each <see cref="ITreePathNode{T}"/></param>
    /// <typeparam name="T">Type of the node payloads.</typeparam>
    /// <returns>First node to satisfy the <paramref name="predicate"/>, or <see langword="default(TValue)"/></returns>
    public static ITreePathNode<T> FirstOrDefaultFromUltimate<T>(this IReadOnlyTreePath<T> treePath, Func<ITreePathNode<T>, bool> predicate)
    {
        return treePath.EnumerateNodesFromUltimate()
                       .FirstOrDefault(predicate);
    }
}