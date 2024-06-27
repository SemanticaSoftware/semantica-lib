using Semantica.Domain.Repositories;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Layered.Domain.Models;

namespace Semantica.Lib.Tests.Design.Examples.Layered.Domain;

public interface ICompositeRepository : IRepository<CompositeIsolationModel, CompositeKey>
{
    
}
