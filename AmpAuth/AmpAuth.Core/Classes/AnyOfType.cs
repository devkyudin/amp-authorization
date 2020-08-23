using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AnyOfType
	{
		#region Private fields
		private List<AllOfType> _allOf;
		#endregion

		public List<AllOfType> AllOf
		{
			get
			{
				return _allOf;
			}
			set
			{
				_allOf = value;
			}
		}
	}
}