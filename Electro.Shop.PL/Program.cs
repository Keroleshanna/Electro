using Electro.Shop.BLL;
using Electro.Shop.BLL.Mapping;
using Electro.Shop.DAL;
using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding;

namespace Electro.Shop.PL
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            #region Added by me

            builder.Services.AddDataAccessL(builder.Configuration);
            builder.Services.AddBusinessLogicL();
            
            #endregion

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();

            // app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{Area=Customer}/{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            // ✅ 3. Seed the data automatically on startup
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();
                await ApplicationDbContextSeeder.SeedAsync(context, services);
            }

            app.Run();
        }
    }
}
