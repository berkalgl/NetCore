using ECommerce.Models;

namespace ECommerce.Services
{
    public interface IProductService
    {
        IEnumerable<ProductViewModel> GetProducts();
    }
}
