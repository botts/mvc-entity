using mvc_entity.Context;
using mvc_entity.Domain;
using mvc_entity.Repos.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace mvc_entity.Repos.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        BookStoreDataContext _db;

        public AuthorRepository(BookStoreDataContext context)
        {
            _db = context;
        }

        public bool Create(Author autor)
        {
            try
            {
                _db.Autores.Add(autor);
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
                var autor = _db.Autores.Find(id);
                _db.Autores.Remove(autor);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Author> Get()
        {
            return _db.Autores.ToList();
        }

        public Author Get(int id)
        {
            return _db.Autores.Find(id);
        }

        public List<Author> GetByName(string name)
        {
            return _db.Autores
                    .Where(x => x.Nome.Contains(name))
                    .ToList();
        }

        public bool Update(Author autor)
        {
            try
            {
                _db.Entry<Author>(autor).State = EntityState.Modified;
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
