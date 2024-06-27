using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using Semantica.Domain;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;

namespace Semantica.Storage.EntityFramework;

/// <summary>
/// Module that registers implementations of:
/// <list type="bullet">
/// <item><see cref="IAggregateDataStore{T,T}"/></item>
/// <item><see cref="IAggregateDataStoreInternal{T,T}"/></item>
/// <item><see cref="IDataStore{T,T}"/></item>
/// <item><see cref="IDbContextProvider"/></item>
/// <item><see cref="ISimpleDataStore{T,T}"/></item>
/// <item><see cref="IUnitOfWorkManager"/></item>
/// </list>
/// The module is dependent on implementations in the <see cref="Semantica.Storage"/>.<see cref="Semantica.Storage.Data"/>
/// assembly.
/// </summary>
public sealed class Module : ModuleBase<IServiceCollection>
{
    public override IEnumerable<Assembly> GetDependencyAssemblies()
    {
        yield return typeof(Semantica.Storage.Data.Module).Assembly;
    }

    public override void RegisterModuleImplementations(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IDbContextProvider, DbContextProvider>();
        serviceCollection.AddScoped<IUnitOfWorkManager, UnitOfWorkManager>();
            
        serviceCollection.AddTransient(typeof(IAggregateDataStore<,>), typeof(AggregateDataStore<,>));
        serviceCollection.AddTransient(typeof(IAggregateDataStoreInternal<,>), typeof(AggregateDataStore<,>));
        serviceCollection.AddTransient(typeof(ISimpleAggregateDataStore<,>), typeof(SimpleAggregateDataStore<,>));
        serviceCollection.AddTransient(typeof(ISimpleAggregateDataStoreInternal<,>), typeof(SimpleAggregateDataStore<,>));
        serviceCollection.AddTransient(typeof(IDataStore<,>), typeof(DataStore<,>));
        serviceCollection.AddTransient(typeof(ISimpleDataStore<,>), typeof(SimpleDataStore<,>));
    }
}