using _3_repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services.Models
{
    public class PersonModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string HMO { get; set; }
        public ICollection<Child> Children { get; set; }
       
    }
}
