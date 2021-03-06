﻿using OnLineOrder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnLinerOrder.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
        Task<IEnumerable<Product>> GetAllProductAsync();
        Task<Product> GetProductIDAsync(int id);
        Task UpdateProductAsync(Product updatedEvent);
        Task DeleteProductAsync(int id);


    }
}
