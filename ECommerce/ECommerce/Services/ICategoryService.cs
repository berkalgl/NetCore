using ECommerce.Models;

namespace ECommerce.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
    }
}
