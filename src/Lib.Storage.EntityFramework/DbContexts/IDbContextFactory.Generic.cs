using Microsoft.EntityFrameworkCore;

namespace Semantica.Storage.EntityFramework.DbContexts;

/// <summary>
/// Used to create instances of <typeparamref name="TDbContext"/>.  
/// </summary>
public interface IDbContextFactory<out TDbContext> : IDbContextFactory
    where TDbContext : DbContext
{
    /// <summary>
    /// Creates the appropriate application specific <see cref="DbContext"/>. 
    /// </summary>
    /// <returns>A new instance of the application's <typeparamref name="TDbContext"/>.</returns>
    TDbContext CreateAppDbContext();
}