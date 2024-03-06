using Microsoft.EntityFrameworkCore;

namespace Product.API.Context
{
    public class ProductDbContext :DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) :base(options) 
        {
            
        }

        public virtual void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
