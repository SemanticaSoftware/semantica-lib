using Semantica.Domain.Repositories;
using Semantica.Lib.Tests.Design.Examples.Unlayered.Domain.Models;

namespace Semantica.Lib.Tests.Design.Examples.Unlayered.Domain;

public interface IGuidRepository : IRepository<GuidModel, Guid>
{
    
}