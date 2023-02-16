using _3_repositories.Entities;
using _3_repositories.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Repositories
{
    public class PersonRepository:IRepository<Person>
    {
        IDataSource dataSource;
        public PersonRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public async Task<IEnumerable<Person>> GetAll()
        {
            return await dataSource.PeopleDetails.ToListAsync(); 
        }
        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Person> Add(Person entity)
        {
            
            dataSource.PeopleDetails.Add(entity);
            await dataSource.SaveChangesAsync();
            return entity;
        }
        public void Update(Person model) { }
        public void Delete(Person model) { }
        public void Search(Person model) { }
    }
}
