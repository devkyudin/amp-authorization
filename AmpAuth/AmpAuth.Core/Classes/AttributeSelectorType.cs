using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AttributeSelectorType : ExpressionType
	{
		#region Private fields
		private string _category;
		private string _requestContextPath;
		private string _dataType;
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

		public string RequestContextPath
		{
			get
			{
				return _requestContextPath;
			}
			set
			{
				_requestContextPath = value;
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