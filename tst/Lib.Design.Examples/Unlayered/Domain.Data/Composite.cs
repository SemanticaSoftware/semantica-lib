using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Data.Repositories;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Storage;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Data;

class CompositeUnlayeredRepository
    : RepositoryBase<CompositeUnlayeredModel, CompositeUnlayeredModel, CompositeKey>, ICompositeUnlayeredRepository
{
    public CompositeUnlayeredRepository(
            IDataStore<CompositeUnlayeredModel, CompositeKey> dataStore,
            IKeyConverter<CompositeUnlayeredModel, CompositeKey> keyConverter,
            IPropertyAnalyser analyser
        ) : base(dataStore, new DomainIsStorageConverter<CompositeUnlayeredModel, CompositeKey>(keyConverter), analyser)
    {
    }
}

class UnlayeredCompositeKeyConverter : KeyConverter<CompositeUnlayeredModel, CompositeKey>
{
    public UnlayeredCompositeKeyConverter() : base(model => model.Key, key => new CompositeUnlayeredModel{Key = key})
    {
    }
}
