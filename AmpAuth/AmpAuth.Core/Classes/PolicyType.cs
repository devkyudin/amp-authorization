using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class PolicyType
	{
		public string Description { get; set; }

		public PolicyIssuerType PolicyIssuer { get; set; }

		public DefaultsType PolicyDefaults { get; set; }

		public TargetType Target { get; set; }

		public List<object> Items { get; set; }

		public List<ObligationExpressionType> ObligationExpressions { get; set; }

		public List<AdviceExpressionType> AdviceExpressions { get; set; }

		public string PolicyId { get; set; }

		public string Version { get; set; }

		public string RuleCombiningAlgId { get; set; }

		public string MaxDelegationDepth { get; set; }
	}
}
