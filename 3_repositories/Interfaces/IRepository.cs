using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        T GetById(int id);
        Task<T> Add(T model);
        void Update(T model);
        void Delete(T model);
        void Search(T model);
    }
}
