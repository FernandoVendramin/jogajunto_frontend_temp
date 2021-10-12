using Newtonsoft.Json;
using System.Collections.Generic;

namespace jogajunto_frontend.Models
{
    public class Feed
    {
        public Feed()
        {
            Likes = new List<FeedLike>();
            Comments = new List<FeedComment>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public long Date { get; set; }

        [JsonProperty("comments")]
        public List<FeedComment> Comments { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("media")]
        public FeedMedia Media { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("expiration_date")]
        public string Expiration_date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("likes")]
        public List<FeedLike> Likes { get; set; }
    }
}
