using AmpAuth.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AmpAuth.Repository.Classes
{
	public class RepositoryContextFactory : IRepositoryContextFactory
	{
		public RepositoryContext CreateDbContext(string connectionString)
		{
			var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();
			optionsBuilder.UseNpgsql(connectionString);
			return new RepositoryContext(optionsBuilder.Options);
		}
	}
}
