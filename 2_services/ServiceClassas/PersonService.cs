using _2_services.Interfaces;
using _2_services.Models;
using _3_repositories;
using _3_repositories.Entities;
using _3_repositories.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services.ServiceClassas
{
    public class PersonService:IService<PersonModel>
    {
       
        IRepository<Person> rep;
        IMapper mapper;
        public PersonService(IRepository<Person> _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        public async Task<PersonModel> Add(PersonModel model)
        {
            //return mapper.Map<PersonModel>(rep.Add(mapper.Map<Person>(model)));
            Person p = mapper.Map<Person>(model);
            return mapper.Map<PersonModel>(rep.Add(p));
        }

        public void Delete(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public PersonModel GetById(int id)
        {
            throw new NotImplementedException();
        }
      
        public async Task<IEnumerable<PersonModel>> GetAll()
        {
            //return _mapper.Map<List<ExercizeDTO>>(await _IDataRepository.GetAllAsync());
            return mapper.Map<IEnumerable<PersonModel>>(await rep.GetAll());
            //ICollection<Person> list = rep.GetAll();
            //ICollection<PersonModel> listToReturn = new List<PersonModel>();
            //foreach (var item in list)
            //{
            //    listToReturn.Add(mapper.Map<PersonModel>(item));
            //}
            //return listToReturn;
        }

        public void Search(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public void Update(PersonModel model)
        {
            throw new NotImplementedException();
        }

    }
}
