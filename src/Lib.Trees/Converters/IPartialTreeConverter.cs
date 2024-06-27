namespace Semantica.Trees.Converters;

/// <summary>
/// Can convert a partial tree of type <typeparamref name="TIn"/> to a partial tree of type <typeparamref name="TOut"/>.
/// The resulting tree wil have the same structure as the source tree. 
/// The payloads are converted by <see cref="IPayloadConverter{TIn,TOut}"/>, on which the implementation is dependent.
/// </summary>
/// <typeparam name="TIn">Type of payloads of the tree to convert.</typeparam>
/// <typeparam name="TOut">Type of payloads of the output tree.</typeparam>
public interface IPartialTreeConverter<in TIn, out TOut>
{
    /// <summary>
    /// Converts a tree with payloads of type <typeparamref name="TIn"/> to a new tree with payloads of type <typeparamref name="TOut"/>, by converting the payloads using the injected <see cref="IPayloadConverter{TIn,TOut}"/>.
    /// </summary>
    /// <param name="source">Tree to convert.</param>
    /// <returns>A new tree with converted payloads that is structurally equivalent to the source.</returns>
    IReadOnlyPartialTree<TOut> Convert(IReadOnlyPartialTree<TIn> source);
}
