using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class ApplyType : ExpressionType
	{
		#region Private fields
		private string _description;
		private List<ExpressionType> _items;
		private string _functionId;
		#endregion

		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}

		public List<ExpressionType> Items
		{
			get
			{
				return _items;
			}
			set
			{
				_items = value;
			}
		}

		public string FunctionId
		{
			get
			{
				return _functionId;
			}
			set
			{
				_functionId = value;
			}
		}
	}
}