using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Data;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Storage;
using Semantica.Storage;
using Semantica.Storage.DataStores;
using Semantica.Storage.EntityFramework;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered;

public class UnlayeredModule : ModuleBase<IServiceCollection>
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
        serviceCollection.AddScoped<ICompositeUnlayeredRepository, CompositeUnlayeredRepository>();
        serviceCollection.AddScoped<IKeyConverter<CompositeUnlayeredModel, CompositeKey>, UnlayeredCompositeKeyConverter>();
        serviceCollection.AddScoped<IPredicateProvider<CompositeUnlayeredModel, CompositeKey>, CompositeUnlayeredPredicateProvider>();
        //Guid
        serviceCollection.AddScoped<IGuidRepository, GuidUnlayeredRepository>();
        serviceCollection.AddScoped<IKeyConverter<GuidModel, Guid>, GuidKeyConverter>();
        serviceCollection.AddScoped<ISimplePredicateProvider<GuidModel, Guid>, GuidUnlayeredPredicateProvider>();
        //Int
        serviceCollection.AddScoped<IIntRepository, IntUnlayeredRepository>();
        serviceCollection.AddScoped<IKeyConverter<IntModel, int>, IntKeyConverter>();
        serviceCollection.AddScoped<ISimplePredicateProvider<IntModel, int>, IntUnlayeredPredicateProvider>();
        //Simple
        serviceCollection.AddScoped<ISimpleRootUnlayeredRepository, SimpleRootUnlayeredRepository>();
        serviceCollection.AddScoped<IKeyConverter<SimpleRootUnlayeredModel, SimpleRootKey>, SimpleRootUnlayeredKeyConverter>();
        serviceCollection.AddScoped<ISimplePredicateProvider<SimpleRootUnlayeredModel, SimpleRootKey>, SimpleRootUnlayeredPredicateProvider>();
    }
}