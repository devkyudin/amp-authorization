using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class ResultType
	{
		public DecisionType Decision { get; set; }

		public StatusType Status { get; set; }

		public List<ObligationType> Obligations { get; set; }

		public List<AdviceType> AssociatedAdvice { get; set; }

		public List<AttributesType> Attributes { get; set; }

		public List<PolicyIdentifierType> PolicyIdentifierList { get; set; }
	}
}
