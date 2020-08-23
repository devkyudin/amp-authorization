using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class FunctionType : ExpressionType
	{
		#region Private fields
		private string _functionId;
		#endregion

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