using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrder.Repository
{
   public class LoginRepository: ILoginRepository
    {
        private readonly OnLineOrderDbContext dbContext;
        public LoginRepository()
        {
          this.dbContext = new OnLineOrderDbContext();
        }


        public async Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password)
        { 
           return dbContext.Login.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }

        public async Task CreateLoginAsync(Login login)
        {
            dbContext.Login.Add(login);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<Login>> GetAllLoginsAsyn()
        {
            return dbContext.Login.ToList();
        }
    }
}
