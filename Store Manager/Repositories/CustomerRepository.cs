using Microsoft.EntityFrameworkCore;
using Store_Manager.Data;
using Store_Manager.Models;

namespace Store_Manager.Repositories
{
    public class CustomerRepository
    {
        private readonly MyDbContext _context;

        public CustomerRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _context.customer.ToListAsync();
        }
        public async Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            return await _context.customer.FindAsync(customerId); 
        }

        public async Task CreateCustomerAsync(Customer customer)
        {
            _context.customer.Add(customer); 
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCustomerAsync(int customerId)
        {
            var customer = await GetCustomerByIdAsync(customerId);
            if (customer != null)
            {
                _context.customer.Remove(customer); 
                await _context.SaveChangesAsync();
            }
        }

    }
}
