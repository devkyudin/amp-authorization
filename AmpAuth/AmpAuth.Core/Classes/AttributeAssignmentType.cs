using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AttributeAssignmentType : AttributeValueType
	{
		#region Private fields
		private string _attributeId;
		private string _category;
		private string _issuer;
		#endregion

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