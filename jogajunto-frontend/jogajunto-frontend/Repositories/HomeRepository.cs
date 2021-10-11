using jogajunto_frontend.Models;
using jogajunto_frontend.Repositories.Interfaces;
using RestSharp;
using System.Threading.Tasks;

namespace jogajunto_frontend.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly RestClient _restClient;

        public HomeRepository()
        {
            _restClient = new RestClient(AppSettings.JogaJuntoApiUrl);
        }

        public async Task<Home> GetHomeAsync()
        {
            var request = new RestRequest("api/home", DataFormat.Json);
            var response = await _restClient.GetAsync<Home>(request);

            //var client = new RestClient(response.Media.Banner);
            //var request2 = new RestRequest("/");
            //var teste = client.DownloadData(request2);

            return response;
        }
    }
}
