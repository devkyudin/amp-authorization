using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AttributeType
	{
		#region Private fields
		private List<AttributeValueType> _attributeValue;
		private string _attributeId;
		private string _issuer;
		private bool _includeInResult;
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

		public bool IncludeInResult
		{
			get
			{
				return _includeInResult;
			}
			set
			{
				_includeInResult = value;
			}
		}
	}
}