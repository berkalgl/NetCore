using ECommerce.Data;
using ECommerce.Models;

namespace ECommerce.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ECommerceDbContext _dbContext;

        public CategoryService(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.Categories.AsEnumerable();
        }
    }
}
