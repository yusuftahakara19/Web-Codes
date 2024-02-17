using FirstApp.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
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
            services.AddRazorPages();
            services.AddControllersWithViews(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();
         //   app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                        name :"areas",
                        pattern:"{Area}/{Controller=Home}/{Action=Index}/{id?}"
                    );

                endpoints.MapControllerRoute(
                        name:"default",
                        pattern:"{Controller}/{Action}/{id?}",
                        defaults : new {Controller = "Home", Action = "Index"}
                    );
            }); 
            //app.UseMiddleware<ResponseEditingMiddleware>();    
            //app.UseMiddleware<RequestEditingMiddleware>();
            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
        }
    }
}
