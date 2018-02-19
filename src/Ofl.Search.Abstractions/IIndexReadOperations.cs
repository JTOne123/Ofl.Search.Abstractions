using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Search
{
    public interface IIndexReadOperations<T>
        where T : class
    {
        Task<SearchResponse<T>> SearchAsync(SearchRequest request, CancellationToken cancellationToken);

        Task<T> GetAsync(IEnumerable<object> ids, CancellationToken cancellationToken);
    }
}
