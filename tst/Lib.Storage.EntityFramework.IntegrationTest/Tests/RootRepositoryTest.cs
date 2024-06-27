using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Tests.Common;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Tests;

[TestClass]
public class RootRepositoryTest : TestBase
{
    private RootKey _nonExistingKey = new RootKey(9999);

    [TestMethod]
    public async Task ContainsAsync_ExistingKey_True()
    {
        var key = RootKey.ExistingKeys[0];
        //ACT
        var result = await _rootRepository.ContainsAsync(key);
        //ASSERT
        Assert.IsTrue(result);
    }

    [TestMethod]
    public async Task ContainsAsync_NonExistingKey_False()
    {
        var key = _nonExistingKey;
        //ACT
        var result = await _rootRepository.ContainsAsync(key);
        //ASSERT
        Assert.IsFalse(result);
    }

    [TestMethod]
    public async Task GetAsync_ExistingKey_EntityModel()
    {
        var key = RootKey.ExistingKeys[0];
        //ACT
        var result = await _rootRepository.GetAsync(key);
        //ASSERT
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task GetListAsync_ExistingKey_OneModel()
    {
        var keyList = new List<RootKey> { RootKey.ExistingKeys[0] };
        //ACT
        var result = await _rootRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public async Task GetListAsync_SingleExistingKey_MatchingEntityModel()
    {
        var key = RootKey.ExistingKeys[0];
        var keyList = new List<RootKey> { key };
        //ACT
        var result = await _rootRepository.GetListAsync(keyList);
        //ASSERT
        var rootKey = result.FirstOrDefault()?.Key ?? default;
        Assert.AreEqual(key, rootKey);
    }

    [TestMethod]
    public async Task GetListAsync_SingleNonExistingKey_Empty()
    {
        var keyList = new List<RootKey> { _nonExistingKey };
        //ACT
        var result = await _rootRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public async Task GetListAsync_MultipleNonExistingKeys_Empty()
    {
        var keyList = new List<RootKey> { _nonExistingKey, new RootKey(9998) };
        //ACT
        var result = await _rootRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public async Task GetListAsync_MultipleKeysOneExisting_OneModel()
    {
        var keyList = new List<RootKey> { RootKey.ExistingKeys[1], _nonExistingKey };
        //ACT
        var result = await _rootRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public async Task GetListAsync_MultipleExistingKeys_MultipleModels()
    {
        var keyList = new List<RootKey> { RootKey.ExistingKeys[0], RootKey.ExistingKeys[1] };
        IReadOnlyList<RootModel> result = null;
        //ACT
        result = await _rootRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(2, result.Count);
    }

    [TestMethod]
    public void Add_RootModel_CorrectKeyFunc()
    {
        var key = _nonExistingKey;
        var model = new RootModel {
            Key = key,
            Prop = "42",
        };
        //ACT
        var result = _rootRepository.Add(model);
        //ASSERT
        Assert.AreEqual(key, result());
    }

    [TestMethod]
    public void Add_RootModel_CreatesNewRoot()
    {
        var key = _nonExistingKey;
        var model = new RootModel
        {
            Key = key,
            Prop = "42",
        };
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _rootRepository.Add(model);
        }
        //ASSERT
        var result = Context.Set<Root>().FirstOrDefault(ar => ar.Id == key.Id);
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Replace_SetPropToNewValue_NewValueIsStored()
    {
        var key = RootKey.ExistingKeys[0];
        const string newPropValue = "42";
        var model = new RootModel
        {
            Key = key,
            Prop = newPropValue,
        };
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _rootRepository.Replace(model);
        }
        //ASSERT
        var result = Context.Set<Root>().FirstOrDefault(ar => ar.Id == key.Id);
        Assert.AreEqual(newPropValue, result?.Prop);
    }

    [TestMethod]
    public void Remove_ExisingKey_EntityRemoved()
    {
        var key = RootKey.ExistingKeys[0];
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _rootRepository.Remove(key);
        }
        //ASSERT
        var result = Context.Set<Root>().FirstOrDefault(ar => ar.Id == key.Id);
        Assert.IsNull(result);
    }
}