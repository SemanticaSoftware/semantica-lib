using Microsoft.EntityFrameworkCore;

namespace Semantica.Storage.EntityFramework.DbContexts;

/// <summary>
/// Used to create instances of <see cref="DbContext"/>.
/// </summary>
public interface IDbContextFactory
{
    /// <summary>
    /// Creates the appropriate <see cref="DbContext"/>. 
    /// </summary>
    /// <returns>The application's <see cref="DbContext"/>.</returns>
    DbContext CreateDbContext();
}
