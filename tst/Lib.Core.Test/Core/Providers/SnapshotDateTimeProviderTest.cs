using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Core.Providers;

namespace Semantica.Lib.Tests.Core.Test.Core.Providers;

[TestClass]
public class SnapshotDateTimeProviderTest
{
    private SnapshotDateTimeProvider _sut = null!;

    [TestInitialize]
    public void Init()
    {
        _sut = new SnapshotDateTimeProvider();
    }
    
    [TestMethod]
    public void GetUtcNow_DoTwice_SameResult()
    {
        //ACT
        var first = _sut.UtcNow();
        Thread.Sleep(2);
        var second = _sut.UtcNow();
        //ASSERT
        Assert.AreEqual(first, second);
    }
    
    [TestMethod]
    public void GetUtcNow_DoTwiceWithReset_DifferentResult()
    {
        //ACT
        var first = _sut.UtcNow();
        _sut.Reset();
        Thread.Sleep(2);
        var second = _sut.UtcNow();
        //ASSERT
        Assert.AreNotEqual(first, second);
    }
}
