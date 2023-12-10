using Microsoft.EntityFrameworkCore;
using Store_Manager.Models;
using System.Collections.Generic;

namespace Store_Manager.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Product> product { get; set; }
        public DbSet<Customer> customer { get; set; }
    }
}
