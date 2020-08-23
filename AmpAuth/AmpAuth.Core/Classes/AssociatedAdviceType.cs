using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class AssociatedAdviceType
	{
		#region Private fields
		private List<AdviceType> _advice;
		#endregion

		public List<AdviceType> Advice
		{
			get
			{
				return _advice;
			}
			set
			{
				_advice = value;
			}
		}
	}
}