using System.Collections.Generic;

namespace Ofl.Search
{
    public class SearchResponse<T>
        where T : class
    {
        public SearchRequest Request { get; set; }

        public IReadOnlyCollection<T> Results { get; set; }
    }
}
