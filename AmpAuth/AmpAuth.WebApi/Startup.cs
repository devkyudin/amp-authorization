using AmpAuth.Repository.Classes;
using AmpAuth.Repository.Interfaces;
using AmpAuth.Repository.Repositories;
using AmpAuth.WebApi.Classes;
using AmpAuth.WebApi.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AmpAuth.WebApi
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
			services.AddControllers();
			services.AddScoped<IRepositoryContextFactory, RepositoryContextFactory>();
			services.AddScoped<IDesignTimeDbContextFactory<RepositoryContext>, DesignTimeRepositoryContextFactory>();
			services.AddScoped<IPolicyRepository>(provider =>
				new PolicyRepository(Configuration.GetConnectionString("DefaultConnection"),
					provider.GetService<IRepositoryContextFactory>()));

			services.AddDbContext<RepositoryContext>(options =>
				options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
			services.AddRazorPages();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseWebpackDevMiddleware();
			}

			app.UseRouting();

			//app.UseAuthorization();
			app.UseStaticFiles();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				endpoints.MapRazorPages();
			});
		}
	}
}
