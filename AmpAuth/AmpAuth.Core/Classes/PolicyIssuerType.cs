using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class PolicyIssuerType
	{
		#region Private fields
		private System.Xml.XmlElement _content;
		private List<AttributeType> _attribute;
		#endregion

		[XmlAnyElement(Name = "Content", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-11")]
		public System.Xml.XmlElement Content
		{
			get
			{
				return _content;
			}
			set
			{
				_content = value;
			}
		}

		public List<AttributeType> Attribute
		{
			get
			{
				return _attribute;
			}
			set
			{
				_attribute = value;
			}
		}
	}
}