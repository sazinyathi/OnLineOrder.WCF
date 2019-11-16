using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OnLineOrder.Repository
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
          
                loginSession.LoginId = loginId;
                dbContext.LoginSessions.Add(loginSession);
                await dbContext.SaveChangesAsync();
                return loginSession.SessionId;
        }

        public async Task<LoginSession> GetLoginSesionBySenssionIdAsync(string sessinonId)
        {
           return dbContext.LoginSessions.Where(x => x.SessionId == sessinonId).Take(1).FirstOrDefault();
        }
    }
}
