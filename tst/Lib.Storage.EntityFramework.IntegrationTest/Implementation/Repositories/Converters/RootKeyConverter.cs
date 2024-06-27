using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.ComplexTypes;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Storage;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories.Converters;

public class RootKeyConverter : IKeyConverter<Root, RootKey>
{
    public RootKey ToKey(Root storageModel)
    {
        return new RootKey(storageModel.Id);
    }

    public Root ToBlankStorageModel(RootKey key)
    {
        return new Root() {
            Id = key.Id,
            Values = new ValueType(),
        };
    }
}