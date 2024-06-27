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
public class SimpleDependentRepositoryTest : TestBase
{

    [TestMethod]
    public async Task ContainsAsync_ExistingKey_Returnstrue()
    {
        var key = SimpleDependentKey.ExistingKeys[0];
        //ACT
        var result = await _simpleDependentRepository.ContainsAsync(key);
        //ASSERT
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public async Task ContainsAsync_NonExistingKey_ReturnsFalse()
    {
        var key = new SimpleDependentKey(4);
        //ACT
        var result = await _simpleDependentRepository.ContainsAsync(key);
        //ASSERT
        Assert.AreEqual(false, result);
    }

    [TestMethod]
    public async Task GetAsync_ExistingKey_ReturnsEntityModel()
    {
        var key = SimpleDependentKey.ExistingKeys[0];
        //ACT
        var result = await _simpleDependentRepository.GetAsync(key);
        //ASSERT
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task GetListAsync_ExistingKey_ReturnsOneModel()
    {
        var keyList = new List<SimpleDependentKey> { SimpleDependentKey.ExistingKeys[0] };
        //ACT
        var result = await _simpleDependentRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public async Task GetListAsync_SingleExistingKey_ReturnsMatchingEntityModel()
    {
        var key = SimpleDependentKey.ExistingKeys[0];
        var keyList = new List<SimpleDependentKey> { key };
        //ACT
        var result = await _simpleDependentRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(key, result.FirstOrDefault()?.Key);
    }

    [TestMethod]
    public async Task GetListAsync_SingleNonExistingKey_ReturnsEmpty()
    {
        var keyList = new List<SimpleDependentKey> { new SimpleDependentKey(4) };
        //ACT
        var result = await _simpleDependentRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public async Task GetListAsync_MultipleNonExistingKeys_ReturnsEmpty()
    {
        var keyList = new List<SimpleDependentKey> { new SimpleDependentKey(4), new SimpleDependentKey(5) };
        //ACT
        var result = await _simpleDependentRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public async Task GetListAsync_MultipleKeysOneExisting_ReturnsOneModel()
    {
        var keyList = new List<SimpleDependentKey> { SimpleDependentKey.ExistingKeys[2], new SimpleDependentKey(4), new SimpleDependentKey(5) };
        //ACT
        var result = await _simpleDependentRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public async Task GetListAsync_MultipleExistingKeys_ReturnsMultipleModels()
    {
        var keyList = new List<SimpleDependentKey> { SimpleDependentKey.ExistingKeys[0], SimpleDependentKey.ExistingKeys[1], SimpleDependentKey.ExistingKeys[2] };
        //ACT
        var result = await _simpleDependentRepository.GetListAsync(keyList);
        //ASSERT
        Assert.AreEqual(3, result.Count);
    }

    [TestMethod]
    public void Add_SimpleDependentModel_ReturnsCorrectKeyFunc()
    {
        var key = new SimpleDependentKey(4);
        var model = new SimpleDependentModel
        {
            Key = key,
            DependentProp = true
        };
        //ACT
        var result = _simpleDependentRepository.Add(model);
        //ASSERT
        Assert.AreEqual(key, result());
    }

    [TestMethod]
    public void Add_SimpleDependentModel_NewSimpleDependent()
    {
        var simpleDependentKey = new SimpleDependentKey(4);
        var aggregateRootKey = RootKey.ExistingKeys[0];
        var model = new SimpleDependentModel
        {
            Key = simpleDependentKey,
            RootKey = aggregateRootKey,
            DependentProp = true
        };
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _simpleDependentRepository.Add(model);
        }
        //ASSERT
        var result = Context.Set<SimpleDependent>().FirstOrDefault(sd => sd.Id == simpleDependentKey.Id);
        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Add_SimpleDependentModel_AggregateRootHasNewSimpleDependent()
    {
        var simpleDependentKey = new SimpleDependentKey(4);
        var aggregateRootKey = RootKey.ExistingKeys[0];
        var model = new SimpleDependentModel
        {
            Key = simpleDependentKey,
            RootKey = aggregateRootKey,
            DependentProp = true
        };
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _simpleDependentRepository.Add(model);
        }
        //ASSERT
        var result = Context.Set<Root>().First(ar => ar.Id == aggregateRootKey.Id);
        Assert.IsNotNull(result.SimpleDependents.First(sd => sd.Id == simpleDependentKey.Id));
    }

    [TestMethod]
    public void Replace_SetPropToNewValue_NewValueIsStored()
    {
        var key = SimpleDependentKey.ExistingKeys[1];
        var model = new SimpleDependentModel
        {
            Key = key,
            RootKey = RootKey.ExistingKeys[1],
            DependentProp = true
        };
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _simpleDependentRepository.Replace(model);
        }
        //ASSERT
        var result = Context.Set<SimpleDependent>().First(sd => sd.Id == key.Id);
        Assert.IsTrue(result.DependentProp);
    }

    [TestMethod]
    public void Replace_SetRootKeyToNewValue_NewValueIsStored()
    {
        var simpleDependentKey = SimpleDependentKey.ExistingKeys[1];
        var aggregateRootKey = RootKey.ExistingKeys[0];
        var model = new SimpleDependentModel
        {
            Key = simpleDependentKey,
            RootKey = aggregateRootKey
        };
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _simpleDependentRepository.Replace(model);
        }
        //ASSERT
        var result = Context.Set<SimpleDependent>().First(sd => sd.Id == simpleDependentKey.Id);
        Assert.AreEqual(aggregateRootKey.Id, result.RootId);
    }

    [TestMethod]
    public void Replace_SetRootKeyToNewValue_AggregateRootHasNewSimpleDependent()
    {
        var simpleDependentKey = SimpleDependentKey.ExistingKeys[1];
        var aggregateRootKey = RootKey.ExistingKeys[0];
        var model = new SimpleDependentModel
        {
            Key = simpleDependentKey,
            RootKey = aggregateRootKey
        };
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _simpleDependentRepository.Replace(model);
        }
        //ASSERT
        var result = Context.Set<Root>().First(ar => ar.Id == aggregateRootKey.Id);
        Assert.IsNotNull(result.SimpleDependents.First(sd => sd.Id == simpleDependentKey.Id));
    }

    [TestMethod]
    public void Remove_ExistingKey_SimpleDependentRemoved()
    {
        var key = SimpleDependentKey.ExistingKeys[0];
        //ACT
        using (_unitOfWorkManager.StartNew())
        {
            _simpleDependentRepository.Remove(key);
        }
        //ASSERT
        Assert.IsFalse(Context.Set<SimpleDependent>().Any(sd => sd.Id == key.Id));
    }
}