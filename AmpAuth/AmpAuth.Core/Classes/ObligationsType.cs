using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class ObligationsType
	{
		#region Private fields
		private List<ObligationType> _obligation;
		#endregion

		public List<ObligationType> Obligation
		{
			get
			{
				return _obligation;
			}
			set
			{
				_obligation = value;
			}
		}
	}
}