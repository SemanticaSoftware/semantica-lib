using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Domain;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.DataStores;
using Semantica.Storage.EntityFramework.DbContexts;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Tests.Common;

public class TestBase
{
    //dependencies
    protected Container _container { get; private set; }

    protected Scope _scope { get; private set; }
    //SUT
    protected SemLibTestDataContext Context => _dataContextProvider.ActiveContext as SemLibTestDataContext;

    protected ISimpleDependentDataStore _dataStore { get; private set; }
    protected IRootRepository _rootRepository { get; private set; }
    protected ISimpleDependentRepository _simpleDependentRepository { get; private set; }
    protected IUnitOfWorkManager _unitOfWorkManager { get; private set; }
    protected IDbContextProvider _dataContextProvider { get; private set; }

    public TestBase()
    {
        _container = new Container();
        _container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();
        var mod = new Module();
        mod.RegisterModuleImplementations(_container);
    }

    [TestInitialize]
    public void Init()
    {
        //Initialize dependencies
        _scope = new Scope(_container);
        _dataContextProvider = _scope.GetInstance<IDbContextProvider>();
        _unitOfWorkManager = _scope.GetInstance<IUnitOfWorkManager>();
        //Initialize SUT
        _simpleDependentRepository = _scope.GetInstance<ISimpleDependentRepository>();
        _rootRepository = _scope.GetInstance<IRootRepository>();
        _dataStore = _scope.GetInstance<ISimpleDependentDataStore>();
        //Common setup
        Context.Database.EnsureCreated();
    }

    [TestCleanup]
    public virtual void Cleanup()
    {
        Context.Database.EnsureDeleted();
        _scope?.Dispose();
    }
}