using _2_services.Interfaces;
using _2_services.Models;
using _3_repositories.Entities;
using _3_repositories.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services.ServiceClassas
{
    public class ChildService/*:*//*IChildService*/
    {

        IRepository<Child> rep;
        IMapper mapper;
        public ChildService(IRepository<Child> _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        public ChildModel Add(ChildModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ChildModel model)
        {
            throw new NotImplementedException();
        }

        public ChildModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<ChildModel> GetAll()
        {
            IEnumerable<Child> list = (IEnumerable<Child>)rep.GetAll();
            ICollection<ChildModel> listToReturn = new List<ChildModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<ChildModel>(item));
            }
            return listToReturn;
        }

        public void Search(ChildModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(ChildModel model)
        {
            throw new NotImplementedException();
        }
    }
}
