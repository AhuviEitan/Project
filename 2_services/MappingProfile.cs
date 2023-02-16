using _2_services.Models;
using _3_repositories.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonModel>().ReverseMap();
            CreateMap<Child, ChildModel>().ReverseMap();
        }
    }
}
