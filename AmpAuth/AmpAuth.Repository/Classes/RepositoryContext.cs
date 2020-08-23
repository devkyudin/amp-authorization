using AmpAuth.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace AmpAuth.Repository.Classes
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
		{
			Database.EnsureCreated();
		}

		public DbSet<PolicyEntity> Policies { get; set; }
	}
}
