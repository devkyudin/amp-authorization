using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AllOfType
	{
		#region Private fields
		private List<MatchType> _match;
		#endregion

		public List<MatchType> Match
		{
			get
			{
				return _match;
			}
			set
			{
				_match = value;
			}
		}
	}
}