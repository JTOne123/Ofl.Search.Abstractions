using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Search
{
    public interface IIndexWriteOperations<in T> : IDisposable
        where T : class
    {
        Task UpsertAsync(IEnumerable<T> source, CancellationToken cancellationToken);
    }
}
