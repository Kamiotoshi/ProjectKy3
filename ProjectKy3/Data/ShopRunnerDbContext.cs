using Microsoft.EntityFrameworkCore;
using ProjectKy3.Models;

namespace ProjectKy3.Data
{
    public class ShopRunnerDbContext : DbContext
    {
        public ShopRunnerDbContext(DbContextOptions<ShopRunnerDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
