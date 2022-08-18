using ECommerce.Data.Data;
using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;

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
            return await _context.Products.ToListAsync(); ;
        }

        public async Task<Product> GetEntity(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(Product entity)
        {
            _context.Products.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
