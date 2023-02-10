using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Test_web_1.Models;
using Microsoft.AspNetCore.Identity;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Test_web_1.Views
{
    

        public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddDbContext<ApplicationDbContextClass>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
                services.AddRazorPages();
            
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {

            }

        }
}
