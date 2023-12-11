using Microsoft.EntityFrameworkCore;
using Store_Manager.Data;
using Store_Manager.Models;


namespace Store_Manager.Repositories
{
    public class ProductFrequencyRepository
    {
        private readonly MyDbContext _context;

        public ProductFrequencyRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductOrderFrequency>> GetProductFrequenciesAsync()
        {
            return await _context.product_order_frequency.ToListAsync();
        }
        public async Task<ProductOrderFrequency> GetPoFrequencyByIdAsync(int poFrequencyId)
        {
            return await _context.product_order_frequency.FindAsync(poFrequencyId);
        }

        
    }
}
