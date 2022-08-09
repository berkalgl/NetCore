using ECommerce.Models;

namespace ECommerce.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        Product Add(Product product);
        Product Update(Product product);
        void Delete(Product product);
        void Delete(int id);
    }
}
