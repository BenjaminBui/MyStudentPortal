using CongThongTin.Data;
using Microsoft.EntityFrameworkCore;

namespace CongThongTin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            
            // builder.Services.AddDbContext<CongThongTinDbContext>(options => 
            // options.UseSqlServer(builder.Configuration.GetConnectionString("CongThongTinDatabase")));
            
            var connectionString = builder.Configuration.GetConnectionString("CongThongTinDatabase") ??
                                   throw new InvalidOperationException("Connection string 'CongThongTinDatabase' not found.");
            
            builder.Services.AddDbContext<CongThongTinDbContext>(
                options => options.UseSqlServer(
                    connectionString,
                    sqlBuilder => { sqlBuilder.MigrationsAssembly(typeof(CongThongTinDbContext).Assembly.GetName().Name); }
                ));

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
            app.MapRazorPages();
            
            app.Run();
        }
    }
}
