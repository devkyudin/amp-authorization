using System.Diagnostics;

namespace AmpAuth.Core
{
	[DebuggerStepThrough]
	public class StatusCodeType
	{
		#region Private fields
		private StatusCodeType _statusCode;
		private string _value;
		#endregion

		public StatusCodeType StatusCode
		{
			get
			{
				return _statusCode;
			}
			set
			{
				_statusCode = value;
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