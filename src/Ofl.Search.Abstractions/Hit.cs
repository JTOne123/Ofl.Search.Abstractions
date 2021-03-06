﻿using System.Collections.Generic;

namespace Ofl.Search
{
    public class Hit<T> where T : class
    {
        public decimal? Score { get; set; }

        public string Id { get; set; }

        public string Index { get; set; }

        public T Item { get; set; }

        public IReadOnlyDictionary<string, IReadOnlyCollection<HighlightOffset>> Highlights { get; set; }
    }
}