using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Name One", Description = "Description One" },
                new Category { Id = 2, Name = "Name Two", Description = "Description Two" },
                new Category { Id = 3, Name = "Name Three", Description = "Description Three" });
        }

        public DbSet<Category> Categories { get; set; }
    }
}
