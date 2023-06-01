using BibliotecaDipendentiSAC.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaDipendentiSAC.Database
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=LibraryDb;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
