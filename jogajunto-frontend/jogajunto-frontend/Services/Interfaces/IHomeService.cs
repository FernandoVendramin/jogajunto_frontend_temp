using jogajunto_frontend.Models;
using System.Threading.Tasks;

namespace jogajunto_frontend.Services.Interfaces
{
    public interface IHomeService
    {
        Task<Home> GetHomeAsync();
    }
}
