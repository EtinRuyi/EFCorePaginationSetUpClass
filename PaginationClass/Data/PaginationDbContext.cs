using Microsoft.EntityFrameworkCore;
using PaginationClass.Model;

namespace PaginationClass.Data
{
    public class PaginationDbContext : DbContext
    {
        public PaginationDbContext(DbContextOptions<PaginationDbContext> options) : base(options)
        {
        }
        public DbSet<Items> Items { get; set; }
    }
}
