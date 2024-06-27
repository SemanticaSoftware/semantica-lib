using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Data.Repositories;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Storage;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Data;

class GuidUnlayeredRepository
    : RepositoryBase<GuidModel, GuidModel, Guid>, IGuidRepository
{
    public GuidUnlayeredRepository(
            ISimpleDataStore<GuidModel, Guid> dataStore,
            IKeyConverter<GuidModel, Guid> keyConverter,
            IPropertyAnalyser analyser
        ) : base(dataStore, new DomainIsStorageConverter<GuidModel, Guid>(keyConverter), analyser)
    {
    }
}

class GuidKeyConverter : KeyConverter<GuidModel, Guid>
{
    public GuidKeyConverter() : base(model => model.Key, key => new GuidModel{Key = key})
    {
    }
}
