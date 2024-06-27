namespace Semantica.Trees.Converters;

/// <summary>
/// Can convert a tree of type <typeparamref name="TIn"/> to a tree of type <typeparamref name="TOut"/>.
/// The resulting tree wil have the same structure as the source tree. 
/// </summary>
/// <remarks>
/// The payloads are converted by <see cref="IPayloadConverter{TIn,TOut}"/>, on which the implementation is dependent.
/// </remarks>
/// <typeparam name="TIn">Type of payload of the tree to convert.</typeparam>
/// <typeparam name="TOut">Type of payload of the output tree.</typeparam>
public interface ITreeConverter<in TIn, TOut>
{
    /// <summary>
    /// Converts a tree of type <typeparamref name="TIn"/> to a new tree of type <typeparamref name="TOut"/>.
    /// </summary>
    /// <param name="source">Tree to convert</param>
    /// <returns>A new tree with converted payloads that is structurally equivalent to the source.</returns>
    IGrowingTree<TOut> Convert(IReadOnlyTree<TIn> source);
}
