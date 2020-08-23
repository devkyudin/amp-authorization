using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class PolicyCombinerParametersType : CombinerParametersType
	{
		#region Private fields
		private string _policyIdRef;
		#endregion

		public string PolicyIdRef
		{
			get
			{
				return _policyIdRef;
			}
			set
			{
				_policyIdRef = value;
			}
		}
	}
}