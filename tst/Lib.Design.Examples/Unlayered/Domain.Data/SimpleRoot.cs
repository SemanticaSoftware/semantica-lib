using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Data.Repositories;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Storage;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Data;

class SimpleRootUnlayeredRepository
    : RepositoryBase<SimpleRootUnlayeredModel, SimpleRootUnlayeredModel, SimpleRootKey>, ISimpleRootUnlayeredRepository
{
    public SimpleRootUnlayeredRepository(
            ISimpleDataStore<SimpleRootUnlayeredModel, SimpleRootKey> dataStore,
            IKeyConverter<SimpleRootUnlayeredModel, SimpleRootKey> keyConverter,
            IPropertyAnalyser analyser
        ) : base(dataStore, new DomainIsStorageConverter<SimpleRootUnlayeredModel, SimpleRootKey>(keyConverter), analyser)
    {
    }
}

class SimpleRootUnlayeredKeyConverter : KeyConverter<SimpleRootUnlayeredModel, SimpleRootKey>
{
    public SimpleRootUnlayeredKeyConverter() : base(model => model.Key, key => new SimpleRootUnlayeredModel{Key = key})
    {
    }
}
