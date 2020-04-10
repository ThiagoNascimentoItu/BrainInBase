using BrainInBaseApi.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace BrainInBaseApi
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
            //Conexão com o banco de dados SQL
            services.AddDbContext<BrainInBaseContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("BrainSqlConnection"));
            });

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "Brain In Base Api", Version = "v1"});
            });

            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","BrainInBase");
            });


            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
