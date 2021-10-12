using Newtonsoft.Json;

namespace jogajunto_frontend.Models
{
    public class HomeMedia
    {
        public HomeMedia()
        {

        }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }
    }
}
