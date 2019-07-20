using mvc_entity.Context;
using mvc_entity.Domain;
using mvc_entity.Repos.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_entity.Repos.Repositories
{
    public class BookRepository : IBookRepository
    {
        BookStoreDataContext _db;

        public BookRepository(BookStoreDataContext context)
        {
            _db = context;
        }
        public bool Create(Book book)
        {
            try
            {
                _db.Livros.Add(book);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var book = _db.Livros.Find(id);

                if (book != null)
                {
                    _db.Livros.Remove(book);
                    _db.SaveChanges();

                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

      
        public List<Book> Get()
        {
            return _db.Livros.ToList();
        }

        public Book Get(int id)
        {
            return _db.Livros.Find(id);
        }

        public List<Book> GetByName(string name)
        {
            return _db.Livros.Where(x => x.Nome.Contains(name)).ToList();
        }

        public bool Update(Book book)
        {
            try
            {
                _db.Entry<Book>(book).State = EntityState.Modified;
                _db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }

    }
}
