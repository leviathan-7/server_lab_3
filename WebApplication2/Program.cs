using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;


namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PopulateDB();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();


            builder.Services.AddSqlite<WebContext>(
                builder.Configuration.GetConnectionString("Default"));

            builder.Services.AddSingleton(new JsonContext());


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();

        }

        public static void PopulateDB()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var options = new DbContextOptionsBuilder<WebContext>()
                .UseSqlite(config.GetConnectionString("Default"))
                .Options;

            using (var context = new WebContext(options))
            {
                context.Database.EnsureCreated();
                context.Database.Migrate();

                DbInitializer.Initialize(context);

                context.SaveChanges();
            }
        }

    }
}
