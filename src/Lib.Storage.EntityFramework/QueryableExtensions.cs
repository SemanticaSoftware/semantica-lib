using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Semantica.Storage.EntityFramework;

public static class QueryableExtensions
{
    /// <summary>
    ///     Asynchronously creates a <see cref="List{T}" /> from an <see cref="IQueryable{T}" /> by enumerating it
    ///     asynchronously, and casting it to a <see cref="IReadOnlyList{T}"/>.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Multiple active operations on the same context instance are not supported. Use <see langword="await" /> to ensure
    ///         that any asynchronous operations have completed before calling another method on this context.
    ///         See <see href="https://aka.ms/efcore-docs-threading">Avoiding DbContext threading issues</see> for more information.
    ///     </para>
    ///     <para>
    ///         See <see href="https://aka.ms/efcore-docs-async-linq">Querying data with EF Core</see> for more information.
    ///     </para>
    /// </remarks>
    /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
    /// <param name="source">An <see cref="IQueryable{T}" /> to create a list from.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <returns>
    ///     A task that represents the asynchronous operation.
    ///     The task result contains a <see cref="IReadOnlyList{T}" /> that contains elements from the input sequence.
    /// </returns>
    /// <exception cref="ArgumentNullException"><paramref name="source" /> is <see langword="null" />.</exception>
    /// <exception cref="OperationCanceledException">If the <see cref="CancellationToken" /> is canceled.</exception>
    public static async Task<IReadOnlyList<TSource>> ToReadOnlyListAsync<TSource>(
        this IQueryable<TSource> source,
        CancellationToken cancellationToken = default)
    {
        var list = new List<TSource>();
        await foreach (var element in source.AsAsyncEnumerable().WithCancellation(cancellationToken))
        {
            list.Add(element);
        }

        return list;
    }
    
}
