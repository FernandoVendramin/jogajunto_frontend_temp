using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace jogajunto_frontend.Models
{
    public class FeedComment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("post_date")]
        public DateTime Post_date { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("likes")]
        public List<FeedLike> Likes { get; set; }

        [JsonProperty("comments")]
        public List<FeedComment> Comments { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
