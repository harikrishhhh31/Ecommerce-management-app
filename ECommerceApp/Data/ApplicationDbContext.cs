using ECommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Description = "Electronic devices and accessories" },
                new Category { Id = 2, Name = "Clothing", Description = "Apparel and fashion items" },
                new Category { Id = 3, Name = "Books", Description = "Books, eBooks and educational material" },
                new Category { Id = 4, Name = "Home & Kitchen", Description = "Household and kitchen products" }
            );

            // Seed products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop Pro 15", Description = "High-performance laptop", Price = 89999, StockQuantity = 10, CategoryId = 1, CreatedDate = new DateTime(2024, 1, 1) },
                new Product { Id = 2, Name = "Wireless Headphones", Description = "Noise-cancelling headphones", Price = 4999, StockQuantity = 25, CategoryId = 1, CreatedDate = new DateTime(2024, 1, 2) },
                new Product { Id = 3, Name = "Cotton T-Shirt", Description = "Comfortable everyday t-shirt", Price = 499, StockQuantity = 100, CategoryId = 2, CreatedDate = new DateTime(2024, 1, 3) },
                new Product { Id = 4, Name = "C# Programming Guide", Description = "Learn C# from scratch", Price = 799, StockQuantity = 50, CategoryId = 3, CreatedDate = new DateTime(2024, 1, 4) }
            );
        }
    }
}
