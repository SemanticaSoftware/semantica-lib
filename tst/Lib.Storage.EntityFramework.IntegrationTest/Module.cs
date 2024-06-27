using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Semantica.Core.DependencyInjection;
using Semantica.Core.SimpleInjector;
using Semantica.Domain;
using Semantica.Domain.Data.Repositories;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.Converters;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.DataStores;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.PredicateProviders;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.Converters;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.DataStores;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.PredicateProviders;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Storage;
using Semantica.Storage.EntityFramework.SimpleInjector;
using SimpleInjector;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test;

public class Module : ModuleBase<Container>
{
    public override IEnumerable<Assembly> GetDependencyAssemblies()
    {
        yield return typeof(Semantica.Storage.EntityFramework.Module).Assembly;
    }

    public override void RegisterModuleImplementations(Container container)
    {
        container.Options.AllowOverridingRegistrations = true;
        container.Register<IUnitOfWorkManager, SimpleUnitOfWorkManager>(Lifestyle.Scoped);
        container.Options.AllowOverridingRegistrations = false;
        container.Register(() => new DbContextOptions<SemLibTestDataContext>(), Lifestyle.Scoped);
        container.RegisterDbContextFactory<SemLibTestDataContext>();

        container.Register<IRootRepository, RootRepository>();
        container.Register<ISimpleDependentRepository, SimpleDependentRepository>();

        container.Register<IKeyConverter<Root, RootKey>, RootKeyConverter>();
        container.Register<IRootConverter, RootConverter>();
        container.Register<IKeyConverter<SimpleDependent, SimpleDependentKey>, SimpleDependentKeyConverter>();
        container.Register<ISimpleDependentConverter, SimpleDependentConverter>();

        container.Register<IRootDataStore, RootDataStore>();
        container.Register<ISimpleDependentDataStore, SimpleDependentDataStore>();

        container.Register<IRootPredicateProvider, RootPredicateProvider>();
        container.Register<ISimpleDependentPredicateProvider, SimpleDependentPredicateProvider>();
        container.Register<IPropertyAnalyser, PropertyAnalyser>();
        container.Register<IPropertyIdentifier, PropertyIdentifier>();
    }

    protected override IServiceCollection ToMicrosoftDependencyInjectionAbstractions(Container container) 
        => new ServiceCollectionContainer(container);
}