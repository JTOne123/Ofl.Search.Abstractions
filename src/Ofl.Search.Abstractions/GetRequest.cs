using System.Collections.Generic;

namespace Ofl.Search
{
    public class GetRequest
    {
        public IReadOnlyCollection<object> Ids { get; set; }

        public int Skip { get; set; } = 0;

        public int? Take { get; set; }
    }
}
