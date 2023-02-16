using _3_repositories.Entities;
using _3_repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Repositories
{
    public class ChildRepository/*:IChildRepository*/
    {
        IDataSource dataSource;
        public ChildRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        //public ICollection<Child> GetAll()
        //{
        //    return dataSource.ChildrenDetails.ToList(); 
        //}
        public Child GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Child Add(Child model)
        {
            throw new NotImplementedException();
        }
        public void Update(Child model) { }
        public void Delete(Child model) { }
        public void Search(Child model) { }
    }
}
