using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration.Json;
using System.Data.SqlClient;
using Kaliber.Models;
using Kaliber.Repository;
using Kaliber.Interfaces;

namespace Kaliber
{
    public class Startup
    {
        public List<Book> books { get; private set; }
        public IConfiguration configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
            // GetAllBooks();
        }

        public void GetAllBooks()
        {
            string connectionstring = configuration.GetConnectionString("KaliberConnStr");

            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Ebooks";
            books = (List<Book>)cmd.ExecuteScalar();
            cmd.Dispose();
        }

       
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddScoped<IRegisterRepository, RegisterRepositiory>();

            services.AddMvc();

            // Add application services.

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
