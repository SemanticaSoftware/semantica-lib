using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Storage.EntityFramework;

[ExcludeFromCodeCoverage]
public static class ModuleExtensions 
{
    /// <summary>
    /// Registers the <see cref="DbContextFactory{TImplementation}"/> using the provided <typeparamref name="TDbContext"/>
    /// as implementation for both the generic and base type <see cref="IDbContextFactory"/>.
    /// </summary>
    /// <remarks>
    /// <para> Registration is done with <see cref="ServiceLifetime.Scoped"/> <see cref="ServiceLifetime"/>. </para>
    /// <para>
    /// The <see cref="DbContextFactory"/> implementation is dependent on <see cref="DbContextOptions{TContext}"/> being
    /// registered. Registration of that dependency in the DI container would by typically done by calling
    /// <see cref="Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext{T}(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)"/>
    /// , or one of it's overloads.
    /// </para>
    /// </remarks>
    /// <param name="serviceCollection"> Container/<see cref="ServiceCollection"/> to add the registrations to. </param>
    /// <typeparam name="TDbContext"> Implmentation of <see cref="DbContext"/> to register. </typeparam>
    public static void RegisterDbContextFactory<TDbContext>(this IServiceCollection serviceCollection)
        where TDbContext : DbContext
    {
        serviceCollection.AddScoped<DbContexts.IDbContextFactory<TDbContext>, DbContextFactory<TDbContext>>();
        serviceCollection.AddScoped<IDbContextFactory, DbContextFactory<TDbContext>>();
    }

    /// <summary>
    /// Registers the untyped <see cref="DbContextFactory"/>  as implementation for the base type
    /// <see cref="IDbContextFactory"/>.
    /// </summary>
    /// <remarks>
    /// <para> Registration is done with <see cref="ServiceLifetime.Scoped"/> <see cref="ServiceLifetime"/>. </para>
    /// <para>
    /// The <see cref="DbContextFactory"/> implementation is dependent on <see cref="DbContextOptions{DbContext}"/> being
    /// registered. Registration of that dependency in the DI container would by typically done by calling
    /// <see cref="Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext{T}(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)"/>
    /// , or one of it's overloads.
    /// </para>
    /// </remarks>
    /// <param name="serviceCollection"> Container/<see cref="ServiceCollection"/> to add the registrations to. </param>
    public static void RegisterDefaultDbContextFactory(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IDbContextFactory, DbContextFactory>();
    }
}