using Microsoft.EntityFrameworkCore;

namespace Order.API.DataContext
{
    public class OrderDbContext :DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options): base(options) { }


        public virtual void OnModelCreateing(ModelBuilder modelBuilder)
        {
        }
    }
}
