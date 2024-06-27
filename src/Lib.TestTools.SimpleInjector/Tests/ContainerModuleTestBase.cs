using System;
using System.Diagnostics;
using Moq;
using Semantica.Core.DependencyInjection;
using Semantica.TestTools.Core;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace Semantica.TestTools.SimpleInjector.Tests;

public abstract class ContainerModuleTestBase<TModule> : ModuleTestBase<TModule>
    where TModule : ModuleBase<Container>, new()
{
    protected Container Container = null!;

    [DebuggerHidden]
    protected override void Act(bool findOtherModulesInSameAssembly = true) 
    { 
        Sut.Register(Container, findOtherModulesInSameAssembly);
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
        where TDependency : class
    {
        Container.RegisterInstance<TDependency>(new Mock<TDependency>().Object);
    }
}