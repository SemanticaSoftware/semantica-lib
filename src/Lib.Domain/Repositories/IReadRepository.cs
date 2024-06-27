using System.Threading;
using System.Threading.Tasks;

namespace Semantica.Domain.Repositories;

/// <summary>
/// An isolated interface providing only the read methods of a repository.
/// </summary>
/// <typeparam name="TDomain"> The type of the returned model class. </typeparam>
/// <typeparam name="TKey"> The type used as key of the elements. </typeparam>
public interface IReadRepository<TDomain, in TKey>
    where TDomain : class, IDomainModel<TKey>
    where TKey : struct, IEquatable<TKey>
{
    /// <summary>
    /// Determines whether the persistent collection contains an entity instance corresponding to the provided key.
    /// </summary>
    /// <param name="key"> A key to look up. </param>
    /// <returns> <see langword="true"/> if the persistent collection the key; <see langword="false"/> otherwise. </returns>
    bool Contains(TKey key);
    
    /// <summary>
    /// Determines whether the persistent collection contains an element corresponding to the provided key.
    /// </summary>
    /// <param name="key"> A key to look up. </param>
    /// <param name="cancellationToken">A CancellationToken to observe while waiting for the task to complete.</param>
    /// <returns> <see langword="true"/> if the persistent collection the key; <see langword="false"/> otherwise. </returns>
    Task<bool> ContainsAsync(TKey key, CancellationToken cancellationToken = default);

    /// <summary> Returns models retrieved from the persistent collection corresponding to the provided key. </summary>
    /// <param name="key"> A key to look up. </param>
    /// <param name="cancellationToken">A CancellationToken to observe while waiting for the task to complete.</param>
    /// <returns> Returns the model corresponding to the; <see langword="null"/> if no such element is found. </returns>
    Task<TDomain?> GetAsync(TKey key, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cancellationToken">A CancellationToken to observe while waiting for the task to complete.</param>
    /// <returns></returns>
    Task<IReadOnlyList<TDomain>> GetAllAsync(CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Zoekt alle <typeparamref name="TDomain" /> modellen op in de Repository die matchen aan de <paramref name="keys"/>.
    /// Sleutels die niet zijn gevonden worden niet in de lijst opgenomen.
    /// Deze methode kan niet worden uitgevoert als <typeparamref name="TKey"/> een samengestelde sleutel is.
    /// </summary>
    /// <exception cref="InvalidOperationException">Als <typeparamref name="TKey"/> een samengestelde sleutel is.</exception>
    /// <param name="keys">Een lijst met unieke sleutels.</param>
    /// <param name="cancellationToken">A CancellationToken to observe while waiting for the task to complete.</param>
    /// <returns>Een lijst van alle gevonden <typeparamref name="TDomain"/> modellen.</returns>
    Task<IReadOnlyList<TDomain>> GetListAsync(IEnumerable<TKey> keys, CancellationToken cancellationToken = default);

    /// <summary>
    /// Zoekt alle <typeparamref name="TDomain"/> modellen op in de Repository die matchen aan de <paramref name="keys"/>.
    /// De lijst is Sleutels die niet zijn gevonden worden niet in de lijst opgenomen.
    /// </summary>
    /// <param name="keys">Een lijst met unieke sleutels.</param>
    /// <param name="cancellationToken">A CancellationToken to observe while waiting for the task to complete.</param>
    /// <returns>Een lijst van alle gevonden <typeparamref name="TDomain"/> modellen.</returns>
    Task<IReadOnlyList<TDomain?>> GetListInMatchingOrderAsync(IEnumerable<TKey> keys, CancellationToken cancellationToken = default);

}
