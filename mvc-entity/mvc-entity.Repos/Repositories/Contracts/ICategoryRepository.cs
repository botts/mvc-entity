using mvc_entity.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_entity.Repos.Repositories.Contracts
{
    public interface ICategoryRepository : IDisposable
    {
        List<Category> Get();
        Category Get(int id);
        List<Category> GetByName(string name);
        bool Create(Category category);
        bool Update(Category category);
        bool Delete(int id);
    }
}
