using AmpAuth.Repository.Entities;
using AmpAuth.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AmpAuth.Repository.Repositories
{
	public class PolicyRepository : BaseRepository, IPolicyRepository
	{
		public PolicyRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory)
		{
		}

		public List<PolicyEntity> GetAllPolicies()
		{
			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				return context.Policies.ToList();
			}
		}

		public void AddPolicy(PolicyEntity policy)
		{
			using var context = ContextFactory.CreateDbContext(ConnectionString);
			context.Policies.Add(policy);
			context.SaveChanges();
		}
	}
}
