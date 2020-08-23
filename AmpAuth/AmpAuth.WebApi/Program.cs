using AmpAuth.Repository.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace AmpAuth.WebApi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args).Build();
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json"); //1
			var config = builder.Build(); // 1

			using (var scope = host.Services.CreateScope()) //2
			{
				var services = scope.ServiceProvider;

				var factory = services.GetRequiredService<IRepositoryContextFactory>();

				factory.CreateDbContext(config.GetConnectionString("DefaultConnection")).Database.Migrate(); // 3
			}

			host.Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
