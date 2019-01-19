using System.Collections.Generic;

namespace Ofl.Search
{
    public class MultiIndexGetResponse
    {
        public MultiIndexGetRequest Request { get; set; }

        public long? TotalHits { get; set; }

        public IReadOnlyCollection<Hit<object>> Hits { get; set; }
    }
}
