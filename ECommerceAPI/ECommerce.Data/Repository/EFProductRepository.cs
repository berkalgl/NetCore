using ECommerce.Data.Data;
using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Repository
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ECommerceDbContext _context;

        public EFProductRepository(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product entity)
        {
            _context.Products.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            return _context.Products.AsEnumerableAsync();
        }

        public async Task Update(Product entity)
        {
            _context.Products.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
