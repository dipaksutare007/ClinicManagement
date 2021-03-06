using ClinicManagement.DAL;
using ClinicManagement.EF;
using ClinicManagement.IDAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ClinicManagement.Api", Version = "v1" });
            });

            //services.AddDbContext<ApplicationContext>(opt => opt
            //.UseSqlServer("Server=NAUSHIK; Database=CDB;User Id=sa; Password=smart@123;"));
            //services.AddDbContext<ClinicDAL>(opt => opt
            //.UseSqlServer("Server=DESKTOP-S74O0PP; Database=CDB;User Id=sa; Password=smart@123;"));
            services.AddDbContext<ClinicContext>(item => item.UseSqlServer
                                (Configuration.GetConnectionString("ClinicDBConnection")));
            services.AddScoped<IPatientRepository, PatientRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ClinicManagement.Api v1"));
            }

        

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
