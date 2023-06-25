using BookDetailsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookDetailsApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
               
                .HasKey(x=>x.Id); // Adjust the precision and scale according to your needs

            // Other entity configurations

            base.OnModelCreating(modelBuilder);
        }
    }

}
