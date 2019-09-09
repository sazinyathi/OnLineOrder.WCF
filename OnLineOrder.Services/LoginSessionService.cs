using OnLineOrder.Models;
using OnLineOrder.Repositories;
using OnLinerOrder.Interfaces.Repositories;
using OnLinerOrder.Interfaces.Services;
using System.Threading.Tasks;

namespace OnLineOrder.Services
{
    public class LoginSessionService : ILoginSessionService
    {
        private readonly ILoginSessionRepository loginSessionRepository;
      
        public LoginSessionService()
        {
            loginSessionRepository = new LoginSessionRepository();
        }
        public async Task<string> CreateLoginSessionAsync(int loginId, LoginSession loginSession)
        {
           return await loginSessionRepository.CreateLoginSessionAsync(loginId, loginSession);
        }

        public async Task<LoginSession> GetLoginSesionBySenssionIdAsync(string sessinonId)
        {
            return await loginSessionRepository.GetLoginSesionBySenssionIdAsync(sessinonId);
        }
    }
}
