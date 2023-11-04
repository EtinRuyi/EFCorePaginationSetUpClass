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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Items>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //        entity.Property(e => e.Name).IsRequired();
        //    });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
