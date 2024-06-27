using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Domain.Data.Repositories;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;
using Semantica.Storage;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Data;

class IntUnlayeredRepository
    : RepositoryBase<IntModel, IntModel, int>, IIntRepository
{
    public IntUnlayeredRepository(
            ISimpleDataStore<IntModel, int> dataStore,
            IKeyConverter<IntModel, int> keyConverter,
            IPropertyAnalyser analyser
        ) : base(dataStore, new DomainIsStorageConverter<IntModel, int>(keyConverter), analyser)
    {
    }
}

class IntKeyConverter : KeyConverter<IntModel, int>
{
    public IntKeyConverter() : base(model => model.Key, key => new IntModel{Key = key})
    {
    }
}
