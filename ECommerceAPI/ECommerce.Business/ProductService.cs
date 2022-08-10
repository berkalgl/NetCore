using ECommerce.Business.DTOs.Response;
using ECommerce.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<IEnumerable<ProductListResponseDTO>> GetProductList()
        {
            var products = await _productRepository.GetAll();
            var response = products.Select(p => new ProductListResponseDTO
            {
                Id = p.Id,
                Description = p.Description,
                ImageUrl = p.ImageUrl,
                Name = p.Name,
                Price = p.Price,
                Rating = p.Rating
            });

            throw new NotImplementedException(); ;
        }
    }
}
