using OnLineOrder.Models;
using OnLineOrder.Repositories;
using OnLinerOrder.Interfaces.Repositories;
using OnLinerOrder.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public Task<string> CreateLoginSessionAsync(int loginId, LoginSession loginSession)
        {
           return loginSessionRepository.CreateLoginSessionAsync(loginId, loginSession);
        }
    }
}
