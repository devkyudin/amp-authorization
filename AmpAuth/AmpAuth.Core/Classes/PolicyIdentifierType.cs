using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class PolicyIdentifierType
	{
		#region Private fields
		private string _policyIdPart;
		private string _versionPart;
		#endregion

		public string PolicyIdPart
		{
			get
			{
				return _policyIdPart;
			}
			set
			{
				_policyIdPart = value;
			}
		}

		public string VersionPart
		{
			get
			{
				return _versionPart;
			}
			set
			{
				_versionPart = value;
			}
		}
	}
}