using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public static class PrepareDb
    {
        public static void SeedData(ECommerceDbContext dbContext)
        {
            dbContext.Database.Migrate();

            if(!dbContext.Categories.Any())
            {
                var categories = new Category[]
                {
                    new Category{ Name = "Computer"},
                    new Category{ Name = "Outfit"}
                };
                dbContext.Categories.AddRange(categories);
            }

            if (!dbContext.Products.Any())
            {
                var products = new Product[]
                {
                    new Product{ Name = "Dell", CategoryId = 1, Price = 15000, ImageUrl = "https://productimages.hepsiburada.net/s/219/550/110000198851384.jpg"},
                    new Product{ Name = "Jean", CategoryId = 2, Price = 200, ImageUrl = "https://productimages.hepsiburada.net/s/219/550/110000198851384.jpg"}
                };
                dbContext.Products.AddRange(products);
            }

            dbContext.SaveChanges();
        }
    }
}
