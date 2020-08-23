using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace AmpAuth.Core
{
	public class AttributeValueType : ExpressionType
	{
		[XmlAnyElement()]
		public List<XmlNode> Any { get; set; }

		public string DataType { get; set; }

		[XmlAnyAttribute()]
		public List<XmlAttribute> AnyAttr { get; set; }
	}
}
