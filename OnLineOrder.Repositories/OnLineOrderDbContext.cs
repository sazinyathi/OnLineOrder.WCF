using OnLineOrder.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrder.Repositories
{
    public class OnLineOrderDbContext : DbContext
    {

        public OnLineOrderDbContext() : base("OnLineOrderDbContext")
        {

        }
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Product { get; set; }


    }
}
