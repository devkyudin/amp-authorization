using System.Collections.Generic;

namespace AmpAuth.Core
{
	public class MissingAttributeDetailType
	{
		public List<AttributeValueType> AttributeValue { get; set; }

		public string Category { get; set; }

		public string AttributeId { get; set; }

		public string DataType { get; set; }

		public string Issuer { get; set; }
	}
}
