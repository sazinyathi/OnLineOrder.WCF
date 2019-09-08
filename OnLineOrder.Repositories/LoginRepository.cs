using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace OnLineOrder.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly OnLineOrderDbContext dbContext;
        public LoginRepository()
        {
            this.dbContext = new OnLineOrderDbContext();
        }

        
        public async Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password)
        {
            try
            {
                return dbContext.Login.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            }
            catch (System.Exception)
            {

                throw;
            }
           
        }

    }
}
