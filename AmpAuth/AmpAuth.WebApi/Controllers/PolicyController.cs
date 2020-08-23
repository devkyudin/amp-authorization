using AmpAuth.Repository.Entities;
using AmpAuth.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AmpAuth.Core;

namespace AmpAuth.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PolicyController : Controller
	{
		private readonly IPolicyRepository _policyRepository;

		public PolicyController(IPolicyRepository policyRepository)
		{
			_policyRepository = policyRepository;
		}

		[Route("All")]
		[HttpGet]
		public List<PolicyEntity> GetAllPolicies()
		{
			return _policyRepository.GetAllPolicies();
		}

		[Route("AddPolicy")]
		[HttpPost]
		public void AddPolicy([FromBody] PolicyEntity policy)
		{
			var policiTest = new PolicyType();
			_policyRepository.AddPolicy(policy);
		}
	}
}
