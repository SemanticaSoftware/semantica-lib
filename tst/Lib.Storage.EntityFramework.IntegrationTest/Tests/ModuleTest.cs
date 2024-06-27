using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.TestTools.SimpleInjector.Tests;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Tests;

[TestClass]
public class ModuleTest : ContainerModuleTestBase<Module>
{
    [TestMethod]
    public override void Register_Verify_DoesNotThrow()
    {
        Initialize();
        Act();
        Assert();
    }
}