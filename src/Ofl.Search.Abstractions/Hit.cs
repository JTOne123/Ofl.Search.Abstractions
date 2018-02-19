using System.Collections.Generic;

namespace Ofl.Search
{
    public class Hit<T> where T : class
    {
        public decimal? Score { get; set; }

        public T Item { get; set; }

        public IReadOnlyDictionary<string, IReadOnlyCollection<HighlightOffset>> Highligts { get; set; }
    }
}