using Data_Access_Layer.Interface;
using Data_Access_Layer.Service;
using demoCoreWithMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Service_Layer.Interface;
using Service_Layer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public  static class Services
    {
        //public static void UseCustomServices( IServiceCollection services) 
        //{
        //    services.AddScoped<IStudentService, StudentService>();
        //    services.AddScoped<IStudentRepo, StudentRepo>();
        //}


        //public static void UseCustomServices(IServiceCollection services)
        //{

        //    services.AddScoped<IStudentService, StudentService>();
        //    services.AddScoped<IStudentRepo<Student>, StudentRepo<Student>>();
        //}


        //public static void UserCustomRouting(IApplicationBuilder app) 
        //{
        //    app.UseEndpoints(endpoints =>
        //    {
        //        endpoints.MapControllers();
        //        endpoints.MapRazorPages();
        //        endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
        //        // endpoints.MapControllerRoute(name: "custom",pattern:"{}/{}/{}")
        //        //endpoints.MapPageRoute("Business", "business", "~/Pages/business.aspx");

        //    });



          

        //}
    }







}
