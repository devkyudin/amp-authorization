using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace AmpAuth.Core
{
	public class StatusDetailType
	{
		[XmlAnyElement()]
		public List<XmlElement> Any { get; set; }
	}
}
