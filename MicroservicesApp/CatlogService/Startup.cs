using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CatlogService.Databases;

namespace CatlogService
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;

        //}
        //public IConfiguration Configuration { get; }
        //// this method gets called by runtime. Use this method to add services to container 
        //public void ConfigurationServices(IServiceCollection services)
        //{
        //   // string strCon = Environment.GetEnvironmentVariable ("DB_Connection");
        //     string strCon = Configuration.GetConnectionString ("DefaultConnection");
        //    services.AddDbContext<DatabaseContext>(options =>
        //    {
        //        options.UseSqlServer(strCon);

        //    });

        //    services.AddControllers();
        //    services.AddSwaggerGen(c =>
        //    {
        //        c.SwaggerDoc("v1", new OpenApiInfo 
        //        {
        //            Title =
        //            "CatlogService",
        //            Version = "v1"
        //        });

        //    });
        //}
        //// This method gets called by runtime. use this method to configure the Http request pipeline
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        //{
        //    if (env.IsDevelopment()) {
        //        app.UseDeveloperExceptionPage();
        //        app.UseSwagger();
        //        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CatlogService v1"));

        //    }
        //    app.UseRouting();
        //    app.UseAuthorization();
        //    app.UseEndpoints(endpoints =>
        //    {
        //        endpoints.MapControllers();
        //    });

        //}
    }
}
