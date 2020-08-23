using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class RequestType
	{
		public List<RequestDefaultsType> RequestDefaults { get; set; }

		public List<AttributesType> Attributes { get; set; }

		public AttributesReferenceType[][][] MultiRequests { get; set; }

		public bool ReturnPolicyIdList { get; set; }
	}
}
