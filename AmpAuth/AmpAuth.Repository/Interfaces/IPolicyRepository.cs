using System.Collections.Generic;
using AmpAuth.Repository.Entities;

namespace AmpAuth.Repository.Interfaces
{
	public interface IPolicyRepository
	{
		List<PolicyEntity> GetAllPolicies();
		void AddPolicy(PolicyEntity policy);
	}
}