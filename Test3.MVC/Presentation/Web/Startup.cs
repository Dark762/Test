using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TestDDD.Application.Main.Interfaces;
using TestDDD.Application.Main.Services;
using TestDDD.Domain.Core;
using TestDDD.Domain.Interfaces.Repositories;
using TestDDD.Domain.Interfaces.Services;
using TestDDD.Infraestructure.Data;
using TestDDD.Infraestructure.Data.Repositories;
using WebApplication.Extensions;


namespace Web
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
            services.AddControllersWithViews();

            services.AddSingleton(typeof(IClienteAppService), typeof(ClienteAppService));
            services.AddSingleton(typeof(IClienteService), typeof(ClienteService));
            services.AddSingleton(typeof(IClienteAppService), typeof(ClienteAppService));
            services.AddSingleton(typeof(IClienteRepository), typeof(ClienteRepository));


            services.AddClassesAsImplementedInterface(Assembly.GetEntryAssembly(), typeof(IBaseAppService<>));
            services.AddClassesAsImplementedInterface(Assembly.GetEntryAssembly(), typeof(IBaseService<>));
            services.AddClassesAsImplementedInterface(Assembly.GetEntryAssembly(), typeof(BaseAppService<>));
            services.AddClassesAsImplementedInterface(Assembly.GetEntryAssembly(), typeof(IBaseRepository<>));

            services.AddLazyResolution();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var client = new ContextData())
            {
                client.Database.EnsureCreated();
            }


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();



            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Cliente}/{action=Index}/{id?}");
            });
        }
    }
}
