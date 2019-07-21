using System;
using System.Collections.Generic;

namespace mvc_entity.Domain
{
    public class Book
    {
        public Book()
        {
            this.Autores = new List<Author>();
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string ISBN { get; set; }
        public DateTime DataLancamento { get; set; }
        public int CategoriaId { get; set; }
        public Category Categoria { get; set; }
        public ICollection<Author> Autores { get; set; }
    }
}
