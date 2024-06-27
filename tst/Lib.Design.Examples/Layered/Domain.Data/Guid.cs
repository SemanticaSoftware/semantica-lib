using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Data.Repositories;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;
using Semantica.Lib.Tests.Design.Examples.Layered.Storage;
using Semantica.Storage;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain.Data;

class GuidRepository
    : RepositoryBase<GuidStorage, GuidModel, Guid>, IGuidRepository
{
    public GuidRepository(
            ISimpleDataStore<GuidStorage, Guid> dataStore,
            IGuidConverter converter,
            IPropertyAnalyser analyser
        ) : base(dataStore, converter, analyser)
    {
    }
}

interface IGuidConverter : IDomainStorageConverter<GuidStorage, GuidModel, Guid> {}

class GuidConverter : GuidKeyConverter, IGuidConverter
{
    public GuidStorage ToStorage(GuidModel domainModel)
    {
        return new GuidStorage() { Key = domainModel.Key, Value = domainModel.Value };
    }

    public GuidModel ToDomain(GuidStorage storageModel)
    {
        return new GuidModel() { Key = storageModel.Key, Value = storageModel.Value };
    }
}

class GuidKeyConverter : KeyConverter<GuidStorage, Guid>
{
    public GuidKeyConverter() : base(model => model.Key, key => new GuidStorage{Key = key})
    {
    }
}
