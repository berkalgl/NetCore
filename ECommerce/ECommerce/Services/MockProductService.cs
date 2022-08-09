using ECommerce.Models;

namespace ECommerce.Services
{
    public class MockProductService : IProductService
    {
        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            return new Product { Id = 3, Name = "Product 3", Description = "Product Description 3", ImageUrl = "https://cdn.dsmcdn.com/ty344/product/media/images/20220225/17/58424250/155631259/1/1_org_zoom.jpg", Price = 1 };
        }

        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 3, Name = "Product 3", Description = "Product Description 3", ImageUrl = "https://cdn.dsmcdn.com/ty344/product/media/images/20220225/17/58424250/155631259/1/1_org_zoom.jpg", Price = 1},
                new Product { Id = 4, Name = "Product 4", Description = "Product Description 4", ImageUrl = "https://cdn.dsmcdn.com/ty344/product/media/images/20220225/17/58424250/155631259/1/1_org_zoom.jpg", Price = 2}
            };
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
