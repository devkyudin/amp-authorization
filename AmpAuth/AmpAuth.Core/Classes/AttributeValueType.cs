using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AttributeValueType : ExpressionType
	{
		#region Private fields
		private List<System.Xml.XmlNode> _any;
		private string _dataType;
		private List<System.Xml.XmlAttribute> _anyAttr;
		#endregion

		[XmlAnyElement()]
		public List<System.Xml.XmlNode> Any
		{
			get
			{
				return _any;
			}
			set
			{
				_any = value;
			}
		}

		public string DataType
		{
			get
			{
				return _dataType;
			}
			set
			{
				_dataType = value;
			}
		}

		[XmlAnyAttribute()]
		public List<System.Xml.XmlAttribute> AnyAttr
		{
			get
			{
				return _anyAttr;
			}
			set
			{
				_anyAttr = value;
			}
		}
	}
}