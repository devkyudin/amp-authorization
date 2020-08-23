using AmpAuth.Repository.Classes;

namespace AmpAuth.Repository.Interfaces
{
	public interface IRepositoryContextFactory
	{
		RepositoryContext CreateDbContext(string connectionString);
	}
}