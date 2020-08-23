using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AttributesType
	{
		#region Private fields
		private System.Xml.XmlElement _content;
		private List<AttributeType> _attribute;
		private string _category;
		private string _id;
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

		public string Category
		{
			get
			{
				return _category;
			}
			set
			{
				_category = value;
			}
		}

		public string id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}
	}
}