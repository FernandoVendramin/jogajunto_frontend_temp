using Newtonsoft.Json;
using System.Collections.Generic;

namespace jogajunto_frontend.Models
{
    public class PageFeed
    {
        public PageFeed()
        {
            Feeds = new List<Feed>();
        }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }

        [JsonProperty("feeds")]
        public List<Feed> Feeds { get; set; }
    }
}
