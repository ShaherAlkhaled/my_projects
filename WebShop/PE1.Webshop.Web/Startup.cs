using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PE1.Webshop.Web.Data;
using PE1.Webshop.Web.Services;
using PE1.Webshop.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE1.Webshop.Web
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
            services.AddDbContext<WebShopDbContext>(
             options => options
             .UseSqlServer(Configuration.GetConnectionString("WebShopDb"))
             );
            services.AddControllersWithViews();
            services.AddTransient<IFileService, FileService>();

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
                   name: "search",
                   pattern: "/Search/product/{price:decimal}/{categoryName}",
                   defaults: new { Controller = "Search", Action = "ShowProductsByPriceAndCategroy" });
                endpoints.MapControllerRoute(
                   name: "search",
                   pattern: "/Search/Product/{property}/{categoryName}",
                   defaults: new { Controller = "Search", Action = "ShowProductsByCategoryAndProperty" });
                endpoints.MapControllerRoute(
                     name: "search",
                     pattern: "/Search/Products/{brand}/{categoryName}",
                     defaults: new { Controller = "Search", Action = "ShowProductsByCategoryAndBrand" });
                endpoints.MapControllerRoute(
                   name: "Product",
                   pattern: "products/ShowProductDetail/{productId:int}",
                   defaults: new { Controller = "products", Action = "ShowProductDetail" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
