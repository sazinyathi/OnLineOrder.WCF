using OnLineOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
   public interface ILoginSessionRepository
    {
        Task<string> CreateLoginSessionAsync(int loginId, LoginSession loginSession);
        Task<LoginSession> GetLoginSesionBySenssionIdAsync(string sessinonId);
    }
}
