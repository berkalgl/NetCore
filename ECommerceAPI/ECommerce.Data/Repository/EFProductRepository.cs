using ECommerce.Data.Data;
using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

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

        public async Task<IList<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetEntity(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null) {
                return null!;
            }
            return product;
        }

        public async Task Update(Product entity)
        {
            _context.Products.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
