using Newtonsoft.Json;

namespace jogajunto_frontend.Models
{
    public class FeedLike
    {
        public FeedLike()
        {

        }

        [JsonProperty("user")]
        public string User { get; set; }
    }
}
