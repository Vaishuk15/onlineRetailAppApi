namespace OnlineRetailApp.Repository
{
    using Microsoft.EntityFrameworkCore;
    using OnlineRetailApp.Repository.EntityModel;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
