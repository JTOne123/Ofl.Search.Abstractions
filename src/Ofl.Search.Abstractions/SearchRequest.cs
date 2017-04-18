using System.Collections.Generic;

namespace Ofl.Search
{
    public class SearchRequest
    {
        public string Query { get; set; }

        public IDictionary<string, object> Filters { get; } = new Dictionary<string, object>();

        public int Skip { get; set; } = 0;

        public int? Take { get; set; }

        public decimal? MinimumScore { get; set; }
    }
}
