using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using W24_TP.Data;
using W24_TP.Models;
namespace W24_TP 
{
    public class Program
    {
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			var connectionString = builder.Configuration.GetConnectionString("W24-TP-Connection") ?? throw new InvalidOperationException("Connection string 'W24-TP' not found.");

			builder.Services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connectionString));

			builder.Services.AddDbContext<W24TpContext>(options =>
				options.UseSqlServer(connectionString));

			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
				.AddRoles<IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>();
			builder.Services.AddControllersWithViews();

			builder.Services.Configure<IdentityOptions>(options =>
			{
				options.Password.RequireDigit = false;
				options.Password.RequiredLength = 1; //https://github.com/dotnet/aspnetcore/issues/25788
				options.Password.RequireLowercase = false;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireUppercase = false;
			});


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
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

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Categories}/{action=Index}/{id?}");
			app.MapRazorPages();

			//using (var scope = app.Services.CreateScope())
			//{
			//	var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			//	var roles = new[] { "Admin", "User" };
			//
			//	foreach (var role in roles)
			//	{
			//		if (!await roleManager.RoleExistsAsync(role))
			//			await roleManager.CreateAsync(new IdentityRole(role));
			//	}
			//}

			app.Run();
		}
	}
}

