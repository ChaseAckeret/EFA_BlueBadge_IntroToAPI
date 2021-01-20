using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToApi.Models
{
    class SearchResult<T>
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public List<T> Results { get; set; }
    }
}
