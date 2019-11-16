using OnLineOrder.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
namespace OnLineOrder.Repository
{
    public class OnLineOrderDbContext: DbContext
    {
        public OnLineOrderDbContext() :
         base(new SQLiteConnection()
         {
             ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = @"C:\Users\nyathiss\Desktop\My File\BVC\Test23.db", ForeignKeys = true }.ConnectionString
         }, true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<LoginSession> LoginSessions { get; set; }

    }
}
