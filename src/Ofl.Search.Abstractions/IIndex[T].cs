using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Search
{
    public interface IIndex<T> : IIndex
        where T : class
    {
        Task<IIndexWriteOperations<T>> GetWriteOperationsAsync(CancellationToken cancellationToken);

        Task<IIndexReadOperations<T>> GetReadOperationsAsync(CancellationToken cancellationToken);
    }
}
