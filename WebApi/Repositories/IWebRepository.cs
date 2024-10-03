using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Repositories
{
    public interface IWebRepository<T> : IDisposable where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllExcludingIds(IEnumerable<int> idsToExclude);
        int Create(T entity);
        int Update(int id, T entity);
        string Delete(int id);
        IEnumerable<T> GetAllWithFields(IEnumerable<string> fields);
        int GetMaxId();
    }
}
