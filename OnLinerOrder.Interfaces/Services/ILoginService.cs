using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Services
{
    public interface ILoginService
    {
        Task CreateLoginAsync(Login login);
        Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password);
        Task<IEnumerable<Login>> GetAllLoginsAsync();
    }
}
