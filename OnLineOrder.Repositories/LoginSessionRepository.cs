using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrder.Repositories
{
    public class LoginSessionRepository : ILoginSessionRepository
    {
        private readonly OnLineOrderDbContext dbContext;
        public LoginSessionRepository()
        {
            this.dbContext = new OnLineOrderDbContext();
        }

        public async Task<string> CreateLoginSessionAsync(int loginId, LoginSession loginSession)
        {
            try
            {
                loginSession.LoginId = loginId;
                dbContext.LoginSessions.Add(loginSession);
                await dbContext.SaveChangesAsync();
                return loginSession.SessionId;
            }
            catch (Exception exc)
            {
                throw;
            }
        }
    }
}
