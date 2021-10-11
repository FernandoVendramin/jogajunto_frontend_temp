using jogajunto_frontend.Models;
using System.Threading.Tasks;

namespace jogajunto_frontend.Repositories.Interfaces
{
    public interface IHomeRepository
    {
        Task<Home> GetHomeAsync();
    }
}
