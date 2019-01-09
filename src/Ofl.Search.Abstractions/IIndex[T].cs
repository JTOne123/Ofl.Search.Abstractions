using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Search
{
    public interface IIndex<T> : IIndex
        where T : class
    {
        Task<IIndexWriteOperations<T>> GetWriteOperationsAsync<T>(CancellationToken cancellationToken)
            where T : class;

        Task<IIndexReadOperations<T>> GetReadOperationsAsync<T>(CancellationToken cancellationToken)
            where T : class;
    }
}
