using jogajunto_frontend.Models;
using jogajunto_frontend.Repositories.Interfaces;
using jogajunto_frontend.Services.Interfaces;
using System.Threading.Tasks;

namespace jogajunto_frontend.Services
{
    public class FeedService : IFeedService
    {
        private readonly IFeedRepository _feedRepository;

        public FeedService(IFeedRepository feedRepository)
        {
            _feedRepository = feedRepository;
        }

        public async Task<PageFeed> GetFeedsAsync(int page, int items)
        {
            return await _feedRepository.GetFeedsAsync(page, items);
        }
    }
}
