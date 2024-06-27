using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Semantica.Domain;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;
using Semantica.Storage.Data;

namespace Semantica.Lib.Tests.Design.Test.Storage.Data.Repositories;

[TestClass]
public class StorageCacheTest
{
    //dependencies
    private Mock<IUnitOfWorkManager> _unitOfWorkManagerMock;
    //SUT
    private StorageCache<SimpleRootKey, SimpleRootModel> _repositoryCache;

    [TestInitialize]
    public void Init()
    {
        //dependencies
        _unitOfWorkManagerMock = new Mock<IUnitOfWorkManager>();
        //SUT
        _repositoryCache = new StorageCache<SimpleRootKey, SimpleRootModel>(_unitOfWorkManagerMock.Object);
    }

    [TestMethod]
    public void CacheAndTryGet_SomeModel_ReturnsSameModel()
    {
        CacheModel(out var model);
        //ACT
        _repositoryCache.TryGet(model.Key, out var cachedModel);
        //ASSERT
        Assert.AreSame(model, cachedModel);
    }

    [TestMethod]
    public void CacheAndTryGet_MultipleModelsCached_ReturnsRequestedModel()
    {
        CacheTwoModels(out var model1, out _);
        //ACT
        _repositoryCache.TryGet(model1.Key, out var cachedModel);
        //ASSERT
        Assert.AreSame(model1, cachedModel);
    }

    [TestMethod]
    public void CacheAndTryGet_CacheSameModelTwice_ReturnsSameModel()
    {
        CacheTwoModels(out var model1, out _);
        //ACT
        _repositoryCache.Cache(model1.Key, model1);
        _repositoryCache.TryGet(model1.Key, out var cachedModel);
        //ASSERT
        Assert.AreSame(model1, cachedModel);
    }

    [TestMethod]
    public void CacheAndTryGet_CacheSameModelWithDifferentProperty_ReturnsNewModelProperty()
    {
        CacheTwoModels(out var model1, out _);
        model1.Value = 42;
        //ACT
        _repositoryCache.Cache(model1.Key, model1);
        _repositoryCache.TryGet(model1.Key, out var cachedModel);
        //ASSERT
        Assert.AreEqual(42, cachedModel.Value);
    }

    [TestMethod]
    public void Flush_RemovesAllCachedModels()
    {
        CacheTwoModels(out var model1, out _);
        //ACT
        _repositoryCache.Flush();
        //ASSERT
        Assert.IsFalse( _repositoryCache.TryGet(model1.Key, out _) && _repositoryCache.TryGet(model1.Key, out var cachedModel2) );
    }

    [TestMethod]
    public void Invalidate_RemoveSpecificModel_InvalidatedModelNotCached()
    {
        CacheTwoModels(out var model1, out _);
        //ACT
        _repositoryCache.Invalidate(model1.Key);
        //ASSERT
        Assert.IsFalse(_repositoryCache.TryGet(model1.Key, out _));
    }

    [TestMethod]
    public void Invalidate_RemoveSpecificModel_OtherModelStillCached()
    {
        CacheTwoModels(out var model1, out var model2);
        //ACT
        _repositoryCache.Invalidate(model1.Key);
        //ASSERT
        Assert.IsTrue(_repositoryCache.TryGet(model2.Key, out _));
    }

    [TestMethod]
    public void Invalidate_RemoveModelNotInCache_NoExceptions()
    {
        CacheModel(out var model1);
        var model2 = Make(2, 2);
        //ACT
        _repositoryCache.Invalidate(model2.Key);
    }

    private void CacheModel(out SimpleRootModel rootModel)
    {
        rootModel = Make();
        _repositoryCache.Cache(rootModel.Key, rootModel);
    }

    private void CacheTwoModels(out SimpleRootModel model1, out SimpleRootModel model2)
    {
        model1 = Make(1, 1);
        model2 = Make(2, 2);
        _repositoryCache.Cache(model1.Key, model1);
        _repositoryCache.Cache(model2.Key, model2);
    }


    private SimpleRootModel Make(int value = 0, int key = 42)
    {
        return new SimpleRootModel() { Key = new SimpleRootKey(key), Value = value };
    }
}