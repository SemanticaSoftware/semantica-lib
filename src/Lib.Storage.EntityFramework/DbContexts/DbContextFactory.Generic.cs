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
/// <typeparam name="TDbContext">
/// Type inheriting from <see cref="DbContext"/>. Must have a constructor with a single argument of type
/// <see cref="DbContextOptions{T}"/>.
/// </typeparam>
/// <inheritdoc cref="IDbContextFactory{TDbContext}"/>
public class DbContextFactory<TDbContext> : IDbContextFactory<TDbContext>
    where TDbContext : DbContext
{
    private readonly DbContextOptions<TDbContext> _dbContextOptions;

    public DbContextFactory(DbContextOptions<TDbContext> dbContextOptions)
    {
        _dbContextOptions = dbContextOptions;
    }

    public TDbContext CreateAppDbContext()
    {
        return (TDbContext)Activator.CreateInstance(typeof(TDbContext), _dbContextOptions)!;
    }

    public DbContext CreateDbContext()
    {
        return CreateAppDbContext();
    }
}