using System.Collections.Generic;
using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class PolicyIdentifierListType
	{
		#region Private fields
		private List<PolicyIdentifierType> _policyIdentifier;
		#endregion

		public List<PolicyIdentifierType> PolicyIdentifier
		{
			get
			{
				return _policyIdentifier;
			}
			set
			{
				_policyIdentifier = value;
			}
		}
	}
}