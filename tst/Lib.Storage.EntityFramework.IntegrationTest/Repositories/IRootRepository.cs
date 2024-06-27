using Semantica.Domain.Repositories;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories;

public interface IRootRepository : IRepository<RootModel, RootKey>
{
        
}