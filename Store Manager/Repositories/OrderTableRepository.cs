using Microsoft.EntityFrameworkCore;
using Store_Manager.Data;
using Store_Manager.Models;

namespace Store_Manager.Repositories
{
    public class OrderTableRepository

    {
        private readonly MyDbContext _context;
        public OrderTableRepository(MyDbContext context) 
        {
            _context = context;
        }
        public async Task<List<OrderTable>> GetOrderTablesAsync()
        {
            return await _context.ordertable
        .Include(o => o.OrderItems) 
            .ThenInclude(oi => oi.Product)
        .ToListAsync();
        }
    }
}
