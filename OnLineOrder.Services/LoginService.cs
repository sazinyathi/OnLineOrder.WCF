using OnLineOrder.Models;
using OnLineOrder.Repositories;
using OnLinerOrder.Interfaces.Repositories;
using OnLinerOrder.Interfaces.Services;
using System.Threading.Tasks;

namespace OnLineOrder.Services
{
    public class LoginService: ILoginService
    {
        private readonly ILoginRepository loginRepository;

        public LoginService()
        {
            loginRepository = new LoginRepository();
        }

        public async Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password)
        {
            return await loginRepository.GetLoginDetailsByUsernameAndPasswordAsync(username,password);
        }
    }
}
