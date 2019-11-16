using OnLineOrder.Models;
using OnLineOrder.Repository;
using OnLinerOrder.Interfaces.Repositories;
using OnLinerOrder.Interfaces.Services;
using System.Collections.Generic;
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
        public async Task CreateLoginAsync(Login login)
        {
           await loginRepository.CreateLoginAsync(login);
        }

        public async Task<IEnumerable<Login>> GetAllLoginsAsync()
        {
            return await loginRepository.GetAllLoginsAsyn();
        }

        public async Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password)
        {
            return await loginRepository.GetLoginDetailsByUsernameAndPasswordAsync(username, password);
        }
    }
}
