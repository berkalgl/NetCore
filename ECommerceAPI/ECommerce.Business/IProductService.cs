using ECommerce.Business.DTOs.Request;
using ECommerce.Business.DTOs.Response;
using ECommerce.Entities;

namespace ECommerce.Business
{
    public interface IProductService
    {
        Task<IEnumerable<ProductListResponseDTO>> GetProductLists();
        Task<int> Create(ProductRequestDTO product);
        Task<Product> GetProduct(int id);
        Task<int> Update(ProductRequestDTO product);
    }
}
