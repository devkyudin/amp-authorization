using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class RuleType
	{
		public string Description { get; set; }

		public TargetType Target { get; set; }

		public ConditionType Condition { get; set; }

		public List<ObligationExpressionType> ObligationExpressions { get; set; }

		public List<AdviceExpressionType> AdviceExpressions { get; set; }

		public string RuleId { get; set; }

		public EffectType Effect { get; set; }
	}
}
