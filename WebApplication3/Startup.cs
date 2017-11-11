using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<InsuranceCompany11Context>(options => options.UseSqlServer(connection));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, InsuranceCompany11Context context)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default1",
                template: "ClientGroups",
                defaults: new { controller = "ClientGroups", action = "Index" });

                routes.MapRoute(
                name: "default2",
                template: "Risks",
                defaults: new { controller = "Risks", action = "Index" });

                routes.MapRoute(
                name: "default3",
                template: "Staffs",
                defaults: new { controller = "Staffs", action = "Index" });

                routes.MapRoute(
                name: "default",
               template: "{controller=Home}/{action=Index}/{id?}");
            });

            DbInitializer.Initialize(context);
        }
    }
}
