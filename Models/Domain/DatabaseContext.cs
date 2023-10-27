using Microsoft.EntityFrameworkCore;

namespace BookStore.Models.Domain
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DatabaseContext(DbSet<Genre> genre, DbSet<Author> author, DbSet<Publisher> publisher, DbSet<Book> book)
        {
            Genre = genre;
            Author = author;
            Publisher = publisher;
            Book = book;
        }

        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }


    }
}