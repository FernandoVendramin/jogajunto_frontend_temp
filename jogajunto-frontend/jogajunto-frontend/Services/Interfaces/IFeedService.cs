using jogajunto_frontend.Models;
using System.Threading.Tasks;

namespace jogajunto_frontend.Services.Interfaces
{
    public interface IFeedService
    {
        Task<PageFeed> GetFeedsAsync(int page, int items);
    }
}
