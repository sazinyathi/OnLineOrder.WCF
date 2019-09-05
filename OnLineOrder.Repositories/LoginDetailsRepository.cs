using OnLineOrder.Models;
using OnLinerOrder.Interfaces.Repositories;
using System.Threading.Tasks;

namespace OnLineOrder.Repositories
{
    public class LoginDetailsRepository : ILogin
    {
        private readonly OnLineOrderDbContext dbContext;
        public LoginDetailsRepository()
        {
            this.dbContext = new OnLineOrderDbContext();
        }

        public async Task CreateLoginDetailsAsync(int customerId, Login login)
        {
            try
            {
                login.CustomerId = customerId;
                dbContext.Login.Add(login);
                await dbContext.SaveChangesAsync();
            }
            catch (System.Exception exc)
            {
                throw;
            }
        }
    }
}
