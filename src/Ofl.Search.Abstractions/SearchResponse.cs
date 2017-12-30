using System.Collections.Generic;

namespace Ofl.Search
{
    public class SearchResponse<T>
        where T : class
    {
        public SearchRequest Request { get; set; }

        public decimal? MaximumScore { get; set; }

        public long? TotalHits { get; set; }

        public IReadOnlyCollection<Hit<T>> Hits { get; set; }
    }
}
