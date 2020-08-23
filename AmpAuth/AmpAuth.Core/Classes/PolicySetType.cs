using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class PolicySetType
	{
		public string Description { get; set; }

		public PolicyIssuerType PolicyIssuer { get; set; }

		public DefaultsType PolicySetDefaults { get; set; }

		public TargetType Target { get; set; }

		public object[] Items { get; set; }

		public ItemsChoiceType[] ItemsElementName { get; set; }

		public List<ObligationExpressionType> ObligationExpressions { get; set; }

		public List<AdviceExpressionType> AdviceExpressions { get; set; }

		public string PolicySetId { get; set; }

		public string Version { get; set; }

		public string PolicyCombiningAlgId { get; set; }

		public string MaxDelegationDepth { get; set; }
	}
}
