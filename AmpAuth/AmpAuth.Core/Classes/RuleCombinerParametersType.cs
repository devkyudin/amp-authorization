using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class RuleCombinerParametersType : CombinerParametersType
	{
		#region Private fields
		private string _ruleIdRef;
		#endregion

		public string RuleIdRef
		{
			get
			{
				return _ruleIdRef;
			}
			set
			{
				_ruleIdRef = value;
			}
		}
	}
}