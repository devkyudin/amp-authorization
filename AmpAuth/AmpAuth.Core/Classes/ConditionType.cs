using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class ConditionType
	{
		#region Private fields
		private ExpressionType _item;
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
	}
}