using Semantica.Domain.Data.DomainStorageConverters;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Entities;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Domain.Keys;
using Semantica.Lib.Tests.Storage.EntityFramework.Test.Storage.Tables;

namespace Semantica.Lib.Tests.Storage.EntityFramework.Test.Repositories.Converters;

public interface ISimpleDependentConverter : IDomainStorageConverter<SimpleDependent, SimpleDependentModel, SimpleDependentKey>
{
        
}