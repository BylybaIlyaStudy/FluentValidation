using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.People;
using WebApplication1.Validators;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    Person person10 = new Person { Age = 10 };
                    Person person400 = new Person { Age = 400 };

                    var personValidator = new PersonValidator();

                    var resultsPerson10 = personValidator.Validate(person10);
                    var resultsPerson400 = personValidator.Validate(person400);

                    Student student = new Student { Age = 900, AverageScore = 8, Course = 9 };

                    var resultsStudent = personValidator.Validate(student);

                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
