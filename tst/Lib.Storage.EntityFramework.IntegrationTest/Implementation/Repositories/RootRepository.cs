using Semantica.Domain.Data.Repositories;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.Converters;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.DataStores;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Implementation.Repositories;

public class RootRepository : RepositoryBase<Root, RootModel, RootKey>, IRootRepository
{
    public RootRepository(
            IRootDataStore dataStore,
            IRootConverter converter,
            IPropertyAnalyser analyser
        ) : base(dataStore, converter, analyser)
    {
    }
}