using FluentValidation;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System.Reflection;
using Villa_Businesss.Abstract;
using Villa_Businesss.Concrete;
using Villa_DataAccess.Abstract;
using Villa_DataAccess.Context;
using Villa_DataAccess.EntityFramework;
using Villa_DataAccess.Repositories;
using Villa_Entity.Entities;
using Villa_WebUI.Extensions;

namespace Villa_WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddServiceExtensions();
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly()); // mapping registry iþlemi


            // mongo db ile ilgili ayarlarý çektik (appsettings.json)
            var mongoDatabase = new MongoClient(builder.Configuration.GetConnectionString("MongoConnection"))
                .GetDatabase(builder.Configuration.GetSection("DatabaseName").Value);

            builder.Services.AddDbContext<VillaContext>(option =>
            {
                option.UseMongoDB(mongoDatabase.Client,mongoDatabase.DatabaseNamespace.DatabaseName);
            });


            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<VillaContext>();

            builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
