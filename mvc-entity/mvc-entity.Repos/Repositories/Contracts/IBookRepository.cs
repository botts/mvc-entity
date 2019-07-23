using mvc_entity.Domain;
using System;
using System.Collections.Generic;

namespace mvc_entity.Repos.Repositories.Contracts
{
    public interface IBookRepository : IDisposable
    {
        List<Book> Get();
        Book Get(int id);
        List<Book> GetByName(string name);
        bool Create(Book book);
        bool Update(Book book);
        bool Delete(int id);
    }
}
