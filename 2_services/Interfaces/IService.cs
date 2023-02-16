using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services.Interfaces
{
    public interface IService<T>
    {
        Task<IEnumerable<T>> GetAll();
        T GetById(int id);
        Task<T>Add(T model);
        void Update(T model);
        void Delete(T model);
        void Search(T model);
    }
}
