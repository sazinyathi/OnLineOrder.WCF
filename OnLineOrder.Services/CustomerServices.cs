using System;
using System.Threading.Tasks;
using OnLineOrder.Models;
using OnLineOrder.Repository;

namespace OnLineOrder.Services
{
    public class CustomerServices : OnLinerOrder.Interfaces.Repositories.ICustomerServices
    {
        private readonly OnLinerOrder.Interfaces.Repositories.ICustomerRepository customerRepository;
        public CustomerServices()
        {
            customerRepository = new CustomerRepository();
        }
        public async Task<int> CreateCustomerAsync(Customer customer)
        {
            var customerId = await customerRepository.CreateCustomerAsync(customer);
            return customerId;
        }
    }
}
