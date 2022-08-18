using ECommerce.Business.DTOs.Response;
using ECommerce.Data.Repository;
using ECommerce.Entities;

namespace ECommerce.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<int> Create(Product product)
        {
            await productRepository.Create(product);
            return product.Id;
        }

        public async Task<Product> GetProduct(int id)
        {
            return await productRepository.GetEntity(id);
        }

        public async Task<IEnumerable<ProductListResponseDTO>> GetProductLists()
        {
            var products = await productRepository.GetAll();
            var response = products.Select(p => new ProductListResponseDTO
            {
                Id = p.Id,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Name = p.Name,
                Price = p.Price,
            });

            return response;
        }

        public async Task<int> Update(Product product)
        {
            await productRepository.Update(product);
            return product.Id;
        }
    }
}
