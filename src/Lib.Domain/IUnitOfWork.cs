using System.Threading;
using System.Threading.Tasks;

namespace Semantica.Domain;

public interface IUnitOfWork : IDisposable
{
    Task CompleteAsync(CancellationToken cancellationToken = default);
}
