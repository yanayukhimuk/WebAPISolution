using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(category => category.Products).WithOne(product => product.Category)
                .HasForeignKey(product => product.CategoryID);
            modelBuilder.Entity<Order>().HasMany(order => order.Products);
            modelBuilder.Entity<Order>().HasOne(order => order.Customer);
            modelBuilder.Entity<Customer>().HasMany(customer => customer.Orders).WithOne(order => order.Customer).HasForeignKey(order => order.CustomerID);
            
        }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;

    }
}
