using Microsoft.EntityFrameworkCore;
using Shopping_Tutorial.Models;

namespace Shopping_Tutorial.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context)
        {
			_context.Database.Migrate();
            if (!_context.Products.Any())
            {
                CategoryModel macbook = new CategoryModel{ Name = "Macbook", Description = "For rich kids", slug = "macbook", Status = 1 };
                CategoryModel pc = new CategoryModel { Name = "PC", Description = "Didn't like Apple", slug = "pc", Status = 1 };
                BrandModel apple = new BrandModel { Name = "Apple", Description = "For rich kids", Slug = "apple", Status = 1 };
                BrandModel dell = new BrandModel { Name = "Dell", Description = "Didn't like Apple", Slug = "dell", Status = 1 };

                _context.Products.AddRange(
                    new ProductModel { Name = "Macbook", Slug = "Macbook", Description = "Macbook is best", Image = "1.jpg", Category = macbook, Brand=apple, Price = 1300 },
                    new ProductModel { Name = "PC", Slug = "pc", Description = "Didn't like Apple", Image = "1.jpg", Category = pc, Brand=dell, Price = 1100 }
                );

                _context.SaveChanges();
            }
        }
    }
}
