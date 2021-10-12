using jogajunto_frontend.Models;
using jogajunto_frontend.Repositories.Interfaces;
using RestSharp;
using System.Threading.Tasks;

namespace jogajunto_frontend.Repositories
{
    public class FeedRepository : IFeedRepository
    {
        private readonly RestClient _restClient;

        public FeedRepository()
        {
            _restClient = new RestClient(AppSettings.JogaJuntoApiUrl);
        }

        public async Task<PageFeed> GetFeedsAsync(int page, int items)
        {
            var request = new RestRequest("api/feeds", DataFormat.Json);
            var response = await _restClient.GetAsync<PageFeed>(request);

            return response;
        }
    }
}
