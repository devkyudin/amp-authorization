using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class MissingAttributeDetailType
	{
		#region Private fields
		private List<AttributeValueType> _attributeValue;
		private string _category;
		private string _attributeId;
		private string _dataType;
		private string _issuer;
		#endregion

		public List<AttributeValueType> AttributeValue
		{
			get
			{
				return _attributeValue;
			}
			set
			{
				_attributeValue = value;
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

		public string AttributeId
		{
			get
			{
				return _attributeId;
			}
			set
			{
				_attributeId = value;
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

		public string Issuer
		{
			get
			{
				return _issuer;
			}
			set
			{
				_issuer = value;
			}
		}
	}
}