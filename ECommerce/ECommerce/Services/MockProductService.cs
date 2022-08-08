using ECommerce.Models;

namespace ECommerce.Services
{
    public class MockProductService : IProductService
    {
        public IEnumerable<ProductViewModel> GetProducts()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel { Id = 3, Name = "Product 3", Description = "Product Description 3", ImageUrl = "https://cdn.dsmcdn.com/ty344/product/media/images/20220225/17/58424250/155631259/1/1_org_zoom.jpg", Price = 1},
                new ProductViewModel { Id = 4, Name = "Product 4", Description = "Product Description 4", ImageUrl = "https://cdn.dsmcdn.com/ty344/product/media/images/20220225/17/58424250/155631259/1/1_org_zoom.jpg", Price = 2}
            };
        }
    }
}
