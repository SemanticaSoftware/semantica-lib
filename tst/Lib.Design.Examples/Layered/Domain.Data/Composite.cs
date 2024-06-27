using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Data.Repositories;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;
using Semantica.Lib.Tests.Design.Examples.Layered.Storage;
using Semantica.Lib.Tests.Design.Examples.Layered.Storage.Models;
using Semantica.Storage;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain.Data;

class CompositeRepository : RepositoryBase<CompositeStorage, CompositeIsolationModel, CompositeKey>, ICompositeRepository
{
    public CompositeRepository(
        ICompositeDataStore dataStore,
        ICompositeConverter converter,
        IPropertyAnalyser analyser) : base(dataStore, converter, analyser)
    {
    }
}

interface ICompositeConverter : IDomainStorageConverter<CompositeStorage, CompositeIsolationModel, CompositeKey>
{
    
}
class CompositeKeyConverter : IKeyConverter<CompositeStorage, CompositeKey>
{
    public CompositeKey ToKey(CompositeStorage storageModel) 
        => new CompositeKey(new SimpleRootKey(storageModel.SimpleId), (Kind)storageModel.Kind);

    public CompositeStorage ToBlankStorageModel(CompositeKey key) 
        => new CompositeStorage() { SimpleId = key.ForeignKey.Id, Kind = (char)key.Kind};
}

class CompositeConverter : CompositeKeyConverter, ICompositeConverter
{
    public CompositeIsolationModel ToDomain(CompositeStorage storageModel)
    {
        var domainModel = new CompositeIsolationModel() { Key = ToKey(storageModel), Value = storageModel.Value };
        return domainModel;
    }

    public CompositeStorage ToStorage(CompositeIsolationModel domainModel)
    {
        var storageModel = ToBlankStorageModel(domainModel.Key);
        SetStorageProperties(storageModel, domainModel);
        return storageModel;
    }

    public void SetStorageProperties(CompositeStorage storageModel, CompositeIsolationModel domainModel)
    {
        storageModel.Value = domainModel.Value;
    }
}
