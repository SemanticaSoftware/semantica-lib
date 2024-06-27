using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Semantica.Storage.EntityFramework.DbContexts;
using SimpleInjector;

namespace Semantica.Storage.EntityFramework.SimpleInjector;

[ExcludeFromCodeCoverage]
public static class ModuleExtensions 
{
    /// <summary>
    /// Registers the <see cref="DbContextFactory{TImplementation}"/> using the provided <typeparamref name="TDbContext"/>
    /// as implementation for both the generic and base type <see cref="IDbContextFactory"/>.
    /// </summary>
    /// <remarks>
    /// <para> Registration is done with <see cref="Lifestyle.Scoped"/> <see cref="Lifestyle"/>. </para>
    /// <para>
    /// The <see cref="DbContextFactory{T}"/> implementation is dependent on <see cref="DbContextOptions{T}"/> being registered.
    /// Registration of that dependency in the DI container would by typically done by calling
    /// <see cref="Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext{T}(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)"/>
    /// , or one of it's overloads.
    /// </para>
    /// </remarks>
    /// <param name="container"> <see cref="Container"/> to add the registrations to. </param>
    /// <typeparam name="TDbContext"> Implementation of <see cref="DbContext"/> to register. </typeparam>
    public static void RegisterDbContextFactory<TDbContext>(this Container container)
        where TDbContext : DbContext
    {
        container.Register<DbContexts.IDbContextFactory<TDbContext>, DbContextFactory<TDbContext>>(Lifestyle.Scoped);
        container.Register<IDbContextFactory, DbContextFactory<TDbContext>>(Lifestyle.Scoped);
    }

    /// <summary>
    /// Registers the untyped <see cref="DbContextFactory"/>  as implementation for the base type
    /// <see cref="IDbContextFactory"/>.
    /// </summary>
    /// <remarks>
    /// <para> Registration is done with <see cref="Lifestyle.Scoped"/> <see cref="Lifestyle"/>. </para>
    /// <para>
    /// The <see cref="DbContextFactory"/> implementation is dependent on <see cref="DbContextOptions{DbContext}"/> being
    /// registered. Registration of that dependency in the DI container would by typically done by calling
    /// <see cref="Microsoft.Extensions.DependencyInjection.EntityFrameworkServiceCollectionExtensions.AddDbContext{T}(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.DependencyInjection.ServiceLifetime,Microsoft.Extensions.DependencyInjection.ServiceLifetime)"/>
    /// , or one of it's overloads.
    /// </para>
    /// </remarks>
    /// <param name="container"> <see cref="Container"/> to add the registrations to. </param>
    public static void RegisterDefaultDbContextFactory(this Container container)
    {
        container.Register<IDbContextFactory, DbContextFactory>(Lifestyle.Scoped);
    }
}