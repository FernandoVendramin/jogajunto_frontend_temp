using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

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

        public string HtmlVideo => $"<html><body><iframe style='position:fixed; top:0; left:0; bottom:0; right:0; width:100%; height:100%; border:none; margin:0; padding:0;' src='{(Media.Content.Count() > 0 ? Media.Content[0] : "")}' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe></body></html>";
    }
}
