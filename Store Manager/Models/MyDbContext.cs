using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Store_Manager.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> product { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
