﻿using OnLineOrder.Models;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface ILogin
    {
        Task CreateLoginDetailsAsync(int customerId,Login login);
    }
}
