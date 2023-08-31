using EFCoreApplication_Model.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCoreApplication_DataAccess.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RNC21JD;Database=EFcore;TrustServerCertificate=True;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book {BookId = Guid.NewGuid() ,Title = "1984", Description = "Antiutopia", Price = 200 }
                );
        }
    }
}
