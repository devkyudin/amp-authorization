using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class PolicySetCombinerParametersType : CombinerParametersType
	{
		#region Private fields
		private string _policySetIdRef;
		#endregion

		public string PolicySetIdRef
		{
			get
			{
				return _policySetIdRef;
			}
			set
			{
				_policySetIdRef = value;
			}
		}
	}
}