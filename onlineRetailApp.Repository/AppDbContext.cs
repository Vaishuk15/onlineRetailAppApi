using Microsoft.EntityFrameworkCore;
using OnlineRetailApp.Repository.EntityModel;
using System;

namespace OnlineRetailApp.Repository
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


    }

   
}
