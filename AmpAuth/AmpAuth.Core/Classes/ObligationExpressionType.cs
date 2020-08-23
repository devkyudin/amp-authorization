using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class ObligationExpressionType
	{
		public List<AttributeAssignmentExpressionType> AttributeAssignmentExpression { get; set; }

		public string ObligationId { get; set; }

		public EffectType FulfillOn { get; set; }
	}
}
