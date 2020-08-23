using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace AmpAuth.WebApi.Interfaces
{
	public interface IDesignTimeDbContextFactory<out TContext> where TContext : DbContext
	{
		TContext CreateDbContext([NotNull] string[] args);
	}
}
