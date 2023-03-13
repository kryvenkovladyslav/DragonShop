using BusinessLogic.Common;
using BusinessLogic.Infrastructure;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using BusinessLogic.Services;
using Core.Interfaces;
using Core.Stores;
using DataAccess.EntityFramework.MSSQL.Infrastucture;
using DataAccess.EntityFramework.MSSQL.Stores;
using DataAccess.MSSQL.Stores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.ViewModels;

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

            services.AddSingleton<IList<ProductViewModel>, List<ProductViewModel>>();

            services.AddTransient<IFile, File>();
            services.AddTransient<IList<string>, List<string>>();
            services.AddTransient<IDataLoader, XmlDataLoader>();
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer("Server=localhost;Database=DragonShop;Trusted_Connection=True;"));


            services.AddTransient<IProductStore, ProductStore>();
            services.AddTransient<IManufacturerStore, ManufacturerStore>();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IManufacturerService, ManufacturerService>();
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
        }
    }
}
