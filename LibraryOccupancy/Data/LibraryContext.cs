using LibraryOccupancy.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryOccupancy.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Library> Libraries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seeding: İlk veri ekleme
            modelBuilder.Entity<Library>().HasData(
                new Library
                {
                    Id = 1,
                    LibraryName = "Prof. Dr. Abdulkadir Karahan Kütüphanesi",
                    StudyTableCapacity = 100,
                    StudyTableOccupied = 80,
                    ComputerTableCapacity = 20,
                    ComputerTableOccupied = 0
                }
            );
        }
    }
}
