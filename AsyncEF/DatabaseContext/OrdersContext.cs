using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AsyncEF.DatabaseContext
{
    public class OrdersContext : DbContext
    {
        public DbSet<Client>   Clients      { get; set; }
        public DbSet<Customer> Customers    { get; set; }
        public DbSet<Item>     Items        { get; set; }
        public DbSet<Order>    Orders       { get; set; }

        public OrdersContext()
        {
            Database.EnsureCreated();
        }

        public OrdersContext(DbContextOptions<OrdersContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=OrdersDB;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasAlternateKey(alKey => new { alKey.CustomerId, alKey.CustomerName })
                .HasName("CustomerKey");

            base.OnModelCreating(modelBuilder);
        }
    }
}
