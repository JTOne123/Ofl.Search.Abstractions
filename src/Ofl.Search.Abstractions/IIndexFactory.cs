using System.Collections.Generic;

namespace Ofl.Search
{
    public interface IIndexFactory
    {
        IReadOnlyCollection<IIndex> CreateIndices();
    }
}
