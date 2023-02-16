using _2_services.Interfaces;
using _2_services.Models;
using _3_repositories;
using _3_repositories.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AhuviEitan.Controllers
{
    //[EnableCors(origins: "*", methods: "*", headers: "*")]
    //[EnableCorsAttribute(origins: "*", methods: "*", headers: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IService<PersonModel> _service;
        public PersonController(IService<PersonModel> service)
        {
             _service= service;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IEnumerable<PersonModel>> Get()
        {
            return await _service.GetAll();
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<ActionResult<PersonModel>> Post([FromBody] PersonModel model)
        {
            // PersonModel p = new PersonModel(person.FirstName, person.LastName, person.Id, person.BirthDate, person.Gender, person.HMO, person.Children);
            // return await _service.Add(person);
            if (!ModelState.IsValid)
            {
               
                return BadRequest();
            }
            return await _service.Add(new PersonModel()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                HMO = model.HMO,
               // UserId = model.UserId,
                BirthDate = model.BirthDate,
                Gender = model.Gender,
                Children = model.Children


            }); ;
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
