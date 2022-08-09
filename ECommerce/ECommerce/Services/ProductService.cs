using ECommerce.Data;
using ECommerce.Models;

namespace ECommerce.Services
{
    public class ProductService : IProductService
    {

        private readonly ECommerceDbContext eCommerceDbContext;

        public ProductService(ECommerceDbContext eCommerceDbContext)
        {
            this.eCommerceDbContext = eCommerceDbContext;
        }

        public Product Add(Product product)
        {
            eCommerceDbContext.Products.Add(product);
            eCommerceDbContext.SaveChanges();
            return product;
        }

        public void Delete(Product product)
        {
            eCommerceDbContext.Products.Remove(product);
            eCommerceDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Delete(GetProductById(id));
        }

        public Product GetProductById(int id)
        {
            return eCommerceDbContext.Products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return eCommerceDbContext.Products.ToList();
        }

        public Product Update(Product product)
        {
            eCommerceDbContext.Products.Update(product);
            eCommerceDbContext.SaveChanges();
            return product;
        }
    }
}
