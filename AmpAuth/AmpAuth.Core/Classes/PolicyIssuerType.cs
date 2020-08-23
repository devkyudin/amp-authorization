using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace AmpAuth.Core
{
	public class PolicyIssuerType
	{
		[XmlAnyElement(Name = "Content", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
		public XmlElement Content { get; set; }

		public List<AttributeType> Attribute { get; set; }
	}
}
