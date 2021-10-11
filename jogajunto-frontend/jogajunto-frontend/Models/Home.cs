using Newtonsoft.Json;

namespace jogajunto_frontend.Models
{
    public class Home
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("media")]
        public HomeMedia Media { get; set; }
    }
}
