using backend.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options){}

        public DbSet<Product> Products { get; set; }
    }
}