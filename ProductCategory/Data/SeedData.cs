using ProductCategory.Models;

namespace ProductCategory.Data
{
    public class SeedData
    {
        public static List<Category> Categories = new List<Category>
        {
            new Category { CategoryId = 1, CategoryName = "Electronics" },
            new Category { CategoryId = 2, CategoryName = "Books" }
        };
        public static List<Product> Products = new List<Product>
        {
            new Product { ProductId = 1, ProductName = "Smartphone", ProductPrice = 999.99m, CategoryId = 1 },
            new Product { ProductId = 2, ProductName = "Laptop", ProductPrice = 499.99m, CategoryId = 1 },
            new Product { ProductId = 3, ProductName = "Novel", ProductPrice = 19.99m, CategoryId = 2 },
            new Product { ProductId = 4, ProductName = "Textbook", ProductPrice = 59.99m, CategoryId = 2 }
        };
    }
}
