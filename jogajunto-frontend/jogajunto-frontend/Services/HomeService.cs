using jogajunto_frontend.Models;
using jogajunto_frontend.Repositories.Interfaces;
using jogajunto_frontend.Services.Interfaces;
using System.Threading.Tasks;

namespace jogajunto_frontend.Services
{
    public class HomeService : IHomeService
    {
        private readonly IHomeRepository _homeRepository;

        public HomeService(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }

        public async Task<Home> GetHomeAsync()
        {
            return await _homeRepository.GetHomeAsync();
        }
    }
}
