using OnLineOrder.Models;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface ILoginRepository
    {
       
        Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password);
    }
}
