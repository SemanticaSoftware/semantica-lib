﻿using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;
using Semantica.Storage.DataStores;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.DataStores;

public interface IRootDataStore : IDataStore<Root, RootKey>
{
}