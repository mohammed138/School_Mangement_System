using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using School.DataAccess; 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace School.Web
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
            //services.AddDirectoryBrowser();



            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();



            //services.AddAuthorization(options =>
            //{

            //    options.AddPolicy("Admin",
            //        authBuilder =>
            //        {
            //            authBuilder.RequireRole(WC.SuperAdminRole);
            //            authBuilder.RequireRole(WC.TeacherRole);
            //            authBuilder.RequireRole(WC.StudentRole);
            //            authBuilder.RequireRole(WC.ImagePath);
            //        });

            //});



            services.AddIdentity<IdentityUser, IdentityRole>()
                 .AddDefaultTokenProviders().AddDefaultUI()
                 .AddEntityFrameworkStores<ApplicationDbContext>();
                
                


            services.AddControllersWithViews();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

             
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

 


            app.UseEndpoints(endpoints =>
            {
                 
               endpoints.MapAreaControllerRoute(
               name: "Manger",
               areaName: "Manger",
               pattern: "Manger/{controller=Home}/{action=Index}/{id?}");

              endpoints.MapAreaControllerRoute(
              name: "StudentUser",
              areaName: "StudentUser",
              pattern: "StudentUser/{controller=Home}/{action=Index}/{id?}");


              endpoints.MapAreaControllerRoute(
              name: "TeacherUsers",
              areaName: "TeacherUsers",
              pattern: "TeacherUsers/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();

            });


        }
    }
}
