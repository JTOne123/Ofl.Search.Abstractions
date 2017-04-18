using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Search
{
    public interface IIndex : IDisposable
    {
        string Name { get; }

        Task RegenerateAsync(CancellationToken cancellationToken);

        Task CreateAsync(CancellationToken cancellationToken);

        Task DestroyAsync(CancellationToken cancellationToken);

        Task<IIndexWriteOperations<T>> GetWriteOperationsAsync<T>(CancellationToken cancellationToken)
            where T : class;

        Task<IIndexReadOperations<T>> GetReadOperationsAsync<T>(CancellationToken cancellationToken)
            where T : class;
    }
}
