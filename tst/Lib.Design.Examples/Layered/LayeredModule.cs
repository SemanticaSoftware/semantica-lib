using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain.Data;
using Semantica.Lib.Tests.Design.Examples.Layered.Storage;
using Semantica.Lib.Tests.Design.Examples.Layered.Storage.Models;
using Semantica.Storage;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework;

namespace Semantica.Lib.Tests.Design.Examples.Layered;

public class LayeredModule : ModuleBase<IServiceCollection>
{
    public override IEnumerable<Assembly> GetDependencyAssemblies()
    {
        yield return typeof(Semantica.Domain.Data.Module).Assembly;
        yield return typeof(Semantica.Storage.EntityFramework.Module).Assembly;
    }

    public override void RegisterModuleImplementations(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton(new DbContextOptions<DbContext>());
        serviceCollection.RegisterDefaultDbContextFactory();
        //Composite
        serviceCollection.AddScoped<ICompositeConverter, CompositeConverter>();
        serviceCollection.AddScoped<ICompositeDataStore, CompositeDataStore>();
        serviceCollection.AddScoped<ICompositeRepository, CompositeRepository>();
        serviceCollection.AddScoped<ICompositePredicateProvider, CompositePredicateProvider>();
        serviceCollection.AddScoped<IKeyConverter<CompositeStorage, CompositeKey>, CompositeKeyConverter>();
        //Guid
        serviceCollection.AddScoped<IGuidConverter, GuidConverter>();
        serviceCollection.AddScoped<IGuidRepository, GuidRepository>();
        serviceCollection.AddScoped<ISimplePredicateProvider<GuidStorage, Guid>, GuidPredicateProvider>();
        serviceCollection.AddScoped<IKeyConverter<GuidStorage, Guid>, GuidKeyConverter>();        
        //Simple
        serviceCollection.AddScoped<ISimpleRootConverter, SimpleRootConverter>();
        serviceCollection.AddScoped<ISimpleRootDataStore, SimpleRootDataStore>();
        serviceCollection.AddScoped<ISimpleRootRepository, SimpleRootRepository>();
        serviceCollection.AddScoped<ISimpleRootPredicateProvider, SimpleRootPredicateProvider>();
        serviceCollection.AddScoped<IKeyConverter<SimpleRootStorage, SimpleRootKey>, SimpleRootKeyConverter>();
        //FirstSub
        serviceCollection.AddScoped<IFirstSubConverter, FirstSubConverter>();
        //SecondSub
        serviceCollection.AddScoped<ISecondSubConverter, SecondSubConverter>();
    }
}
