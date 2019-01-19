using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Search
{
    public interface IIndexManager : IDisposable
    {
        Task<IIndex> GetIndexAsync(string name, CancellationToken cancellationToken);

        Task<IReadOnlyCollection<IIndex>> GetIndexesAsync(CancellationToken cancellationToken);

        Task<MultiIndexGetResponse> MultiIndexGetAsync(MultiIndexGetRequest request, CancellationToken cancellationToken);
    }
}
