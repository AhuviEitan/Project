using _3_repositories.Entities;
using _3_repositories.Interfaces;
using _3_repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Person>, PersonRepository>();
            // services.AddScoped<IRepository<Child>, ChildRepository>();
            
            return services;
        }
    }
}
