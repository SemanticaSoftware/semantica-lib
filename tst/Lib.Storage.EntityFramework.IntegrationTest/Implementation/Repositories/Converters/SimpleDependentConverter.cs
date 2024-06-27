using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.Converters;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.Converters;

public class SimpleDependentConverter : SimpleDependentKeyConverter, ISimpleDependentConverter
{
    public SimpleDependentModel ToDomain(SimpleDependent storageModel)
    {
        return new SimpleDependentModel() {
            Key = ToKey(storageModel),
            RootKey = new RootKey(storageModel.RootId)
        };
    }

    public SimpleDependent ToStorage(SimpleDependentModel domainModel)
    {
        var entity = ToBlankStorageModel(domainModel.Key);
        entity.RootId = domainModel.RootKey.Id;
        entity.DependentProp = domainModel.DependentProp;
        return entity;
    }
}