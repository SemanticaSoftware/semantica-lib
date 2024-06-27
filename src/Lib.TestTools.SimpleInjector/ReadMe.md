# Semantica.Lib.TestTools.SimpleInjector
This package is part of the testing packages of Semantica.Lib.

### Summary

Provides two abstract base classes in order make compact unit tests that verify registrations of your DI modules based on 
``Semantica.Lib.Core.DependencyInjection.ModuleBase``. Use ``ContainerModuleTestBase`` to make unit tests when you use
``SimpleInjector.Container`` as your DI container, or ``ServiceCollectionModuleTestBase`` to make unit tests when you use
``System.Extensions.DependencyInjection.IServiceCollection`` as you DI container.

Both implementations leverage SimpleInjector's ``Container.Verify()`` method for registration validation.   

## Contents

The outline base class (from **Semantica.Lib.TestTools.Core**) provides three methods that should be called from your test
assembly.

```csharp
[TestClass]
public class MyModuleTest : ContainerModuleTestBase<MyModule>
{
    [TestMethod]
    public override void Register_Verify_DoesNotThrow()
    {
        Initialize(); //sets up the DI container
        Act(); //calls the registration method of MyModule
        Assert(); //verifies registration, and throws when a missing registration is encountered
    }
}
```
This example tests the ``MyModule`` registrations, and all dependent modules. In this case using MSTest, and a SimpleInjector
container. 

When the module is dependent on reverse dependencies (interfaces that have their implementations registered upstream of the 
module), these registrations have to registered by overriding ``RegisterInvertedDependencies`` and calling ``RegisterAsMock``
for each reversed dependency.

```csharp
    protected override void RegisterInvertedDependencies()
    {
        RegisterAsMock<IMyReverseDependency>();
    }
```

## Dependencies

- Moq
- MSTest.TestFramework
- Semantica.Lib.Checks
- Semantica.Lib.Core
- Semantica.Lib.Core.SimpleInjector
- Semantica.Lib.Intervals
- Semantica.Lib.Patterns
- Semantica.Lib.TestTools.Core
- Semantica.Lib.Types
- SimpleInjector
