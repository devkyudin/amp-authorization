using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class IdReferenceType
	{
		#region Private fields
		private string _version;
		private string _earliestVersion;
		private string _latestVersion;
		private string _value;
		#endregion

		public string Version
		{
			get
			{
				return _version;
			}
			set
			{
				_version = value;
			}
		}

		public string EarliestVersion
		{
			get
			{
				return _earliestVersion;
			}
			set
			{
				_earliestVersion = value;
			}
		}

		public string LatestVersion
		{
			get
			{
				return _latestVersion;
			}
			set
			{
				_latestVersion = value;
			}
		}

		public string Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
			}
		}
	}
}