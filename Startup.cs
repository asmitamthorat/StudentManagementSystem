using Data_Access_Layer.Interface;
using Data_Access_Layer.Service;
using demoCoreWithMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Service_Layer;
using Service_Layer.Interface;
using Service_Layer.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3;

namespace StudentManagementSystem
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
            //services.AddMvc().AddRazorPagesOptions(options => { options.RootDirectory = "/Home"; });
            //services.AddMvc().AddRazorPagesOptions(options =>{ options.Conventions.AddPageRoute("/View", "View");});

            //services.AddMvc().AddRazorPagesOptions(options =>options.Conventions.AddPageRoute("/page1","/testpage.cshtml"));
            //services.AddMvc().AddRazorPagesOptions(options =>options.Conventions.AddPageRoute("/page2", "~/Home/test.cshtml"));
            //services.AddMvc().AddRazorPagesOptions(options =>options.Conventions.AddPageRoute("/page3","/Views/Home/Index"));
            services.AddDbContext<StudentDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("UserDbConnection")));
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IStudentRepo<Student>, StudentRepo<Student>>();
            services.AddScoped<IEmail,Email>();
            //Services.UseCustomServices(services);

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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //Services.UserCustomRouting(app);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(name: "blog",
                   pattern: "test/hello",
                   defaults: new { controller = "Students1", action = "Index" });
            });

      

        }
    }
}
