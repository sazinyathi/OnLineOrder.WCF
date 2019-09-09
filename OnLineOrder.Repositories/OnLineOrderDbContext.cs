﻿using OnLineOrder.Models;
using System.Data.Entity;

namespace OnLineOrder.Repositories
{
    public class OnLineOrderDbContext : DbContext
    {

        public OnLineOrderDbContext()   
        {

        }
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<LoginSession> LoginSessions { get; set; }


    }
}