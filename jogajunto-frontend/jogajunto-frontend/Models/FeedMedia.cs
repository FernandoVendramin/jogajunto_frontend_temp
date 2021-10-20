using Newtonsoft.Json;
using System.Collections.Generic;

namespace jogajunto_frontend.Models
{
    public class FeedMedia
    {
        public FeedMedia()
        {
            Content = new List<string>();
        }

        [JsonProperty("content")]
        public List<string> Content { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        public bool IsPhoto => Type?.ToLower() == "foto";
    }
}
