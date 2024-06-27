using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Storage;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.Converters;

public class SimpleDependentKeyConverter : IKeyConverter<SimpleDependent, SimpleDependentKey>
{
    public SimpleDependentKey ToKey(SimpleDependent storageModel)
    {
        return new SimpleDependentKey(storageModel.Id);
    }

    public SimpleDependent ToBlankStorageModel(SimpleDependentKey key)
    {
        return new SimpleDependent() {
            Id = key.Id,
        };
    }
}