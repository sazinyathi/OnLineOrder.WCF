using OnLineOrder.Models;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Services
{
    public interface ILoginService
    {
        Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password);
    }
}
