using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Tests.Common;
using Semantica.Storage.EntityFramework.DataStores;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Tests;

[TestClass]
public class InclusionTest : TestBase
{
    private static readonly InclusionPrototype<SimpleDependent, Root> c_inclusion = new InclusionPrototype<SimpleDependent, Root>(sd => sd.Root, sd => sd.Root = null);

    [TestMethod]
    public async Task ContainsAsync_ExistingKey_ReturnsTrue()
    {
        var key = SimpleDependentKey.ExistingKeys[0];
        //ACT
        var result = await _dataStore.ExistsAsync(key);
        //ASSERT
        Assert.AreEqual(true, result);
    }

    [TestMethod]
    public async Task RetrieveAsync_WithInclusion_ReturnsModelWithInclusion()
    {
        var key = SimpleDependentKey.ExistingKeys[0];
        using (var inclusion = c_inclusion.MakeInclusion())
        {
            //ACT
            var result = (await _dataStore.RetrieveAsync(key, inclusion)).Root;
            //ASSERT
            Assert.IsInstanceOfType(result, typeof(Root));
        }
    }

    [TestMethod]
    public async Task RetrieveAsync_WithInclusionAndDispose_InclusionRemovedFromModel()
    {
        var key = SimpleDependentKey.ExistingKeys[0];
        SimpleDependent retrievedModel;
        using (var inclusion = c_inclusion.MakeInclusion())
        {
            //ACT
            retrievedModel = await _dataStore.RetrieveAsync(key, inclusion);
        }
        var result = retrievedModel.Root;
        //ASSERT
        Assert.IsNull(result);
    }

    [TestMethod]
    public async Task Update_WithDisposedInclusion_DoesNotDeleteReference()
    {
        var key = SimpleDependentKey.ExistingKeys[0];
        SimpleDependent retrievedModel;
        using (var inclusion = c_inclusion.MakeInclusion())
        {
            //ACT
            retrievedModel = await _dataStore.RetrieveAsync(key, inclusion);
        }

        using (_unitOfWorkManager.StartNew())
        {
            _dataStore.Update(retrievedModel);
        }

        var result = retrievedModel.RootId;
        //ASSERT
        Assert.AreEqual(1, result);
    }

    [TestMethod]
    public async Task Update_TwoItemsWithSameInclusion_UpdateSuccesful()
    {
        var key = SimpleDependentKey.ExistingKeys[1];
        var key2 = SimpleDependentKey.ExistingKeys[2];
        SimpleDependent retrievedModel, retrievedModel2;
        using (var inclusion = c_inclusion.MakeInclusion())
        {
            //ACT
            retrievedModel = await _dataStore.RetrieveAsync(key, inclusion);
            retrievedModel2 = await _dataStore.RetrieveAsync(key2, inclusion);
            Assert.AreEqual(retrievedModel.Root.Id, retrievedModel2.Root.Id);
        }

        using (_unitOfWorkManager.StartNew())
        {
            _dataStore.Update(retrievedModel);
            _dataStore.Update(retrievedModel2);
        }
    }

}