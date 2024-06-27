using Microsoft.EntityFrameworkCore;

namespace Semantica.Storage.EntityFramework.DbContexts;

/// <remarks>
/// <para>
/// Dependent on <see cref="DbContextOptions{T}"/> being injected.
/// </para>
/// <para>
/// Registration of that dependency in the DI container would by typically done by calling
/// <see cref="Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext{T}(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)"/>
/// , or one of it's overloads.
/// </para>
/// </remarks>
/// <inheritdoc cref="IDbContextFactory"/>
public class DbContextFactory : IDbContextFactory
{
    private readonly DbContextOptions<DbContext> _dbContextOptions;

    public DbContextFactory(DbContextOptions<DbContext> dbContextOptions)
    {
        _dbContextOptions = dbContextOptions;
    }

    public DbContext CreateDbContext()
    {
        return (DbContext)Activator.CreateInstance(typeof(DbContext), _dbContextOptions)!;
    }
}
