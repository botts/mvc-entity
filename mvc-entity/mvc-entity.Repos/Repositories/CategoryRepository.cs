using mvc_entity.Context;
using mvc_entity.Domain;
using mvc_entity.Repos.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace mvc_entity.Repos.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private BookStoreDataContext _db;

        public CategoryRepository(BookStoreDataContext context)
        {
            _db = context;
        }

        public bool Create(Category category)
        {
            try
            {
                _db.Categorias.Add(category);
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
                var category = _db.Categorias.Find(id);
                if (category != null)
                {
                    _db.Categorias.Remove(category);
                    _db.SaveChanges();

                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

     

        public List<Category> Get()
        {
            return _db.Categorias.ToList();
        }

        public Category Get(int id)
        {
            return _db.Categorias.Find(id);
        }

        public List<Category> GetByName(string name)
        {
            return _db.Categorias.Where(x => x.Nome == name).ToList();
        }

        public bool Update(Category category)
        {
            try
            {
                _db.Entry<Category>(category).State = EntityState.Modified;

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
