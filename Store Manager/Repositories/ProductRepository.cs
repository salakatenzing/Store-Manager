using Microsoft.EntityFrameworkCore;
using Store_Manager.Data;
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
        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _context.product.FindAsync(productId); 
        }

        public async Task CreateProductAsync(Product product)
        {
            _context.product.Add(product); 
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product = await GetProductByIdAsync(productId);
            if (product != null)
            {
                _context.product.Remove(product); 
                await _context.SaveChangesAsync();
            }
        }
    }
}
