using Semantica.Domain.Repositories;
using Semantica.Lib.Tests.Design.Examples.Keys;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain;

public interface ICompositeUnlayeredRepository : IRepository<CompositeUnlayeredModel, CompositeKey>
{
    
}