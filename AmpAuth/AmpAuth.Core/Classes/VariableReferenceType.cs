using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class VariableReferenceType : ExpressionType
	{
		#region Private fields
		private string _variableId;
		#endregion

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