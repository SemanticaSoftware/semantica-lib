using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Design.Examples;
using Semantica.Lib.Tests.Design.Examples.Unlayered;
using Semantica.TestTools.SimpleInjector.Tests;

namespace Semantica.Lib.Tests.Design.Test.Examples.Tests;

[TestClass]
public class UnlayeredModuleTest : ServiceCollectionModuleTestBase<UnlayeredModule>
{
    [TestMethod]
    public override void Register_Verify_DoesNotThrow()
    {
        Initialize();
        Act(findOtherModulesInSameAssembly: false);
        Assert();
    }
}
