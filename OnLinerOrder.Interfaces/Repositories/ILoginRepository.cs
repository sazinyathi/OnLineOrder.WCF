using OnLineOrder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface ILoginRepository
    {
        Task CreateLoginAsync(Login login);
        Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password);
        Task<IEnumerable<Login>> GetAllLoginsAsyn();
    }
}
