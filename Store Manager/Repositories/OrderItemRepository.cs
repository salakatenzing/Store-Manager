using Microsoft.EntityFrameworkCore;
using Store_Manager.Data;
using Store_Manager.Models;

namespace Store_Manager.Repositories
{
    public class OrderItemRepository
    {
        private readonly MyDbContext _context;

        public OrderItemRepository(MyDbContext context)
        {
            _context = context;
        }

      
        public async Task<List<OrderItem>> GetAllOrderItemsAsync()
        {
            return await _context.order_item.ToListAsync();
        }

       
        public async Task<OrderItem> GetOrderItemByIdAsync(int orderItemId)
        {
            return await _context.order_item.FindAsync(orderItemId);
        }

       
        public async Task AddOrderItemAsync(OrderItem orderItem)
        {
            _context.order_item.Add(orderItem);
            await _context.SaveChangesAsync();
        }

       
        public async Task UpdateOrderItemAsync(OrderItem orderItem)
        {
            _context.Entry(orderItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

       
        public async Task DeleteOrderItemAsync(int orderItemId)
        {
            var orderItem = await _context.order_item.FindAsync(orderItemId);
            if (orderItem != null)
            {
                _context.order_item.Remove(orderItem);
                await _context.SaveChangesAsync();
            }
        }
    }
}
