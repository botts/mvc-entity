using mvc_entity.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_entity.Repos.Repositories.Contracts
{
    public interface IAuthorRepository : IDisposable
    {
        List<Author> Get();
        Author Get(int id);
        List<Author> GetByName(string name);
        bool Create(Author autor);
        bool Update(Author autor);
        bool Delete(int id);
    }
}
