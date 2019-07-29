using System.Collections.Generic;

namespace mvc_entity.Domain
{
    public class Author
    {
        public Author()
        {
            this.Livros = new List<Book>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Book> Livros { get; set; }
    }
}