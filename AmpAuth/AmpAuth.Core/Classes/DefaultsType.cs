using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class DefaultsType
	{
		#region Private fields
		private string _item;
		#endregion

		public string Item
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