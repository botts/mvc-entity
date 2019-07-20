using mvc_entity.Domain;
using mvc_entity.Mapping;
using System.Data.Entity;

namespace mvc_entity.Context
{
    public class BookStoreDataContext : DbContext
    {
        public BookStoreDataContext() : base("BookStoreConnectionString")
        {

        }
        public DbSet<Author> Autores { get; set; }
        public DbSet<Category> Categorias { get; set; }
        public DbSet<Book> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new BookMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }

    }
}