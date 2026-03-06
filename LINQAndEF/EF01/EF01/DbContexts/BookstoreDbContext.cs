using EF01.Models;
using Microsoft.EntityFrameworkCore;

namespace EF01.DbContexts
{
    internal class BookstoreDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Book>()
                .Property(B => B.Title)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<Book>()
                .Property(B => B.Price)
                .HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Book>()
                .Property(B => B.PublishedDate)
                .IsRequired(false);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
