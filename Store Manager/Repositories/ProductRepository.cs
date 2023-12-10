using Microsoft.EntityFrameworkCore;
using Store_Manager.Models;

namespace Store_Manager.Repositories
{
    public class ProductRepository
    {
        private readonly MyDbContext _context;

        public ProductRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.product.ToListAsync();
        }
    }
}
