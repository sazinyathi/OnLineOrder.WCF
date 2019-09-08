using OnLineOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Services
{
   public interface ILoginService
    {
        Task<Login> GetLoginDetailsByUsernameAndPasswordAsync(string username, string password);
    }
}
