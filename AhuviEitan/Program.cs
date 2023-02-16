using _2_services;
//using _2_services.Interfaces;
//using _2_services.Models;
//using _2_services.ServiceClassas;
//using _3_repositories.Entities;

//using _3_repositories.Interfaces;
//using _3_repositories.Repositories;
//using Microsoft.Extensions.Options;
//using Nest;

namespace AhuviEitan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            

        
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyCorsPolicy", builder =>
                                     builder.WithOrigins("*")
                                            .AllowAnyMethod()
                                            .AllowAnyHeader());
            });
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddService();
            var app = builder.Build();
            
           

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors("MyCorsPolicy");
            app.UseStaticFiles();

            app.UseAuthorization();


            app.MapControllers();
            

            app.Run();
        }
       
    }
}