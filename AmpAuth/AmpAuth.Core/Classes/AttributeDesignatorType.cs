using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AttributeDesignatorType : ExpressionType
	{
		#region Private fields
		private string _category;
		private string _attributeId;
		private string _dataType;
		private string _issuer;
		private bool _mustBePresent;
		#endregion

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

		public bool MustBePresent
		{
			get
			{
				return _mustBePresent;
			}
			set
			{
				_mustBePresent = value;
			}
		}
	}
}