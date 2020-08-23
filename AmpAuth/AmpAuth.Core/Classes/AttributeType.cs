using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class AttributeType
	{
		public List<AttributeValueType> AttributeValue { get; set; }

		public string AttributeId { get; set; }

		public string Issuer { get; set; }

		public bool IncludeInResult { get; set; }
	}
}
