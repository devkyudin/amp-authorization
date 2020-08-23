using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class VariableDefinitionType
	{
		#region Private fields
		private ExpressionType _item;
		private string _variableId;
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

		public string VariableId
		{
			get
			{
				return _variableId;
			}
			set
			{
				_variableId = value;
			}
		}
	}
}