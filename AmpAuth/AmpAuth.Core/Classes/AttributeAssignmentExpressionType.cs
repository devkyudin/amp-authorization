using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AttributeAssignmentExpressionType
	{
		#region Private fields
		private ExpressionType _item;
		private string _attributeId;
		private string _category;
		private string _issuer;
		#endregion

		public ExpressionType Item
		{
			get
			{
				return _item;
			}
			set
			{
				_item = value;
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