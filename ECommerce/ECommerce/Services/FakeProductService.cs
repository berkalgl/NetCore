using ECommerce.Models;

namespace ECommerce.Services
{
    public class FakeProductService : IProductService
    {
        public IEnumerable<ProductViewModel> GetProducts()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel { Id = 1, Name = "Product 1", Description = "Product Description 1", ImageUrl = "https://cdn.dsmcdn.com/ty344/product/media/images/20220225/17/58424250/155631259/1/1_org_zoom.jpg", Price = 1},
                new ProductViewModel { Id = 2, Name = "Product 2", Description = "Product Description 2", ImageUrl = "https://cdn.dsmcdn.com/ty344/product/media/images/20220225/17/58424250/155631259/1/1_org_zoom.jpg", Price = 2}
            };
        }
    }
}
