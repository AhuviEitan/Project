using _2_services.Interfaces;
using _2_services.Models;
using _2_services.ServiceClassas;
using _3_repositories;
using _3_repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace _2_services
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<PersonModel>, PersonService>();
            //services.AddScoped<IService<ChildModel>, ChildService>();

            services.AddSingleton<IDataSource, Context>();
           
            return services;
        }
    }
}