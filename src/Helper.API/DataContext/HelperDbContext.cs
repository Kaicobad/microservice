using Helper.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Helper.API.DataContext
{
    public class HelperDbContext : DbContext
    {
        public HelperDbContext(DbContextOptions<HelperDbContext> options) : base(options) { }



        public virtual void OnModelCreateing(ModelBuilder modelBuilder)
        {
        }

        public DbSet<BrandModel> Brands { get; set; }
    }
}
