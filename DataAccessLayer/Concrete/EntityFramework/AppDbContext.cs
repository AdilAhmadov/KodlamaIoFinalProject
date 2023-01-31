using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace DataAccessLayer.Concrete.EntityFramework
{
    //2300-10000055
    public class AppDbContext : DbContext
    {
        private string connectionString = @"Data Source=ADIL-PC; Database=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public AppDbContext()
        {         
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Order_Detail> Order_Details { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

    }
}
