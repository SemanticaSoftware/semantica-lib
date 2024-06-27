namespace Semantica.Trees.Converters;

/// <summary>
/// Can convert a treenode of the type <typeparamref name="TNode"/> to a payload of type <typeparamref name="TOut"/>.
/// </summary>
/// <remarks>
/// Implement this interface with <typeparamref name="TNode"/> as <see cref="ITreeNode{T}"/> for DI support for <see cref="ITreeConverter{T,TOut}"/>.
/// Implement this interface with <typeparamref name="TNode"/> as <see cref="IPartialTreeNode{T}"/>for DI support for <see cref="IPartialTreeConverter{T,TOut}"/>.
/// </remarks>
/// <typeparam name="TNode">Type of node.</typeparam>
/// <typeparam name="TOut">Type of the output.</typeparam>
public interface IPayloadConverter<in TNode ,out TOut>
{
    /// <summary>
    /// Converts a treenode of type <typeparamref name="TNode"/> to a payload of type <typeparamref name="TOut"/>.
    /// </summary>
    /// <param name="node">Node to convert.</param>
    /// <returns>The converted payload.</returns>
    TOut ConvertPayload(TNode node);
}
