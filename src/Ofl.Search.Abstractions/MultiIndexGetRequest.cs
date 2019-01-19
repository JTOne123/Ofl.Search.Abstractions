using System.Linq;

namespace Ofl.Search
{
    public class MultiIndexGetRequest
    {
        public ILookup<string, object> Ids { get; set; }
    }
}
