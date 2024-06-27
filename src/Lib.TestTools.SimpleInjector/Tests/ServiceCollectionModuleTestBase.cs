using System;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Semantica.Core.DependencyInjection;
using Semantica.Core.SimpleInjector;
using Semantica.TestTools.Core;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace Semantica.TestTools.SimpleInjector.Tests;

public abstract class ServiceCollectionModuleTestBase<TModule> : ModuleTestBase<TModule>
    where TModule : ModuleBase<IServiceCollection>, new()
{
    protected Container Container = null!;

    [DebuggerHidden]
    protected override void Act(bool findOtherModulesInSameAssembly = true)
    {
        Sut.Register(new ServiceCollectionContainer(Container), findOtherModulesInSameAssembly);
    }

    [DebuggerHidden]
    protected override void Assert()
    {
        Container.Verify();
    }

    [DebuggerHidden]
    protected override void Initialize()
    {
        //Initialize SUT
        Sut = Activator.CreateInstance<TModule>();
        //Common setup
        Container = new Container();
        Container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
        RegisterInvertedDependencies();
    }

    [DebuggerHidden]
    protected override void RegisterAsMock<TDependency>()
    {
        Container.RegisterInstance<TDependency>(new Mock<TDependency>().Object);
    }
}
