using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ofl.Search
{
    public class SearchRequest
    {
        public string Query { get; set; }

        public IReadOnlyCollection<Filter> Filters { get; set; } = new ReadOnlyCollection<Filter>(new List<Filter>());

        public int Skip { get; set; } = 0;

        public int? Take { get; set; }

        public decimal? MinimumScore { get; set; }

        public bool Highlight { get; set; }
    }
}
