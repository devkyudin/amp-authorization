using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class CombinerParametersType
	{
		#region Private fields
		private List<CombinerParameterType> _combinerParameter;
		#endregion

		public List<CombinerParameterType> CombinerParameter
		{
			get
			{
				return _combinerParameter;
			}
			set
			{
				_combinerParameter = value;
			}
		}
	}
}