using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class TargetType
	{
		#region Private fields
		private List<AnyOfType> _anyOf;
		#endregion

		public List<AnyOfType> AnyOf
		{
			get
			{
				return _anyOf;
			}
			set
			{
				_anyOf = value;
			}
		}
	}
}