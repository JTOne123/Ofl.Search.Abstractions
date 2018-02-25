using System.Collections.Generic;

namespace Ofl.Search
{
    public class GetResponse<T>
        where T : class
    {
        public GetRequest Request { get; set; }

        public long? TotalHits { get; set; }

        public IReadOnlyCollection<Hit<T>> Hits { get; set; }
    }
}
