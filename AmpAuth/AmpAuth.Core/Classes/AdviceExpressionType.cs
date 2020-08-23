using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class AdviceExpressionType
	{
		public List<AttributeAssignmentExpressionType> AttributeAssignmentExpression { get; set; }

		public string AdviceId { get; set; }

		public EffectType AppliesTo { get; set; }
	}
}
